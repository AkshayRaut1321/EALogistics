﻿
CREATE TABLE PARTIES (
PARTYID INT
, NAME VARCHAR(100) NOT NULL
, ADDRESS VARCHAR(500)
, CITYID INT NOT NULL
, STATEID INT NOT NULL
, CONSTRAINT PK_PARTY_ID PRIMARY KEY(PARTYID)
, CONSTRAINT UK_PARTIES_NAME UNIQUE(NAME, CITYID)
, CONSTRAINT FK_PARTIES_CITYID FOREIGN KEY(CITYID) REFERENCES CITIES
, CONSTRAINT FK_PARTIES_STATEID FOREIGN KEY(STATEID) REFERENCES STATES
)
