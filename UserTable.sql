USE [Task2Prog]
GO

/****** Object:  Table [dbo].[Userstbl]    Script Date: 5/29/2023 3:45:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Userstbl](
	[UserId] [int] IDENTITY(100,10) NOT NULL,
	[Username] [varchar](50) NULL,
	[Email] [varchar](255) NULL,
	[Passcode] [varchar](20) NULL,
	[Roles] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

