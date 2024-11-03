CREATE PROCEDURE [dbo].[spOrder_delete]
	@id int
AS
begin
	set nocount on;

	delete 
	from [dbo.Order]
	where id = @id;
end
