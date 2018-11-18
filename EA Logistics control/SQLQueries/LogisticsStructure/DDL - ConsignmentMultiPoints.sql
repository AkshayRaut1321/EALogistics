CREATE TABLE ConsignmentMultiPoints
(
ConsignmentNo INT
, ConsignmentDate DATE NOT NULL
, ThirdParty VARCHAR(200)
, CONSTRAINT pkConsignmentNo_Date_ThirdParty_MultiPoints PRIMARY KEY(ConsignmentNo, ConsignmentDate, ThirdParty)
, CONSTRAINT fkConsignment_MultiPoints FOREIGN KEY(ConsignmentNo,ConsignmentDate) REFERENCES Consignments(ConsignmentNo,ConsignmentDate)
)