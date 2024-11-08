CREATE PROCEDURE [dbo].[spUsers_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(100),
	@Password nvarchar(20)
AS
	begin
		set nocount on;

		insert dbo.Users(FirstName, LastName, EmailAddress, [Password])
		values(@FirstName, @LastName, @EmailAddress, @Password);
	end
