CREATE PROCEDURE sp_GetStatesByCountryId
    @CountryId UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, CountryId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.States
    WHERE CountryId = @CountryId
	AND IsActive = 1;
END;