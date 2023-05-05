USE [Kitted Galore Staff]
GO

/****** Object:  Table [dbo].[tbl_stock]    Script Date: 2021/10/10 23:27:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_stock](
	[SKU] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nchar](50) NULL,
	[Quantity] [numeric](18, 0) NULL,
	[ProductPrice] [money] NULL,
	[Size] [char](1) NULL
) ON [PRIMARY]
GO

