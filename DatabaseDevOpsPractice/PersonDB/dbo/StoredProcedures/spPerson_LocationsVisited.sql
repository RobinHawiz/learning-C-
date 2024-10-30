CREATE PROCEDURE [dbo].[spPerson_LocationsVisited]
	@personId int

AS
begin
	set nocount on;

	select [l].[LocationName], [l].[Location], [v].[VisitDate]
	from dbo.person p
	inner join dbo.LocationVisit v on p.Id = v.PersonId
	inner join dbo.[Location] l on l.Id = v.LocationId
	where p.Id = @personId;

end