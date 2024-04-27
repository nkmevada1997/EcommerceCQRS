CREATE PROCEDURE sp_DeleteCity
    @Id UNIQUEIDENTIFIER,
    @UpdatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();

    UPDATE dbo.Cities
    SET IsActive = 0,
        UpdatedDate = @CurrentDateTime,
        UpdatedBy = @UpdatedBy
    WHERE Id = @Id;
END;