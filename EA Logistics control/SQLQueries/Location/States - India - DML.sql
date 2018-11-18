--prepare database
use DbLocality
truncate table States
drop table States
go

--generating table
create table States(StateID int identity, State nvarchar(100) NOT NULL, CountryID int NOT NULL, constraint pkStateID_States PRIMARY KEY(StateID),
constraint ukState_States unique(State), constraint fkCID_States_Countries FOREIGN KEY(CountryID) REFERENCES Countries)

--inserting States of India
insert States values('Andhra Pradesh', 42)
insert States values('Arunachal Pradesh', 42)
insert States values('Assam', 42)
insert States values('Bihar', 42)
insert States values('Chhattisgarh', 42)
insert States values('Dadra & Nagar Haveli', 42)
insert States values('Delhi', 42)
insert States values('Goa', 42)
insert States values('Gujarat', 42)
insert States values('Haryana', 42)
insert States values('Himachal Pradesh', 42)
insert States values('Jammu & Kashmir', 42)
insert States values('Jharkhand', 42)
insert States values('Karnataka', 42)
insert States values('Kerala', 42)
insert States values('Maharashtra', 42)
insert States values('Madhya Pradesh', 42)
insert States values('Manipur', 42)
insert States values('Meghalaya', 42)
insert States values('Mizoram', 42)
insert States values('Nagaland', 42)
insert States values('Punjab', 42)
insert States values('Rajasthan', 42)
insert States values('Sikkim', 42)
insert States values('Tamilnadu', 42)
insert States values('Telangana', 42)
insert States values('Tripura', 42)
insert States values('Uttar Pradesh', 42)
insert States values('West Bengal', 42)
