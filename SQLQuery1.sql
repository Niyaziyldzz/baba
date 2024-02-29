CREATE DATABASE EMedicine
Use EMedicine

Create Table Users(ID INT IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50), Password VARCHAR(50), Email VARCHAR(50), Fund DECIMAL(18,2), Type VARCHAR(100), Status INT,CreatedOn Datetime);

Create Table Medicines(ID INT IDENTITY(1,1) PRIMARY KEY, Name Varchar(50),Manufacturer Varchar(50),UnitPrice Decimal(18,2),Discount Decimal(18,2),Quantity INT,ExpDate Datetime, ImageUrl Varchar(50), Status INT)

Create Table Cart(ID INT IDENTITY(1,1) PRIMARY KEY, UserID INT, MedicineID INT, UnitPrice Decimal(18,2),Discount Decimal(18,2),Quantity INT, TotalPrice Decimal (18,2))

Create Table Orders(ID INT IDENTITY(1,1) PRIMARY KEY, UserID INT, OrderNo Varchar(50),OrderTotal Decimal(18,2),OrderStatus Varchar(50))

Create Table OrderItems(ID INT IDENTITY(1,1) PRIMARY KEY,OrdersID INT,Medicine INT, UnitPrice Decimal(18,2),Discount Decimal(18,2),Quantity INT, TotalPrice Decimal(18,2))

Select * From Users;
Select * From Medicines;
Select * From Cart;
Select * From Orders;
Select * From OrderItems;
