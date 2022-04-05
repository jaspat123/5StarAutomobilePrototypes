CREATE TABLE [dbo].[Customerdb] (
    [CustomerName]  VARCHAR (50) NOT NULL,
    [EmailAddress]  VARCHAR (50) NOT NULL,
    [AddressStreet] VARCHAR (50) NOT NULL,
    [City]          VARCHAR (50) NOT NULL,
    [Province]      VARCHAR (50) NOT NULL,
    [PostalCode]    CHAR (10)    NOT NULL,
    [PhoneNumber] INT NOT NULL, 
    CONSTRAINT [PK_Customerdb] PRIMARY KEY ([CustomerName])
);

