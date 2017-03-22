USE [MIC_Data]
GO

INSERT INTO [dbo].[ProductCategories]  
           ([ProductCategory]
           ,[bActive])
     VALUES
           ('shelter'	,        1),('shelter'	,        0)
GO

INSERT INTO dbo.ProductTypes
           ([ProductType],[ProductCategoryID] ,[bActive])
     VALUES
           	('BASIC shelter (3 mths < x < 6 mths)'	, 1,1),
	   	('TRANSITIONAL shelter (x < 18 mths)'	, 1,1),
		('WAREHOUSE structure (x < 2y)'	        , 1,1),
		('PREFABRICATED structures (x < 5y)'	, 1,1)
GO

USE [MIC_Data]
GO

INSERT INTO [dbo].[AttributeSection]
           ([AttributeSection]
           ,[bActive])
     VALUES
           ('Technical Characteristics',1),
           ('HQ Qualitative Pre Validation',1),
		   ('Feed-back from the Field',1)
GO


USE [MIC_Data]
GO

INSERT INTO [dbo].[AttributeClasifications]
           ([AttributeSectionID]
           ,[CharacteristicClass]
           ,[bActive])
     VALUES
           (1, 'Supplier', 1 ),
		   (1, 'Physical Characteristics', 1 ),
		   (1, 'ENVELOPE CHARACTERISTICS', 1 ),
		   (2, 'Trustworthiness and durability', 1 ),
		   (2, 'Modularity and customization', 1 ),
		   (2, 'Building Envelope performance', 1 ),
		   (2, 'Installation', 1 ),
		   (2, 'Supply', 1 ),
		   (3, 'Trustworthiness and durability', 1 ),
		   (3, 'Modularity and customization', 1 ),
		   (3, 'Building Envelope performance', 1 ),
		   (3, 'Installation', 1 ),
		   (3, 'Supply', 1 )
		  
GO

---------------------------------

USE [MIC_Data]
GO

INSERT INTO [dbo].[Attributes]
           ([AttributeClassID]
           ,[Attribute]
		   ,[AttributeDataType]
           ,[bActive])
     VALUES

(	1,	'AVERAGE STOCK AVAILABILITY',	'num',1),
(	1,	'PRODUCTION CAPACITY',	'text',1),
(	2,	'SHAPE',	'text',1),
(	2,	'DIMENSIONS IN M',	'text',1),
(	2,	'COVERED SURFACE IN M2',	'num',1),
(	2,	'OUTHER STRUCTURE MATERIAL',	'text',1),
(	4,	'Stability/robustness',	'num',1),
(	4,	'Tendency to aging',	'num',1),
(	4,	'Estimated lifespan for medical use',	'num',1),
(	4,	'Maintenance plan',	'num',1),
(	5,	'Modularity',	'num',1),
(	5,	'Customization',	'num',1),
(	5,	'Continuity/sustainability',	'num',1),
(	6,	'Thermal performance',	'num',1),
(	6,	'Natural light',	'num',1),
(	6,	'Natural ventilation',	'num',1),
(	6,	'cleanability of floor and walls',	'num',1),
(	6,	'Tendency to get dirty/slippery',	'num',1),
(	7,	'Required training',	'num',1),
(	7,	'Ease, duration and safety of setup',	'num',1),
(	7,	'Required tools and machinery',	'num',1),
(	7,	'Clarity of manual',	'num',1),
(	7,	'SetupTime/h',	'num',1),
(	8,	'Mobility',	'num',1),
(	8,	'Quality of service',	'num',1),
(	8,	'Pricing',	'num',1),
(	8,	'Cost Effectiveness',	'num',1),
(	8,	'FLOORING PROVIDED',	'num',1),
(	8,	'TRANSPORT BY PLANE',	'num',1),
(	8,	'TRANSPORT BY CONTAINER TRUCK',	'num',1),
(	8,	'TRANSPORT BY PICKUP',	'num',1),
(	9,	'Stability/robustness',	'num',1),
(	9,	'Tendency to aging',	'num',1),
(	9,	'Estimated lifespan for medical use',	'num',1),
(	9,	'Maintenance plan',	'num',1),
(	10,	'Modularity',	'num',1),
(	10,	'Customization',	'num',1),
(	10,	'Continuity/sustainability',	'num',1),
(	11,	'Thermal performance',	'num',1),
(	11,	'Natural light',	'num',1),
(	11,	'Natural ventilation',	'num',1),
(	11,	'cleanability of floor and walls',	'num',1),
(	11,	'Tendency to get dirty/slippery',	'num',1),
(	12,	'Required training',	'num',1),
(	12,	'Ease, duration and safety of setup',	'num',1),
(	12,	'Required tools and machinery',	'num',1),
(	12,	'Clarity of manual',	'num',1),
(	13,	'Mobility',	'num',1),
(	13,	'Quality of service',	'num',1),
(	13,	'Pricing',	'num',1)
GO
---------------------------------
USE [MIC_Data]
GO

