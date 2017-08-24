SET NOCOUNT ON
USE Emigrace

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persons')
BEGIN
	PRINT 'Create Persons table'
	CREATE TABLE [dbo].[Persons] (
		Id BIGINT CONSTRAINT PK_Persons_Id PRIMARY KEY IDENTITY(1,1) NOT NULL,
		SourceTypeID BIGINT NOT NULL,
		CONSTRAINT FK_Persons_SourceTypeId FOREIGN KEY(SourceTypeId) REFERENCES SourceTypes(Id),
		SourceId BIGINT NOT NULL,
		Name_Latin NVARCHAR(50) NOT NULL,
		FamilyName_Latin NVARCHAR(50) NOT NULL,
		Name_Cyrillic NVARCHAR(50) NOT NULL,
		FamilyName_Cyrillic NVARCHAR(50) NOT NULL,
		Sex CHAR(1) NOT NULL,
		FatherName NVARCHAR(50) NULL,
		DateOfBirth Date NULL,
		Citizenship NVARCHAR(40) NULL,
		PlaceOfBirthId BIGINT NULL,
		PlaceOfEmigrationId BIGINT NULL,
		PlaceOfLivingId BIGINT NULL,
		CONSTRAINT FK_Persons_PlaceOfBirthId FOREIGN KEY(PlaceOfBirthId) REFERENCES Cities(Id),
		CONSTRAINT FK_Persons_PlaceOfEmigrationId FOREIGN KEY(PlaceOfEmigrationId) REFERENCES Cities(Id),
		CONSTRAINT FK_Persons_PlaceOfLivingId FOREIGN KEY(PlaceOfLivingId) REFERENCES Cities(Id),
		FatherId BIGINT NULL,
		MotherId BIGINT NULL,
		CONSTRAINT FK_Persons_FatherId FOREIGN KEY(FatherId) REFERENCES Persons(Id),
		CONSTRAINT FK_Persons_MotherId FOREIGN KEY(MotherId) REFERENCES Persons(Id),
		MaritalStatus NVARCHAR NULL,
		PartnerId BIGINT NULL,
		CONSTRAINT FK_Persons_PartnerId FOREIGN KEY(PartnerId) REFERENCES Persons(Id),
		Profession NVARCHAR(50) NULL,
		Notice NVARCHAR(1000) NULL,
		PhotoNumber VARCHAR(50) NULL
	)
END
GO
SET NOCOUNT OFF
