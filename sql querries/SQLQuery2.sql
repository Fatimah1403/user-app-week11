  --DDL
  --Creating Tables
USE WomenTechsters;

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(120) NOT NULL,
	LastName VARCHAR(120)
);
 --ALTERING Tables
ALTER TABLE CUSTOMERS
ADD Age INT

ALTER TABLE CUSTOMERS
ADD CHECK (Age >=18);

--Dropping Tables
--DROP TABLE CUSTOMERS;

--DML
--By specifying the values to be inserted.
INSERT INTO Customers (FirstName, Age) VALUES ('Chibuikem', 50);

---By adding all the data
INSERT INTO Customers VALUES('Chibuikem', 'Akpaka', '100');
INSERT INTO Customers VALUES('Fatimah', 'Hassan', '100');
INSERT INTO Customers VALUES('Aishsat', 'Tesleem', '100');


--UPDATE
UPDATE Customers SET LastName = 'Babaloa' WHERE Id = 8;

--DELETE
DELETE FROM Customers WHERE Id = 3;
DELETE FROM Customers WHERE Id = 4;
DELETE FROM Customers WHERE Age =100;

INSERT INTO Customers VALUES('Chibuikem', 'Akpaka', '100');
INSERT INTO Customers VALUES('Fatimah', 'Hassan', '100');
INSERT INTO Customers VALUES('Aishsat', 'Tesleem', '100');

--Read using SELECT
SELECT * FROM Customers;

SELECT * FROM Customers WHERE LastName = null

--SELECT based on a particular criteria
SELECT FirstName, LastName From Customers WHERE Age = 100;

SELECT FirstName, LastName From Customers WHERE LastName = 'Hassan';
SELECT FirstName, LastName From Customers WHERE LastName = 'Babalola';

---USING STORE PROCEDURES
EXEC INSERTINTOCUSTOMERS 'Tesleem', 'Babalola', 50

SELECT * FROM Customers