INSERT INTO [dbo].[Filters]
           ([ProducttypeCategoryId]
           ,[FilterGroup]
           ,[FilterDescription])
     VALUES
			(	1,	1,	'LIFESPAN OF INFRASTRUCTURE'),
			(	1,	2,	'SIZE OF INFRASTRUCTURE'),
			(	1,	3,	'THERMAL VALUE'),
			(	1,	4,	'COST EFFECTIVENESS'),
			(	1,	5,	'SET-UP TIME'),
			(	1,	6,	'SPECIFIC FEATURES')

GO
---------------------------------
USE [MIC_Data]
GO

INSERT INTO [dbo].[FilterItems]
           ([FilterId]
           ,[ItemSer]
           ,[Filter]
           ,[FilterCriteria])
     VALUES
(	1,	1,	'BASIC shelter (3 mths < x < 6 mths)',	'ProductType=1'),
(	1,	2,	'TRANSITIONAL shelter (x < 18 mths)',	'ProductType=2'),
(	1,	3,	'WAREHOUSE structure (x < 2y)',	'ProductType=3'),
(	1,	4,	'PREFABRICATED structures (x < 5y)',	'ProductType=4'),
(	2,	1,	'FAMILY size (10m≤ < x < 20m≤)',	'(ProductAttributes.AttributeId=14 and (ProductAttributes.AttributeValue >10 and  ProductAttributes.attributeValue <=20)'),
(	2,	2,	'POLYVALENT size (20m≤ < x < 50m≤)',	'(ProductAttributes.AttributeId=14 and (ProductAttributes.AttributeValue >20 and  ProductAttributes.attributeValue <=50)'),
(	2,	3,	'MEDIUM size (50m≤ < x < 150m≤)',	'(ProductAttributes.AttributeId=14 and (ProductAttributes.AttributeValue >50 and  ProductAttributes.attributeValue <=150)'),
(	2,	4,	'LARGE size (150m≤ < x)',	'(ProductAttributes.AttributeId=14 and ProductAttributes.AttributeValue >150 )'),
(	3,	1,	'LOW',	'(ProductAttributes.AttributeId=23 and ProductAttributes.attributeValue <=2)'),
(	3,	2,	'MEDIUM',	'(ProductAttributes.AttributeId=23 and (ProductAttributes.AttributeValue >2 and  ProductAttributes.attributeValue <=4)'),
(	3,	3,	'HIGH',	'(ProductAttributes.AttributeId=23 and ProductAttributes.AttributeValue >4 )'),
(	4,	1,	'LOW',	'(0 < x < 100 Ä/m≤)	(ProductAttributes.AttributeId=36 and ProductAttributes.attributeValue <=100)'),
(	4,	2,	'MEDIUM',	'(100Ä/m≤ < x < 500 Ä/m≤)	(ProductAttributes.AttributeId=36 and (ProductAttributes.AttributeValue >100 and  ProductAttributes.attributeValue <=500)'),
(	4,	3,	'HIGH (500 Ä/m≤ < x < 1000 Ä/m≤)',	'(ProductAttributes.AttributeId=36 and ProductAttributes.AttributeValue >500 )	'),
(	5,	1,	'LOW (0 < x < 5h)',	'(ProductAttributes.AttributeId=32 and  ProductAttributes.attributeValue <=5)	'),
(	5,	2,	'MEDIUM (5h < x 2 days)',	'(ProductAttributes.AttributeId=32 and (ProductAttributes.AttributeValue >5 and  ProductAttributes.attributeValue <=48)	'),
(	5,	3,	'HIGH (2 days',	'(ProductAttributes.AttributeId=32 and ProductAttributes.AttributeValue >48 )	'),
(	6,	1,	'FLOORING PROVIDED',	'(ProductAttributes.AttributeId=37 and ProductAttributes.AttributeValue =True )	'),
(	6,	2,	'TRANSPORT BY PLANE',	'(ProductAttributes.AttributeId=38 and ProductAttributes.AttributeValue =True )	'),
(	6,	3,	'TRANSPORT BY CONTAINER TRUCK',	'(ProductAttributes.AttributeId=39 and ProductAttributes.AttributeValue =True )	'),
(	6,	4,	'TRANSPORT BY PICKUP',	'(ProductAttributes.AttributeId=40 and ProductAttributes.AttributeValue =True )')

