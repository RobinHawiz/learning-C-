CREATE PROCEDURE [dbo].[spZones_GetAll]
AS
begin
	set nocount on;

	select z.Id, z.Price, z.Title
	from dbo.Zones z;
end
