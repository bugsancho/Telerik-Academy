CREATE DATABASE Accounts
GO

USE Accounts;
GO

CREATE TABLE Persons(
	PersonID int IDENTITY PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN char(10) UNIQUE CHECK(LEN(SSN) = 10) 

)
GO

CREATE TABLE Accounts(
	AccountID int IDENTITY PRIMARY KEY,
	PersonID int FOREIGN KEY REFERENCES Persons(PersonID) NOT NULL,
	Balance money NOT NULL
)
GO

CREATE TABLE Logs(
	LogID int IDENTITY PRIMARY KEY,
	AccountID int FOREIGN KEY REFERENCES Accounts(AccountID) NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL


)
GO

INSERT INTO Persons(FirstName,LastName,SSN)
	VALUES
		('Gosho', 'Georgiev', '1234567890'),
		('Ivan', 'Ivanov', '2345678901'),
		('Petka', 'Petkova', '3456789012'),
		('Vasil', 'Vankov', '9876543210'),
		('Neiko', 'Neikov', '1478523690')
GO

INSERT INTO Accounts(PersonID,Balance)
	VALUES
		(1,66.33),
		(2,5532.11),
		(3,5.81),
		(4,10000),
		(5,321.68)
GO

