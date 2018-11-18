﻿CREATE TABLE CONSIGNMENTS
(
ConsignmentNo INT
,BillNo INT
,ConsignmentDate DATE NOT NULL
,InvoiceNo VARCHAR(20)
,SignorId INT NOT NULL
,SigneeId INT NOT NULL
,TravelFrom INT NOT NULL
,TRAVELTO INT NOT NULL
,PACKAGES INT
,CONTENTS VARCHAR(500)
,VehicleNO VARCHAR(20)
,RATE decimal(12,2)
,WEIGHT decimal(12,2)
,AMOUNT decimal(12,2)
,BILLED BIT DEFAULT(0)
,CONSTRAINT pkConsignmentNo_Date_Consignments PRIMARY KEY(ConsignmentNo, ConsignmentDate)
,CONSTRAINT fkSignorId_Consignments FOREIGN KEY(SIGNORID) REFERENCES PARTIES(PARTYID)
,CONSTRAINT fkSigneeId_Consignments FOREIGN KEY(SIGNEEID) REFERENCES PARTIES(PARTYID)
,CONSTRAINT fkTravelFrom_Consignments FOREIGN KEY(TRAVELFROM) REFERENCES CITIES(CITYID)
,CONSTRAINT fkTravelTo_Consignments FOREIGN KEY(TRAVELTO) REFERENCES CITIES(CITYID)
)
