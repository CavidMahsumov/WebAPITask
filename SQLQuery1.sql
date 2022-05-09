create database MyDB

use MyDB

drop table Customers


CREATE TABLE Customers (
	CustomerID int identity(1,1) NOT NULL ,
	CompanyName nvarchar (40) NOT NULL ,
	ContactName nvarchar (30) NULL ,
	ContactTitle nvarchar (30) NULL ,
	Address nvarchar (60) NULL ,
	City nvarchar (15) NULL ,
	Region nvarchar (15) NULL ,
	PostalCode nvarchar (10) NULL ,
	Country nvarchar (15) NULL ,
	Phone nvarchar (24) NULL ,
	Fax nvarchar (24) NULL ,
	CONSTRAINT "PK_Customers" PRIMARY KEY  CLUSTERED 
	(
		"CustomerID"
	)
)


CREATE TABLE "Orders" (
	"OrderID" "int" IDENTITY (1, 1) NOT NULL ,
	"CustomerID" int  NULL ,
	"EmployeeID" "int" NULL ,
	"OrderDate" "datetime" NULL ,
	"RequiredDate" "datetime" NULL ,
	"ShippedDate" "datetime" NULL ,
	"ShipVia" "int" NULL ,
	"Freight" "money" NULL CONSTRAINT "DF_Orders_Freight" DEFAULT (0),
	"ShipName" nvarchar (40) NULL ,
	"ShipAddress" nvarchar (60) NULL ,
	"ShipCity" nvarchar (15) NULL ,
	"ShipRegion" nvarchar (15) NULL ,
	"ShipPostalCode" nvarchar (10) NULL ,
	"ShipCountry" nvarchar (15) NULL ,
	CONSTRAINT "PK_Orders" PRIMARY KEY  CLUSTERED 
	(
		"OrderID"
	),
	CONSTRAINT "FK_Orders_Customers" FOREIGN KEY 
	(
		"CustomerID"
	) REFERENCES "dbo"."Customers" (
		"CustomerID"
	),

)




