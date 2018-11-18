
drop proc sp_ealog_GetScalar
go

create proc sp_ealog_GetScalar @retrieve char(60), @table char(30), @compare char(30), @param char(100)=null
with encryption as set nocount on
declare @strQry nvarchar(500)
declare @retval char(500)

if @compare = 'max' and @param is null
	select @strQry = 'select @dy_retval=max(' + rtrim(ltrim(@retrieve)) + ') from ' + rtrim(ltrim(@table))
else
	select @strQry = 'select @dy_retval=' + rtrim(ltrim(@retrieve)) + ' from ' + rtrim(ltrim(@table)) + ' where '+ @compare + '=''' + rtrim(ltrim(@param))+''''
Exec SP_ExecuteSQL @strQry, N'@dy_retval char(60) output', @retval output
select @retval
return
