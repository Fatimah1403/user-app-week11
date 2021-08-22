--creating tables
USE WomenTechsters;

CREATE TABLE StoreDetails 
(
  Id INT PRIMARY KEY IDENTITY(1,1),
	StoreName VARCHAR(120) NOT NULL,
	StoreNumber INT NOT NULL,
	StoreType VARCHAR(120) NOT NULL,
	ProductPrice INT NOT NULL,
	
	);

	---inserting
INSERT INTO StoreDetails VALUES ('Hfk Consult', 251,'Supermarket',$700);
INSERT INTO StoreDetails VALUES ('Kehinde', 741,'Kiosk',$120);
INSERT INTO StoreDetails VALUES ('Holland', 20,'Supermarket',$500);

SELECT * FROM Storedetails

