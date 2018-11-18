CREATE TABLE ConsignmentMultiPointCharges(
ConsignmentNo INT
,ConsignmentDate Date
,CHARGE INT
,CONSTRAINT pkConsignmentNo_Date_PointCharges PRIMARY KEY(ConsignmentNo, ConsignmentDate)
,CONSTRAINT fkConsignment_Date_PointCharges_Consignments FOREIGN KEY(ConsignmentNo,ConsignmentDate) REFERENCES CONSIGNMENTS(ConsignmentNo, ConsignmentDate)
)
