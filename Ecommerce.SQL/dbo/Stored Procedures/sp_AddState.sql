CREATE PROCEDURE sp_AddState
    @Name NVARCHAR(MAX),
    @CountryId UNIQUEIDENTIFIER,
    @CreatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();
    DECLARE @Id UNIQUEIDENTIFIER = NEWID();

    INSERT INTO dbo.States (Id, Name, CountryId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive)
    VALUES (@Id, @Name, @CountryId, @CurrentDateTime, @CreatedBy, NULL, NULL, 1);

    SELECT @Id AS NewId;
END;