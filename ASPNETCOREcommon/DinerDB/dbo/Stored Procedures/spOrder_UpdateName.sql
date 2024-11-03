CREATE PROCEDURE [dbo].[spOrder_UpdateName]
	@id int,
	@orderName nvarchar(50)
AS
begin
	set nocount on;

	update [dbo.Order]
	set OrderName = @orderName
	where id = @id;
end