
drop proc sp_ealog_consignments
go

create proc sp_ealog_consignments @option varchar(10), @ConsignmentNo int=null, @BillNo int=null, @ConsignmentDate date=null, @InvoiceNo varchar(20)=null
, @SignorId int=null, @SigneeId int=null, @travelFromInt int=null, @travelToInt int=null, @packages int=null, @contents varchar(500)=null
, @vehicleno varchar(20)=null, @rate decimal(12,2)=null, @weight decimal(12,2)=null, @amount decimal(12,2)=null, @billed bit=null
as
begin
	if @option='retrieve'
	begin
		select c1.*, p1.Name as 'SignorStr', p2.Name as 'SigneeStr', c2.City as 'TravelFromStr', c3.City as 'TravelToStr' from consignments c1
		join cities c2 on c1.TravelFrom= c2.CityID join cities c3 on c1.TravelTo= c3.CityID join Parties p1 on c1.SignorID=p1.PartyID
		join Parties p2 on c1.SigneeID=p2.PartyID where
		(ConsignmentNo = @ConsignmentNo or @ConsignmentNo=-1)
		and (Billed = @billed or @billed = 0)
	end
	else if @option='entry'
	begin
		insert into consignments (ConsignmentNo, ConsignmentDate,InvoiceNo,SignorId,SigneeId,TravelFrom,TRAVELTO,PACKAGES,CONTENTS,VehicleNO,RATE,WEIGHT,AMOUNT)
		values(@ConsignmentNo,@ConsignmentDate,@InvoiceNo,@SignorId,@SigneeId,@TravelFromInt,@travelToInt,@Packages,@Contents,@VehicleNo,@Rate,@Weight,@Amount)
	end
	else if @option='update'
	begin
		update consignments set BillNo=@BillNo, ConsignmentDate=@ConsignmentDate, InvoiceNo=@InvoiceNo, SignorID=@SignorId, SigneeID=@SigneeId, TravelFrom=@travelFromInt, TravelTo=@travelToInt,
		Packages=@Packages, Contents=@Contents, VehicleNo=@VehicleNo, Rate=@Rate, Weight=@Weight, Amount=@Amount, Billed=@Billed where ConsignmentNo=@ConsignmentNo
	end
	else if @option='remove'
	begin
		delete from consignments where ConsignmentNo=@ConsignmentNo
	end
end
go

--declare @res int
--exec @res = sp_ealog_consignments 'ins', null, 10, '12/21/2015', 'c', 3, 4, 3, 4, 300, 'some boxes', 'MH430k', 2000, 12.682, 12000, 0
--print @res

--exec sp_ealog_consignments 'sel','cno',@ConsignmentNo=10
