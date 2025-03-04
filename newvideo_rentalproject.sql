USE [master]
GO
/****** Object:  Database [NewVideoRentalProject]    Script Date: 23/02/2021 12:50:08 AM ******/
CREATE DATABASE [NewVideoRentalProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NewVideoRentalProject_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NewVideoRentalProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NewVideoRentalProject_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NewVideoRentalProject.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NewVideoRentalProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NewVideoRentalProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NewVideoRentalProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NewVideoRentalProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NewVideoRentalProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NewVideoRentalProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NewVideoRentalProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NewVideoRentalProject] SET  MULTI_USER 
GO
ALTER DATABASE [NewVideoRentalProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NewVideoRentalProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NewVideoRentalProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NewVideoRentalProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NewVideoRentalProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NewVideoRentalProject] SET QUERY_STORE = OFF
GO
USE [NewVideoRentalProject]
GO
/****** Object:  Table [dbo].[BookingPannel]    Script Date: 23/02/2021 12:50:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingPannel](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[CustomerID] [int] NULL,
	[IssueDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_BookingPannel] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerPannel]    Script Date: 23/02/2021 12:50:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerPannel](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
 CONSTRAINT [PK_CustomerPannel] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoPannel]    Script Date: 23/02/2021 12:50:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoPannel](
	[VideoID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Plot] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
	[Year] [int] NULL,
	[Copies] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_VideoPannel] PRIMARY KEY CLUSTERED 
(
	[VideoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookingPannel] ON 

INSERT [dbo].[BookingPannel] ([BookingID], [MovieID], [CustomerID], [IssueDate], [ReturnDate]) VALUES (1, 1, 1001, N'22/02/2021', N'Book')
SET IDENTITY_INSERT [dbo].[BookingPannel] OFF
SET IDENTITY_INSERT [dbo].[CustomerPannel] ON 

INSERT [dbo].[CustomerPannel] ([CustomerID], [Name], [Address], [Phone], [Country]) VALUES (1, N'qw', N'qw', N'qw', N'qw')
INSERT [dbo].[CustomerPannel] ([CustomerID], [Name], [Address], [Phone], [Country]) VALUES (1001, N'cm', N'nz', N'123', N'nz')
SET IDENTITY_INSERT [dbo].[CustomerPannel] OFF
SET IDENTITY_INSERT [dbo].[VideoPannel] ON 

INSERT [dbo].[VideoPannel] ([VideoID], [Name], [Plot], [Genre], [Year], [Copies], [Price]) VALUES (2, N'ok', N'1.2', N'qw', 2021, 5, 5)
SET IDENTITY_INSERT [dbo].[VideoPannel] OFF
USE [master]
GO
ALTER DATABASE [NewVideoRentalProject] SET  READ_WRITE 
GO
