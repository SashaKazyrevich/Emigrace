SET NOCOUNT ON

IF NOT EXISTS (SELECT * FROM SourceTypes)
BEGIN
	PRINT 'Inserting SourceTypes data'
	INSERT INTO [dbo].[SourceTypes] 
		(Name)
	VALUES
		('Archival document'),
		('Book'),
		('Web page'),
		('Human Source')
		
END
GO

SET NOCOUNT OFF