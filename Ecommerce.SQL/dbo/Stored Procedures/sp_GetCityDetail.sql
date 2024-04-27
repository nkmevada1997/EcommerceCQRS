CREATE PROCEDURE sp_GetCityDetail
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, StateId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.Cities
    WHERE Id = @Id
    AND IsActive = 1;
END;