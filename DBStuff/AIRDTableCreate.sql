drop table Manufacturer;
drop table FirearmType;
drop table ActionType;
drop table Caliber;



CREATE TABLE ListTypes(
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,                      
    Name TEXT NOT NULL,
    Description TEXT NULL
);


CREATE TABLE FirearmType (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
    ListTypeId INTEGER 
        CONSTRAINT FK_FirearmType_ListType REFERENCES ListTypes (Id) NOT NULL, 
    Name TEXT NOT NULL, 
    Description TEXT
);

CREATE TABLE ActionType (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ListTypeId INTEGER 
        CONSTRAINT FK_FirearmType_ListType REFERENCES ListTypes (Id) NOT NULL, 
    Name TEXT NOT NULL,
    Description TEXT NULL
);

CREATE TABLE Caliber (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ListTypeId INTEGER 
        CONSTRAINT FK_FirearmType_ListType REFERENCES ListTypes (Id) NOT NULL,                      
    CaliberInches REAL NOT NULL,
    CaliberMetricDiameter REAL NULL,
    CaliberMetricLength INTEGER  NULL
);

CREATE TABLE Model (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT
                        NOT NULL,
    ListTypeId  INTEGER CONSTRAINT FK_Model_ListType REFERENCES ListTypes (Id) 
                        NOT NULL,
    Name        TEXT    NOT NULL,
    Description TEXT
);

CREATE TABLE SubModel (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT
                        NOT NULL,
    ListTypeId  INTEGER CONSTRAINT FK_SubModel_ListType REFERENCES ListTypes (Id) 
                        NOT NULL,
    Name        TEXT    NOT NULL,
    Description TEXT
);

CREATE TABLE Platform (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT
                        NOT NULL,
    ListTypeId  INTEGER CONSTRAINT FK_Platform_ListType REFERENCES ListTypes (Id) 
                        NOT NULL,
    Name        TEXT    NOT NULL,
    Description TEXT
);

CREATE TABLE Manufacturer (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ListTypeId INTEGER 
        CONSTRAINT FK_FirearmType_ListType REFERENCES ListTypes (Id) NOT NULL,                      
    Name TEXT NOT NULL,
    ShortName TEXT NULL,
    Location TEXT NULL,
    Url TEXT NULL
);


CREATE TABLE Trustee (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ListTypeId INTEGER 
        CONSTRAINT FK_FirearmType_ListType REFERENCES ListTypes (Id) NOT NULL,
    FirstName TEXT NOT NULL,
    LastName  TEXT NOT NULL,
    BirthDate DATETIME NOT NULL,
    Relationship TEXT NULL
);

CREATE TABLE Customer (
    Id        INTEGER      PRIMARY KEY AUTOINCREMENT
                           NOT NULL,
    FirstName VARCHAR (20),
    LastName  VARCHAR (50),
    BirthDate DATETIME
);