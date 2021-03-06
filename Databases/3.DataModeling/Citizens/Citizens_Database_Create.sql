USE [master]
GO
/****** Object:  Database [Citizens]    Script Date: 8/20/2014 6:24:23 PM ******/
CREATE DATABASE [Citizens]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Citizens', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Citizens.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Citizens_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Citizens_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Citizens] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Citizens].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Citizens] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Citizens] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Citizens] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Citizens] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Citizens] SET ARITHABORT OFF 
GO
ALTER DATABASE [Citizens] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Citizens] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Citizens] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Citizens] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Citizens] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Citizens] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Citizens] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Citizens] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Citizens] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Citizens] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Citizens] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Citizens] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Citizens] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Citizens] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Citizens] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Citizens] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Citizens] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Citizens] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Citizens] SET RECOVERY FULL 
GO
ALTER DATABASE [Citizens] SET  MULTI_USER 
GO
ALTER DATABASE [Citizens] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Citizens] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Citizens] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Citizens] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Citizens', N'ON'
GO
USE [Citizens]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 8/20/2014 6:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[AddressText] [nvarchar](50) NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 8/20/2014 6:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 8/20/2014 6:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 8/20/2014 6:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 8/20/2014 6:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (1, N'Calle Major 8', 8)
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (2, N'Bressington Park 632', 11)
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (3, N'Brent str. 12', 11)
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (4, N'Via Trieste 95', 9)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (1, N'Asia')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (3, N'North America')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (4, N'South America')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (5, N'Antarctica')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (6, N'Europe')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (7, N'Australia')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (1, N'China', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (2, N'India', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (3, N'Japan', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (4, N'Italy', 6)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (5, N'Canada', 3)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (6, N'Australia', 7)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (7, N'Peru', 4)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (8, N'Germany', 6)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (9, N'USA', 3)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (10, N'Equador', 4)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (11, N'Spain', 6)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (12, N'CAR', 2)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (13, N'Egypt', 2)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (14, N'Bolivia', 4)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (1, N'Mauricio', N'Grecio', 4)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (2, N'Rosana', N'Murias', 1)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (3, N'Julio', N'Mendez', 1)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (4, N'Edward', N'Mayer', 2)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (2, N'Berlin', 8)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (3, N'Beijing', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (5, N'Vancouver', 5)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (6, N'Munich', 8)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (7, N'Madrid', 11)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (8, N'Barcelona', 11)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (9, N'Venice', 6)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (10, N'Cairo', 13)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (11, N'Sydney', 6)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownID])
REFERENCES [dbo].[Towns] ([TownID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continents] ([ContinentID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [Citizens] SET  READ_WRITE 
GO
