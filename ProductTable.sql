USE [Task2Prog]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 5/29/2023 3:43:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[ProductName] [varchar](50) NULL,
	[ProductDescription] [varchar](255) NULL,
	[ProductQuantity] [int] NULL,
	[ProductPrice] [decimal](10, 2) NULL,
	[ProductDate] [varchar](100) NULL,
	[FarmerId] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Farmer] FOREIGN KEY([FarmerId])
REFERENCES [dbo].[Farmer] ([FarmerId])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Farmer]
GO

