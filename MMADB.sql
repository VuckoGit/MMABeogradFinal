USE [master]
GO
/****** Object:  Database [MMABelgrade]    Script Date: 8/28/2021 4:10:40 PM ******/
CREATE DATABASE [MMABelgrade]

GO
ALTER DATABASE [MMABelgrade] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [MMABelgrade] SET ANSI_NULLS ON 
GO
ALTER DATABASE [MMABelgrade] SET ANSI_PADDING ON 
GO
ALTER DATABASE [MMABelgrade] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [MMABelgrade] SET ARITHABORT ON 
GO
ALTER DATABASE [MMABelgrade] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MMABelgrade] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MMABelgrade] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MMABelgrade] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MMABelgrade] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [MMABelgrade] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [MMABelgrade] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MMABelgrade] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [MMABelgrade] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MMABelgrade] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MMABelgrade] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MMABelgrade] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MMABelgrade] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MMABelgrade] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MMABelgrade] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MMABelgrade] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MMABelgrade] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MMABelgrade] SET RECOVERY FULL 
GO
ALTER DATABASE [MMABelgrade] SET  MULTI_USER 
GO
ALTER DATABASE [MMABelgrade] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MMABelgrade] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MMABelgrade] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MMABelgrade] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MMABelgrade] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MMABelgrade] SET QUERY_STORE = OFF
GO
USE [MMABelgrade]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MMABelgrade]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[TaxId] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Account] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[Price] [float] NULL,
	[Gender] [varchar](50) NULL,
	[Brand] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[PurchaseOrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NULL,
	[Total] [float] NULL,
	[Comment] [varchar](max) NULL,
	[Canceled] [varchar](50) NULL,
	[ManufacturerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderItem]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderItem](
	[PurchaseOrderId] [int] NOT NULL,
	[PurchaseOrderItemId] [int] NOT NULL,
	[Quantity] [float] NULL,
	[Amount] [float] NULL,
	[ProductId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderId] ASC,
	[PurchaseOrderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceptionList]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceptionList](
	[ReceptionListId] [int] IDENTITY(1,1) NOT NULL,
	[ReceptionDate] [datetime] NULL,
	[Comment] [varchar](max) NULL,
	[Total] [float] NULL,
	[Canceled] [varchar](50) NULL,
	[ManufacturerID] [int] NULL,
	[PurchaseOrderId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReceptionListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceptionListItem]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceptionListItem](
	[ReceptionListId] [int] NOT NULL,
	[ReceptionListItemId] [int] NOT NULL,
	[Quantity] [float] NULL,
	[Amount] [float] NULL,
	[ProductId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReceptionListId] ASC,
	[ReceptionListItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8/28/2021 4:10:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (1, N'ads', N'asd', N'das', N'ads', N'asd', N'asd')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (2, N'dasasd', N'sda', N'dasdas', N'dada', N'sad', N'da')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (3, N'as', N'dasd', N'sdsad', N'adas', N'aas', N'as')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (4, N'UFC', N'123', N'office@ufc.com', N'+555123123', N'123123123', N'New York')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (5, N'UFC', N'123', N'office@ufc.com', N'+555123123', N'123123123', N'New York')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (1004, N'asdas', N'1231', N'dasd@da', N'da', N'da', N'd')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [Name], [TaxId], [Email], [Phone], [Account], [Address]) VALUES (2004, N'da', N'1231sdd', N'dasd@sda', N'das', N'das', N'da')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (3, N'Glovees', 125, N'Female', N'Addidas')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (4, N'Head Guard', 250, N'Male', N'Nike')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (5, N'Gloves', 100, N'Female', N'UFC')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (1002, N'Mouth Guard', 30, N'Male', N'UFC')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (2002, N'MMA leg shiled', 250, N'Male', N'UFC')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (3002, N'dddddd', 11111, N'Female', N'novi')
INSERT [dbo].[Product] ([ProductId], [Name], [Price], [Gender], [Brand]) VALUES (4002, N'dasd', 123, N'Male', N'asd')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseOrder] ON 

INSERT [dbo].[PurchaseOrder] ([PurchaseOrderId], [OrderDate], [Total], [Comment], [Canceled], [ManufacturerID]) VALUES (3002, CAST(N'2021-11-11T11:22:00.000' AS DateTime), 620, N'No comment', N'Yes', 2)
INSERT [dbo].[PurchaseOrder] ([PurchaseOrderId], [OrderDate], [Total], [Comment], [Canceled], [ManufacturerID]) VALUES (3003, CAST(N'2021-01-01T01:11:00.000' AS DateTime), 1850, N'All white', N'Yes', 4)
INSERT [dbo].[PurchaseOrder] ([PurchaseOrderId], [OrderDate], [Total], [Comment], [Canceled], [ManufacturerID]) VALUES (3004, CAST(N'2021-11-09T22:33:00.000' AS DateTime), 2775, N'All red', N'No', 5)
INSERT [dbo].[PurchaseOrder] ([PurchaseOrderId], [OrderDate], [Total], [Comment], [Canceled], [ManufacturerID]) VALUES (5002, CAST(N'2021-11-11T11:44:00.000' AS DateTime), 700, N'asda', N'Yes', 1)
INSERT [dbo].[PurchaseOrder] ([PurchaseOrderId], [OrderDate], [Total], [Comment], [Canceled], [ManufacturerID]) VALUES (6002, CAST(N'2021-08-27T18:07:00.000' AS DateTime), 590, N'da', N'No', 1)
SET IDENTITY_INSERT [dbo].[PurchaseOrder] OFF
GO
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3002, 1, 2, 500, 4)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3002, 2, 4, 120, 1002)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3003, 1, 4, 400, 5)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3003, 2, 7, 700, 5)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3003, 3, 3, 750, 4)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3004, 1, 5, 150, 1002)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3004, 2, 7, 1750, 4)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3004, 3, 3, 375, 3)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (3004, 4, 5, 500, 5)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (5002, 1, 2, 500, 4)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (5002, 2, 2, 200, 5)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (6002, 1, 2, 500, 4)
INSERT [dbo].[PurchaseOrderItem] ([PurchaseOrderId], [PurchaseOrderItemId], [Quantity], [Amount], [ProductId]) VALUES (6002, 2, 3, 90, 1002)
GO
SET IDENTITY_INSERT [dbo].[ReceptionList] ON 

INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (2002, CAST(N'2022-11-07T12:12:00.000' AS DateTime), N'It all ok', 620, N'Yes', 1, 3002)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (2003, CAST(N'2022-11-07T12:12:00.000' AS DateTime), N'Something is missing', 2300, N'Yes', 4, 3004)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (2004, CAST(N'2022-07-07T12:30:00.000' AS DateTime), N'Something is missing', 2060, N'No', 4, 3003)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (3002, CAST(N'2008-09-20T18:00:00.000' AS DateTime), N'sdasd', 0, N'Yes', 3, 3003)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (4002, CAST(N'2021-08-27T14:34:00.000' AS DateTime), N'dasd', 590, N'No', 1, 3002)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (4003, CAST(N'2021-08-27T14:34:00.000' AS DateTime), N'dasd', 590, N'No', 1, 3002)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (5002, CAST(N'2021-08-27T18:09:00.000' AS DateTime), N'da', 150, N'Yes', 5, 3002)
INSERT [dbo].[ReceptionList] ([ReceptionListId], [ReceptionDate], [Comment], [Total], [Canceled], [ManufacturerID], [PurchaseOrderId]) VALUES (5003, CAST(N'2021-08-27T18:11:00.000' AS DateTime), N'das', 500, N'Yes', 1, 3004)
SET IDENTITY_INSERT [dbo].[ReceptionList] OFF
GO
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2002, 1, 2, 500, 4)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2002, 2, 4, 120, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2003, 1, 4, 400, 5)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2003, 2, 7, 1750, 4)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2003, 3, 5, 150, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2004, 1, 2, 60, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2004, 2, 5, 500, 5)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2004, 3, 3, 750, 4)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (2004, 4, 6, 750, 3)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (3002, 1, 0, 0, 5)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (4002, 1, 2, 500, 4)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (4002, 2, 3, 90, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (4003, 1, 2, 500, 4)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (4003, 2, 3, 90, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (5002, 1, 2, 60, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (5002, 2, 3, 90, 1002)
INSERT [dbo].[ReceptionListItem] ([ReceptionListId], [ReceptionListItemId], [Quantity], [Amount], [ProductId]) VALUES (5003, 1, 2, 500, 4)
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Username], [Password]) VALUES (1, N'Luka', N'Vucetic', N'luka', N'luka')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Username], [Password]) VALUES (2, N'Stefan', N'Vucetic', N'stefan', N'stefan')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Username], [Password]) VALUES (3, N'David', N'Vucetic', N'david', N'david')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Manufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrder] CHECK CONSTRAINT [FK_PurchaseOrder_Manufacturer]
GO
ALTER TABLE [dbo].[PurchaseOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrderItem] CHECK CONSTRAINT [FK_PurchaseOrderItem_Product]
GO
ALTER TABLE [dbo].[PurchaseOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderItem_PurchaseOrder] FOREIGN KEY([PurchaseOrderId])
REFERENCES [dbo].[PurchaseOrder] ([PurchaseOrderId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrderItem] CHECK CONSTRAINT [FK_PurchaseOrderItem_PurchaseOrder]
GO
ALTER TABLE [dbo].[ReceptionList]  WITH CHECK ADD  CONSTRAINT [FK_ReceptionList_Manufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ReceptionList] CHECK CONSTRAINT [FK_ReceptionList_Manufacturer]
GO
ALTER TABLE [dbo].[ReceptionList]  WITH CHECK ADD  CONSTRAINT [FK_ReceptionList_PurchaseOrder] FOREIGN KEY([PurchaseOrderId])
REFERENCES [dbo].[PurchaseOrder] ([PurchaseOrderId])
GO
ALTER TABLE [dbo].[ReceptionList] CHECK CONSTRAINT [FK_ReceptionList_PurchaseOrder]
GO
ALTER TABLE [dbo].[ReceptionListItem]  WITH CHECK ADD  CONSTRAINT [FK_ReceptionListItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ReceptionListItem] CHECK CONSTRAINT [FK_ReceptionListItem_Product]
GO
ALTER TABLE [dbo].[ReceptionListItem]  WITH CHECK ADD  CONSTRAINT [FK_ReceptionListItem_ReceptionList] FOREIGN KEY([ReceptionListId])
REFERENCES [dbo].[ReceptionList] ([ReceptionListId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ReceptionListItem] CHECK CONSTRAINT [FK_ReceptionListItem_ReceptionList]
GO
USE [master]
GO
ALTER DATABASE [MMABelgrade] SET  READ_WRITE 
GO
