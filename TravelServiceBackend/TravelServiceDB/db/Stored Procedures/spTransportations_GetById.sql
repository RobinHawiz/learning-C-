CREATE PROCEDURE [dbo].[spTransportations_GetById]
	@Id int
AS
begin
	set nocount on;

	select t.Id, t.PriceMultiplier, t.Title
	from dbo.Transportations t
	where t.Id = @Id;
end
