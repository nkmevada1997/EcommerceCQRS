CREATE PROCEDURE sp_UpdateCountry
    @Id UNIQUEIDENTIFIER,
    @Name NVARCHAR(MAX),
    @UpdatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();

    UPDATE dbo.Countries
    SET Name = @Name,
        UpdatedDate = @CurrentDateTime,
        UpdatedBy = @UpdatedBy
    WHERE Id = @Id;
END;