GO
---------------------------------
USE [MIC_Data]
GO

INSERT INTO [dbo].[Countries]
           ([CountryId]
           ,[CountryName])
     VALUES

('ABW' ,'Aruba') ,
('AFG' ,'Afghanistan') ,
('AGO' ,'Angola') ,
('AIA' ,'Anguilla') ,
('ALA' ,'Aland Islands') ,
('ALB' ,'Albania') ,
('AND' ,'Andorra') ,
('ANT' ,'Netherlands Antilles') ,
('ARE' ,'United Arab Emirates') ,
('ARG' ,'Argentina') ,
('ARM' ,'Armenia') ,
('ASM' ,'American Samoa') ,
('ATA' ,'Antarctica') ,
('ATF' ,'French Southern Territories') ,
('ATG' ,'Antigua and Barbuda') ,
('AUS' ,'Australia') ,
('AUT' ,'Austria') ,
('AZE' ,'Azerbaijan') ,
('BDI' ,'Burundi') ,
('BEL' ,'Belgium') ,
('BEN' ,'Benin') ,
('BFA' ,'Burkina Faso') ,
('BGD' ,'Bangladesh') ,
('BGR' ,'Bulgaria') ,
('BHR' ,'Bahrain') ,
('BHS' ,'Bahamas') ,
('BIH' ,'Bosnia and Herzegovina') ,
('BLM' ,'Saint-Barth√lemy') ,
('BLR' ,'Belarus') ,
('BLZ' ,'Belize') ,
('BMU' ,'Bermuda') ,
('BOL' ,'Bolivia') ,
('BRA' ,'Brazil') ,
('BRB' ,'Barbados') ,
('BRN' ,'Brunei Darussalam') ,
('BTN' ,'Bhutan') ,
('BVT' ,'Bouvet Island') ,
('BWA' ,'Botswana') ,
('CAF' ,'Central African Republic') ,
('CAN' ,'Canada') ,
('CCK' ,'Cocos (Keeling) Islands') ,
('CHE' ,'Switzerland') ,
('CHL' ,'Chile') ,
('CHN' ,'China') ,
('CIV' ,'Cote deIvoire') ,
('CMR' ,'Cameroon') ,
('COD' ,'Congo') ,
('COG' ,'Congo (Brazzaville)') ,
('COK' ,'Cook Islands ') ,
('COL' ,'Colombia') ,
('COM' ,'Comoros') ,
('CPV' ,'Cape Verde') ,
('CRI' ,'Costa Rica') ,
('CUB' ,'Cuba') ,
('CXR' ,'Christmas Island') ,
('CYM' ,'Cayman Islands ') ,
('CYP' ,'Cyprus') ,
('CZE' ,'Czech Republic') ,
('DEU' ,'Germany') ,
('DJI' ,'Djibouti') ,
('DMA' ,'Dominica') ,
('DNK' ,'Denmark') ,
('DOM' ,'Dominican Republic') ,
('DZA' ,'Algeria') ,
('ECU' ,'Ecuador') ,
('EGY' ,'Egypt') ,
('ERI' ,'Eritrea') ,
('ESH' ,'Western Sahara') ,
('ESP' ,'Spain') ,
('EST' ,'Estonia') ,
('ETH' ,'Ethiopia') ,
('FIN' ,'Finland') ,
('FJI' ,'Fiji') ,
('FLK' ,'Falkland Islands (Malvinas) ') ,
('FRA' ,'France') ,
('FRO' ,'Faroe Islands') ,
('FSM' ,'Micronesia') ,
('GAB' ,'Gabon') ,
('GBR' ,'United Kingdom') ,
('GEO' ,'Georgia') ,
('GGY' ,'Guernsey') ,
('GHA' ,'Ghana') ,
('GIB' ,'Gibraltar ') ,
('GIN' ,'Guinea') ,
('GLP' ,'Guadeloupe') ,
('GMB' ,'Gambia') ,
('GNB' ,'Guinea-Bissau') ,
('GNQ' ,'Equatorial Guinea') ,
('GRC' ,'Greece') ,
('GRD' ,'Grenada') ,
('GRL' ,'Greenland') ,
('GTM' ,'Guatemala') ,
('GUF' ,'French Guiana') ,
('GUM' ,'Guam') ,
('GUY' ,'Guyana') ,
('HKG' ,'Hong Kong') ,
('HMD' ,'Heard and Mcdonald Islands') ,
('HND' ,'Honduras') ,
('HRV' ,'Croatia') ,
('HTI' ,'Haiti') ,
('HUN' ,'Hungary') ,
('IDN' ,'Indonesia') ,
('IMN' ,'Isle of Man ') ,
('IND' ,'India') ,
('IOT' ,'British Indian Ocean Territory') ,
('IRL' ,'Ireland') ,
('IRN' ,'Iran Islamic Republic of') ,
('IRQ' ,'Iraq') ,
('ISL' ,'Iceland') ,
('ISR' ,'Israel') ,
('ITA' ,'Italy') ,
('JAM' ,'Jamaica') ,
('JEY' ,'Jersey') ,
('JOR' ,'Jordan') ,
('JPN' ,'Japan') ,
('KAZ' ,'Kazakhstan') ,
('KEN' ,'Kenya') ,
('KGZ' ,'Kyrgyzstan') ,
('KHM' ,'Cambodia') ,
('KIR' ,'Kiribati') ,
('KNA' ,'Saint Kitts and Nevis') ,
('KOR' ,'Korea (South)') ,
('KWT' ,'Kuwait') ,
('LAO' ,'Lao PDR') ,
('LBN' ,'Lebanon') ,
('LBR' ,'Liberia') ,
('LBY' ,'Libya') ,
('LCA' ,'Saint Lucia') ,
('LIE' ,'Liechtenstein') ,
('LKA' ,'Sri Lanka') ,
('LSO' ,'Lesotho') ,
('LTU' ,'Lithuania') ,
('LUX' ,'Luxembourg') ,
('LVA' ,'Latvia') ,
('MAC' ,'Macao SAR China') ,
('MAF' ,'Saint-Martin (French part)') ,
('MAR' ,'Morocco') ,
('MCO' ,'Monaco') ,
('MDA' ,'Moldova') ,
('MDG' ,'Madagascar') ,
('MDV' ,'Maldives') ,
('MEX' ,'Mexico') ,
('MHL' ,'Marshall Islands') ,
('MKD' ,'Macedonia Republic of') ,
('MLI' ,'Mali') ,
('MLT' ,'Malta') ,
('MMR' ,'Myanmar') ,
('MNE' ,'Montenegro') ,
('MNG' ,'Mongolia') ,
('MNP' ,'Northern Mariana Islands') ,
('MOZ' ,'Mozambique') ,
('MRT' ,'Mauritania') ,
('MSR' ,'Montserrat') ,
('MTQ' ,'Martinique') ,
('MUS' ,'Mauritius') ,
('MWI' ,'Malawi') ,
('MYS' ,'Malaysia') ,
('MYT' ,'Mayotte') ,
('NAM' ,'Namibia') ,
('NCL' ,'New Caledonia') ,
('NER' ,'Niger') ,
('NFK' ,'Norfolk Island') ,
('NGA' ,'Nigeria') ,
('NIC' ,'Nicaragua') ,
('NIU' ,'Niue ') ,
('NLD' ,'Netherlands') ,
('NOR' ,'Norway') ,
('NPL' ,'Nepal') ,
('NRU' ,'Nauru') ,
('NZL' ,'New Zealand') ,
('OMN' ,'Oman') ,
('PAK' ,'Pakistan') ,
('PAN' ,'Panama') ,
('PCN' ,'Pitcairn') ,
('PER' ,'Peru') ,
('PHL' ,'Philippines') ,
('PLW' ,'Palau') ,
('PNG' ,'Papua New Guinea') ,
('POL' ,'Poland') ,
('PRI' ,'Puerto Rico') ,
('PRK' ,'Korea (North)') ,
('PRT' ,'Portugal') ,
('PRY' ,'Paraguay') ,
('PSE' ,'Palestinian Territory') ,
('PYF' ,'French Polynesia') ,
('QAT' ,'Qatar') ,
('REU' ,'R√©union') ,
('ROU' ,'Romania') ,
('RUS' ,'Russian Federation') ,
('RWA' ,'Rwanda') ,
('SAU' ,'Saudi Arabia') ,
('SDN' ,'Sudan') ,
('SEN' ,'Senegal') ,
('SGP' ,'Singapore') ,
('SGS' ,'South Georgia and the South Sandwich Islands') ,
('SHN' ,'Saint Helena') ,
('SJM' ,'Svalbard and Jan Mayen Islands ') ,
('SLB' ,'Solomon Islands') ,
('SLE' ,'Sierra Leone') ,
('SLV' ,'El Salvador') ,
('SMR' ,'San Marino') ,
('SOM' ,'Somalia') ,
('SPM' ,'Saint Pierre and Miquelon ') ,
('SRB' ,'Serbia') ,
('SSD' ,'South Sudan') ,
('STP' ,'Sao Tome and Principe') ,
('SUR' ,'Suriname') ,
('SVK' ,'Slovakia') ,
('SVN' ,'Slovenia') ,
('SWE' ,'Sweden') ,
('SWZ' ,'Swaziland') ,
('SYC' ,'Seychelles') ,
('SYR' ,'Syrian Arab Republic (Syria)') ,
('TCA' ,'Turks and Caicos Islands ') ,
('TCD' ,'Chad') ,
('TGO' ,'Togo') ,
('THA' ,'Thailand') ,
('TJK' ,'Tajikistan') ,
('TKL' ,'Tokelau ') ,
('TKM' ,'Turkmenistan') ,
('TLS' ,'Timor-Leste') ,
('TON' ,'Tonga') ,
('TTO' ,'Trinidad and Tobago') ,
('TUN' ,'Tunisia') ,
('TUR' ,'Turkey') ,
('TUV' ,'Tuvalu') ,
('TWN' ,'Taiwan, Republic of China') ,
('TZA' ,'Tanzania, United Republic of') ,
('UGA' ,'Uganda') ,
('UKR' ,'Ukraine') ,
('UMI' ,'US Minor Outlying Islands') ,
('URY' ,'Uruguay') ,
('USA' ,'United States of America') ,
('UZB' ,'Uzbekistan') ,
('VAT' ,'Holy See (Vatican City State)') ,
('VCT' ,'Saint Vincent and Grenadines') ,
('VEN' ,'Venezuela (Bolivarian Republic)') ,
('VGB' ,'British Virgin Islands') ,
('VIR' ,'Virgin Islands, US') ,
('VNM' ,'Viet Nam') ,
('VUT' ,'Vanuatu') ,
('WLF' ,'Wallis and Futuna Islands ') ,
('WSM' ,'Samoa') ,
('YEM' ,'Yemen') ,
('ZAF' ,'South Africa') ,
('ZMB' ,'Zambia') ,
('ZWE' ,'Zimbabwe') 
GO
---------------------------------

