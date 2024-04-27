CREATE PROCEDURE sp_AddCountry
    @Name NVARCHAR(MAX),
    @CreatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();
    DECLARE @Id UNIQUEIDENTIFIER = NEWID();

    INSERT INTO dbo.Countries (Id, Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive)
    VALUES (@Id, @Name, @CurrentDateTime, @CreatedBy, NULL, NULL, 1);

    SELECT @Id AS NewId;
END;