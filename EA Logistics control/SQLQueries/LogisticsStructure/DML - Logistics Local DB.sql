
INSERT INTO Parties VALUES(1,'Abc','ABC', 1, 1)
INSERT INTO Parties VALUES(2,'Bcd','BCD',2, 2)
INSERT INTO Parties VALUES(3,'Cde','CDE',3,3)
INSERT INTO Parties VALUES(4, 'Old age boxing','oae',4,4)

SELECT * FROM ;

INSERT INTO Consignments VALUES(1, '12/21/2015', 'a', 1, 2, 1, 2, NULL, NULL, NULL, NULL, NULL, NULL, '')
INSERT INTO Consignments VALUES(2, '12/21/2015', 'b', 2, 3, 2, 3, 750, 'some boxes', 'MH S0M3 7H1N6', 2000, 1.689,  0.0, '')
INSERT INTO Consignments VALUES(3, '12/21/2015', 'c', 3, 4, 3, 4, 300, 'some other boxes', 'MH0th3r7H1N6', 2000, 1.689,  0.0, '')
INSERT INTO Consignments VALUES(4, '12/21/2015', 'c', 3, 4, 3, 4, 300, 'some other boxes', 'MH0th3r7H1N6', 2000, -9,  0.0, '')


INSERT INTO Bills VALUES(1, '12/21/2015', 1, 30256)

INSERT INTO BillsAndCSMs VALUES(1, 1)
INSERT INTO BillsAndCSMs VALUES(1, 2)

INSERT INTO CatCharges VALUES(1, 'Advance payment')
INSERT INTO CatCharges VALUES(2, 'Checkpost')
INSERT INTO CatCharges VALUES(3, 'Halting')
INSERT INTO CatCharges VALUES(4, 'Length (open door)')
INSERT INTO CatCharges VALUES(5, 'Loading')
INSERT INTO CatCharges VALUES(6, 'Multipoint')
INSERT INTO CatCharges VALUES(7, 'Points')
INSERT INTO CatCharges VALUES(8, 'Statical')
INSERT INTO CatCharges VALUES(9, 'Unloading')

INSERT INTO AppCharges VALUES(1, 7, 100)
INSERT INTO AppCharges VALUES(1, 8, 100)
INSERT INTO AppCharges VALUES(1, 2, 100)
