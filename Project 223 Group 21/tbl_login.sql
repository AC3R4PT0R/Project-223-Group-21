USE [Kitted Galore Staff]
GO

/****** Object:  Table [dbo].[tbl_login]    Script Date: 2021/10/10 23:26:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_login](
	[Username] [nchar](20) NULL,
	[Password] [nchar](9) NULL,
	[Access Level] [char](1) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbl_login] ADD  CONSTRAINT [DF_tbl_login_Access Level]  DEFAULT ((1)) FOR [Access Level]
GO

