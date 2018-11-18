CREATE TABLE USERS(
--Columns
SqlId INT IDENTITY --serial number ever increasing
,JPGUID NVARCHAR(32) NOT NULL --globally unique id
,LoginId NVARCHAR(8) NOT NULL -- login id
,FIRSTNAME NVARCHAR(45) NOT NULL -- first name of user
,LASTNAME NVARCHAR(45) -- last name of user
,ACTIVE BIT DEFAULT(1) -- whether a user is active admin is always active
,LoginPW NVARCHAR(MAX) NOT NULL -- password
,GENDER numeric(1) default(2) -- male female or unspecified
,MaritalStatus NUMERIC(1) default(0) -- single married or widowed
,DOB DATE -- date of birth
,ValidFrom date default(getdate()) -- validity for users exceeding validity cannot access software. default value is current date
,ValidTo date default(getdate() + 30) -- when validity last date is not supplied a sample one month of access is assigned
,SECQUEST NVARCHAR(50) -- security question and answer in case a user forgets her/his password
,SECANSWER NVARCHAR(50) 
,TWOSTEP BIT default(0) -- if a user has given his contact detail and activated two step security then he will need to use phone or email to login.
,TWOSTEPCODE NUMERIC(6) -- two step code which is sent to phone or email will stored temporarily here.
,CreatedOn DATETIME default(getdate()) -- date and time when this user was added
,CreatedBy NVARCHAR(45) -- name of person who added this user
,AccessLevel numeric(1) default(9) -- permission level of user
-- Constraints
,CONSTRAINT pkSqlId_Users PRIMARY KEY(SqlId) -- primary key is the serial number of entry
,CONSTRAINT ukGuid_Users UNIQUE(JPGuid) -- Guid for merging with other databases
,CONSTRAINT ukLoginId_Users UNIQUE(LoginId) -- makes sure login id of users who are going to use this software is unique
,CONSTRAINT ckActive_Users CHECK(Active=0 OR Active=1) -- allows 0 for Inactive or 1 for active. 
,CONSTRAINT ckGender_Users CHECK(GENDER>=0 OR GENDER<=2) -- makes sure it is male female or unspecified
,CONSTRAINT ckMarital_Users CHECK(MaritalStatus>=0 OR MaritalStatus<=2) -- allows only single married or widowed
,CONSTRAINT ckDob_Users CHECK(DOB<=dateadd(YEAR, -18, getdate())) -- only allows users who are 18years old or above
,CONSTRAINT ckValidFrom Check(ValidFrom <= ValidTo) -- ValidFrom should be less than or equal to ValidTo
,CONSTRAINT ckAccess_USERS CHECK(AccessLevel>=0 OR AccessLevel<=4) -- permitted from Superior Manager Cashier Operator Clerks
,CONSTRAINT ck2Step_Users CHECK(TwoStep=0 OR TwoStep=1) -- 0 for disabled and 1 for enabled two step.
)