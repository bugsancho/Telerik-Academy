USE TelerikAcademy;

--1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS Name, Salary 
	FROM Employees 
		WHERE Salary = 
			(SELECT MIN(Salary) FROM Employees)

--2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName + ' ' + LastName AS Name, Salary 
	FROM Employees 
		WHERE Salary >  
			(SELECT MIN(Salary) FROM Employees) 
				AND Salary <= (SELECT MIN(Salary) FROM Employees) * 1.1

--3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS Name, Salary, d.Name AS Department
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		WHERE Salary = 
			(SELECT MIN(Salary) FROM Employees
				WHERE DepartmentID = e.DepartmentID )

--4.Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS [Average Salary], d.Name AS Department 
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		WHERE e.DepartmentID = 1
			GROUP BY d.Name

--5.Write a SQL query to find the average salary  in the "Sales" department.

SELECT AVG(Salary) AS [Average Salary], d.Name AS Department 
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		WHERE d.Name = 'Sales'
			GROUP BY d.Name

--6.Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(*) AS [Number of Employees], d.Name AS Department 
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		WHERE d.Name = 'Sales'
			GROUP BY d.Name

--7.Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(ManagerID) AS [Employees with Manager]
	FROM Employees

--8.Write a SQL query to find the number of all employees that have no manager.


SELECT COUNT(*) AS [Employees without Manager]
	FROM Employees
		WHERE ManagerID IS NULL

--9.Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS Department, AVG(e.Salary) AS [Average Salary]
	FROM Departments d
		JOIN Employees e
			ON e.DepartmentID = d.DepartmentID
	GROUP BY e.DepartmentID, d.Name

--10.Write a SQL query to find the count of all employees in each department and for each town.

SELECT d.Name AS Department, t.Name AS Town, COUNT(*) AS [Number of Employees]
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		JOIN Addresses a
			ON e.AddressID = a.AddressID
		JOIN Towns t
			ON a.TownID = t.TownID
		GROUP BY d.Name, t.Name

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT FirstName + ' ' + LastName AS [Manager Name], e.EmployeeID
	FROM Employees e
		WHERE (SELECT COUNT(*) 
					FROM Employees 
						WHERE ManagerID = e.EmployeeID) = 1

--12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], ISNULL((m.FirstName + ' ' + m.LastName), 'No Manager') AS [Manager Name] 
	FROM Employees e
		LEFT OUTER JOIN Employees m
			ON e.ManagerID = m.EmployeeID

--13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

SELECT FirstName + ' ' + LastName AS [Employee Name]
	FROM Employees
		WHERE LEN(LastName) = 5

--14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
 
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff') AS [Current Date & Time];


--15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. 
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. 
--Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users(
	UserID int IDENTITY PRIMARY KEY,
	Username nvarchar(30) UNIQUE NOT NULL, 
	Password nvarchar(30) CHECK(LEN(Password) >= 5),
	FullName nvarchar(50),
	LastLogin date
) 
GO

--16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. Test if the view works correctly.


--CREATE VIEW [Users Online Today] AS 
--	SELECT * FROM Users
--		WHERE DATEDIFF(DAY, LastLogin, GETDATE()) < 1 
--GO

--17.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). 
--Define primary key and identity column.

CREATE TABLE Groups (
	GroupID int IDENTITY PRIMARY KEY,
	Name nvarchar(50) UNIQUE
)
GO

--18.Write a SQL statement to add a column GroupID to the table Users. Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users
	ADD GroupID int,
	CONSTRAINT FK_Users_Groups
		FOREIGN KEY(GroupID)
		REFERENCES Groups(GroupID)
GO

--19.Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Groups(Name)
	VALUES
	('Smokers'),
	('Gamers'),
	('Asocial'),
	('Pet owners'),
	('Parents'),
	('Annoying')
GO
	
