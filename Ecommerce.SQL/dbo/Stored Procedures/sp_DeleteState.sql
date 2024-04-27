CREATE PROCEDURE sp_DeleteState
    @Id UNIQUEIDENTIFIER,
    @UpdatedBy UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDateTime DATETIME = GETUTCDATE();

    UPDATE dbo.States
    SET IsActive = 0,
        UpdatedDate = @CurrentDateTime,
        UpdatedBy = @UpdatedBy
    WHERE Id = @Id;
END;