SET NOCOUNT ON
USE Emigrace

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Archives')
BEGIN
	PRINT 'Create Archives table'
	CREATE TABLE [dbo].[Archives] (

		Id BIGINT CONSTRAINT PK_Archives_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		Name NVARCHAR(200) NOT NULL,
		Adress NVARCHAR(150) NOT NULL,
		Country NVARCHAR(50) NOT NULL,
		Phone NVARCHAR(30) NULL, 
		WebPages VARCHAR(50) NULL
		)
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ArchivalDocuments')
BEGIN
	PRINT 'Create ArchivalDocuments table'
	CREATE TABLE [dbo].[ArchivalDocuments] (
		Id BIGINT CONSTRAINT PK_ArchivalDocuments_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		ArchiveId BIGINT NOT NULL,
	        CONSTRAINT FK_ArchivalDocuments_ArchiveId FOREIGN KEY(ArchiveId) REFERENCES Archives(Id),
		FondNumber NVARCHAR NOT NULL,
		FondName NVARCHAR(100) NULL,
		InventoryNumber int NULL,
		DocumentNumber int NOT NULL,
		TimeInterval VARCHAR(50),
		Language CHAR(10) NULL 
		
	)
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Books')
BEGIN
	PRINT 'Create Books table'
	CREATE TABLE [dbo].[Books] (
		Id BIGINT CONSTRAINT PK_Books_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		Name NVARCHAR(150) NOT NULL,
		Author NVARCHAR(100) NOT NULL,
		PublishingYear CHAR(4) NOT NULL,
		TimeInterval VARCHAR(50),
		Language CHAR(10)
		
	)
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'HumanSourses')
BEGIN
	PRINT 'Create HumanSourses table'
	CREATE TABLE [dbo].[HumanSourses] (
		Id BIGINT CONSTRAINT PK_HumanSources_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		AuthorName NVARCHAR(150) NOT NULL,
		AuthorFamilyName NVARCHAR(100) NOT NULL,
		DateOfBirth Date NULL,
		PlaceOfBirth NVARCHAR(30) NULL,
		SharingDate Date NULL,
		TimeInterval VARCHAR(50) NULL,
		TypeOfInformation NVARCHAR(20) NOT NULL,
		Language CHAR(10)
		
	)
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'WebPages')
BEGIN
	PRINT 'Create WebPages table'
	CREATE TABLE [dbo].[WebPages] (
		Id BIGINT CONSTRAINT PK_WebPages_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		WebPage VARCHAR(150) NOT NULL,
		ExactLink VARCHAR(200) NOT NULL,
		TimeInterval VARCHAR(50) NULL,
		Language CHAR(10)
		
	)
END
GO

SET NOCOUNT OFF