INSERT INTO Users(Username, Password, FullName, LastLogin,GroupID)
	VALUES
	('Ginka','Ginka123', 'Ginka Ginkina', '2005.05.10', 5),
	('Penko','Penko345', 'Penko Penkov', '2011.07.12', 2),
	('Petercho_Sexy','Password', 'Peter Petrov', '2013.05.15', 6),
	('Steve','123456', 'Stefan Stefanov', '2014.08.25', 4),
	('Mich123','Michepich', 'Mich Ivanov', '2014.08.25', 1)

GO
--20.Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Groups
	SET Name = 'Very Annoying'
		WHERE Name = 'Annoying'
GO

UPDATE Users
	SET GroupID = 3
		WHERE GroupID = 5
GO

--21.Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users 
	WHERE Username = 'Penko'
GO

DELETE FROM Groups
	WHERE GroupID = 5
GO

--22.Write SQL statements to insert in the Users table the names of all employees from the Employees table. 
--Combine the first and last names as a full name. For username use the first letter of the first name + the last name (in lowercase).
-- Use the same for the password, and NULL for last login time.


--Changed the substring to include three symbols because there are too short names and the password length constraint cannot be met
INSERT INTO Users(Username,Password, FullName)
	SELECT
		SUBSTRING(FirstName, 1,3) + LOWER(LastName),
		SUBSTRING(FirstName, 1,3) + LOWER(LastName), 
		FirstName + ' ' + LastName
			FROM Employees

--23.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

UPDATE Users 
	SET Password = NULL
		WHERE LastLogin < '10.03.2010'
GO

--24.Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
	WHERE Password IS NULL

--25.Write a SQL query to display the average employee salary by department and job title.

SELECT d.Name AS Department, e.JobTitle, AVG(e.Salary) AS [Average Salary]
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		GROUP BY e.JobTitle, d.Name

--26.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT d.Name AS Department, e.JobTitle, MIN(e.Salary) AS [Minimal Salary], MIN(e.FirstName + ' ' + e.LastName)
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
		GROUP BY e.JobTitle, d.Name

--27.Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name AS Town, COUNT(e.EmployeeID) AS [Employees count]
	FROM Employees e
		JOIN Addresses a
			ON e.AddressID = a.AddressID
		JOIN Towns t
			ON a.TownID = t.TownID
	GROUP BY t.Name
	ORDER BY [Employees count] DESC

--28.Write a SQL query to display the number of managers from each town.

SELECT t.Name AS Town, COUNT(*) AS [Managers count]
	FROM Employees e
		JOIN Employees m
			ON e.ManagerID = m.EmployeeID
		JOIN Addresses a
			ON m.AddressID = a.AddressID
		JOIN Towns t
			ON a.TownID = t.TownID
		GROUP BY t.Name

--29.Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments). 

CREATE TABLE WorkHours(
	WorkHoursID int IDENTITY,
	EmployeeID int,
	WorkDate datetime,
	Task nvarchar(50),
	WorkHours int,
	Comment nvarchar(256),
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHoursID),
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID)
)
GO

--Issue few SQL statements to insert, update and delete of some data in the table.

INSERT INTO WorkHours(WorkDate, Task, WorkHours, Comment)
	VALUES 
	(GETDATE(), 'Fix bug #256', 23, 'No commits before bug fixed'),
	(GETDATE(), 'Implement Composite pattern', 3, '15% bonus'),
	(GETDATE(), 'Add like button to the form', 6, 'No bonus');

DELETE 
	FROM WorkHours
		WHERE Task LIKE '%bug #256%';

UPDATE WorkHours
	SET WorkHours = 2
		WHERE Task LIKE '%like button%';
GO

--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. 
--For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TABLE WorkHoursLog(
	Id int IDENTITY,
	OldRecord nvarchar(100) NOT NULL,
	NewRecord nvarchar(100) NOT NULL,
	Command nvarchar(10) NOT NULL,
	CONSTRAINT PK_WorkHoursLog PRIMARY KEY(Id)
)
GO

