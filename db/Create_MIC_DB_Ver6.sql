--Create DB
USE master;
GO


/*ALTER DATABASE [MIC_Data] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
USE MIC_Data;
GO*/

 if db_ID( 'MIC_Data')   is not null   DROP DATABASE [MIC_Data]

GO


CREATE DATABASE MIC_Data ON 
	PRIMARY
	(
		NAME = 'MIC_Data', 
		FILENAME = 'C:\Database\MIC_Data.mdf', 
		SIZE = 50 MB, 
		FILEGROWTH = 10%
		
	)
LOG ON 
	(
		NAME = 'MIC_Log', 
		FILENAME = 'c:\Database\MIC_Log.ldf', 
		SIZE = 10 MB, 
		FILEGROWTH = 10%
		
	)
	GO

	use MIC_Data;
	go



if object_id('dbo.ProductCategories','U') is not null drop table ProductCategories;
go

CREATE TABLE dbo.ProductCategories (
		ProductCategoryId  int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		ProductCategory  nVarchar(255) NOT NULL,
		bActive bit NOT NULL default 1
	) ON [PRIMARY]
GO

if object_id('dbo.ProductTypes','U') is not null drop table ProductTypes;
go
CREATE TABLE dbo.ProductTypes (
		ProductTypeId int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		ProductType nVarchar(255) NOT NULL,
		ProductCategoryId int NOT NULL Foreign key (ProductCategoryId) references dbo.ProductCategories(ProductCategoryId),
		bActive bit NOT NULL default 1
	) ON [PRIMARY]
GO

if object_id('dbo.AttributeSection','U') is not null drop table AttributeSection;
go
CREATE TABLE AttributeSection (
		AttributeSectionID int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		AttributeSection nVarchar(255) NOT NULL,
		bActive bit NOT NULL default 1
	) ON [PRIMARY]
GO
if object_id('dbo.AttributeClasifications','U') is not null drop table AttributeClasifications;
go

CREATE TABLE dbo.AttributeClasifications (
		AttributeClassID int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		AttributeSectionID int NOT NULL,
		CharacteristicClass nVarchar(255),
		bActive bit NOT NULL default 1,

		    
		CONSTRAINT FK_AttributeSectionID    FOREIGN KEY ( AttributeSectionID )     
    		REFERENCES dbo.AttributeSection ( AttributeSectionID )     
    		ON DELETE CASCADE    
    		ON UPDATE CASCADE    

	) ON [PRIMARY]
GO

if object_id('dbo.Attributes','U') is not null drop table Attributes ;
go

CREATE TABLE Attributes (
		AttributeId int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		AttributeClassID int NOT NULL,
		Attribute nVarchar(255),
		AttributeDataType nVarchar(10),
		bActive bit NOT NULL default 1,

		    
		CONSTRAINT FK_AttributeClassID     FOREIGN KEY ( AttributeClassID )     
    		REFERENCES dbo.AttributeClasifications ( AttributeClassID )     
    		ON DELETE CASCADE    
    		ON UPDATE CASCADE    

	) ON [PRIMARY]
GO


if object_id('dbo.Filters','U') is not null drop table dbo.Filters ;
go

CREATE TABLE dbo.Filters (
		FilterId int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		ProducttypeCategoryId  int NOT NULL,
		FilterGroup int  NOT NULL,
		FilterDescription nVarchar(255),
				    
		CONSTRAINT FK_ProductCategoryId     FOREIGN KEY ( ProducttypeCategoryId)     
    		REFERENCES dbo.ProductCategories ( ProductCategoryId)     
    		ON DELETE CASCADE    
    		ON UPDATE CASCADE    

	) ON [PRIMARY]
GO

if object_id('dbo.FilterItems','U') is not null drop table dbo.FilterItems ;
go

CREATE TABLE dbo.FilterItems (
		ItemId int NOT NULL IDENTITY(1,1) PRIMARY KEY CLUSTERED,
		FilterId int NOT NULL,
		ItemSer int  NOT NULL,
		Filter nVarchar(255),
		FilterCriteria nVarchar(1000),
		    
		CONSTRAINT FK_FilterId      FOREIGN KEY ( FilterId )     
    		REFERENCES dbo.Filters ( FilterId )     
    		ON DELETE CASCADE    
    		ON UPDATE CASCADE    

	) ON [PRIMARY]
GO


/* VIKY */

if object_id('dbo.Countries','U') is not null drop table dbo.Countries ;
go
CREATE TABLE dbo.Countries (
		CountryId nvarchar(3) NOT NULL PRIMARY KEY CLUSTERED,
		CountryName nVarchar(50) NOT NULL
	) ON [PRIMARY]

if object_id('dbo.Supplier','U') is not null drop table dbo.FilterItems ;
go
CREATE TABLE dbo.Supplier (
	SupplierId int NOT NULL  IDENTITY(1,1) PRIMARY KEY ,
	SupplierName nVarchar(255) NOT NULL,	
	ContactPerson nVarchar(100),			
	Email nVarchar(100),			
	Website nVarchar(255),			
	Address1 nVarchar(100),			
	Address2 nVarchar(100),			
	City nVarchar(100),			
	SState nVarchar(100),			
	CountryId nVarchar(3),
	ZipCode	nVarchar(32),			
	MobilePhone	nVarchar(15),			
	Telephone1 nVarchar(15),			
	Telephone2 nVarchar(15),			
	PoBox nVarchar(15),			
	SkypeId	nVarchar(50),			
	SupplierDescription nVarchar(1000),			
	Numberofemployees int,			
	Numberofcustomers int,			
	bActive bit NOT NULL default 1	
) ON [PRIMARY]


if object_id('dbo.Product','U') is not null drop table dbo.FilterItems ;
go
CREATE TABLE dbo.Product (
		ProductId int NOT NULL  IDENTITY(1,1) PRIMARY KEY ,
		ProductTypeId int NOT NULL FOREIGN KEY REFERENCES dbo.ProductTypes(ProductTypeId),
		SupplierId int NOT NULL FOREIGN KEY REFERENCES Supplier(SupplierId),
		ProductName nVarchar(255) NOT NULL,
		DateCreated datetime NOT NULL default GETDATE(),
		bActive bit NOT NULL default 1
	)ON [PRIMARY]
GO


if object_id('dbo.ProductAttributes','U') is not null drop table dbo.ProductAttributes ;
go

CREATE TABLE ProductAttributes (
		ProductAttributeId int  NOT NULL identity(1,1)  PRIMARY KEY CLUSTERED,
		ProductId  int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
		AttributeId	int  NOT NULL FOREIGN KEY REFERENCES Attributes(AttributeId),
		AttributeValue	nVarchar(255),
		DateCreated  datetime ,
		bActive  bit NOT NULL  default 1


	) ON [PRIMARY]
GO

if object_id('dbo.ProductFiles','U') is not null drop table dbo.ProductAttributes ;
go
CREATE TABLE dbo.ProductFiles(
	FileId	int NOT NULL  IDENTITY(1,1) PRIMARY KEY ,
	ProductId int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
	ProductFile	varbinary(MAX),			
	FileExtention Varchar(3),			
	FDescription nVarchar(255),		
	bActive	bit			
)ON [PRIMARY]


if object_id('dbo.FileExtension','U') is not null drop table dbo.FileExtension ;
go
CREATE TABLE dbo.FileExtension(
	FileExtentionId	nVarchar(3)	NOT NULL PRIMARY KEY,
	Description	nVarchar(50)
)ON [PRIMARY]				


