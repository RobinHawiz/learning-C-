CREATE PROCEDURE [dbo].[spUsers_GetByEmailAddressAndPassword]
	@emailAddress nvarchar(100),
	@password nvarchar(20)
AS
begin
	set nocount on;

	select [u].[Id], [u].[FirstName], [u].[LastName], [u].[EmailAddress]
	from dbo.Users u
	where u.EmailAddress = @emailAddress
	and
	u.[Password] = @password

end
