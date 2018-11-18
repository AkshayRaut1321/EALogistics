CREATE TABLE CatCharges(
ChargeID INT
, Name VARCHAR(50)
, CONSTRAINT pkChargeID_CatCharges PRIMARY KEY(ChargeID)
, CONSTRAINT ukName_CatCharges UNIQUE(Name)
)
