
SELECT * FROM Cities;
DROP TABLE ;
go;

drop proc sp_ealog_select
go

create proc sp_ealog_select @pid int=null, @flag varchar(10)
as
begin
	if @flag is null
		select * from Parties
	else if @flag='pid' and @pid is not null
		select * from parties where partyid=@pid
	else if @flag='names'
		select distinct name from parties
	else
		select * from parties where name=''
return 0
end
go

drop proc sp_ealog_IU @

