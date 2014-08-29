USE TelerikAcademy;

----1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. Use a nested SELECT statement.

--SELECT FirstName + ' ' + LastName AS Name, Salary 
--	FROM Employees 
--		WHERE Salary = 
--			(SELECT MIN(Salary) FROM Employees)

----2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

--SELECT FirstName + ' ' + LastName AS Name, Salary 
--	FROM Employees 
--		WHERE Salary >  
--			(SELECT MIN(Salary) FROM Employees) 
--				AND Salary <= (SELECT MIN(Salary) FROM Employees) * 1.1

----3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. Use a nested SELECT statement.

--SELECT FirstName + ' ' + LastName AS Name, Salary, d.Name AS Department
--	FROM Employees e
--		JOIN Departments d
--			ON e.DepartmentID = d.DepartmentID
--		WHERE Salary = 
--			(SELECT MIN(Salary) FROM Employees
--				WHERE DepartmentID = e.DepartmentID )

----4.Write a SQL query to find the average salary in the department #1.

--SELECT AVG(Salary) AS [Average Salary], d.Name AS Department 
--	FROM Employees e
--		JOIN Departments d
--			ON e.DepartmentID = d.DepartmentID
--		WHERE e.DepartmentID = 1
--			GROUP BY d.Name

----5.Write a SQL query to find the average salary  in the "Sales" department.

--SELECT AVG(Salary) AS [Average Salary], d.Name AS Department 
--	FROM Employees e
--		JOIN Departments d
--			ON e.DepartmentID = d.DepartmentID
--		WHERE d.Name = 'Sales'
--			GROUP BY d.Name

----6.Write a SQL query to find the number of employees in the "Sales" department.

--SELECT COUNT(*) AS [Number of Employees], d.Name AS Department 
--	FROM Employees e
--		JOIN Departments d
--			ON e.DepartmentID = d.DepartmentID
--		WHERE d.Name = 'Sales'
--			GROUP BY d.Name

----7.Write a SQL query to find the number of all employees that have manager.

--SELECT COUNT(ManagerID) AS [Employees with Manager]
--	FROM Employees

----8.Write a SQL query to find the number of all employees that have no manager.


--SELECT COUNT(*) AS [Employees without Manager]
--	FROM Employees
--		WHERE ManagerID IS NULL

----9.Write a SQL query to find all departments and the average salary for each of them.

--SELECT d.Name AS Department, AVG(e.Salary) AS [Average Salary]
--	FROM Departments d
--		JOIN Employees e
--			ON e.DepartmentID = d.DepartmentID
--	GROUP BY e.DepartmentID, d.Name

----10.Write a SQL query to find the count of all employees in each department and for each town.

--SELECT d.Name AS Department, t.Name AS Town, COUNT(*) AS [Number of Employees]
--	FROM Employees e
--		JOIN Departments d
--			ON e.DepartmentID = d.DepartmentID
--		JOIN Addresses a
--			ON e.AddressID = a.AddressID
--		JOIN Towns t
--			ON a.TownID = t.TownID
--		GROUP BY d.Name, t.Name

----11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

--SELECT FirstName + ' ' + LastName AS [Manager Name], e.EmployeeID
--	FROM Employees e
--		WHERE (SELECT COUNT(*) 
--					FROM Employees 
--						WHERE ManagerID = e.EmployeeID) = 1

----12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

--SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], ISNULL((m.FirstName + ' ' + m.LastName), 'No Manager') AS [Manager Name] 
--	FROM Employees e
--		LEFT OUTER JOIN Employees m
--			ON e.ManagerID = m.EmployeeID

----13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

--SELECT FirstName + ' ' + LastName AS [Employee Name]
--	FROM Employees
--		WHERE LEN(LastName) = 5

----14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
 
--SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff') AS [Current Date & Time];
