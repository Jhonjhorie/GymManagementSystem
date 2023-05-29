-- Drop tables if they exist
DROP TABLE IF EXISTS MemberSessions;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS GymInfo;
DROP TABLE IF EXISTS Payments;
DROP TABLE IF EXISTS WalkInSessions;
DROP TABLE IF EXISTS Equipments;
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Members;

-- Create the Members table
CREATE TABLE Members (
    MemberID VARCHAR(5) PRIMARY KEY,
    FullName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    MembershipType VARCHAR(50) NOT NULL,
    JoinDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    RenewDate DATE,
    QRCode VARBINARY(Max),
    MemberPicture VARBINARY(Max),
    EmergencytoContact VARCHAR(50) NOT NULL,
    EmergencyContactNo VARCHAR(20) NOT NULL,
    ETCRelationship VARCHAR(20) NOT NULL
);

-- Create the Employees table
CREATE TABLE Employees (
    EmployeeID VARCHAR(3) PRIMARY KEY,
    FullName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    [Address] VARCHAR(200) NOT NULL,
    HireDate DATE NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    Position VARCHAR(50)
);


-- Create the Payments table
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    MemberID VARCHAR(5) NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);

-- Create the WalkInSessions table
CREATE TABLE WalkInSessions (
    SessionID INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(50) NOT NULL,
    SessionDate DATE NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL
);

-- Create the MemberSessions table
CREATE TABLE MemberSessions (
    MemberID VARCHAR(5) PRIMARY KEY,
    SessionDate DATE NOT NULL,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);

-- Create the Equipments table
CREATE TABLE Equipments (
    EquipmentID INT IDENTITY(1,1) PRIMARY KEY,
    EquipmentName VARCHAR(100) NOT NULL,
    EquipmentType VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    EquipmentCost DECIMAL(10, 2) NOT NULL,
    [Description] VARCHAR(200)
);

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Usertype VARCHAR(20) NOT NULL,
    Username VARCHAR(50) NOT NULL,
    [Password] VARCHAR(50) NOT NULL
);

CREATE TABLE GymInfo (
    GymID INT PRIMARY KEY,
    SystemEmail VARCHAR(20) NOT NULL,
    EmailPassword VARCHAR(50) NOT NULL,
    GymName VARCHAR(50) NOT NULL
);

