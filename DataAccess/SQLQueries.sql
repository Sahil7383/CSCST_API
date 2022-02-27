CREATE DATABASE CSCST_Database;
CREATE TABLE Customer
(
 Id int Identity(1,1) PRIMARY KEY NOT NULL,
 FirstName varchar(20) NOT NULL,
 LastName varchar(25),
 Email varchar(25) NOT NULL,
 CustomerPassword varchar(50) NOT NULL,
 PhoneNo int NOT NULL,
 AlternatePhoneNo int,
 CreatedBy varchar(25) NOT NULL, 
 CreatedDate DATETIME NOT NULL, 
 UpdatedBy varchar(25), 
 UpdatedDate DATETIME,
IsActive Bit NOT NULL,
);

INSERT INTO Customer(FirstName,Email,CustomerPassword,PhoneNo,AlternatePhoneNo,IsActive)
VALUES('vinod','vinod@gmail.com','1234avcb',12345678,123456789);
INSERT INTO Customer(FirstName,LastName,Email,CustomerPassword,PhoneNo)
VALUES('jay','patel','jay@gmail.com','1201avcb;',987654321);

SELECT * FROM Customer;