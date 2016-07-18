SELECT Id, Name, Description
FROM ListTypes; 

SELECT Id, ListTypeId, Name, Description
FROM ActionType; 

SELECT Id, ListTypeId, CaliberInches, CaliberMetricDiameter, CaliberMetricLength
FROM Caliber; 

SELECT Id, ListTypeId, Name, Description
FROM Firearmtype; 

SELECT Id, ListTypeId, Name,ShortName, Location, Url
FROM Manufacturer;


INSERT OR REPLACE INTO ActionType VALUES (1,1,'Bolt','Bolt Action');