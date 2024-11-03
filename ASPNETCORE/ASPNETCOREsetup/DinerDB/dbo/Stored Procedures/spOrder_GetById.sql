CREATE PROCEDURE [dbo].[spOrder_GetById]
	@id int
AS
begin
	set nocount on;

	select Id
		 , OrderName
		 , OrderDate
		 , FoodId
		 , Quantity
		 , Total
	from dbo.[Order]
	where id = @id;
end
