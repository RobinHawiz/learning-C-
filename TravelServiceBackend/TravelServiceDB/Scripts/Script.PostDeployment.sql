

begin
	set nocount on;

	if not exists (select 1 from dbo.Zones)
		begin
			insert into dbo.Zones (Title, Price)
			values ('En zon', 20)
				 , ('Två zoner', 40)
				 , ('Till eller från Arlanda', 75)
		end
	if not exists (select 1 from dbo.Transportations)
	begin
		insert into dbo.Transportations(Title, Price)
		values ('Samåkning', 2)
				, ('Egen bil', 4)
	end
end