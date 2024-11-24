CREATE PROCEDURE [dbo].[spTransportations_GetAll]
AS
begin
	set nocount on;

	select t.Id, t.PriceMultiplier, t.Title
	from dbo.Transportations t;
end
