CREATE VIEW [dbo].[PersonPrimaryPhoneView]
AS
select [p].[Id], [p].[FirstName], [p].[LastName], [p].[DateOfBirth], [p].[EmailAddress], ph.PhoneNumber
from dbo.Person p
left join dbo.PhoneNumber ph on p.Id = ph.PersonId and ph.PrimaryNumber = 1
