USE [master]
GO
/****** Object:  Database [MockCarDealer]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE DATABASE [MockCarDealer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MockCarDealer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MockCarDealer.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MockCarDealer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MockCarDealer_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MockCarDealer] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MockCarDealer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MockCarDealer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MockCarDealer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MockCarDealer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MockCarDealer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MockCarDealer] SET ARITHABORT OFF 
GO
ALTER DATABASE [MockCarDealer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MockCarDealer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MockCarDealer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MockCarDealer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MockCarDealer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MockCarDealer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MockCarDealer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MockCarDealer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MockCarDealer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MockCarDealer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MockCarDealer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MockCarDealer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MockCarDealer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MockCarDealer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MockCarDealer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MockCarDealer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MockCarDealer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MockCarDealer] SET RECOVERY FULL 
GO
ALTER DATABASE [MockCarDealer] SET  MULTI_USER 
GO
ALTER DATABASE [MockCarDealer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MockCarDealer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MockCarDealer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MockCarDealer] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MockCarDealer] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MockCarDealer', N'ON'
GO
USE [MockCarDealer]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Advertisement]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Advertisement](
	[AdID] [int] IDENTITY(1,1) NOT NULL,
	[AdHeader] [varchar](100) NULL,
	[AdBody] [varchar](1000) NULL,
	[AdTypeID] [int] NULL,
 CONSTRAINT [PK_Ad] PRIMARY KEY CLUSTERED 
(
	[AdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdvertisementType]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdvertisementType](
	[AdTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AdType] [varchar](20) NULL,
 CONSTRAINT [PK_AdvertisementType] PRIMARY KEY CLUSTERED 
(
	[AdTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BestTimeToCall]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BestTimeToCall](
	[BestTimeToCallID] [int] IDENTITY(1,1) NOT NULL,
	[BestTime] [varchar](15) NULL,
 CONSTRAINT [PK_BestTimeToCall] PRIMARY KEY CLUSTERED 
(
	[BestTimeToCallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chassis]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chassis](
	[ChassisID] [int] IDENTITY(1,1) NOT NULL,
	[ChassisType] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Chassis] PRIMARY KEY CLUSTERED 
(
	[ChassisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContactHistory]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContactHistory](
	[ContactHistID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NULL,
	[ContactDate] [datetime] NULL CONSTRAINT [DF_ContactHistory_ContactDate]  DEFAULT (getdate()),
	[ContactDetails] [varchar](250) NULL,
	[LeadID] [int] NULL,
 CONSTRAINT [PK_ContactHistory] PRIMARY KEY CLUSTERED 
(
	[ContactHistID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Drivetrain]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Drivetrain](
	[DrivetrainID] [int] IDENTITY(1,1) NOT NULL,
	[DrivetrainType] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Drivetrain] PRIMARY KEY CLUSTERED 
(
	[DrivetrainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HowToContact]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HowToContact](
	[HowToContactID] [int] IDENTITY(1,1) NOT NULL,
	[ContactMethod] [varchar](15) NULL,
 CONSTRAINT [PK_HowToContact] PRIMARY KEY CLUSTERED 
(
	[HowToContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lead]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lead](
	[LeadID] [int] IDENTITY(1,1) NOT NULL,
	[LeadName] [varchar](60) NULL,
	[LeadPhone] [varchar](50) NOT NULL,
	[LeadEmail] [varchar](50) NULL,
	[BestTimeToCallID] [int] NULL,
	[PurchTimeframeID] [int] NULL,
	[LeadQuestion] [varchar](250) NULL,
	[HowToContactID] [int] NULL,
 CONSTRAINT [PK_Lead] PRIMARY KEY CLUSTERED 
(
	[LeadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeadSalesRequest]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeadSalesRequest](
	[SalesRequestID] [int] NOT NULL,
	[LeadID] [int] NOT NULL,
 CONSTRAINT [PK_LeadSalesRequest] PRIMARY KEY CLUSTERED 
(
	[SalesRequestID] ASC,
	[LeadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Make]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Make](
	[MakeID] [int] IDENTITY(1,1) NOT NULL,
	[MakeName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Make] PRIMARY KEY CLUSTERED 
(
	[MakeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Model]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Model](
	[ModelID] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [varchar](20) NOT NULL,
	[MakeID] [int] NOT NULL,
	[ChassisID] [int] NOT NULL,
	[DrivetrainID] [int] NOT NULL,
	[Trim] [varchar](20) NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[ModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OptionType]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OptionType](
	[OptionTypeID] [int] IDENTITY(1,1) NOT NULL,
	[OptionTypeName] [varchar](35) NULL,
 CONSTRAINT [PK_OptionType] PRIMARY KEY CLUSTERED 
(
	[OptionTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseTimeframe]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseTimeframe](
	[PurchTimeframeID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseTimeframe] [varchar](20) NULL,
 CONSTRAINT [PK_PurchaseTimeframe] PRIMARY KEY CLUSTERED 
(
	[PurchTimeframeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesRequest]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesRequest](
	[SalesRequestID] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [datetime] NOT NULL CONSTRAINT [DF_SalesRequest_DateCreated]  DEFAULT (getdate()),
	[AdID] [int] NOT NULL,
	[SrsID] [int] NOT NULL CONSTRAINT [DF_SalesRequest_SrsID]  DEFAULT ((1)),
	[VehID] [int] NOT NULL,
 CONSTRAINT [PK_SalesRequest] PRIMARY KEY CLUSTERED 
(
	[SalesRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesRequestStatus]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesRequestStatus](
	[SrsID] [int] IDENTITY(1,1) NOT NULL,
	[SrSType] [varchar](20) NULL CONSTRAINT [DF_SalesRequestStatus_SrSType]  DEFAULT ('new'),
 CONSTRAINT [PK_SalesRequestStatus] PRIMARY KEY CLUSTERED 
(
	[SrsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle](
	[VehID] [int] IDENTITY(1,1) NOT NULL,
	[VinNo] [varchar](20) NULL,
	[ModelYear] [int] NOT NULL,
	[IsNew] [bit] NULL,
	[ImageURL] [varchar](200) NULL,
	[Mileage] [int] NULL,
	[SellingPrice] [money] NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Vehicle_Birthday]  DEFAULT (getdate()),
	[IsDeleted] [bit] NOT NULL CONSTRAINT [DF__Vehicle__IsDelet__37A5467C]  DEFAULT ('false'),
	[ModelID] [int] NULL,
	[IsAvailable] [bit] NULL,
	[AdID] [int] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehicleOptionType]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleOptionType](
	[VehID] [int] NOT NULL,
	[OptionTypeID] [int] NOT NULL,
 CONSTRAINT [PK_VehicleOptionType] PRIMARY KEY CLUSTERED 
(
	[VehID] ASC,
	[OptionTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201510151512268_InitialCreate', N'UI.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5CDB6EE336107D2FD07F10F4D416A9954B77B10DEC16A993B4463717AC93A26F0B5AA21D61254A95A86C82A25FD6877E527FA14389BAF1A28BADD84E51A0588BC333C3E1901C8E8EF2EFDFFF8C7F7CF23DE31147B11B908979343A340D4CECC071C96A622674F9ED3BF3C71FBEFC627CE1F84FC66FB9DC0993839E249E980F9486A79615DB0FD847F1C877ED288883251DD9816F2127B08E0F0FBFB78E8E2C0C10266019C6F84342A8EBE3F407FC9C06C4C6214D90771538D88BF9736899A7A8C635F2711C221B4FCCFBD92813328D33CF4560C01C7B4BD3408404145130EFF43EC6731A0564350FE101F2EE9E430C724BE4C5989B7D5A8A771DC1E1311B815576CCA1EC24A681DF13F0E884BBC412BBAFE558B3701938ED029C4B9FD9A853C74DCC9983D3471F020F1C202A3C9D7A11139E9857858AB338BCC67494771C65909711C07D0EA24FA32AE281D1B9DF411142C7A343F6DF81314D3C9A447842704223E41D18B7C9C273ED5FF1F35DF00993C9C9D16279F2EECD5BE49CBCFD0E9FBCA98E14C60A72B507F0E8360A421C816D78598CDF34AC7A3F4BEC5874ABF4C9BC02B104ABC134AED0D37B4C56F401D6C9F13BD3B8749FB0933FE1C1754F5C583CD0894609FCBC4E3C0F2D3C5CB45B8D3AD9FF1BB41EBF793B88D66BF4E8AED2A917F4C3C289605D7DC05EDA1A3FB861B6BC6AF3FD918B5D4681CF7ED7E32B6BFD380F92C8668309B42277285A615AB76E6C95C1DB29A419D4F0619DA3EE7F68334BE5F0568AB201ADB3127215DB5E0DB9BD2FABB773C49D85214C5E1A5ACC234D01579C5123A1D381713F2B03E5A86BA01018C0FF79DFBBF091EB0DB0F175D002A9C6D28D7C5C8CF2A700C20C91DE36DFA2388675EFFC82E28706D3E19F03983EC776124138CE29F2C317D776FB10107C9DF80B16E5DBD335D8D4DC7D0E2E914D83E882B05E1BE3BD0FEC4F41422F88738E28BEA7760EC87EDEB97E778041CC39B36D1CC79710CCD899069049E78033424F8E7BC3B17D69D789C7D443AEAFCE3C841DF4632E5A661F6A092903D188A9B2902653DF072B9774333517D59B9A49B49ACAC5FA9ACAC0BA59CA25F586A602AD76665283E575E90C0D9FD8A5B0FB9FD96D7678EBF6828A1BE7B043E29F31C1116C63CE2DA21447A49C812EFBC62E928574FA98D2173F9B524DBF212F195AD55AAB21DD04865F0D29ECFEAF86D44C78FCE83A2C2BE970DDC98501BE93BCFA26D5BEE604CBB6BD1C6AC3DCB6F2EDEC01BAE57216C781EDA6AB4051E8E2658ABAFD90C319ED358B6C3462DD03060681EEB2230F9EC0D84C31A86EC839F630C5C6999D1502A728B69123BB1106E4F4302C3F51158695F58FBA71DF483A21D271C43A2176098A61A5BA84CACBC225B61B22AFD54B42CF8E47181B7BA1436C39C721264C61AB27BA2857973B9801851E6152DA3C34B62A11D71C889AAC5537E76D296C39EF5215622B31D9923B6BE292E76F2F1298CD1EDB427036BBA48B01DAD2DD2E0294DF55BA06807871D9B700156E4C9A00E529D55602B4EEB11D0468DD25AF2E40B32B6AD7F917EEABFB169EF58BF2F68FF54677ED20366BFED8B3D0CC724FE843A1078EE4F03C5FB046FC44159733B093DFCF629EEA8A21C2C0E798D64B3665BEABCC43AD661031889A00CB406B01E52FFD24206941F5302EAFE5355AC7B3881EB079DDAD1196EFFD026C250664ECEACBCF8AA0FE15A9189C9D6E1FC5C88A689082BCD365A182A3080871F3AA0FBC8353747559D9315D72E13ED97065607C321A1CD492B96A9C940F66702FE5A1D9EE255542D62725DBC84B42FAA4F1523E98C1BDC463B4DD498AA4A0475AB0918BEA47F8408B2DAF7414A74DD136B6322A147F30B6349CA9F1150A4397AC2A1C2AFEC4986704AAE9B7F3FE14233FC3B0EC58C1342AAC2D34D120422B2CB4826AB0F4D28D627A8E285A2056E7993ABE24A63C5B35DB7FAEB27A7CCA93989F03B934FB373FD68A57F5B52356CE4178D74B1898CF1299B47AAE987675778351D990872245C17E1A78894FF47995BE77F6DAAEDA3F7B22238C2DC17E296F929C2465B7758F779A0F792D6C363745B6B2FEFCE821745ECE73CDAA9F75F9A71E252F4755517425AA9DCD972E6DE932476222D87F8A5A115E661571F64915803FEA89512130486095B6EEA8758E4915B3DED21D512092542185A61E5656E9223523AB0D6BE1693CAA96E8AE41268854D1E5D6EEC80AAA48155AD1BC06B6C266B1AD3BAA824D5205563477C72EA925E2DEB9C7E794F67AD2F7A0CA2EAE9B9D541A8C97D9088739E82AEFE7AB4095C73DB1F81B78098C3FDFCB20D2DEDEFA065156A6D82C883418FA7DA6F642BBBECD34BE85D763D6DE52D7B6F2A6B7F47ABC7EA1FAA20121DDD94491427B717713EE68637E5F6AFFF845BA406522A691BB118EF1E798627FC40446F33FBCA9E762B669E7025788B84B1CD38C99611E1F1E1D0B1FD2ECCF472D561C3B9EE2BEA9FBB2A53E675B2059914714D90F2892290F1B7CF851824AD5E41971F0D3C4FC33ED759A1626D8BFD2C707C62CBE27EE1F0934DC450936FE92299CC310E19B6F527BFAD94277AFCE7EFF98753D306E225831A7C6A1E0CB7566B8FE31432F6BB2AE1B58B3F6270EAF7741D5BE2850A20A0B62FD0F08162E1DE4E381DCCAAF7CF4F4755FD3941F086C84A8F8086028BC415CA823F9AF83A525F83BF093A604FF7E835513FED7314D4BF677497F3091EADF7D1BCA7BEEF0A8515C85B6B125A57E6EA54A6FC49BDCF5D92431AA375AE8326BBA07DC06CCE83522E395918A073B1D159CE1C1B07719DA2F4E14DE176E70C9DAD82D25789B2CE086773FFF2BF2EF1ED0D514F49BDD537CB71D6BBAF2ED9EF324FB1179F72CD838296BF774DD6D079BAECCBBE7C1D68B94BB67B1B6ABF373C791D6F908DD39C556660B695EC3A86AC16D14DAAC700E37FC450041906594D9978F6ACE5613DFB4456129A257AA278B898AA58523E995249AD5F61B2B3FF01B07CB659AD56A28964DBAF9FEDFA89BCB34EBD610177741FE5552075584EC967DAC89E9F49AC8BEB591B470CBDB72D6C677EAAF89DB3B88536AAB47F38EF8F550790771C9904BA70775577EDD0B6767E52F22C2F91DBBAB1282FD7D4482EDDAA959C8CCC832C80F6FC1A25C44A8D05C618A1C3852CF22EA2E914DA199D598D34FB7D3BA1D7BD3B1C0CE8CDC24344C280C19FB0BAF56F062494093FE949F5CB7797C13A67F8564882180992EABCDDF909F12D7730ABB2F1535210D04CB2E784597CD256595DDD57381741D908E40DC7D45527487FDD003B0F886CCD1235EC73608BFF77885ECE7B202A803699F88BADBC7E72E5A45C88F3946D91F7E420C3BFED30FFF01B892E9C618540000, N'6.1.3-40302')
SET IDENTITY_INSERT [dbo].[Advertisement] ON 

INSERT [dbo].[Advertisement] ([AdID], [AdHeader], [AdBody], [AdTypeID]) VALUES (1, N'Look!', N'Great deal!!!!', 1)
INSERT [dbo].[Advertisement] ([AdID], [AdHeader], [AdBody], [AdTypeID]) VALUES (2, N'Yo!', N'Cannot miss this deal!!!', NULL)
INSERT [dbo].[Advertisement] ([AdID], [AdHeader], [AdBody], [AdTypeID]) VALUES (3, N'Matts ad', N'Testing ad body', NULL)
SET IDENTITY_INSERT [dbo].[Advertisement] OFF
SET IDENTITY_INSERT [dbo].[AdvertisementType] ON 

INSERT [dbo].[AdvertisementType] ([AdTypeID], [AdType]) VALUES (1, N'regular')
INSERT [dbo].[AdvertisementType] ([AdTypeID], [AdType]) VALUES (2, N'promotion')
SET IDENTITY_INSERT [dbo].[AdvertisementType] OFF
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5fa13a6c-e452-41f7-8248-0adcedd0bc06', N'dimitre613@gmail.com', 0, N'AAQ4VFzqtr9z6xXPvldr8O2JGrBlY3U3yVRUbd5/ldP3xS2p62ZNgm0cAUeaaIxdmA==', N'3ab2c5e6-ad25-40ab-ab93-3bd040c20f90', NULL, 0, 0, NULL, 1, 0, N'dimitre613@gmail.com')
SET IDENTITY_INSERT [dbo].[BestTimeToCall] ON 

INSERT [dbo].[BestTimeToCall] ([BestTimeToCallID], [BestTime]) VALUES (2, N'Before 10am')
INSERT [dbo].[BestTimeToCall] ([BestTimeToCallID], [BestTime]) VALUES (3, N'10am - Noon')
INSERT [dbo].[BestTimeToCall] ([BestTimeToCallID], [BestTime]) VALUES (4, N'Noon - 4pm')
INSERT [dbo].[BestTimeToCall] ([BestTimeToCallID], [BestTime]) VALUES (5, N'Evening')
SET IDENTITY_INSERT [dbo].[BestTimeToCall] OFF
SET IDENTITY_INSERT [dbo].[Chassis] ON 

INSERT [dbo].[Chassis] ([ChassisID], [ChassisType]) VALUES (1, N'car')
INSERT [dbo].[Chassis] ([ChassisID], [ChassisType]) VALUES (2, N'truck')
INSERT [dbo].[Chassis] ([ChassisID], [ChassisType]) VALUES (3, N'suv')
INSERT [dbo].[Chassis] ([ChassisID], [ChassisType]) VALUES (4, N'van')
INSERT [dbo].[Chassis] ([ChassisID], [ChassisType]) VALUES (5, N'motorcycle')
SET IDENTITY_INSERT [dbo].[Chassis] OFF
SET IDENTITY_INSERT [dbo].[ContactHistory] ON 

INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (1, 1, CAST(N'2015-10-25 00:00:00.000' AS DateTime), N'this guy is an idiot', 3)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (2, 2, CAST(N'2015-10-26 00:00:00.000' AS DateTime), N'truly an idiot', 3)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (3, 32, CAST(N'2015-10-26 20:33:56.710' AS DateTime), N'bobboomm', 6)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (4, 32, CAST(N'2015-10-26 20:34:48.083' AS DateTime), N'moron!', 14)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (5, 65, CAST(N'2015-10-26 20:35:02.323' AS DateTime), N'what a db!', 15)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (6, 23, CAST(N'2015-10-27 10:48:45.493' AS DateTime), N'jo mama is an idiot!!!', 16)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (7, 25, CAST(N'2015-10-27 10:50:33.823' AS DateTime), N'idiot ', 3)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (8, 996, CAST(N'2015-10-27 10:50:54.490' AS DateTime), N'wow!', 5)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (9, 65, CAST(N'2015-10-27 10:51:19.460' AS DateTime), N'changed status', 6)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (10, 65, CAST(N'2015-10-27 10:52:07.590' AS DateTime), N'changed status', 6)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (11, 65, CAST(N'2015-10-27 10:53:05.307' AS DateTime), N'changed status again', 4)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (12, 35, CAST(N'2015-10-27 11:00:29.170' AS DateTime), N'testing....', 6)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (13, 99, CAST(N'2015-10-27 11:01:00.770' AS DateTime), N'he''s gone', 3)
INSERT [dbo].[ContactHistory] ([ContactHistID], [EmpID], [ContactDate], [ContactDetails], [LeadID]) VALUES (14, 99, CAST(N'2015-10-27 11:01:42.697' AS DateTime), N'boom!', 5)
SET IDENTITY_INSERT [dbo].[ContactHistory] OFF
SET IDENTITY_INSERT [dbo].[Drivetrain] ON 

INSERT [dbo].[Drivetrain] ([DrivetrainID], [DrivetrainType]) VALUES (1, N'fwd')
INSERT [dbo].[Drivetrain] ([DrivetrainID], [DrivetrainType]) VALUES (2, N'rwd')
INSERT [dbo].[Drivetrain] ([DrivetrainID], [DrivetrainType]) VALUES (3, N'4wd')
INSERT [dbo].[Drivetrain] ([DrivetrainID], [DrivetrainType]) VALUES (4, N'awd')
INSERT [dbo].[Drivetrain] ([DrivetrainID], [DrivetrainType]) VALUES (5, N'moto')
SET IDENTITY_INSERT [dbo].[Drivetrain] OFF
SET IDENTITY_INSERT [dbo].[HowToContact] ON 

INSERT [dbo].[HowToContact] ([HowToContactID], [ContactMethod]) VALUES (1, N'Phone')
INSERT [dbo].[HowToContact] ([HowToContactID], [ContactMethod]) VALUES (2, N'Email')
INSERT [dbo].[HowToContact] ([HowToContactID], [ContactMethod]) VALUES (3, N'No Preference')
SET IDENTITY_INSERT [dbo].[HowToContact] OFF
SET IDENTITY_INSERT [dbo].[Lead] ON 

INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (3, N'john smithedit', N'775-351-5555', N'johnsmith@yahoo.com', 3, 2, N'gggg', 2)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (4, N'jo mama', N'651-333-2265', N'jomama@jomama.com', 5, 4, N'jo mama foo!', 3)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (5, N'jo mama da ii', N'652-555-3333', N'jomamaaswell@jomamada2.com', 3, 2, N'jo mama too foo!', 1)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (6, N'putano', N'999-221-6523', N'putoj@puto.com', 2, 1, N'jo ar a puto!!!', 1)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (14, N'ppp', N'333-354-3333', N'hp@ppp.com', 2, 1, N'mmm', 1)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (15, N'dddedit', N'999-666-3521', N'dd516@gmail.com', 2, 1, N'ddd', 1)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (16, N'jo mama da ii', N'999-666-3521', N'jomamaaswell@jomamada3.com', 2, 1, N'jo ar a puto!!!', 1)
INSERT [dbo].[Lead] ([LeadID], [LeadName], [LeadPhone], [LeadEmail], [BestTimeToCallID], [PurchTimeframeID], [LeadQuestion], [HowToContactID]) VALUES (17, N'moron', N'999-222-2222', N'marroone@moron.com', 2, 4, N'screw you guys', 2)
SET IDENTITY_INSERT [dbo].[Lead] OFF
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (3, 3)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (4, 4)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (5, 5)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (6, 6)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (14, 14)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (15, 15)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (16, 16)
INSERT [dbo].[LeadSalesRequest] ([SalesRequestID], [LeadID]) VALUES (17, 17)
SET IDENTITY_INSERT [dbo].[Make] ON 

INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (2, N'toyota')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (3, N'honda')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (4, N'mitsubishi')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (5, N'dodge')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (6, N'chevrolet')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (7, N'ford')
INSERT [dbo].[Make] ([MakeID], [MakeName]) VALUES (8, N'bmw')
SET IDENTITY_INSERT [dbo].[Make] OFF
SET IDENTITY_INSERT [dbo].[Model] ON 

INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (2, N'corolla', 2, 1, 1, N'test')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (3, N'335is', 8, 1, 1, N'3.0 ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (7, N'x5', 8, 1, 1, N'3.0 diesel ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (8, N'135i', 8, 1, 1, N'fully electric')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (9, N'aveo', 6, 1, 1, N'2.0 ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (10, N'lancer evo', 4, 1, 4, N'X 2.0 turbo')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (11, N'colorado', 6, 2, 2, N'LE')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (12, N'viper', 5, 1, 2, N'convertible')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (13, N'mustang', 7, 1, 2, N'5.0 ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (14, N'civic', 3, 1, 1, N'si')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (15, N'camry', 2, 1, 1, N'2.5')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (16, N'x3', 8, 3, 1, N'3.5 ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (17, N'impala', 6, 1, 2, N'lt')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (18, N'pilot', 3, 3, 4, N'2.8')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (19, N'535i', 8, 1, 2, N'3.5 is')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (20, N'rav 4 ', 2, 3, 4, N'2.8 ')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (21, N'x3', 8, 3, 4, N'2.5 diesel')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (22, N'cressida', 2, 1, 2, N'classic')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (23, N'ram', 5, 2, 1, N'1500 SLT Quad')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (24, N'ram', 5, 2, 1, N'3500 heavy duty')
INSERT [dbo].[Model] ([ModelID], [ModelName], [MakeID], [ChassisID], [DrivetrainID], [Trim]) VALUES (25, N'escort', 7, 1, 2, N'classic')
SET IDENTITY_INSERT [dbo].[Model] OFF
SET IDENTITY_INSERT [dbo].[PurchaseTimeframe] ON 

INSERT [dbo].[PurchaseTimeframe] ([PurchTimeframeID], [PurchaseTimeframe]) VALUES (1, N'ASAP')
INSERT [dbo].[PurchaseTimeframe] ([PurchTimeframeID], [PurchaseTimeframe]) VALUES (2, N'This week')
INSERT [dbo].[PurchaseTimeframe] ([PurchTimeframeID], [PurchaseTimeframe]) VALUES (3, N'This month')
INSERT [dbo].[PurchaseTimeframe] ([PurchTimeframeID], [PurchaseTimeframe]) VALUES (4, N'Undecided')
SET IDENTITY_INSERT [dbo].[PurchaseTimeframe] OFF
SET IDENTITY_INSERT [dbo].[SalesRequest] ON 

INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (3, CAST(N'2015-10-24 00:00:00.000' AS DateTime), 3, 5, 9)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (4, CAST(N'2015-10-25 00:00:00.000' AS DateTime), 3, 1, 8)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (5, CAST(N'2015-10-25 00:00:00.000' AS DateTime), 3, 4, 12)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (6, CAST(N'2015-10-25 00:00:00.000' AS DateTime), 3, 1, 7)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (14, CAST(N'2015-10-25 00:00:00.000' AS DateTime), 3, 1, 7)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (15, CAST(N'2015-10-25 00:00:00.000' AS DateTime), 3, 1, 9)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (16, CAST(N'2015-10-26 09:07:13.637' AS DateTime), 3, 2, 9)
INSERT [dbo].[SalesRequest] ([SalesRequestID], [DateCreated], [AdID], [SrsID], [VehID]) VALUES (17, CAST(N'2015-10-27 11:02:39.930' AS DateTime), 3, 1, 9)
SET IDENTITY_INSERT [dbo].[SalesRequest] OFF
SET IDENTITY_INSERT [dbo].[SalesRequestStatus] ON 

INSERT [dbo].[SalesRequestStatus] ([SrsID], [SrSType]) VALUES (1, N'new')
INSERT [dbo].[SalesRequestStatus] ([SrsID], [SrSType]) VALUES (2, N'future prospect')
INSERT [dbo].[SalesRequestStatus] ([SrsID], [SrSType]) VALUES (3, N'awaiting reply')
INSERT [dbo].[SalesRequestStatus] ([SrsID], [SrSType]) VALUES (4, N'reqsted veh sold')
INSERT [dbo].[SalesRequestStatus] ([SrsID], [SrSType]) VALUES (5, N'lost opportunity')
SET IDENTITY_INSERT [dbo].[SalesRequestStatus] OFF
SET IDENTITY_INSERT [dbo].[Vehicle] ON 

INSERT [dbo].[Vehicle] ([VehID], [VinNo], [ModelYear], [IsNew], [ImageURL], [Mileage], [SellingPrice], [InsertDate], [IsDeleted], [ModelID], [IsAvailable], [AdID]) VALUES (7, N'abc123', 1999, 1, N'http://media.ed.edmunds-media.com/toyota/corolla/2013/oem/2013_toyota_corolla_sedan_s_fq_oem_2_300.jpg', 10, 35995.0000, CAST(N'2015-09-25 00:00:00.000' AS DateTime), 0, 2, 0, 3)
INSERT [dbo].[Vehicle] ([VehID], [VinNo], [ModelYear], [IsNew], [ImageURL], [Mileage], [SellingPrice], [InsertDate], [IsDeleted], [ModelID], [IsAvailable], [AdID]) VALUES (8, N'cde456', 2014, 0, N'http://images.thecarconnection.com/med/chevrolet_100303251_m.jpg', 21355, 15995.0000, CAST(N'2015-04-30 00:00:00.000' AS DateTime), 0, 9, 1, 3)
INSERT [dbo].[Vehicle] ([VehID], [VinNo], [ModelYear], [IsNew], [ImageURL], [Mileage], [SellingPrice], [InsertDate], [IsDeleted], [ModelID], [IsAvailable], [AdID]) VALUES (9, N'123fde', 2015, 1, N'http://globalexportcars.com/imgs/inventory/used/5YMGZ0C54DLL298/1.jpg', 0, 45995.0000, CAST(N'2015-04-30 00:00:00.000' AS DateTime), 0, 7, 1, 3)
INSERT [dbo].[Vehicle] ([VehID], [VinNo], [ModelYear], [IsNew], [ImageURL], [Mileage], [SellingPrice], [InsertDate], [IsDeleted], [ModelID], [IsAvailable], [AdID]) VALUES (12, N'999662ffddee', 2013, 0, N'http://globalexportcars.com/imgs/inventory/used/5YMGZ0C54DLL298/1.jpg', 345, 21995.0000, CAST(N'2015-05-15 00:00:00.000' AS DateTime), 0, 7, 1, 3)
INSERT [dbo].[Vehicle] ([VehID], [VinNo], [ModelYear], [IsNew], [ImageURL], [Mileage], [SellingPrice], [InsertDate], [IsDeleted], [ModelID], [IsAvailable], [AdID]) VALUES (15, N'124Blablalalb', 1998, 0, N'testurlEdit', 99999, 999.9500, CAST(N'2015-10-27 20:06:00.893' AS DateTime), 0, 22, 0, NULL)
SET IDENTITY_INSERT [dbo].[Vehicle] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 10/29/2015 1:01:08 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Advertisement_AdvertisementType] FOREIGN KEY([AdTypeID])
REFERENCES [dbo].[AdvertisementType] ([AdTypeID])
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Advertisement_AdvertisementType]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ContactHistory]  WITH CHECK ADD  CONSTRAINT [FK_ContactHistory_Lead] FOREIGN KEY([LeadID])
REFERENCES [dbo].[Lead] ([LeadID])
GO
ALTER TABLE [dbo].[ContactHistory] CHECK CONSTRAINT [FK_ContactHistory_Lead]
GO
ALTER TABLE [dbo].[Lead]  WITH CHECK ADD  CONSTRAINT [FK_Lead_BestTimeToCall] FOREIGN KEY([BestTimeToCallID])
REFERENCES [dbo].[BestTimeToCall] ([BestTimeToCallID])
GO
ALTER TABLE [dbo].[Lead] CHECK CONSTRAINT [FK_Lead_BestTimeToCall]
GO
ALTER TABLE [dbo].[Lead]  WITH CHECK ADD  CONSTRAINT [FK_Lead_HowToContact] FOREIGN KEY([HowToContactID])
REFERENCES [dbo].[HowToContact] ([HowToContactID])
GO
ALTER TABLE [dbo].[Lead] CHECK CONSTRAINT [FK_Lead_HowToContact]
GO
ALTER TABLE [dbo].[Lead]  WITH CHECK ADD  CONSTRAINT [FK_Lead_PurchaseTimeframe] FOREIGN KEY([PurchTimeframeID])
REFERENCES [dbo].[PurchaseTimeframe] ([PurchTimeframeID])
GO
ALTER TABLE [dbo].[Lead] CHECK CONSTRAINT [FK_Lead_PurchaseTimeframe]
GO
ALTER TABLE [dbo].[LeadSalesRequest]  WITH CHECK ADD  CONSTRAINT [FK_LeadSalesRequest_Lead] FOREIGN KEY([SalesRequestID])
REFERENCES [dbo].[Lead] ([LeadID])
GO
ALTER TABLE [dbo].[LeadSalesRequest] CHECK CONSTRAINT [FK_LeadSalesRequest_Lead]
GO
ALTER TABLE [dbo].[LeadSalesRequest]  WITH CHECK ADD  CONSTRAINT [FK_LeadSalesRequest_SalesRequest] FOREIGN KEY([SalesRequestID])
REFERENCES [dbo].[SalesRequest] ([SalesRequestID])
GO
ALTER TABLE [dbo].[LeadSalesRequest] CHECK CONSTRAINT [FK_LeadSalesRequest_SalesRequest]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Chassis] FOREIGN KEY([ChassisID])
REFERENCES [dbo].[Chassis] ([ChassisID])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Chassis]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Drivetrain] FOREIGN KEY([DrivetrainID])
REFERENCES [dbo].[Drivetrain] ([DrivetrainID])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Drivetrain]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Make] FOREIGN KEY([MakeID])
REFERENCES [dbo].[Make] ([MakeID])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Make]
GO
ALTER TABLE [dbo].[SalesRequest]  WITH CHECK ADD  CONSTRAINT [FK_SalesRequest_Advertisement] FOREIGN KEY([AdID])
REFERENCES [dbo].[Advertisement] ([AdID])
GO
ALTER TABLE [dbo].[SalesRequest] CHECK CONSTRAINT [FK_SalesRequest_Advertisement]
GO
ALTER TABLE [dbo].[SalesRequest]  WITH CHECK ADD  CONSTRAINT [FK_SalesRequest_SalesRequestStatus] FOREIGN KEY([SrsID])
REFERENCES [dbo].[SalesRequestStatus] ([SrsID])
GO
ALTER TABLE [dbo].[SalesRequest] CHECK CONSTRAINT [FK_SalesRequest_SalesRequestStatus]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Advertisement] FOREIGN KEY([AdID])
REFERENCES [dbo].[Advertisement] ([AdID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Advertisement]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Model] FOREIGN KEY([ModelID])
REFERENCES [dbo].[Model] ([ModelID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Model]
GO
ALTER TABLE [dbo].[VehicleOptionType]  WITH CHECK ADD  CONSTRAINT [FK_VehicleOptionType_OptionType] FOREIGN KEY([OptionTypeID])
REFERENCES [dbo].[OptionType] ([OptionTypeID])
GO
ALTER TABLE [dbo].[VehicleOptionType] CHECK CONSTRAINT [FK_VehicleOptionType_OptionType]
GO
ALTER TABLE [dbo].[VehicleOptionType]  WITH CHECK ADD  CONSTRAINT [FK_VehicleOptionType_Vehicle1] FOREIGN KEY([VehID])
REFERENCES [dbo].[Vehicle] ([VehID])
GO
ALTER TABLE [dbo].[VehicleOptionType] CHECK CONSTRAINT [FK_VehicleOptionType_Vehicle1]
GO
/****** Object:  StoredProcedure [dbo].[ContactHistOnID]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ContactHistOnID]
(
@lID int
)
as
select 
ch.EmpID, 
ch.ContactDate, 
ch.ContactDetails 
from 
ContactHistory ch 
where 
LeadID = @lID

GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicle]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteVehicle]
(
@vID int,
@isDel bit

)
as
update Vehicle
set 
IsDeleted=@isDel
where 
VehID = @vID

GO
/****** Object:  StoredProcedure [dbo].[InsertContactHistory]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertContactHistory]
(
@empID int,
@contactDetails varchar(250),
@leadID int
)
as
insert into ContactHistory
(
EmpID,ContactDetails,LeadID
)
values
(
@empID,@contactDetails,@leadID
)
GO
/****** Object:  StoredProcedure [dbo].[InsertVehicle]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertVehicle]
(
@VehID int output,
@VinNo varchar(20), 
@ModelYear int, 
@IsNew bit, 
@ImageURL varchar(200),
@Mileage int,
@SellingPrice money,
@ModelID int,
@IsAvailable bit
)
as
insert into Vehicle
(
VinNo,ModelYear,IsNew,ImageURL,Mileage,SellingPrice,ModelID,IsAvailable
)
values
(@VinNo, @ModelYear, @IsNew,@ImageURL, @Mileage, @SellingPrice, @ModelID, @IsAvailable)

select @VehID = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[LoadAdvertisedInventory]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure 
[dbo].[LoadAdvertisedInventory] as
select
v.VehID,
v.VinNo, 
v.ModelYear,
mk.MakeName,
m.ModelName,
m.Trim,
v.Mileage,
v.SellingPrice,
a.AdHeader,
a.AdBody,
v.ImageURL
 
from vehicle v,
Advertisement a,
Make mk,
Model m

where
v.ModelID = m.ModelID and
v.AdID = a.AdID and
m.MakeID = mk.MakeID and
v.IsDeleted = 0

order by 
v.SellingPrice desc


GO
/****** Object:  StoredProcedure [dbo].[LoadAllChassis]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadAllChassis]
as
select * from Chassis

GO
/****** Object:  StoredProcedure [dbo].[LoadAllDrivetrain]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadAllDrivetrain]
as
select * from Drivetrain


GO
/****** Object:  StoredProcedure [dbo].[LoadAllInventory]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadAllInventory] as
select
v.VehID, 
v.ModelYear,
mk.MakeName,
m.ModelName,
m.Trim,
v.Mileage,
v.SellingPrice,
a.AdHeader,
v.IsAvailable
 
from vehicle v
Inner join Model m on v.ModelID = m.ModelID
Inner join Make mk on m.MakeID = mk.MakeID
Left outer join Advertisement a on v.AdID = a.AdID

where
v.IsDeleted = 0

order by 
v.SellingPrice desc

GO
/****** Object:  StoredProcedure [dbo].[LoadAllMake]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadAllMake]
as
select * from Make

GO
/****** Object:  StoredProcedure [dbo].[LoadAllModelForDisplay]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LoadAllModelForDisplay]
as

select 
         m.ModelID,
         mk.MakeName, 
		 m.ModelName, 
		 c.ChassisType, 
		 d.DrivetrainType,
         m.Trim
from 
		 Make mk, 
		 Model m, 
		 Chassis c, 
		 Drivetrain d
where 
		 m.ChassisID = c.ChassisID and 
		 m.DrivetrainID = d.DrivetrainID and 
		 mk.MakeID = m.MakeID 	
order by
		 mk.MakeName



GO
/****** Object:  StoredProcedure [dbo].[LoadAllSrS]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadAllSrS] as select * from SalesRequestStatus
GO
/****** Object:  StoredProcedure [dbo].[LoadAllVehicle]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadAllVehicle]
as
select 
	v.VehID,
	mk.MakeID, 
	v.VinNo, 
	v.ModelYear, 
	mk.MakeName, 
	m.ModelName,
	m.Trim, 
	c.ChassisType, 
	d.DrivetrainType, 
	v.Mileage, 
	v.SellingPrice,
	v.ImageURL

from 
	Vehicle v, 
	Chassis c, 
	Drivetrain d, 
	Model m, 
	Make mk
where 
	v.ModelID = m.ModelID and 
	m.ChassisID = c.ChassisID and
	m.DrivetrainID = d.DrivetrainID and 
	m.MakeID = mk.MakeID and
	v.IsDeleted = 0
order by
	mk.MakeName, 
	v.ModelYear desc



GO
/****** Object:  StoredProcedure [dbo].[LoadBestTimeToCall]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadBestTimeToCall] as select * from BestTimeToCall
GO
/****** Object:  StoredProcedure [dbo].[LoadHowToContact]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LoadHowToContact] as select * from HowToContact

GO
/****** Object:  StoredProcedure [dbo].[LoadLeadOnID]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadLeadOnID]
(
@lID int
)
as
select 
sr.SalesRequestID, 
l.LeadID,
sr.DateCreated,
l.LeadName,
l.LeadPhone,
l.LeadEmail,
btc.BestTime,
htc.ContactMethod,
ptf.PurchaseTimeframe,
l.LeadQuestion,
sr.VehID,
v.IsDeleted,
ptf.PurchTimeframeID,
srs.SrSType,
srs.SrsID,
ch.ContactDate

from 
SalesRequest sr
inner join LeadSalesRequest lsr on sr.SalesRequestID = lsr.SalesRequestID
inner join Lead l on l.LeadID = lsr.LeadID
inner join HowToContact htc on htc.HowToContactID = l.HowToContactID
inner join BestTimeToCall btc on l.BestTimeToCallID = btc.BestTimeToCallID
inner join PurchaseTimeframe ptf on ptf.PurchTimeframeID = l.PurchTimeframeID
inner join SalesRequestStatus srs on srs.SrsID = sr.SrsID
left outer join ContactHistory ch on ch.LeadID = l.LeadID
and ch.ContactDate = (select max(ContactDate) from ContactHistory ch where ch.LeadID = l.LeadID),
Vehicle v
--inner join Model mdl on mdl.ModelID = v.ModelID
--inner join Make mk on mk.MakeID = mdl.MakeID
--inner join Drivetrain dt on dt.DrivetrainID = mdl.ModelID

where 
v.VehID = sr.VehID and
srs.SrsID != '5' and
sr.SalesRequestID = @lID
GO
/****** Object:  StoredProcedure [dbo].[LoadLeadSummary]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadLeadSummary]
as
select 
sr.SalesRequestID,
l.LeadID,
l.LeadName,
sr.VehID, 
sr.DateCreated, 
v.IsDeleted,
ptf.PurchaseTimeframe,
ptf.PurchTimeframeID,
srs.SrSType,
srs.SrsID,
ch.ContactDate

from 
SalesRequest sr
inner join LeadSalesRequest lsr on sr.SalesRequestID = lsr.SalesRequestID
inner join Lead l on l.LeadID = lsr.LeadID
inner join PurchaseTimeframe ptf on ptf.PurchTimeframeID = l.PurchTimeframeID
inner join SalesRequestStatus srs on srs.SrsID = sr.SrsID
left outer join ContactHistory ch on ch.LeadID = l.LeadID and ch.ContactDate = (select max(ContactDate) from ContactHistory ch where ch.LeadID = l.LeadID),
Vehicle v

where 
v.VehID = sr.VehID and
srs.SrsID != '5' 
 
order by 
ptf.PurchTimeframeID asc,
ch.ContactDate asc, 
srs.SrsID asc
GO
/****** Object:  StoredProcedure [dbo].[LoadModelByID]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadModelByID]
(
@mID int
)
as
select  
	m.ModelID, 
	mk.MakeName, 
	m.ModelName, 
	c.ChassisType, 
	d.DrivetrainType, 
	m.Trim
from 
	Make mk, 
	Model m, 
	Chassis c, 
	Drivetrain d
where 
	m.ChassisID = c.ChassisID and
	m.DrivetrainID = d.DrivetrainID and
	m.MakeID = mk.MakeID and 
	m.ModelID = @mID


GO
/****** Object:  StoredProcedure [dbo].[LoadModelOnMakeID]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadModelOnMakeID]
(
@MakeID int
)
as

select
		m.ModelID,
		mk.MakeName, 
		m.ModelName, 
		c.ChassisType, 
		d.DrivetrainType,
		m.Trim
		
from 
		Make mk, 
		Model m, 
		Chassis c, 
		Drivetrain d
where 
		m.ChassisID = c.ChassisID and 
		m.DrivetrainID = d.DrivetrainID and 
		mk.MakeID = m.MakeID and 
		mk.MakeID = @MakeID

order by 
		mk.MakeName


GO
/****** Object:  StoredProcedure [dbo].[LoadOneVehicleOnID]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadOneVehicleOnID]
(
@vehID int
)
as
select
v.VehID,
v.VinNo, 
v.ModelYear,
mk.MakeName,
m.ModelName,
m.Trim,
v.Mileage,
v.SellingPrice,
a.AdHeader,
a.AdBody,
v.IsAvailable,
v.ImageURL,
v.AdID
 
from vehicle v
Inner join Model m on v.ModelID = m.ModelID
Inner join Make mk on m.MakeID = mk.MakeID
Left outer join Advertisement a on v.AdID = a.AdID

where
v.IsDeleted = 0 and
v.VehID = @vehID
GO
/****** Object:  StoredProcedure [dbo].[LoadPurchaseTimeframe]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadPurchaseTimeframe] as select * from PurchaseTimeframe
GO
/****** Object:  StoredProcedure [dbo].[LoadVehicleByMake]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoadVehicleByMake]
(
@mkID int
)
as
select 
mk.MakeID,
v.VehID, 
v.VinNo, 
v.ModelYear, 
mk.MakeName, 
m.ModelName,
m.Trim, 
c.ChassisType, 
d.DrivetrainType, 
v.Mileage, 
v.SellingPrice,
v.ImageURL
from 
Vehicle v, 
Chassis c, 
Drivetrain d, 
Model m, 
Make mk
where 
v.ModelID = m.ModelID and 
m.ChassisID = c.ChassisID and
m.DrivetrainID = d.DrivetrainID and 
m.MakeID = mk.MakeID and
mk.MakeID = @mkID
order by 
mk.MakeName


GO
/****** Object:  StoredProcedure [dbo].[UpdateModel]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateModel]
(
@mID int,
@mName varchar(20),
@mkID int,
@chID int,
@dtID int,
@trim varchar (20)
)
as
update Model 
set
 ModelName = @mName,
 MakeID = @mkID,
 ChassisID = @chID,
 DrivetrainID = @dtID,
 Trim = @trim
 where 
 ModelID = @mID



GO
/****** Object:  StoredProcedure [dbo].[UpdateSalesRequest]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateSalesRequest]
(
@salesRequestID int,
@srsID int
)
as
update SalesRequest
set
SrsID = @srsID
where 
@salesRequestID = SalesRequestID

GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicle]    Script Date: 10/29/2015 1:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateVehicle]
(
@vID int,
@vnNo varchar(20), 
@mdlYear int, 
@isItNew bit, 
@imgURL varchar(200),
@mi int,
@price money,
@isDel bit,
@modelID int,
@isAvail bit

)
as
if(@vnNo is not null) begin
update Vehicle
set 
VinNo =@vnNo 
where 
VehID = @vID
end

if(@mdlYear is not null) begin
update Vehicle
set 
ModelYear = @mdlYear 
where 
VehID = @vID
end

if(@isItNew is not null) begin
update Vehicle
set 
IsNew = @isItNew 
where 
VehID = @vID
end

if(@imgURL is not null) begin
update Vehicle
set 
ImageURL = @imgURL 
where 
VehID = @vID
end

if(@mi is not null) begin
update Vehicle
set 
Mileage = @mi 
where 
VehID = @vID
end

if(@price is not null) begin
update Vehicle
set 
SellingPrice = @price 
where 
VehID = @vID
end

if(@isDel is not null) begin
update Vehicle
set 
IsDeleted = @isDel 
where 
VehID = @vID
end

if(@modelID <>0) begin
update Vehicle
set 
ModelID = @modelID 
where 
VehID = @vID
end

if(@isAvail is not null) begin
update Vehicle
set 
IsAvailable = @isAvail 
where 
VehID = @vID
end



GO
USE [master]
GO
ALTER DATABASE [MockCarDealer] SET  READ_WRITE 
GO
