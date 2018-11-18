
drop proc sp_ealog_GetKeyValue
go

create proc sp_ealog_GetKeyValue
@key varchar(60)
,@value varchar(60)
,@table varchar(30)
with encryption as set nocount on

declare @strQry nvarchar(500)
set @key = rtrim(ltrim(@key))
set @table = rtrim(ltrim(@table))
set @value = rtrim(ltrim(@value))

select @strQry = 'select distinct '  + @key + ', ' + @value  + ' from ' + @table

Exec SP_ExecuteSQL @strQry
return

--test
--exec sp_ealog_GetKeyValue 'CityId', 'City', 'cities'