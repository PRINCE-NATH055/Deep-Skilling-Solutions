USE EmployeeManagementDB;

-- File Name - 4. SQL Exercise - Stored procedure

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');


INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');


-- Exercise 1: Create a Stored Procedure(Mandatory)


CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DeptID INT
AS
BEGIN
    SELECT 
        EmployeeID, FirstName, LastName, Salary, JoinDate
    FROM 
        Employees
    WHERE 
        DepartmentID = @DeptID;
END;


EXEC sp_GetEmployeesByDepartment @DeptID = 3;


CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;



EXEC sp_InsertEmployee 
    @FirstName = 'Alice',
    @LastName = 'Brown',
    @DepartmentID = 2,
    @Salary = 6200.00,
    @JoinDate = '2023-09-01';

SELECT * FROM Employees;

-- Exercise 4: Execute a Stored Procedure(Additional)

EXEC sp_GetEmployeesByDepartment @DeptID = 3;


-- Exercise 5: Return Data from a Stored Procedure(Mandatory)

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 1;



