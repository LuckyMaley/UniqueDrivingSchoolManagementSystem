

Use UniqueDrivingSchoolDB;

CREATE TABLE Customer(
	CustomerID INT NOT NULL UNIQUE,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	DateOfBirth DATE,
	Gender VARCHAR(50),
	Cellphone VARCHAR(50),
	HouseNumber VARCHAR(50),
	StreetName VARCHAR(50),
	CityOrTown VARCHAR(50),
	ZipCode VARCHAR(50),
	EmailAddress VARCHAR(50),
	DrivingTestDate DATE,
	DrivingTestResult VARCHAR(50),
	UserName VARCHAR(50),
	[PassWord] VARCHAR(50),
	PRIMARY KEY (CustomerID)
);

CREATE TABLE Payment(
	PaymentID INT NOT NULL UNIQUE,
	CustomerID INT,
	[Date] Date,
	AmountPaid DECIMAL(18,2),
	AmountOwing DECIMAL(18,2),
	ReceiptNumber INT,
	PRIMARY KEY (PaymentID),
	FOREIGN KEY (CustomerID) references Customer
);

CREATE TABLE Instructor(
	InstructorID INT NOT NULL UNIQUE,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	HouseNumber VARCHAR(50),
	StreetName VARCHAR(50),
	CityOrTown VARCHAR(50),
	ZipCode VARCHAR(50),
	UserName VARCHAR(50),
	[PassWord] VARCHAR(50),
	PRIMARY KEY (InstructorID)
);

CREATE TABLE Manager(
	ManagerID INT NOT NULL UNIQUE,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	HouseNumber VARCHAR(50),
	StreetName VARCHAR(50),
	CityOrTown VARCHAR(50),
	ZipCode VARCHAR(50),
	CarHourCost INT,
	CarHireCost INT,
	TruckHourCost INT,
	TruckHireCost INT,
	Code10FullCourse INT,
	Code08FullCourse INT,
	UserName VARCHAR(50),
	[PassWord] VARCHAR(50),
	PRIMARY KEY (ManagerID)
);

CREATE TABLE Car(
	CarID INT NOT NULL UNIQUE,
	ManagerID INT,
	Model VARCHAR(50),
	[Status] VARCHAR(50),
	[Type] VARCHAR(50)
	PRIMARY KEY (CarID),
	FOREIGN KEY (ManagerID) references Manager
);

CREATE TABLE Instructor_Car(
	InstructorCarID INT NOT NULL IDENTITY(1,1) UNIQUE,
	CarID INT,
	InstructorID INT,
	PRIMARY KEY (InstructorCarID),
	FOREIGN KEY (CarID) references Car,
	FOREIGN KEY (InstructorID) references Instructor
);

CREATE TABLE Booking(
	BookingID INT NOT NULL IDENTITY(1,1) UNIQUE,
	CustomerID INT,
	ManagerID INT,
	InstructorID INT,
	CarID INT,
	PaymentID INT,
	BookingDate Date,
	LicenseCode VARCHAR(50),
	BookingStatus VARCHAR(50),
	PickupVenue VARCHAR(50),
	NumOfLessons INT,
	LessonNumber INT,
	LessonCost DECIMAL(18,2),
	LessonDate DATE,
	LessonTime TIME(7),
	PRIMARY KEY (BookingID),
	FOREIGN KEY (CustomerID) references Customer,
	FOREIGN KEY (ManagerID) references Manager,
	FOREIGN KEY (InstructorID) references Instructor,
	FOREIGN KEY (CarID) references Car,
	FOREIGN KEY (PaymentID) references Payment,
);

CREATE TABLE Packages(
	PackageID INT NOT NULL IDENTITY(1,1) UNIQUE,
	PackageName VARCHAR(50),
	PackageType VARCHAR(50),
	PackageCount INT,
	PackageCode VARCHAR(50),
	PackageDescription Text,
	PackageCost Decimal(18,2),
	PackagePicture IMAGE,
	ManagerID INT,
	PRIMARY KEY (PackageID),
	FOREIGN KEY (ManagerID) references Manager
);