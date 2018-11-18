
drop proc sp_ealog_parties_select
go

create proc sp_ealog_parties_select @flag varchar(10), @pid int=null, @pname varchar(100)=null
as
begin
	if @flag='pid' and @pid is not null
		select * from parties where partyid=@pid
	else if @flag='names'
		select distinct name from parties
	else if @flag='all'
		select * from Parties
	else if @flag='IdByName' and @pname is not null
		select partyid from parties where name=@pname
	else
		select * from parties where name=''
end
go
