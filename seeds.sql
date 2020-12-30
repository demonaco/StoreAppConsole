CREATE DATABASE ShoeCompany;


CREATE TABLE Customers(
UserID INT PRIMARY KEY IDENTITY,
Firstn VARCHAR(50) NOT NULL,
Lastn VARCHAR(50) NOT NULL,

);

CREATE TABLE Items(
ItemID INT PRIMARY KEY IDENTITY,
Sandals VARCHAR(50) NOT NULL, 
TennisShoes VARCHAR(50) NOT NULL,
DanceShoes VARCHAR (50) NOT NULL,
Loafers VARCHAR (50) NOT NULL,
Boots VARCHAR(50) NOT NULL,
 
);

CREATE TABLE Orders(
OrderID INT PRIMARY KEY IDENTITY

);

CREATE TABLE Locations(
LocationID INT PRIMARY KEY IDENTITY,
CityName VARCHAR (50) NOT NULL,
);

INSERT INTO Locations (CityName)
VALUES ("Los Angeles");
INSERT INTO Locations (CityName)
VALUES ("San Francisco");
INSERT INTO Locations (CityName)
VALUES ("Seattle");
INSERT INTO Locations (CityName)
VALUES ("Dallas");
INSERT INTO Locations (CityName)
VALUES ("Miami");
INSERT INTO Locations (CityName)
VALUES ("NYC");
INSERT INTO Locations (CityName)
VALUES ("Minneapolis");
INSERT INTO Locations (CityName)
VALUES ("Denver");