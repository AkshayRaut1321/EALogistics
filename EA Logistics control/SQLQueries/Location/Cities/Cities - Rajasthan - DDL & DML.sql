--prepare database
use DbLocality
truncate table Cities
drop table Cities
go

--generating table
create table Cities(CityID int identity, City nvarchar(100) NOT NULL, StateID int NOT NULL, constraint pkCID_Cities PRIMARY KEY(CityID),
constraint ukCity_State_States unique(City, StateID), constraint fkSID_Cities_States FOREIGN KEY(StateID) REFERENCES States)

--insert Cities of Rajasthan of India
insert Cities values('Ajmer', 23)
insert Cities values('Alwar', 23)
insert Cities values('Banswara', 23)
insert Cities values('Baran', 23)
insert Cities values('Barmer', 23)
insert Cities values('Bharatpur', 23)
insert Cities values('Bhilwara', 23)
insert Cities values('Bikaner', 23)
insert Cities values('Bundi', 23)
insert Cities values('Chittaurgarh', 23)
insert Cities values('Churu', 23)
insert Cities values('Dausa', 23)
insert Cities values('Dhaulpur', 23)
insert Cities values('Dungarpur', 23)
insert Cities values('Hanumangarh', 23)
insert Cities values('Jaipur', 23)
insert Cities values('Jaisalmer', 23)
insert Cities values('Jalor', 23)
insert Cities values('Jhalawar', 23)
insert Cities values('Jhunjhunun', 23)
insert Cities values('Karauli', 23)
insert Cities values('Kota', 23)
insert Cities values('Nagaur', 23)
insert Cities values('Pali', 23)
insert Cities values('Rajsamand', 23)
insert Cities values('Sawai Madhopur ', 23) 
insert Cities values('Sikar', 23)
insert Cities values('Sirohi', 23)
insert Cities values('Tonk', 23)
insert Cities values('Udaipur', 23)
