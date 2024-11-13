CREATE PROCEDURE [dbo].[spBookings_UpdateAddress]
	@Id int,
	@ZoneId int,
	@AddressFrom datetime2,
	@AddressTo datetime2

AS
begin
	set nocount on

	update dbo.Bookings
	set AddressFrom = @AddressFrom
	  , AddressTo = @AddressTo
	  , ZoneId = @ZoneId
	where Id = @Id;
end
