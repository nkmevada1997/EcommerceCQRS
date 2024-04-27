CREATE PROCEDURE sp_GetCountryDetail
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.Countries
    WHERE Id = @Id
    AND IsActive = 1;
END;