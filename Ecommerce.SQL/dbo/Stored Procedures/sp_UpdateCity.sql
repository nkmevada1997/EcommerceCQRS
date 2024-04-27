CREATE PROCEDURE sp_UpdateCity
    @Id UNIQUEIDENTIFIER,
    @Name NVARCHAR(MAX),
    @StateId UNIQUEIDENTIFIER,
    @UpdatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();

    UPDATE dbo.Cities
    SET Name = @Name,
        StateId = @StateId,
        UpdatedDate = @CurrentDateTime,
        UpdatedBy = @UpdatedBy
    WHERE Id = @Id;
END;