--creating tables
USE WomenTechsters;

CREATE TABLE CustomerActions 
(
  Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(120) NOT NULL,
	LastName VARCHAR(120) NOT NULL,
	Email VARCHAR(120) NOT NULL,
	Password VARCHAR(120)NOT NULL
	
);
----Inserting to table by specifying values 
INSERT INTO CustomerActions (FirstName, LastName, Email, Password) VALUES ('Fatimah', 'Hassan','fatty14@gmail.com','Kehinde');
INSERT INTO CustomerActions (FirstName, LastName, Email, Password) VALUES ('Maryam', 'Hassan','maryamb@gmail.com','Bolanle23');
INSERT INTO CustomerActions (FirstName, LastName, Email, Password) VALUES ('Aishat', 'Tesleem','eniola672@gmail.com','Motun12');

----inserting by adding all data
INSERT INTO CustomerActions VALUES('Anas','Tesleem', 'ololade43@gmail.com', 'Ololadesheik');
INSERT INTO CustomerActions VALUES('Mazeedah','Yusuff', 'mazzy563@gmail.com', 'Umulayr28');
INSERT INTO CustomerActions VALUES('Tesleem','Babalola', 'kydbabalola3@gmail.com', 'aljannat01');
INSERT INTO CustomerActions VALUES('Kabirah','Zakariyah', 'Kanira3@gmail.com', 'motunrayot01');


SELECT * FROM CustomerActions;

----Update
UPDATE Customeractions SET LastName = 'Tesleem-Babalola' WHERE Id = 3;
UPDATE Customeractions SET Email = 'omokehinde24@gmail.com' WHERE Id = 1;

SELECT * FROM CustomerActions;

----Delete
DELETE FROM CustomerActions WHERE Id = 7;

SELECT * FROM CustomerActions;

----Altering 
ALTER TABLE CustomerActions
ADD OtherName VARCHAR ( 120) NULL;

SELECT * FROM CustomerActions;

-----order by
SELECT * FROM CustomerActions ORDER By FirstName;

-----Using stored procedure

EXEC INSERTINTOCUSTOMERACTIONS 'Salmat', 'Akinosho', 'salmah23@gmail.com', 'Salmatdemmmy', 'demmy'

SELECT * FROM CustomerActions

--======================================================================================================================================================
--===================================================================================================================================================
CREATE TABLE CustomerActions 
(
  Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(120) NOT NULL,
	LastName VARCHAR(120) NOT NULL,
	Email VARCHAR(120) NOT NULL,
	Password VARCHAR(120)NOT NULL
	
);
--=================================================================================================================================================
--creating tables for StoreDetails
USE WomenTechsters;

CREATE TABLE StoreDetailss 
(
  Id INT PRIMARY KEY IDENTITY(1,1),
	StoreName VARCHAR(120) NOT NULL,
	StoreNumber INT NOT NULL,
	StoreType VARCHAR(120) NOT NULL,
	ProductPrice INT NOT NULL
	);
--CustomerActionsId INT FOREIGN KEY REFERENCES CustomerActions(Id)
	

	---inserting into storedetails table
INSERT INTO StoreDetails VALUES ('Hfk Consult', 251,'Supermarket',$700);
INSERT INTO StoreDetails VALUES ('Kehinde', 741,'Kiosk',$120);
INSERT INTO StoreDetails VALUES ('Holland', 20,'Supermarket',$500);


SELECT * FROM Storedetails

-----foreign key demo
INSERT INTO StoreDetails VALUES ('Holland', 20,'Supermarket',$500, 6);






