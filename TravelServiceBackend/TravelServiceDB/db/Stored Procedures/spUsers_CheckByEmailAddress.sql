CREATE PROCEDURE [dbo].[spUsers_GetByEmailAddress]
	@emailAddress nvarchar(100)
AS
begin
	set nocount on;

	select 1
	from dbo.Users u
	where u.EmailAddress = @emailAddress; 

end