CREATE TABLE [dbo].[PhoneNumber]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PhoneNumber] NVARCHAR(20) NOT NULL, 
    [PersonId] INT NOT NULL, 
    [PrimaryNumber] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_PhoneNumber_Person] FOREIGN KEY (PersonId) REFERENCES Person(Id)
)
