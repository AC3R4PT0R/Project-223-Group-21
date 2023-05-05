USE [Kitted Galore Staff]
GO

/****** Object:  Table [dbo].[tbl_orders]    Script Date: 2021/10/10 23:27:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_orders](
	[OrderNumber] [nchar](10) NOT NULL,
	[Weight] [nchar](10) NULL,
	[DateDispatched] [date] NULL,
	[Date Recieved] [date] NULL,
	[Amount Revieced] [money] NULL,
	[OrderStatus] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

