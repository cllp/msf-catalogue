CREATE TABLE [dbo].[ProductPhoto](
    [ProductPhotoID] [int] IDENTITY(1,1) NOT NULL,
    [ThumbNailPhoto] [varbinary](max) NULL,
    [ThumbnailPhotoFileName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [LargePhoto] [varbinary](max) NULL,
    [LargePhotoFileName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [ModifiedDate] [datetime] NOT NULL,
	[ID] [int] not null,
	PRIMARY KEY CLUSTERED ([ProductPhotoID] ASC)
 );