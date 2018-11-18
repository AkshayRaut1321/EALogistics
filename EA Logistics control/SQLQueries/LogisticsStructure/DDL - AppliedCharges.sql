CREATE TABLE AppliedCharges
(
ConsignmentNo INT
,ConsignmentDate Date
,ChargeId INT
,Value INT
,CONSTRAINT pkConsignmentNo_Date_ChargeId_AppliedCharges PRIMARY KEY(ConsignmentNo, ConsignmentDate, ChargeId)
,CONSTRAINT fkConsignmentNo_AppliedCharges FOREIGN KEY(ConsignmentNo, ConsignmentDate) REFERENCES CONSIGNMENTS(ConsignmentNo, ConsignmentDate)
,CONSTRAINT fkChargeId_AppliedChargesFOREIGN FOREIGN KEY(ChargeId) REFERENCES CATCHARGES(ChargeId)
)
