CREATE TABLE [dbo].[Vehicles] (
    [PlateNumber]  VARCHAR (20)  NOT NULL,
    [VehicleType]  NVARCHAR (50) NULL,
    [VehicleBrand] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PlateNumber] ASC)
);

CREATE TABLE [dbo].[Users] (
    [UserId]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (50) NULL,
    [MiddleInitial] NVARCHAR (50) NULL,
    [LastName]      NVARCHAR (50) NULL,
    [UserName]      NVARCHAR (50) NULL,
    [Password]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [UQ_UserName] UNIQUE NONCLUSTERED ([UserName] ASC)
);

CREATE TABLE [dbo].[UserLogs] (
    [UserLogNo]  INT           IDENTITY (1, 1) NOT NULL,
    [UserName]   NVARCHAR (50) NOT NULL,
    [UserLogIn]  DATETIME      NULL,
    [UserLogOut] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([UserLogNo] ASC),
    CONSTRAINT [FK_UserLogs_UserDetails] FOREIGN KEY ([UserName]) REFERENCES [dbo].[Users] ([UserName])
);

CREATE TABLE [dbo].[Transaction] (
    [TransactionID]   INT          IDENTITY (1, 1) NOT NULL,
    [UserID]          INT          NOT NULL,
    [PlateNumber]     VARCHAR (20) NOT NULL,
    [Slots]           NVARCHAR (5) NOT NULL,
    [TransactionType] VARCHAR (20) DEFAULT ('Park In') NULL,
    [ParkIn]          DATETIME     NULL,
    [ParkOut]         DATETIME     NULL,
    [PaymentStatus]   VARCHAR (10) DEFAULT ('Pending') NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_Transaction_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[UserLogs] ([UserLogNo]),
    CONSTRAINT [FK_Transaction_VehicleID] FOREIGN KEY ([PlateNumber]) REFERENCES [dbo].[Vehicles] ([PlateNumber]),
    CONSTRAINT [FK_Transaction_ParkingArea] FOREIGN KEY ([Slots]) REFERENCES [dbo].[ParkingArea] ([SlotsId])
);

CREATE TABLE [dbo].[ParkingArea] (
    [Floor]      CHAR (1)     NULL,
    [SlotsId]    NVARCHAR (5) NOT NULL,
    [SlotStatus] VARCHAR (20) DEFAULT ('Vacant') NOT NULL,
    CONSTRAINT [PK_ParkingArea] PRIMARY KEY CLUSTERED ([SlotsId] ASC)
);

SELECT * FROM Vehicles
SELECT * FROM ParkingArea

INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MA1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MB1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MC1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MD1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'ME1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MF1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MG1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MH1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MI1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'MJ1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'A1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'B1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'C1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'D1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'E1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'F1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'G1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'H1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'I1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'J1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'K1', N'Vacant')
INSERT INTO [dbo].[ParkingArea] ([Floor], [SlotsId], [SlotStatus]) VALUES (N'A', N'L1', N'Vacant')


