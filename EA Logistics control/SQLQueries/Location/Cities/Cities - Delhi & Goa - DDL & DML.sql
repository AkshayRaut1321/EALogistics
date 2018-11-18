--prepare database
use DbLocality
truncate table Cities
drop table Cities
go

--generating table
create table Cities(CityID int identity, City nvarchar(100) NOT NULL, StateID int NOT NULL, constraint pkCID_Cities PRIMARY KEY(CityID),
constraint ukCity_State_States unique(City, StateID), constraint fkSID_Cities_States FOREIGN KEY(StateID) REFERENCES States)

--insert Cities of Delhi & Goa of India
insert Cities values('Greater Noida', 7)

insert Cities values('Panaji', 8)