USE [MIC_Data]
GO
-- Adding the used File extentions
INSERT INTO [dbo].[FileExtension]
           ([FileExtentionId]
           ,[Description])
     VALUES
           ('JPG','Photos'),
		   ('TIF','Photos'),
		   ('GIF','Photos'),
		   ('PNG','Photos'),
		   ('BMP','Photos'),
		   ('PDF','Text files'),
		   ('CAD','CAD File')
GO

---------------------------------

--Adding 1st supplier and his product
USE [MIC_Data]
GO

declare  @LastSupplier int;

INSERT INTO [dbo].[Supplier]
           (
           [SupplierName]
           ,[ContactPerson]
           ,[Email]
           ,[Website]
           ,[Address1]
           ,[Address2]
           ,[City]
           ,[SState]
           ,[CountryId]
           ,[ZipCode]
           ,[MobilePhone]
           ,[Telephone1]
           ,[Telephone2]
           ,[PoBox]
           ,[SkypeId]
           ,[SupplierDescription]
           ,[Numberofemployees]
           ,[Numberofcustomers]
           ,[bActive])
     VALUES
(	'x Workshop ltd','Fredrik x','infor@XWorkShop.com','www.XWorkShop.com','Dalas','215,Albert Street','','Texas','USA','TX-21555','015435421','01-33443377','01-72328833','2331','xWorshop','a small workshop produces prefabricated housing',2,100,1)


