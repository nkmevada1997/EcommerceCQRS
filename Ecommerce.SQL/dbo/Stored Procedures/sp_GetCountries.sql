CREATE PROCEDURE sp_GetCountries
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.Countries
    WHERE IsActive = 1;
END;