--prepare database
use DbLocality
truncate table Cities
drop table Cities
go

--generating table
create table Cities(CityID int identity, City nvarchar(100) NOT NULL, StateID int NOT NULL, constraint pkCID_Cities PRIMARY KEY(CityID),
constraint ukCity_State_States unique(City, StateID), constraint fkSID_Cities_States FOREIGN KEY(StateID) REFERENCES States)

--insert Cities of Gujarat of India
insert Cities values('Ahmadabad', 9)
insert Cities values('Ahwa', 9)
insert Cities values('Amerli', 9)
insert Cities values('Anand', 9)
insert Cities values('Bhavnagar', 9)
insert Cities values('Bhuj', 9)
insert Cities values('Daman', 9)
insert Cities values('Gandhinagar', 9)
insert Cities values('Godhra', 9)
insert Cities values('Himatnagar', 9)
insert Cities values('Jamnagar', 9)
insert Cities values('Junagadh', 9)
insert Cities values('Mahesana', 9)
insert Cities values('Nadiad', 9)
insert Cities values('Palanpur', 9)
insert Cities values('Patan', 9)
insert Cities values('Porbandar', 9)
insert Cities values('Rajkot', 9)
insert Cities values('Rajpipla', 9)
insert Cities values('Surat', 9)
insert Cities values('Surendranagar', 9)
insert Cities values('Vadodara', 9)
insert Cities values('Valsad', 9)
