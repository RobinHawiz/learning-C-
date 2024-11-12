CREATE PROCEDURE [dbo].[spBookings_Insert]
	@transportationId int,
	@zoneId int,
	@userId int,
	@startDate datetime2,
	@endDate datetime2,
	@wheelChair bit,
	@totalCost money,
	@addressFrom nvarchar(100),
	@addressTo nvarchar(100)
AS
begin
	set nocount on;

	insert dbo.Bookings (TransportationId, ZoneId, UserId, StartDate, EndDate, Wheelchair, TotalCost, AddressFrom, AddressTo)
				 values (@transportationId, @zoneId, @userId, @startDate, @endDate, @wheelChair, @totalCost, @addressFrom, @addressTo)

end
