
drop proc sp_ealog_cities_select
go
create proc sp_ealog_cities_select @flag varchar(20), @cid int=null, @cname varchar(100)=null, @sid int=null
as
begin
	if @flag='all'
		select * from Cities
	else if @flag='AutoComplete'
		select CityID, City from Cities
	else if @flag='AllByPK' and @cid is not null
		select * from Cities where cityid = @cid
	else if @flag='AllByName' and @cname is not null
		select * from Cities where City = @cname
	else if @flag='AllByNameLike' and @cname is not null
		select * from Cities where City like '%' + @cname + '%'
	else if @flag='AllByFK' and @sid is not null
		select * from Cities where stateid = @sid
	else
		select * from cities where city=''
end
go