set @LastSupplier=(select max([dbo].[Supplier].[SupplierId]) from [dbo].[Supplier]);



declare @LastPrductId  int;


INSERT INTO [dbo].[Product]
           (
           [ProductTypeId]
           ,[SupplierId]
           ,[ProductName]
           ,[DateCreated]
           ,[bActive])
     VALUES
           (	1,	@LastSupplier ,	'Product Name 1',	'20160320',	1)
set @LastPrductId = (select max([ProductId]) from [dbo].[Product]);

INSERT INTO [dbo].[ProductAttributes]
           (
           [ProductId]
           ,[AttributeId]
           ,[AttributeValue]
           ,[DateCreated]
           ,[bActive])
     VALUES
(@LastPrductId,1    ,	'20','20170320',1),
(@LastPrductId,2	,	'10/month','20170320',1),
(@LastPrductId,3	,	'Rectangular','20170320',1),
(@LastPrductId,4 	,	'6x3','20170320',1),
(@LastPrductId,5 	,	'18','20170320',1),
(@LastPrductId,6 	,	'Aluminume+Wood','20170320',1),
(@LastPrductId,7 	,	'4','20170320',1),
(@LastPrductId,8 	,	'3','20170320',1),
(@LastPrductId, 9	,	'1','20170320',1),
(@LastPrductId,10	,	'1','20170320',1),
(@LastPrductId,11	,	'1','20170320',1),
(@LastPrductId,12	,	'2','20170320',1),
(@LastPrductId,13	,	'2','20170320',1),
(@LastPrductId,14	,	'3','20170320',1),
(@LastPrductId,15 , '1','20170320',1),
(@LastPrductId,16	,	'2','20170320',1),
(@LastPrductId,17	,	'3','20170320',1),
(@LastPrductId,18	,	'1','20170320',1),
(@LastPrductId,19	,	'2','20170320',1),
(@LastPrductId,20	,	'2','20170320',1),
(@LastPrductId,21	,	'1','20170320',1),
(@LastPrductId,22	,	'4','20170320',1),
(@LastPrductId,23	,	'23','20170320',1),
(@LastPrductId,24	,	'2','20170320',1),
(@LastPrductId,25	,	'2','20170320',1),
(@LastPrductId,26	,	'6000','20170320',1),
(@LastPrductId,27	,	'333','20170320',1),
(@LastPrductId,28	,	'1','20170320',1),
(@LastPrductId,29	,	'0','20170320',1),
(@LastPrductId,30	,	'1','20170320',1),
(@LastPrductId,31	,	'1','20170320',1),
(@LastPrductId,32	,	'3','20170320',1),
(@LastPrductId,33	,	'3','20170320',1),
(@LastPrductId,34	,	'1','20170320',1),
(@LastPrductId,35	,	'1','20170320',1),
(@LastPrductId,36	,	'1','20170320',1),
(@LastPrductId,37	,	'2','20170320',1),
(@LastPrductId,38	,	'2','20170320',1),
(@LastPrductId,39	,	'3','20170320',1),
(@LastPrductId,40	,	'0','20170320',1),
(@LastPrductId,41	,	'0','20170320',1),
(@LastPrductId,42	,	'2','20170320',1),
(@LastPrductId,43	,	'4','20170320',1),
(@LastPrductId,44	,	'1','20170320',1),
(@LastPrductId,45	,	'1','20170320',1),
(@LastPrductId,46	,	'1','20170320',1),
(@LastPrductId,47	,	'1','20170320',1),
(@LastPrductId,48	,	'1','20170320',1),
(@LastPrductId,49	,	'1','20170320',1),
(@LastPrductId,50	,	'1','20170320',1)

