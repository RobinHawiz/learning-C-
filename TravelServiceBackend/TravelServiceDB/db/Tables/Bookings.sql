CREATE TABLE [dbo].[Bookings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TransportationId] INT NOT NULL, 
    [ZoneId] INT NOT NULL,
    [UserId] INT NOT NULL, 
    [StartDate] DATETIME2 NOT NULL, 
    [EndDate] DATETIME2 NOT NULL, 
    [Wheelchair] BIT NOT NULL DEFAULT 0, 
    [TotalCost] MONEY NOT NULL, 
    [AddressFrom] NVARCHAR(100) NOT NULL, 
    [AddressTo] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_Bookings_Transportations] FOREIGN KEY (TransportationId) REFERENCES Transportations(Id), 
    CONSTRAINT [FK_Bookings_Zones] FOREIGN KEY (ZoneId) REFERENCES Zones(Id), 
    CONSTRAINT [FK_Bookings_Users] FOREIGN KEY (UserId) REFERENCES Users(Id) 
)
