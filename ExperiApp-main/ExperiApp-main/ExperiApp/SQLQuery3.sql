CREATE DATABASE ParkingSystemDB
Use ParkingSystemDB
CREATE TABLE Users
(
	usrID int primary key identity,
	usrFN nvarchar (50),
	usrLN nvarchar (50),
	usrMI nvarchar (2),
	usrname nvarchar (100) unique,
	usrpw nvarchar (50)
)

CREATE TABLE SystemLogs
(
	usrLogNo int primary key identity,
	usrId int,
	usrname nvarchar (100),
	usrLogDate datetime
	foreign key (userID) references Users(usrID)
)

INSERT INTO Users
VALUES ('Bryl' , 'Gorgonio', 'M', 'admin123', 'admin123')

SELECT * FROM Users