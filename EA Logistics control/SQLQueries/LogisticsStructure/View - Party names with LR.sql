
CREATE VIEW View_CSM_Party AS
(
SELECT CNo, CDate, InvoiceNo, Packages, p1.Name as 'Consignor', p2.Name as 'Consignee', VehicleNo, Rate, Weight, Amount, Billed
FROM Consignments c JOIN Parties p1 ON p1.PartyID=c.SignorID JOIN Parties p2 ON c.SigneeID = p2.PartyID
)