DROP TRIGGER tr_WorkHoursInsert;
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
	AS
		INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
		VALUES(' ',
		(SELECT 'Day: ' + 
			CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + 
			Task + ' ' + ' Hours: ' + 
			CAST([WorkHours] AS nvarchar(50)) + ' ' +  
			CAST([WorkHours] AS nvarchar(50)) + ' '+ Comment 
		FROM Inserted),
				'INSERT'
);
GO

DROP TRIGGER tr_WorkHoursUpdate;
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
	AS
		INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
		VALUES((SELECT 'Day: ' + 
			CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + 
			Task + ' ' + ' Hours: ' + 
			CAST([WorkHours] AS nvarchar(50)) + ' ' + Comment 
			FROM Deleted),

			(SELECT 'Day: ' + 
			CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + 
			Task + ' ' + ' Hours: ' + 
			CAST([WorkHours] AS nvarchar(50)) + ' ' + Comment 
		FROM Inserted),
				'UPDATE'
);
GO

DROP TRIGGER tr_WorkHoursDeleted;
GO

CREATE TRIGGER tr_WorkHoursDeleted ON WorkHours AFTER DELETE
	AS
		INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
		VALUES(
			(SELECT 'Day: ' + 
			CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + 
			Task + ' ' + ' Hours: ' + 
			CAST([WorkHours] AS nvarchar(50)) + ' ' + Comment 
		FROM Deleted),
		' ',
		'DELETE'
);
GO

--30.	Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.

BEGIN TRAN
	ALTER TABLE Departments
		DROP CONSTRAINT FK_Departments_Employees;

ALTER TABLE Departments
	ADD CONSTRAINT FK_Departments_Employees
		FOREIGN KEY (ManagerID)
		      REFERENCES Employees (EmployeeID)
		      ON DELETE CASCADE
		      ON UPDATE CASCADE;

ALTER TABLE EmployeesProjects
DROP CONSTRAINT FK_EmployeesProjects_Employees;

ALTER TABLE EmployeesProjects 
	ADD CONSTRAINT FK_EmployeesProjects_Employees
		FOREIGN KEY (EmployeeID)
		      REFERENCES Employees (EmployeeID)
		      ON DELETE CASCADE
		      ON UPDATE CASCADE;

ALTER TABLE WorkHours
DROP CONSTRAINT FK_WorkHours_Employees;

ALTER TABLE WorkHours
	ADD CONSTRAINT FK_WorkHours_Employees
		FOREIGN KEY (EmployeeID)
		      REFERENCES Employees (EmployeeID)
		      ON DELETE CASCADE
		      ON UPDATE CASCADE;

DELETE FROM Employees
	SELECT d.Name
		FROM Employees e 
			JOIN Departments d
				ON e.DepartmentID = d.DepartmentID
		WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN;
GO

--31.	Start a database transaction and drop the table EmployeesProjects. Now how you could restore back the lost table data?

BEGIN TRAN
	DROP TABLE EmployeesProjects;
	ROLLBACK TRAN;
GO

--32.	Find how to use temporary tables in SQL Server. Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

CREATE TABLE #BackUpEmployeesProjects(
        EmployeeID INT NOT NULL,
        ProjectID INT NOT NULL,
        CONSTRAINT PK_BackUpEmployeesProjects PRIMARY KEY (EmployeeID, ProjectID),
);
 
INSERT INTO #BackUpEmployeesProjects
	SELECT * FROM EmployeesProjects;
 
DROP TABLE EmployeesProjects;
 
CREATE TABLE EmployeesProjects(
        EmployeeID INT NOT NULL,
        ProjectID INT NOT NULL,
        CONSTRAINT PK_EmployeeesProjects PRIMARY KEY (EmployeeID, ProjectID),
        CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY (EmployeeID)
                REFERENCES Employees(EmployeeId),
        CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY (ProjectID)
                REFERENCES Projects(ProjectId)
);
 
INSERT INTO EmployeesProjects
	SELECT * FROM #BackUpEmployeesProjects;
GO