--adding files for product1
insert into  [dbo].[ProductFiles] Values(@LastPrductId, cast('c:\twb\ShelterPlatform8.pdf' as varbinary(max)),'pdf','example',1);
insert into  [dbo].[ProductFiles] Values(@LastPrductId, cast('c:\twb\product1.jpg' as varbinary(max)),'jpg','jpg example',1);

go

USE [MIC_Data]
GO
-- product 2-- 
declare  @LastSupplier int;

INSERT INTO [dbo].[Supplier]
           (
           [SupplierName]
           ,[ContactPerson]
           ,[Email]
           ,[Website]
           ,[Address1]
           ,[Address2]
           ,[City]
           ,[SState]
           ,[CountryId]
           ,[ZipCode]
           ,[MobilePhone]
           ,[Telephone1]
           ,[Telephone2]
           ,[PoBox]
           ,[SkypeId]
           ,[SupplierDescription]
           ,[Numberofemployees]
           ,[Numberofcustomers]
           ,[bActive])
     VALUES
(	'Malm Housing foretag','Ole someonson','sals@MalmHousing.com','www.MalmHousing.com','Malmo','21 Hermosdalgatan','','Skane','SW','21311','+46121233','+4672830333','0046723232','44-12','yCo','midium large workshop produces caravans',	25,	55,	0)

