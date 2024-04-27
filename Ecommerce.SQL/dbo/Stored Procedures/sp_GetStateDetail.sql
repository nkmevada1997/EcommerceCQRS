CREATE PROCEDURE sp_GetStateDetail
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, CountryId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.States
    WHERE Id = @Id
    AND IsActive = 1;
END;