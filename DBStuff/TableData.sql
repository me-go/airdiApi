
select * from listTypes;

select Id, Name, Description from listTypes;

INSERT INTO ListTypes(Name) VALUES('Caliber');
INSERT INTO ListTypes(Name) VALUES('Firearmtype');
INSERT INTO ListTypes(Name) VALUES('ActionType');
INSERT INTO ListTypes(Name) VALUES('Manufacturer');

update ListTypes set Description = 'Id, Name, Description' WHERE Id = 1;
update ListTypes set Description = 'Id, CaliberInches, CaliberMetricDiameter, CaliberMetricLength' WHERE Id = 2;
update ListTypes set Description = 'Id, Name, Description' WHERE Id = 3;
update ListTypes set Description = 'Id, Name,ShortName, Location, Url' WHERE Id = 4;

select * from ActionType;

INSERT INTO ActionType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'ActionType'),'Bolt','Bolt');
INSERT INTO ActionType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'ActionType'),'Pump','Pump');
INSERT INTO ActionType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'ActionType'),'Revolver','Revolver');
INSERT INTO ActionType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'ActionType'),'Semi-Auto','Semi-Auto');

select * from caliber;

INSERT INTO Caliber(ListTypeId,CaliberInches, CaliberMetricDiameter, CaliberMetricLength)VALUES((select Id from ListTypes where name = 'Caliber'),.308, 7.62, 51);
INSERT INTO Caliber(ListTypeId,CaliberInches, CaliberMetricDiameter, CaliberMetricLength)VALUES((select Id from ListTypes where name = 'Caliber'),.355, 9, 19);


select * from firearmType;

INSERT INTO FirearmType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Firearmtype'),'Pistol','Pistol');
INSERT INTO FirearmType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Firearmtype'),'Rifle','Rifle');
INSERT INTO FirearmType(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Firearmtype'),'SBR','Short Barreled Rifle');


select * from Model;

INSERT INTO Model(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Model'),'M6A1','M6A1');
INSERT INTO Model(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Model'),'P938','P938');
INSERT INTO Model(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Model'),'XD','XD');

select * from SubModel;

INSERT INTO SubModel(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'SubModel'),'NightMare','NightMare');
INSERT INTO SubModel(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'SubModel'),'Garand','Garand');
INSERT INTO SubModel(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'SubModel'),'Socom 16','Socom 16');

select * from Platform;

INSERT INTO Platform(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Platform'),'AR-10 DI','AR-10 Direct Impingement');
INSERT INTO Platform(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Platform'),'LR 308 DI','LR 308 Direct Impingement');
INSERT INTO Platform(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Platform'),'AR-15 DI','AR-15 Direct Impingement');
INSERT INTO Platform(ListTypeId,Name,Description) VALUES((select Id from ListTypes where name = 'Platform'),'AR-15 Piston','AR-15 Short Stroke Gas Piston');


select * from manufacturer;

INSERT INTO Manufacturer(ListTypeId,Name,ShortName)VALUES((select Id from ListTypes where name = 'Manufacturer'),'Bushmaster','Bushmaster');
INSERT INTO Manufacturer(ListTypeId,Name,ShortName)VALUES((select Id from ListTypes where name = 'Manufacturer'),'Land Warefare Resource Corporation','LWRC');

select * from Customer;

INSERT INTO Customer(firstName, lastName, birthDate)VALUES('Merril','Onigkeit','1967-12-17 08:50:00');
INSERT INTO Customer(firstName, lastName, birthDate)VALUES('Jacqueline','Onigkeit','1970-08-23 13:00:00');
INSERT INTO Customer(firstName, lastName, birthDate)VALUES('Alicia','Shokrgozar','1992-11-01 17:30:00');


select * from Trustee;

INSERT INTO Trustee(FirstName, LastName, BirthDate, Relationship)VALUES('Merril','Onigkeit','1967-12-17 08:50:00','Self');
INSERT INTO Trustee(FirstName, LastName, BirthDate, Relationship)VALUES('Jacqueline','Onigkeit','1970-08-23 13:00:00','Spouse');
INSERT INTO Trustee(FirstName, LastName, BirthDate, Relationship)VALUES('Alicia','Shokrgozar','1992-11-01 17:30:00','Daughter');
