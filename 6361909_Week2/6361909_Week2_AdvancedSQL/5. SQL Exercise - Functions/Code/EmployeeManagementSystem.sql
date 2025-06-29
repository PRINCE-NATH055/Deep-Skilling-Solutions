CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
    (1, 'HR'),
    (2, 'IT'),
    (3, 'Finance');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
    (1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
    (2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
    (3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-01');


CREATE FUNCTION dbo.fn_CalculateAnnualSalary (@EmpID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmpID;

    RETURN @AnnualSalary;
END;

SELECT dbo.fn_CalculateAnnualSalary(1) AS AnnualSalary;