set @LastSupplier=(select max([dbo].[Supplier].[SupplierId]) from [dbo].[Supplier]);

declare @LastPrductId  int;


INSERT INTO [dbo].[Product]
           (
           [ProductTypeId]
           ,[SupplierId]
           ,[ProductName]
           ,[DateCreated]
           ,[bActive])
     VALUES
           (1,	@LastSupplier ,	'Product Name 2',	'20160320',	1)
		   set @LastPrductId = (select max(ProductId) from Product);

INSERT INTO [dbo].[ProductAttributes]
           (
           [ProductId]
           ,[AttributeId]
           ,[AttributeValue]
           ,[DateCreated]
           ,[bActive])
     VALUES
(@LastPrductId,1    ,   '3','20170320',1),
(@LastPrductId,2	,	'2/month','20170320',1),
(@LastPrductId,3	,	'Circular','20170320',1),
(@LastPrductId,4 	,	'Diameter 5m','20170320',1),
(@LastPrductId,5 	,	'19.5','20170320',1),
(@LastPrductId,6 	,	'blastic+iron','20170320',1),
(@LastPrductId,7 	,	'3','20170320',1),
(@LastPrductId,8 	,	'3','20170320',1),
(@LastPrductId, 9	,	'1','20170320',1),
(@LastPrductId,10	,	'1','20170320',1),
(@LastPrductId,11	,	'1','20170320',1),
(@LastPrductId,12	,	'2','20170320',1),
(@LastPrductId,13	,	'2','20170320',1),
(@LastPrductId,14	,	'3','20170320',1),
(@LastPrductId,15   ,   '1','20170320',1),
(@LastPrductId,16	,	'2','20170320',1),
(@LastPrductId,17	,	'2','20170320',1),
(@LastPrductId,18	,	'1','20170320',1),
(@LastPrductId,19	,	'2','20170320',1),
(@LastPrductId,20	,	'2','20170320',1),
(@LastPrductId,21	,	'1','20170320',1),
(@LastPrductId,22	,	'4','20170320',1),
(@LastPrductId,23	,	'23','20170320',1),
(@LastPrductId,24	,	'2','20170320',1),
(@LastPrductId,25	,	'2','20170320',1),
(@LastPrductId,26	,	'1500','20170320',1),
(@LastPrductId,27	,	'77','20170320',1),
(@LastPrductId,28	,	'1','20170320',1),
(@LastPrductId,29	,	'0','20170320',1),
(@LastPrductId,30	,	'1','20170320',1),
(@LastPrductId,31	,	'1','20170320',1),
(@LastPrductId,32	,	'1','20170320',1),
(@LastPrductId,33	,	'1','20170320',1),
(@LastPrductId,34	,	'1','20170320',1),
(@LastPrductId,35	,	'1','20170320',1),
(@LastPrductId,36	,	'1','20170320',1),
(@LastPrductId,37	,	'2','20170320',1),
(@LastPrductId,38	,	'2','20170320',1),
(@LastPrductId,39	,	'3','20170320',1),
(@LastPrductId,40	,	'0','20170320',1),
(@LastPrductId,41	,	'1','20170320',1),
(@LastPrductId,42	,	'3','20170320',1),
(@LastPrductId,43	,	'1','20170320',1),
(@LastPrductId,44	,	'1','20170320',1),
(@LastPrductId,45	,	'0','20170320',1),
(@LastPrductId,46	,	'1','20170320',1),
(@LastPrductId,47	,	'5','20170320',1),
(@LastPrductId,48	,	'1','20170320',1),
(@LastPrductId,49	,	'3','20170320',1),
(@LastPrductId,50	,	'3','20170320',1)

