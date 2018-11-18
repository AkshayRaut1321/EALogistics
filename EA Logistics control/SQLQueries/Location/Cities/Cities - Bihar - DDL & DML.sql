--prepare database
use DbLocality
truncate table Cities
drop table Cities
go

--generating table
create table Cities(CityID int identity, City nvarchar(100) NOT NULL, StateID int NOT NULL, constraint pkCID_Cities PRIMARY KEY(CityID),
constraint ukCity_State_States unique(City, StateID), constraint fkSID_Cities_States FOREIGN KEY(StateID) REFERENCES States)

--insert Cities of Bihar of India
insert Cities values('Ara', 4)
insert Cities values('Araria', 4)
insert Cities values('Arrah', 4)
insert Cities values('Aurangabad', 4)
insert Cities values('Banka', 4)
insert Cities values('Begusarai', 4)
insert Cities values('Bettiah', 4)
insert Cities values('Bhabhua', 4)
insert Cities values('Bhagalpur', 4)
insert Cities values('Bihar Sharif', 4) 
insert Cities values('Buxar', 4)
insert Cities values('Chhapra', 4)
insert Cities values('Darbhanga', 4)
insert Cities values('Gaya', 4)
insert Cities values('Gopalganj', 4)
insert Cities values('Hajipur', 4)
insert Cities values('Jamui', 4)
insert Cities values('Katihar', 4)
insert Cities values('Kishanganj', 4)
insert Cities values('Lakhisarai', 4)
insert Cities values('Madhepura', 4)
insert Cities values('Madhubani', 4)
insert Cities values('Motihari', 4)
insert Cities values('Munger', 4)
insert Cities values('Muzaffarpur', 4)
insert Cities values('Nawada', 4)
insert Cities values('Patna', 4)
insert Cities values('Saharsa', 4)
insert Cities values('Sahibganj', 4)
insert Cities values('Samastipur', 4)
insert Cities values('Sasaram', 4)
insert Cities values('Shaikhpura', 4)
insert Cities values('Shivhar', 4)
insert Cities values('Sitamarhi', 4)
insert Cities values('Siwan', 4)
insert Cities values('Supaul', 4)
insert Cities values('Vaishali', 4)
