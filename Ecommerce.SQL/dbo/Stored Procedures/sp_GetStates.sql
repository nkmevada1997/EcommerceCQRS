CREATE PROCEDURE sp_GetStates
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, CountryId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.States
    WHERE IsActive = 1;
END;