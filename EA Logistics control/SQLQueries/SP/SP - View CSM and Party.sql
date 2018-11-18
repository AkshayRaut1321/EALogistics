
drop proc sp_ealog_V_CSM_Party
go

create proc sp_ealog_V_CSM_Party @flag varchar(10), @pid int=null, @pname varchar(100)=null
as
begin
	select * from sp_ealog_V_CSM_Party
end
go
