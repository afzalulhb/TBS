USE [master]
GO
/****** Object:  Database [TBS]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE DATABASE [TBS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TBS', FILENAME = N'C:\Users\Ashraful Hoque\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v11.0\TBS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TBS_log', FILENAME = N'C:\Users\Ashraful Hoque\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v11.0\TBS.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TBS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TBS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TBS] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [TBS] SET ANSI_NULLS ON 
GO
ALTER DATABASE [TBS] SET ANSI_PADDING ON 
GO
ALTER DATABASE [TBS] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [TBS] SET ARITHABORT ON 
GO
ALTER DATABASE [TBS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TBS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TBS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TBS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TBS] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [TBS] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [TBS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TBS] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [TBS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TBS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TBS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TBS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TBS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TBS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TBS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TBS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TBS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TBS] SET RECOVERY FULL 
GO
ALTER DATABASE [TBS] SET  MULTI_USER 
GO
ALTER DATABASE [TBS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TBS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TBS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TBS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TBS]
GO
/****** Object:  Table [dbo].[EBillingRules]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBillingRules](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[From1] [int] NOT NULL,
	[From2] [int] NOT NULL,
	[From3] [int] NOT NULL,
	[From4] [int] NOT NULL,
	[To1] [int] NOT NULL,
	[To2] [int] NOT NULL,
	[To3] [int] NOT NULL,
	[To4] [int] NOT NULL,
	[Rate1] [decimal](18, 2) NOT NULL,
	[Rate2] [decimal](18, 2) NOT NULL,
	[Rate3] [decimal](18, 2) NOT NULL,
	[Rate4] [decimal](18, 2) NOT NULL,
	[DemandCharge] [decimal](18, 2) NOT NULL,
	[MinimumCharge] [decimal](18, 2) NOT NULL,
	[ServiceCharge] [decimal](18, 2) NOT NULL,
	[Vat] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.EBillingRules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMeters]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMeters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MeterNumber] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[Flat_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EMeters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EReadings]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EReadings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[PreviousReading] [int] NOT NULL,
	[CurrentReading] [int] NOT NULL,
	[EMeter_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EReadings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Flats]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Rent] [decimal](18, 2) NULL,
 CONSTRAINT [PK_dbo.Flats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tenants]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Occupation] [nvarchar](max) NULL,
	[PAddress] [nvarchar](max) NULL,
	[Telephone] [nvarchar](max) NULL,
	[StartDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Flat_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Tenants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UtilityOptionFlats]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilityOptionFlats](
	[UtilityOption_Id] [int] NOT NULL,
	[Flat_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UtilityOptionFlats] PRIMARY KEY CLUSTERED 
(
	[UtilityOption_Id] ASC,
	[Flat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UtilityOptions]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilityOptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Cost] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.UtilityOptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WBillingRules]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WBillingRules](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[ServiceCharge] [decimal](18, 2) NOT NULL,
	[Vat] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.WBillingRules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WMeters]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WMeters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MeterNumber] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[Flat_Id] [int] NULL,
 CONSTRAINT [PK_dbo.WMeters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WReadings]    Script Date: 19/02/2017 12:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WReadings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[PreviousReading] [int] NOT NULL,
	[CurrentReading] [int] NOT NULL,
	[WMeter_Id] [int] NULL,
 CONSTRAINT [PK_dbo.WReadings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[tmpMonthlyBills]    Script Date: 2/21/2017 5:28:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tmpMonthlyBills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenantName] [nvarchar](256) NULL,
	[BillingPeriod] [nvarchar](50) NULL,
	[BillStartDate] [nvarchar](50) NULL,
	[BillEndDate] [nvarchar](50) NULL,
	[ElectricMeterNo] [nvarchar](50) NULL,
	[ElectricMeterCurrentReading] [nvarchar](50) NULL,
	[ElectricMeterLastReading] [nvarchar](50) NULL,
	[ConsumedElectricUnit] [nvarchar](50) NULL,
	[ElectricityCharge] [nvarchar](50) NULL,
	[DemandCharge] [nvarchar](50) NULL,
	[ServiceCharge] [nvarchar](50) NULL,
	[MinimumCharge] [nvarchar](50) NULL,
	[PrincipalAmount] [nvarchar](50) NULL,
	[VAT] [nvarchar](50) NULL,
	[ElectricityBill] [nvarchar](50) NULL,
	[WaterMeter1No] [nvarchar](50) NULL,
	[WaterMeter1CurrentReading] [nvarchar](50) NULL,
	[WaterMeter1LastReading] [nvarchar](50) NULL,
	[WaterMeter1ConsumedUnit] [nvarchar](50) NULL,
	[WaterMeter2No] [nvarchar](50) NULL,
	[WaterMeter2CurrentReading] [nvarchar](50) NULL,
	[WaterMeter2LastReading] [nvarchar](50) NULL,
	[WaterMeter2ConsumedUnit] [nvarchar](50) NULL,
	[TotalConsumedWaterUnit] [nvarchar](50) NULL,
	[WaterUnitPrice] [nvarchar](50) NULL,
	[WaterBill] [nvarchar](50) NULL,
	[HouseRent] [nvarchar](50) NULL,
	[GasBill] [nvarchar](50) NULL,
	[CleanerBill] [nvarchar](50) NULL,
	[Total] [nvarchar](50) NULL
) ON [PRIMARY]

GO

SET IDENTITY_INSERT [dbo].[EBillingRules] ON 

INSERT [dbo].[EBillingRules] ([Id], [From1], [From2], [From3], [From4], [To1], [To2], [To3], [To4], [Rate1], [Rate2], [Rate3], [Rate4], [DemandCharge], [MinimumCharge], [ServiceCharge], [Vat]) VALUES (1, 0, 101, 201, 301, 100, 200, 300, 6000, CAST(5.11 AS Decimal(18, 2)), CAST(5.50 AS Decimal(18, 2)), CAST(8.70 AS Decimal(18, 2)), CAST(9.98 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[EBillingRules] OFF
SET IDENTITY_INSERT [dbo].[EMeters] ON 

INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (1, N'183927', N'', 1, 1)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (2, N'183928', NULL, 1, 2)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (3, N'00979', NULL, 1, 3)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (4, N'00903', NULL, 1, 4)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (5, N'25094', NULL, 1, 5)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (6, N'25069', NULL, 1, 6)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (7, N'25148', NULL, 1, 7)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (8, N'25198', NULL, 1, 8)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (9, N'00905', NULL, 1, 9)
INSERT [dbo].[EMeters] ([Id], [MeterNumber], [Description], [IsActive], [Flat_Id]) VALUES (10, N'00901', NULL, 1, 10)
SET IDENTITY_INSERT [dbo].[EMeters] OFF
SET IDENTITY_INSERT [dbo].[EReadings] ON 

INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (1, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 17310, 17385, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (2, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 17485, 17566, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (3, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 17242, 17334, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (4, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 19362, 19490, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (5, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 14707, 14771, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (6, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 14112, 14171, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (7, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 21462, 21554, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (8, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 13555, 13637, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (9, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 13060, 13149, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (10, CAST(N'2014-01-01 00:00:00.000' AS DateTime), CAST(N'2014-01-31 00:00:00.000' AS DateTime), 16562, 16665, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (11, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 19286, 19417, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (12, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 19266, 19404, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (13, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 19394, 19526, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (14, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 22178, 22400, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (15, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 16469, 16599, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (16, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 16000, 16161, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (17, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 24519, 24726, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (18, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 15460, 15629, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (19, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 14914, 15085, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (20, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-30 00:00:00.000' AS DateTime), 19370, 19571, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (21, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 19417, 19546, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (22, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 19404, 19543, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (23, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 19526, 19659, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (24, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 22400, 22599, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (25, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 16599, 16729, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (26, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 16161, 16274, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (27, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 24726, 24943, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (28, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 15629, 15786, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (29, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 15085, 15265, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (30, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-31 00:00:00.000' AS DateTime), 19571, 19787, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (31, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 19546, 19683, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (32, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 19543, 19685, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (33, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 19659, 19795, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (34, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 22599, 22841, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (35, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 16729, 16852, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (36, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 16274, 16415, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (37, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 24943, 25157, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (38, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 15786, 15930, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (39, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 15265, 15447, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (40, CAST(N'2015-08-01 00:00:00.000' AS DateTime), CAST(N'2015-08-31 00:00:00.000' AS DateTime), 19787, 20002, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (41, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 16415, 16541, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (42, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 19683, 19816, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (43, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 19685, 19819, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (44, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 19795, 19961, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (45, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 22841, 23076, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (46, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 16852, 16980, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (47, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 25157, 25374, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (48, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 15930, 16054, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (49, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 15447, 15623, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (50, CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 20002, 20217, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (51, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 19816, 19961, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (52, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 19819, 19962, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (53, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 19961, 20152, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (54, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 23076, 23316, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (55, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 16980, 17118, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (56, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 16541, 16649, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (57, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 25374, 25597, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (58, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 16054, 16182, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (59, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 15623, 15793, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (60, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'2015-10-31 00:00:00.000' AS DateTime), 20217, 20440, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (61, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 19961, 20073, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (62, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 19962, 20078, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (63, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 20152, 20280, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (64, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 23316, 23488, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (65, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 17118, 17224, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (66, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 16649, 16726, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (67, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 25597, 25795, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (68, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 16182, 16275, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (69, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 15793, 15895, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (70, CAST(N'2015-11-01 00:00:00.000' AS DateTime), CAST(N'2015-11-30 00:00:00.000' AS DateTime), 20440, 20612, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (71, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 20073, 20157, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (72, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 20078, 20154, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (73, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 20280, 20400, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (74, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 23468, 23618, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (75, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 17224, 17303, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (76, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 16726, 16773, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (77, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 25795, 25947, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (78, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 16275, 16317, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (79, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 15895, 15943, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (80, CAST(N'2015-12-01 00:00:00.000' AS DateTime), CAST(N'2015-12-31 00:00:00.000' AS DateTime), 20612, 20725, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (81, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 20157, 20219, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (82, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 20154, 20219, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (83, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 20400, 20512, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (84, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 23618, 23743, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (85, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 17303, 17366, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (86, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 16773, 16807, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (87, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 25947, 26078, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (88, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 16317, 16363, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (89, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 15943, 16018, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (90, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-31 00:00:00.000' AS DateTime), 20725, 20836, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (91, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 20219, 20306, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (92, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 20219, 20300, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (93, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 20512, 20630, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (94, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 23743, 23897, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (95, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 17366, 17437, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (96, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 16807, 16870, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (97, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 26078, 26251, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (98, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 16363, 16441, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (99, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 16018, 16109, 9)
GO
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (100, CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-29 00:00:00.000' AS DateTime), 20836, 20956, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (101, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 20306, 20438, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (102, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 20300, 20430, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (103, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 20630, 20780, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (104, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 23897, 24120, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (105, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 17437, 17554, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (106, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 16870, 16965, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (107, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 26251, 26465, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (108, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 16441, 16567, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (109, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 16109, 16258, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (110, CAST(N'2016-03-01 00:00:00.000' AS DateTime), CAST(N'2016-03-31 00:00:00.000' AS DateTime), 20956, 21147, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (111, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 20438, 20563, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (112, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 20430, 20579, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (113, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 20780, 20963, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (114, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 24120, 24350, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (115, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 17554, 17696, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (116, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 16965, 17086, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (117, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 26465, 26678, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (118, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 16567, 16703, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (119, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 16258, 16415, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (120, CAST(N'2016-04-01 00:00:00.000' AS DateTime), CAST(N'2016-04-30 00:00:00.000' AS DateTime), 21147, 21343, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (121, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 24350, 24536, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (122, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 20563, 20693, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (123, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 20579, 20711, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (124, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 20963, 21144, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (125, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 17696, 17804, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (126, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 17086, 17198, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (127, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 26678, 26907, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (128, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 16703, 16822, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (129, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 16415, 16574, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (130, CAST(N'2016-05-01 00:00:00.000' AS DateTime), CAST(N'2016-05-31 00:00:00.000' AS DateTime), 21343, 21539, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (131, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 20693, 20837, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (132, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 20711, 20857, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (133, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 21144, 21329, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (134, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 24536, 24738, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (135, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 17804, 17902, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (136, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 17198, 17312, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (137, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 26907, 27127, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (138, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 16822, 16942, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (139, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 16574, 16733, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (140, CAST(N'2016-06-01 00:00:00.000' AS DateTime), CAST(N'2016-06-30 00:00:00.000' AS DateTime), 21539, 21746, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (141, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 20837, 20981, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (142, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 20857, 21007, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (143, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 21329, 21515, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (144, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 24738, 24923, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (145, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 17902, 18018, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (146, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 17312, 17417, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (147, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 27127, 27343, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (148, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 16942, 17076, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (149, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 16733, 16877, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (150, CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'2016-07-31 00:00:00.000' AS DateTime), 21746, 21957, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (151, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 20981, 21121, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (152, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 21007, 21135, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (153, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 21515, 21687, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (154, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 24923, 25096, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (155, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 18018, 18158, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (156, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 17417, 17502, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (157, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 27343, 27557, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (158, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 17076, 17219, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (159, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 16877, 17062, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (160, CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'2016-08-31 00:00:00.000' AS DateTime), 21957, 22160, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (161, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 21121, 21245, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (162, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 21135, 21181, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (163, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 21687, 21857, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (164, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 25096, 25259, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (165, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 18158, 18286, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (166, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 17502, 17607, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (167, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 27557, 27781, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (168, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 17219, 17344, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (169, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 17062, 17209, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (170, CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-09-30 00:00:00.000' AS DateTime), 22160, 22357, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (171, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 21245, 21387, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (172, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 21181, 21265, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (173, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 21857, 22020, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (174, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 25259, 25485, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (175, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 18286, 18411, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (176, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 17607, 17735, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (177, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 27781, 27948, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (178, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 17344, 17480, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (179, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 17209, 17342, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (180, CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-31 00:00:00.000' AS DateTime), 22357, 22564, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (181, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 27948, 28107, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (182, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 21387, 21497, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (183, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 21265, 21293, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (184, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 22020, 22139, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (185, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 25485, 25636, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (186, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 18411, 18501, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (187, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 17735, 17812, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (188, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 17480, 17554, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (189, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 17342, 17495, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (190, CAST(N'2016-11-01 00:00:00.000' AS DateTime), CAST(N'2016-11-30 00:00:00.000' AS DateTime), 22564, 22712, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (191, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 21497, 21571, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (192, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 21293, 21303, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (193, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 22139, 22254, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (194, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 25636, 25726, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (195, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 18501, 18579, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (196, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 17812, 17860, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (197, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 28107, 28149, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (198, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 17554, 17613, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (199, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 17495, 17562, 9)
GO
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (200, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2016-12-31 00:00:00.000' AS DateTime), 22712, 22832, 10)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (201, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 21571, 21635, 1)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (202, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 21303, 21311, 2)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (203, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 22254, 22370, 3)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (204, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 25726, 25826, 4)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (205, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 18579, 18633, 5)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (206, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 17860, 17908, 6)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (207, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 28149, 28180, 7)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (208, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 17613, 17663, 8)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (209, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 17562, 17629, 9)
INSERT [dbo].[EReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [EMeter_Id]) VALUES (210, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 22832, 22948, 10)
SET IDENTITY_INSERT [dbo].[EReadings] OFF
SET IDENTITY_INSERT [dbo].[Flats] ON 

INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (1, N'102', CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (2, N'103', CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (3, N'202', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (4, N'203', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (5, N'302', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (6, N'303', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (7, N'401', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (8, N'402', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (9, N'403', CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[Flats] ([Id], [Code], [Rent]) VALUES (10, N'404', CAST(7500.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Flats] OFF
SET IDENTITY_INSERT [dbo].[Tenants] ON 

INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (1, N'Mr. Jillur Rahman', N'Business', N'Jessore', N'01716123576', CAST(N'2015-05-01 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (2, N'Mr. Nazrul Islam', N'Govt. Service', N'Brahmon Baria', N'01913671214', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (3, N'Mr. Shohel', N'Service', N'Dhaka', N'01916777007', CAST(N'2014-01-01 00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (4, N'Mr. Shohrab Hossain', N'Govt. Service', N'Tangail', N'', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 0, 4)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (5, N'Mr. Shamsuddin', N'Business', N'Gazipur', N'01716091177', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (6, N'Mr. Farhad Hossain', N'Govt. Service', N'Tangail', N'01715075094', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 0, 6)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (7, N'Mr. Shohug', N'Govt. Service', N'', N'01711085117', CAST(N'2015-01-01 00:00:00.000' AS DateTime), 0, 7)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (8, N'Mr. Jahirul Islam', N'Service', N'Barishal', N'01711435609', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 1, 8)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (9, N'Mr. Khoshru', N'Business', N'Faridpur', N'01717224330', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 1, 9)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (10, N'Mr. Noman Matobber', N'Govt. Service', N'Khulna', N'', CAST(N'2001-01-01 00:00:00.000' AS DateTime), 1, 10)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (11, N'Mr. Kamrul Islam', N'Driver', N'', N'01716414424', CAST(N'2015-06-01 17:36:35.000' AS DateTime), 0, 2)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (12, N'Mr. Delwar Hossain Babu', N'Cook', N'Comilla', N'0171569672', CAST(N'2015-09-29 13:25:51.000' AS DateTime), 1, 6)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (13, N'Mr. Monir', N'Private Service', N'', N'', CAST(N'2016-05-31 11:00:18.000' AS DateTime), 0, 4)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (14, N'Mr. Ruhul Amin', N'Manager Singer, Babasree branch', N'', N'01727520203', CAST(N'2016-09-01 13:51:37.000' AS DateTime), 1, 2)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (15, N'Md. Abu Hanif Khan', N'Business', N'Vill. Binaviti, PS.Kosba, B.Baria', N'01818341627', CAST(N'2016-12-16 12:51:25.000' AS DateTime), 1, 7)
INSERT [dbo].[Tenants] ([Id], [Name], [Occupation], [PAddress], [Telephone], [StartDate], [IsActive], [Flat_Id]) VALUES (1017, N'Mr. Titu', N'Private Service', N'', N'01883888250', CAST(N'2017-02-01 13:24:19.000' AS DateTime), 1, 4)
SET IDENTITY_INSERT [dbo].[Tenants] OFF
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 1)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 1)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 2)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 2)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 3)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 3)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 4)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 4)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 5)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 5)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 6)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 6)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 7)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 7)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 8)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 8)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 9)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 9)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (1, 10)
INSERT [dbo].[UtilityOptionFlats] ([UtilityOption_Id], [Flat_Id]) VALUES (2, 10)
SET IDENTITY_INSERT [dbo].[UtilityOptions] ON 

INSERT [dbo].[UtilityOptions] ([Id], [Name], [Description], [Cost], [IsActive]) VALUES (1, N'Gas', N'', CAST(650.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[UtilityOptions] ([Id], [Name], [Description], [Cost], [IsActive]) VALUES (2, N'Cleaner', N'', CAST(60.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[UtilityOptions] ([Id], [Name], [Description], [Cost], [IsActive]) VALUES (3, N'Gas and Cleaner', N'', CAST(710.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[UtilityOptions] OFF
SET IDENTITY_INSERT [dbo].[WBillingRules] ON 

INSERT [dbo].[WBillingRules] ([Id], [UnitPrice], [ServiceCharge], [Vat]) VALUES (1, CAST(10.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[WBillingRules] OFF
SET IDENTITY_INSERT [dbo].[WMeters] ON 

INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (29, N'B103', 1, 2)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (30, N'B203', 1, 3)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (31, N'B303', 1, 6)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (32, N'C102', 1, 1)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (33, N'C202', 1, 4)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (34, N'C302', 1, 5)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (35, N'C402', 1, 8)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (36, N'C403', 1, 9)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (37, N'K103', 1, 2)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (38, N'K203', 1, 3)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (39, N'K303', 1, 6)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (40, N'K401', 1, 7)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (42, N'B401', 1, 7)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (44, N'B404', 1, 10)
INSERT [dbo].[WMeters] ([Id], [MeterNumber], [IsActive], [Flat_Id]) VALUES (45, N'K404', 1, 10)
SET IDENTITY_INSERT [dbo].[WMeters] OFF
SET IDENTITY_INSERT [dbo].[WReadings] ON 

INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1014, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 11, 29)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1015, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 6, 30)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1016, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 6, 31)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1017, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 28, 32)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1018, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 14, 33)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1019, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 12, 34)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1020, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 10, 35)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1021, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 11, 36)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1022, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 1, 37)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1023, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 3, 38)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1024, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 2, 39)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1025, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 7, 40)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1026, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 8, 42)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1027, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 19, 44)
INSERT [dbo].[WReadings] ([Id], [StartDate], [EndDate], [PreviousReading], [CurrentReading], [WMeter_Id]) VALUES (1028, CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-31 00:00:00.000' AS DateTime), 0, 8, 45)
SET IDENTITY_INSERT [dbo].[WReadings] OFF
/****** Object:  Index [IX_Flat_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_Flat_Id] ON [dbo].[EMeters]
(
	[Flat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EMeter_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_EMeter_Id] ON [dbo].[EReadings]
(
	[EMeter_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Flat_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_Flat_Id] ON [dbo].[Tenants]
(
	[Flat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Flat_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_Flat_Id] ON [dbo].[UtilityOptionFlats]
(
	[Flat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UtilityOption_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_UtilityOption_Id] ON [dbo].[UtilityOptionFlats]
(
	[UtilityOption_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Flat_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_Flat_Id] ON [dbo].[WMeters]
(
	[Flat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EMeter_Id]    Script Date: 19/02/2017 12:43:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_EMeter_Id] ON [dbo].[WReadings]
(
	[WMeter_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EMeters]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EMeters_dbo.Flats_Flat_Id] FOREIGN KEY([Flat_Id])
REFERENCES [dbo].[Flats] ([Id])
GO
ALTER TABLE [dbo].[EMeters] CHECK CONSTRAINT [FK_dbo.EMeters_dbo.Flats_Flat_Id]
GO
ALTER TABLE [dbo].[EReadings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EReadings_dbo.EMeters_EMeter_Id] FOREIGN KEY([EMeter_Id])
REFERENCES [dbo].[EMeters] ([Id])
GO
ALTER TABLE [dbo].[EReadings] CHECK CONSTRAINT [FK_dbo.EReadings_dbo.EMeters_EMeter_Id]
GO
ALTER TABLE [dbo].[Tenants]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tenants_dbo.Flats_Flat_Id] FOREIGN KEY([Flat_Id])
REFERENCES [dbo].[Flats] ([Id])
GO
ALTER TABLE [dbo].[Tenants] CHECK CONSTRAINT [FK_dbo.Tenants_dbo.Flats_Flat_Id]
GO
ALTER TABLE [dbo].[UtilityOptionFlats]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UtilityOptionFlats_dbo.Flats_Flat_Id] FOREIGN KEY([Flat_Id])
REFERENCES [dbo].[Flats] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilityOptionFlats] CHECK CONSTRAINT [FK_dbo.UtilityOptionFlats_dbo.Flats_Flat_Id]
GO
ALTER TABLE [dbo].[UtilityOptionFlats]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UtilityOptionFlats_dbo.UtilityOptions_UtilityOption_Id] FOREIGN KEY([UtilityOption_Id])
REFERENCES [dbo].[UtilityOptions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilityOptionFlats] CHECK CONSTRAINT [FK_dbo.UtilityOptionFlats_dbo.UtilityOptions_UtilityOption_Id]
GO
ALTER TABLE [dbo].[WMeters]  WITH CHECK ADD  CONSTRAINT [FK_dbo.WMeters_dbo.Flats_Flat_Id] FOREIGN KEY([Flat_Id])
REFERENCES [dbo].[Flats] ([Id])
GO
ALTER TABLE [dbo].[WMeters] CHECK CONSTRAINT [FK_dbo.WMeters_dbo.Flats_Flat_Id]
GO
ALTER TABLE [dbo].[WReadings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.WReadings_dbo.WMeters_WMeter_Id] FOREIGN KEY([WMeter_Id])
REFERENCES [dbo].[WMeters] ([Id])
GO
ALTER TABLE [dbo].[WReadings] CHECK CONSTRAINT [FK_dbo.WReadings_dbo.WMeters_WMeter_Id]
GO
USE [master]
GO
ALTER DATABASE [TBS] SET  READ_WRITE 
GO
