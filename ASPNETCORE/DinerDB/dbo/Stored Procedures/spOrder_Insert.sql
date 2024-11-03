CREATE PROCEDURE [dbo].[spOrder_Insert]
	@OrderName nvarchar(50),
	@OrderDate datetime2,
	@FoodId int,
	@Quantity int,
	@Total money,
	@Id int output
AS
begin
	set nocount on;

	insert dbo.[Order](OrderName, OrderDate, FoodId, Quantity, Total)
	values(@OrderName, @OrderDate, @FoodId, @Quantity, @Total);

	set @id = SCOPE_IDENTITY();
end
