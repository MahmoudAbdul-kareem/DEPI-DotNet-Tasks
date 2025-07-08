-- Step 1: Create Database
CREATE DATABASE DEPI_Company;
GO

USE DEPI_Company;
GO

CREATE TABLE Employee (
    SSN INT PRIMARY KEY,
    FName NVARCHAR(100) NOT NULL,
    LName NVARCHAR(100) NOT NULL,
    BirthDate DATE,
    Gender CHAR(1) NOT NULL CHECK (Gender IN ('M', 'F')),
    DNum INT NOT NULL,
    SupSSN INT NULL,
    CONSTRAINT UQ_Employee_Name UNIQUE (FName, LName),
    CONSTRAINT DF_Gender DEFAULT 'M' FOR Gender
);

CREATE TABLE Department (
    DNum INT PRIMARY KEY,
    DName NVARCHAR(100) NOT NULL UNIQUE,
    MgrSSN INT NOT NULL,
    HiringDate DATE DEFAULT GETDATE()
);

CREATE TABLE Project (
    PNum INT PRIMARY KEY,
    PName NVARCHAR(100) NOT NULL UNIQUE,
    LocationCity NVARCHAR(100),
    DNum INT NOT NULL
);

CREATE TABLE DeptLocations (
    DNum INT NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    PRIMARY KEY (DNum, Location)
);

CREATE TABLE WorkOn (
    SSN INT NOT NULL,
    PNum INT NOT NULL,
    WorkingHours TIME NOT NULL,
    PRIMARY KEY (SSN, PNum)
);

CREATE TABLE Dependent (
    SSN INT NOT NULL,
    DName NVARCHAR(100) NOT NULL,
    BirthDate DATE,
    Gender CHAR(1) CHECK (Gender IN ('M', 'F')),
    PRIMARY KEY (SSN, DName)
);

-- Employee -> Department
ALTER TABLE Employee
ADD CONSTRAINT FK_Emp_Dept
FOREIGN KEY (DNum) REFERENCES Department(DNum)
    ON DELETE NO ACTION
    ON UPDATE CASCADE;

-- Employee -> Employee (Supervisor)
ALTER TABLE Employee
ADD CONSTRAINT FK_Emp_Supervisor
FOREIGN KEY (SupSSN) REFERENCES Employee(SSN)
    ON DELETE SET NULL
    ON UPDATE CASCADE;

-- Department -> Employee (Manager)
ALTER TABLE Department
ADD CONSTRAINT FK_Dept_Manager
FOREIGN KEY (MgrSSN) REFERENCES Employee(SSN)
    ON DELETE NO ACTION
    ON UPDATE CASCADE;

-- Project -> Department
ALTER TABLE Project
ADD CONSTRAINT FK_Proj_Dept
FOREIGN KEY (DNum) REFERENCES Department(DNum)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

-- DeptLocations -> Department
ALTER TABLE DeptLocations
ADD CONSTRAINT FK_DeptLoc_Dept
FOREIGN KEY (DNum) REFERENCES Department(DNum)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

-- WorkOn -> Employee
ALTER TABLE WorkOn
ADD CONSTRAINT FK_WorkOn_Emp
FOREIGN KEY (SSN) REFERENCES Employee(SSN)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

-- WorkOn -> Project
ALTER TABLE WorkOn
ADD CONSTRAINT FK_WorkOn_Proj
FOREIGN KEY (PNum) REFERENCES Project(PNum)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

-- Dependent -> Employee (with CASCADE DELETE)
ALTER TABLE Dependent
ADD CONSTRAINT FK_Dep_Emp
FOREIGN KEY (SSN) REFERENCES Employee(SSN)
    ON DELETE CASCADE
    ON UPDATE CASCADE;

ALTER TABLE Employee
ADD Email NVARCHAR(100);

ALTER TABLE Employee
ALTER COLUMN Email NVARCHAR(150);

ALTER TABLE Employee
DROP CONSTRAINT DF_Gender;

-- Insert Employees
INSERT INTO Employee (SSN, FName, LName, BirthDate, Gender, DNum, SupSSN)
VALUES
(1001, N'Ali',     N'Omar',   '1990-01-01', 'M', 1, NULL),
(1002, N'Sara',    N'Ahmed',  '1992-02-02', 'F', 2, 1001),
(1003, N'Hassan',  N'Youssef','1988-03-03', 'M', 1, 1001),
(1004, N'Nour',    N'Samir',  '1995-04-04', 'F', 2, 1002),
(1005, N'Mona',    N'Khaled', '1991-05-05', 'F', 3, 1003);

-- Insert Departments
INSERT INTO Department (DNum, DName, MgrSSN, HiringDate)
VALUES
(1, N'IT',      1001, '2020-01-01'),
(2, N'HR',      1002, '2019-06-15'),
(3, N'Finance', 1003, '2018-08-20');

-- Insert Projects
INSERT INTO Project (PNum, PName, LocationCity, DNum)
VALUES
(101, N'Payroll System', N'Cairo', 1),
(102, N'Website Redesign', N'Alexandria', 2),
(103, N'ERP Integration', N'Mansoura', 3);

-- Insert WorkOn Records
INSERT INTO WorkOn (SSN, PNum, WorkingHours)
VALUES
(1001, 101, '08:00:00'),
(1002, 102, '06:30:00'),
(1003, 101, '07:15:00');

-- Insert Dependents
INSERT INTO Dependent (SSN, DName, BirthDate, Gender)
VALUES
(1001, N'Khaled', '2010-10-10', 'M'),
(1002, N'Layla', '2012-12-12', 'F');

