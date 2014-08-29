USE Accounts
GO

----1.Write a stored procedure that selects the full names of all persons.

--CREATE PROC dbo.usp_SelectPeopleNames
--AS
--	SELECT FirstName + ' ' + LastName AS [Full Name]
--		FROM Persons
--GO	

----2.Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

--CREATE PROC dbo.usp_SelectPeopleWithBalanceGreaterThan(
--	@Balance money = 100)
--AS
--	SELECT p.FirstName + ' ' + p.LastName AS [Full Name]
--		FROM Persons p
--			JOIN Accounts a
--				ON a.PersonID = p.PersonID
--			WHERE a.Balance > @Balance			
--GO	

----3.Create a function that accepts as parameters – sum, yearly interest rate and number of months. It should calculate and return the new sum.

--CREATE PROC dbo.usp_CalculateSumWithInterest(
--	@InitialSum money,
--	@YearlyInterestRate real,
--	@NumberOfMonths int,
--	@Result money OUTPUT)
--AS
--	SET @Result =  @InitialSum * (1 + (@YearlyInterestRate /12) * @NumberOfMonths) 
--GO

----Write a SELECT to test whether the function works as expected.

--DECLARE @Result money
--EXEC usp_CalculateSumWithInterest 100, 0.12, 1, @Result OUTPUT
--SELECT 'Sum after a month: ', @Result
--GO

----4.Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month. 
----It should take the AccountId and the interest rate as parameters.

--CREATE PROC dbo.usp_CalculatePersonBalanceInterest(
--	@PersonID int,
--	@YearlyInterestRate real,
--	@NumberOfMonths int,
--	@Result money OUTPUT)
--AS
--	DECLARE @PersonBalance money
--	SELECT @PersonBalance = Balance
--		 FROM Accounts
--			WHERE PersonID = @PersonID

--	EXEC usp_CalculateSumWithInterest @PersonBalance,@YearlyInterestRate, @NumberOfMonths, @Result OUTPUT
--GO

--DECLARE @Result money
--EXEC usp_CalculatePersonBalanceInterest 2, 0.12, 1, @Result OUTPUT
--SELECT 'Sum after a month: ', @Result
--GO

----5.Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney (AccountId, money) that operate in transactions.

--CREATE PROC dbo.usp_WithdrawMoney(
--	@PersonID int,
--	@Money money)
--AS
--	BEGIN TRAN
--		DECLARE @PersonBalance money
--		SELECT @PersonBalance = Balance
--			 FROM Accounts
--				WHERE PersonID = @PersonID
--		IF	(@PersonBalance >= @Money)
--			BEGIN
--				UPDATE Accounts
--					SET Balance = @PersonBalance - @Money
--						WHERE AccountID = @PersonID
--			END
--		ELSE
--			BEGIN
--				ROLLBACK TRAN
--			END
--	COMMIT TRAN
--GO

--CREATE PROC dbo.usp_DepositMoney(
--	@PersonID int,
--	@Money money)
--AS
--	BEGIN TRAN
--		DECLARE @PersonBalance money
--		SELECT @PersonBalance = Balance
--			 FROM Accounts
--				WHERE PersonID = @PersonID
--		UPDATE Accounts
--			SET Balance = @PersonBalance + @Money
--				WHERE AccountID = @PersonID			
--	COMMIT TRAN
--GO

----6.Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

--ALTER TRIGGER tr_AccountBalanceUpdate ON Accounts FOR UPDATE
--AS
--	DECLARE @UpdatedPersonID int,
--		@InitialAccountBalance money,
--		@UpdatedAccountBalance money
--		SELECT @UpdatedPersonID = PersonID, @UpdatedAccountBalance = Balance
--			FROM inserted
		
--		SELECT @InitialAccountBalance = Balance
--			FROM deleted
--				WHERE PersonID = @UpdatedPersonID

--		INSERT INTO Logs(AccountID,OldSum,NewSum)
--			VALUES
--				(@UpdatedPersonID,@InitialAccountBalance,@UpdatedAccountBalance)
--GO

----7.Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
 ----Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.


USE TelerikAcademy;
GO

CREATE FUNCTION usp_IsComposed(
	@name nvarchar(50),
	@characters nvarchar(50)
	)
	RETURNS bit
