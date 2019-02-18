use Form;

CREATE TABLE Form(
	FromId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] VARCHAR(20) NULL,
	[Description] VARCHAR(100)  NULL,
	[Date] Date Null,
);
INSERT INTO Form 
	([Name], [Description], [Date])
	VALUES
	('Bob','Chef', '02/01/1991'),
	('Pam','Firefighter', '03/05/1990' ),
	('Rob','Software Engineer', '05/08/1986' );

	SELECT [Name] FROM Form;

