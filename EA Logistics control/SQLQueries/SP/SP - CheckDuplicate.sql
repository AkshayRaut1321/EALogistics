
drop proc sp_CheckDuplicate
go

create proc sp_CheckDuplicate @table varchar(30), @compare varchar(60), @param varchar(100), @retval bit output with encryption
as set nocount on
	declare @strQry nvarchar(500)
	select @strQry = 'select @dy_retval=1  from ' + rtrim(ltrim(@table)) + ' where '+ @compare + '=''' + rtrim(ltrim(@param))+''''
	Exec SP_ExecuteSQL @strQry, N'@dy_retval char(60) output', @retval output
	if @retval is null set @retval=0 else set @retval=1
return

declare @retval bit
exec sp_CheckDuplicate 'Consignments', 'CNo', '10', @retval output
select @retval