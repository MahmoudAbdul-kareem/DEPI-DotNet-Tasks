
use DEPI_Company

CREATE TABLE Employee (
	SSN INT PRIMARY KEY,
	FName NVARCHAR(100) NOT NULL,
	LName NVARCHAR(100) NOT NULL,
	BirthDate DATE,
	Gender CHAR(1),
	DNum INT,
	SupSSN INT REFERENCES Employee(SSN)
);

CREATE TABLE Department (
    DNum INT PRIMARY KEY,
    DName NVARCHAR(100),
    MgrSSN INT,
    HiringDate DATE,
    FOREIGN KEY (MgrSSN) REFERENCES Employee(SSN)
);

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department 
FOREIGN KEY (DNum) REFERENCES Department(DNum);

CREATE TABLE PROJECT (
    PNum INT PRIMARY KEY,
    PName NVARCHAR(100) NOT NULL,
    LocationCity NVARCHAR(100),
    DNum INT,
    FOREIGN KEY (DNum) REFERENCES DEPARTMENT(DNum)
);

CREATE TABLE DeptLocations (
    DNum INT,
    Location NVARCHAR(100),
    PRIMARY KEY (DNum, Location),
    FOREIGN KEY (DNum) REFERENCES DEPARTMENT(DNum)
);

CREATE TABLE WORKON (
    SSN INT,
    PNum INT,
    WorkingHours TIME,
    PRIMARY KEY (SSN, PNum),
    FOREIGN KEY (SSN) REFERENCES EMPLOYEE(SSN),
    FOREIGN KEY (PNum) REFERENCES PROJECT(PNum)
);

CREATE TABLE DEPENDENT (
    SSN INT,
    DName VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Gender CHAR(1),
    PRIMARY KEY (SSN, DName),
    FOREIGN KEY (SSN) REFERENCES EMPLOYEE(SSN)
);

INSERT INTO Employee (SSN, FName, LName, BirthDate, Gender, DNum, SupSSN) 
VALUES
(1001, 'Ali',     'Omar',   '1990-01-01', 'M', NULL, NULL),
(1002, 'Sara',    'Ahmed',  '1992-02-02', 'F', NULL, 1001),
(1003, 'Hassan',  'Youssef','1988-03-03', 'M', NULL, 1001),
(1004, 'Nour',    'Samir',  '1995-04-04', 'F', NULL, 1002),
(1005, 'Mona',    'Khaled', '1991-05-05', 'F', NULL, 1003);

INSERT INTO Department (DNum, DName, MgrSSN, HiringDate) 
VALUES
(1, N'IT',      1001, '2020-01-01'),
(2, N'HR',      1002, '2019-06-15'),
(3, N'Finance', 1003, '2018-08-20');

UPDATE Employee 
SET DNum = 1 
WHERE SSN IN (1001, 1003);

UPDATE Employee 
SET DNum = 2 
WHERE SSN IN (1002, 1004);

UPDATE Employee 
SET DNum = 3 
WHERE SSN = 1005;

UPDATE Employee
SET DNum = 3
WHERE SSN = 1003;


INSERT INTO Dependent (SSN, DName, BirthDate, Gender) 
VALUES
(1001, 'Khaled', '2010-10-10', 'M');

DELETE FROM Dependent
WHERE SSN = 1001 AND DName = 'Khaled';

select * from DEPENDENT

SELECT *
FROM Employee
WHERE DNum = 1;


