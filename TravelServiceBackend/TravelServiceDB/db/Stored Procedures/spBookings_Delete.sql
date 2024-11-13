CREATE PROCEDURE [dbo].[spBookings_Delete]
	@id int
AS
begin
	set nocount on

	delete
	from dbo.Bookings
	where Id = @id;
end
