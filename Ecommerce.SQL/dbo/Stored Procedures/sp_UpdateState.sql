CREATE PROCEDURE sp_UpdateState
    @Id UNIQUEIDENTIFIER,
    @Name NVARCHAR(MAX),
    @CountryId UNIQUEIDENTIFIER,
    @UpdatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();

    UPDATE dbo.States
    SET Name = @Name,
        CountryId = @CountryId,
        UpdatedDate = @CurrentDateTime,
        UpdatedBy = @UpdatedBy
    WHERE Id = @Id;
END;