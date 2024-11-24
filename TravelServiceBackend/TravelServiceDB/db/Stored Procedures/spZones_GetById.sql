CREATE PROCEDURE [dbo].[spZones_GetById]
	@Id int
AS
begin
	set nocount on;

	select z.Id, z.Price, z.Title
	from dbo.Zones z
	where z.Id = @Id;
end
