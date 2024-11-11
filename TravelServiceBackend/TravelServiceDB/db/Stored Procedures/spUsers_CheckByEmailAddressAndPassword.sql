CREATE PROCEDURE [dbo].[spUsers_CheckByEmailAddressAndPassword]
	@emailAddress nvarchar(100),
	@password nvarchar(20)
AS
begin
	set nocount on;

	select 1
	from dbo.Users u
	where u.EmailAddress = @emailAddress
	and
	u.[Password] = @password


end