AS
BEGIN
	DECLARE @index int = 1,
			@foundIndex int,
			@currentCharacter nvarchar(1),
			@counter int,
			@result bit;

	DECLARE @usedLetters table(LetterIndex int, Letter nvarchar(1));
	SET @characters = LOWER(@characters);

	WHILE(@index <= LEN(@name))
	BEGIN
		SET @currentCharacter = LOWER(SUBSTRING(@name, @index, 1));
		SET @foundIndex = CHARINDEX(@currentCharacter, @characters);

		IF (@foundIndex = 0)
		BEGIN
			SET @result = 0;
			BREAK;
		END	
		ELSE
		BEGIN
			IF(EXISTS(SELECT * FROM @usedLetters WHERE LetterIndex = @foundIndex))
			BEGIN
				SELECT TOP 1 @foundIndex = LetterIndex
				FROM @usedLetters
				WHERE Letter = @currentCharacter
				ORDER BY Letter DESC;

				SET @foundIndex = CHARINDEX(@currentCharacter, @characters, @foundIndex + 1);

				IF (@foundIndex = 0)
				BEGIN
					SET @result = 0;
					BREAK;
				END
			END
			
			INSERT INTO @usedLetters
			VALUES (@foundIndex, @currentCharacter);
		END
		SET @index = @index + 1;
	END

	SELECT @counter = COUNT(*) FROM @usedLetters;

	IF(@counter = LEN(@name))
	BEGIN 
		SET @result = 1;
	END
	ELSE
	BEGIN
		SET @result = 0;
	END
	RETURN @result;
END
GO

-- Create function
CREATE FUNCTION ufn_GetComposedNames (@characters nvarchar(50))
	RETURNS TABLE
AS
RETURN (
	(SELECT 'First Name: ' + e.FirstName AS Name 
	FROM Employees as e
	WHERE 1 = (SELECT dbo.usp_IsComposed(e.FirstName, @characters)))
	UNION
	(SELECT 'Middle Name: ' + e.MiddleName AS Name
	FROM Employees As e
	WHERE 1 = (SELECT dbo.usp_IsComposed(e.MiddleName, @characters)))
	UNION
	(SELECT 'Last Name: ' + e.LastName AS Name
	FROM Employees AS e
	WHERE 1 = (SELECT dbo.usp_IsComposed(e.LastName, @characters)))
	UNION
	(SELECT 'Town Name: ' + t.Name AS Name
	FROM Towns AS t
	WHERE 1 = (SELECT dbo.usp_IsComposed(t.Name, @characters)))
);
GO


---- Test the functions
SELECT * 
FROM dbo.ufn_GetComposedNames('oistmiahf');
GO

SELECT * 
FROM dbo.ufn_GetComposedNames('RoBERto');
GO

-- Test with three equal letters i
SELECT * 
FROM dbo.ufn_GetComposedNames('Kharatishvili');
GO

----8.Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.


DECLARE lineCursor CURSOR READ_ONLY FOR
	SELECT e1.FirstName, e1.LastName, t1.Name,
			e2.FirstName, e2.LastName
		FROM Employees e1
			JOIN Addresses a1
				ON a1.AddressID = e1.AddressID
			JOIN Towns t1
				ON t1.TownID = a1.TownID,
										Employees e2
			JOIN Addresses a2
				ON a2.AddressID = e2.AddressID
			JOIN Towns t2
				ON t2.TownID = a2.TownID               
			WHERE t1.TownID = t2.TownID AND e1.EmployeeID <> e2.EmployeeID
				ORDER BY t1.Name, e1.FirstName, e2.FirstName;

	OPEN lineCursor
	DECLARE @firstName1 nvarchar(50),
			@lastName1 nvarchar(50),
		    @town nvarchar(50),
		    @firstName2 nvarchar(50),
		    @lastName2 nvarchar(50);

	DECLARE @resultTable table(
				FirstEmployee nvarchar(100),
				Town nvarchar(500),
				SecondEmployee nvarchar(100)
			);
	FETCH NEXT FROM lineCursor
			INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
 
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO @resultTable
			VALUES (@firstName1 + ' ' + @lastName1, @town, @firstName2 + ' ' + @lastName2);
		FETCH NEXT FROM lineCursor INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
	END
	
	CLOSE lineCursor
	DEALLOCATE lineCursor

	SELECT * FROM @resultTable;
GO
