CREATE PROCEDURE [dbo].[spBookings_GetAllByUserId]
	@userId int
AS
begin
	set nocount on;

	select [Id], [TransportationId], [ZoneId], [UserId], [StartDate], [EndDate], [Wheelchair], [TotalCost], [AddressFrom], [AddressTo]
	from dbo.Bookings b
	where b.UserId = @userId;

end
