CREATE PROCEDURE [dbo].[spBookings_GetById]
	@id int
AS
begin
	set nocount on;

	select *
	from dbo.Bookings b
	where b.Id = @id;

end
