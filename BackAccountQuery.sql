Create database BankAccount
go

CREATE TABLE [dbo].[User] (

		Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		FirstName VARCHAR(50) NOT NULL,
		LastName VARCHAR(50) NOT NULL,
		Gender VARCHAR(10) NOT NULL,
		DateOfBirth DATE NOT NULL,
		PhoneNumber NVARCHAR(14) NOT NULL,
		IdentificationNumber NVARCHAR(14) NOT NULL,
		EmailAddress VARCHAR(50) NOT NULL,
		PackageId INT NOT NULL ,
		AddressId int NOT NULL ,

		FOREIGN KEY (PackageId) REFERENCES [dbo].[Package] (Id),
		FOREIGN KEY (AddressId) REFERENCES [dbo].[Address] (Id),
);



CREATE TABLE [dbo].[Address] (

		Id INT IDENTITY NOT NULL PRIMARY KEY,
		Name VARCHAR(50) NOT NULL

);

CREATE TABLE [dbo].[Package] (
		Id INT IDENTITY  NOT NULL PRIMARY KEY,
		Name VARCHAR(10) NOT NULL,
		Price INT NOT NULL

);


INSERT INTO Address VALUES 
('Sarajevo'),
( 'Banja Luka'),
( 'Tuzla'),
( 'Zenica'),
( 'Srebrenica'),
( 'Bratunac');

INSERT INTO Package VALUES
( 'Basic', 5),
( 'Premium', 10),
( 'Supreme', 15);
