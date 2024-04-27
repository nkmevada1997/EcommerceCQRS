CREATE PROCEDURE sp_AddCity
    @Name NVARCHAR(MAX),
    @StateId UNIQUEIDENTIFIER,
    @CreatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();
    DECLARE @Id UNIQUEIDENTIFIER = NEWID();

    INSERT INTO dbo.Cities (Id, Name, StateId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive)
    VALUES (@Id, @Name, @StateId, @CurrentDateTime, @CreatedBy, NULL, NULL, 1);

    SELECT @Id AS NewId;
END;