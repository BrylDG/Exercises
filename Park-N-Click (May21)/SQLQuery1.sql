CREATE DATABASE ParkingSystemDB
USE ParkingSystemDB

CREATE TABLE Users
(
	UserID int primary key identity,
	UserUsername nvarchar (100) unique,
	UserPassword nvarchar (100),
	UserFirstName nvarchar (50),
	UserMiddleInitial nvarchar (50),
	UserLastName nvarchar (50)
)

	CREATE TABLE UserLogs
	(
		UserLogNo int primary key identity,
		UserID int,
		UserUsername nvarchar (100),
		UserLoginDate datetime,
		UserLogoutDate datetime,
		Transactions int,
		foreign key (UserID) references Users(UserID)
	)

CREATE TABLE VehicleData
(
	VehicleID int primary key identity,
	VehiclePlateNumber nvarchar (100) unique,
	VehicleType nvarchar (100),
	VehicleBrand nvarchar (100)
)

CREATE TABLE TransactionTable
(
	TransactionID int primary key identity,
	TransactionType nvarchar (100),
	TransactionUser nvarchar (100),
	ParkingSlot nvarchar (100),
	VehiclePlateNumber nvarchar (100),
	VehicleType nvarchar (100),
	VehicleBrand nvarchar (100),
	ParkInParkOut datetime,
	PaymentStatus nvarchar (100),
)

CREATE TABLE ParkedIn
(
	ParkingSlot nvarchar (100) unique,
	SlotStatus nvarchar (100),
)
CREATE TABLE PaymentsTable
(
	PaymentID int primary key identity,
	TransactionID int,
	TransactionDate DateTime,
	Amount int,
	foreign key (TransactionID) references TransactionTable(TransactionID),
)

CREATE TABLE ParkingHistory
(
	ParkingSlot nvarchar (100),
	PlateNumber nvarchar (100),
	ParkIn datetime,
	ParkOut datetime,
	Duration int,
)

DBCC CHECKIDENT ('[UserLogs]', RESEED, 0);
GO
declare @max int select @max=ISNULL(max([UserID]),0) from [UserLogs]; DBCC CHECKIDENT ('[UserLogs]', RESEED, @max );
declare @max int select @max=ISNULL(max([UserID]),0) from [Users]; DBCC CHECKIDENT ('[Users]', RESEED, @max );
declare @max int select @max=ISNULL(max([TransactionID]),0) from [TransactionTable]; DBCC CHECKIDENT ('[TransactionTable]', RESEED, @max );
declare @max int select @max=ISNULL(max([VehicleID]),0) from [VehicleData]; DBCC CHECKIDENT ('[VehicleData]', RESEED, @max );

SELECT * FROM Users
SELECT * FROM UserLogs
SELECT * FROM VehicleData
SELECT * FROM ParkedIn
SELECT * FROM TransactionTable
SELECT * FROM PaymentsTable
SELECT * FROM ParkingHistory

ALTER TABLE TransactionTable
ADD PaymentStatus nvarchar (100)
DROP TABLE TransactionTable
DROP TABLE ParkedIn
DROP TABLE PaymentsTable
DROP TABLE ParkingHistory
DROP TABLE UserLogs

DELETE FROM TransactionTable
DELETE FROM VehicleData
DELETE FROM UserLogs
DELETE FROM Users
DELETE FROM ParkingHistory


INSERT INTO ParkedIn (ParkingSlot, SlotStatus)
VALUES ('MA1', 'Vacant'),('MB1', 'Vacant'),('MC1', 'Vacant'),('MD1', 'Vacant'),('ME1', 'Vacant'),('MF1', 'Vacant'),('MG1', 'Vacant'),('MH1', 'Vacant'),('MI1', 'Vacant'),('MJ1', 'Vacant'),('MK1', 'Vacant'),('ML1', 'Vacant'),('MM1', 'Vacant'),('MN1', 'Vacant'),('MO1', 'Vacant'),('MP1', 'Vacant'),('MQ1', 'Vacant'),('MR1', 'Vacant')

SELECT 
    tt.TransactionID,
    tt.TransactionType,
    tt.TransactionUser,
    tt.ParkingSlot,
    tt.VehiclePlateNumber,
    tt.VehicleType,
    tt.VehicleBrand,
    tt.ParkInParkOut,
    tt.PaymentStatus
FROM 
    TransactionTable tt
LEFT JOIN 
    UserLogs ul ON tt.TransactionUser = ul.UserUsername;