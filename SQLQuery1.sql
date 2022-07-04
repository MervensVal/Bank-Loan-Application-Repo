--BEGIN TRANSACTION (or BEGIN TRAN) - it automatically makes the transaction explicit and holds 
--a lock on the table until the transaction is either committed or rolled back. 

--The NOLOCK hint allows SQL to read data from tables by ignoring any locks and 
--therefore not get blocked by other processes.

--ROLLBACK TRANSACTION
--Rolls back an explicit or implicit transaction to the beginning of the transaction, 
--or to a savepoint inside the transaction. You can use ROLLBACK TRANSACTION to erase 
--all data modifications made from the start of the transaction or to a savepoint. 
--It also frees resources held by the transaction.

--COMMIT makes the changes permenant

----------------------------------------------------------------------------------------
--CREATE  DATABASE LoanApplication;
USE LoanApplication
CREATE TABLE Applicant
(
ApplicationNum INT PRIMARY KEY Identity(1,1),
SSN varchar(9) NOT NULL,
userQualifies  varchar(5) NOT NULL,
Name varchar(40) NOT NULL,
Email varchar(40) NOT NULL,
DOB DATE NOT NULL,
LoanAmount INT NOT NULL,
YearlyIncome INT NOT NULL,
CreditScore INT NOT NULL,
Interest INT NOT NULL,
PassedBackroundCheck varchar(5);

----------------------------------------------------------------------------------------
BEGIN TRAN
INSERT INTO LoanApplication.dbo.Applicant(SSN,userQualifies,Name,Email,DOB,LoanAmount,YearlyIncome,CreditScore,Interest,PassedBackroundCheck)
VALUES('111111111','Yes','testName','test@email.com','10-10-2000',5000,60000,750,5,0)
COMMIT TRAN;

----------------------------------------------------------------------------------------
BEGIN TRAN
DELETE from LoanApplication.dbo.Applicant 
where ApplicationNum = 2;
COMMIT TRAN;
--or
--ROLLBACK TRAN;

----------------------------------------------------------------------------------------
BEGIN TRAN
UPDATE Applicant SET Name = 'testname2' where ApplicationNum = 3;
COMMIT TRAN;

----------------------------------------------------------------------------------------
SELECT * FROM LoanApplication.dbo.Applicant;
