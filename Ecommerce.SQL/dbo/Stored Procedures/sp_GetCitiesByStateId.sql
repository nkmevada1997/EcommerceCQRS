CREATE PROCEDURE sp_GetCitiesByStateId
    @StateId UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, StateId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy, IsActive
    FROM dbo.Cities
    WHERE StateId = @StateId
    AND IsActive = 1;
END;