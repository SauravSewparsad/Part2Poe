USE [Task2Prog]
GO

/****** Object:  Table [dbo].[Farmer]    Script Date: 5/29/2023 3:42:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Farmer](
	[FarmerId] [int] IDENTITY(1,1) NOT NULL,
	[FarmerName] [varchar](50) NULL,
	[FarmerAddress] [varchar](255) NULL,
	[FarmerPhone] [varchar](10) NULL,
 CONSTRAINT [PK_Farmer] PRIMARY KEY CLUSTERED 
(
	[FarmerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

