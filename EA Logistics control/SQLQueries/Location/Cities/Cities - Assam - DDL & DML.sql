--prepare database
use DbLocality
truncate table Cities
drop table Cities
go

--generating table
create table Cities(CityID int identity, City nvarchar(100) NOT NULL, StateID int NOT NULL, constraint pkCID_Cities PRIMARY KEY(CityID),
constraint ukCity_State_States unique(City, StateID), constraint fkSID_Cities_States FOREIGN KEY(StateID) REFERENCES States)

--insert Cities of Assam of India
insert Cities values('Bongaigaon', 3)
insert Cities values('Dibrugarh', 3)
insert Cities values('Diphu', 3)
insert Cities values('Goalpara', 3)
insert Cities values('Guwahati', 3)
insert Cities values('Haflong', 3)
insert Cities values('Hailakandi', 3)
insert Cities values('Jorhat', 3)
insert Cities values('Kalasib', 3)
insert Cities values('Kamargaon', 3)
insert Cities values('Karimganj', 3)
insert Cities values('Kokrajhar', 3)
insert Cities values('Lakhimpur', 3)
insert Cities values('Mangaldai', 3)
insert Cities values('Marigaon', 3)
insert Cities values('Nagaon', 3)
insert Cities values('Nalbari', 3)
insert Cities values('Sibsagar', 3)
insert Cities values('Silchar', 3)
insert Cities values('Tezpur', 3)
insert Cities values('Tinsukia', 3)
