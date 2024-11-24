CREATE PROCEDURE [dbo].[spBookings_Insert]
	@TransportationId int,
	@ZoneId int,
	@UserId int,
	@StartDate datetime2,
	@EndDate datetime2,
	@WheelChair bit,
	@TotalCost money,
	@AddressFrom nvarchar(100),
	@AddressTo nvarchar(100),
	@Id int output
AS
begin
	set nocount on;

	insert dbo.Bookings (TransportationId, ZoneId, UserId, StartDate, EndDate, Wheelchair, TotalCost, AddressFrom, AddressTo)
				 values (@TransportationId, @ZoneId, @UserId, @StartDate, @EndDate, @WheelChair, @TotalCost, @AddressFrom, @AddressTo);

	set @Id = SCOPE_IDENTITY();

end