--adding files for product2
insert into  [dbo].[ProductFiles] Values(@LastPrductId, cast('c:\twb\Project Description.pdf' as varbinary(max)),'pdf','example',1);
insert into  [dbo].[ProductFiles] Values(@LastPrductId, cast('c:\twb\product2.jpg' as varbinary(max)),'jpg','jpg example',1);


go
-- product 3-- 

USE [MIC_Data]
GO

declare  @LastSupplier int;

INSERT INTO [dbo].[Supplier]
           (
		   [SupplierName]
           ,[ContactPerson]
           ,[Email]
           ,[Website]
           ,[Address1]
           ,[Address2]
           ,[City]
           ,[SState]
           ,[CountryId]
           ,[ZipCode]
           ,[MobilePhone]
           ,[Telephone1]
           ,[Telephone2]
           ,[PoBox]
           ,[SkypeId]
           ,[SupplierDescription]
           ,[Numberofemployees]
           ,[Numberofcustomers]
           ,[bActive])
     VALUES
('SousaCampTents','Badr something','eid@SousaCampTent.tu','www.SousaCampTent.tu','sousa','12 Sousa square','','SOUSA','TU','1325','+1121222','+11-11-1111','+11-525252','21522','TentsCo','a big fabric produces tents',50,	600,	1)


set @LastSupplier=(select  max([SupplierId]) from [dbo].[Supplier]);


USE [MIC_Data]
GO

SELECT [FileId]
      ,[ProductId]
      ,[ProductFile]
      ,[FileExtention]
      ,[FDescription]
      ,[bActive]
  FROM [dbo].[ProductFiles]
GO



