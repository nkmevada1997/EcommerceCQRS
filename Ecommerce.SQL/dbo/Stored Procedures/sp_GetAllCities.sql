CREATE PROCEDURE sp_GetAllCities
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, StateId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.Cities
    WHERE IsActive = 1;
END;