USE [master]
GO
/****** Object:  Database [MultilingualDictionaryDB]    Script Date: 23.8.2014 г. 15:08:04 ******/
CREATE DATABASE [MultilingualDictionaryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MultilingualDictionaryDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MultilingualDictionaryDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MultilingualDictionaryDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MultilingualDictionaryDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MultilingualDictionaryDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MultilingualDictionaryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET  MULTI_USER 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MultilingualDictionaryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MultilingualDictionaryDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MultilingualDictionaryDB', N'ON'
GO
USE [MultilingualDictionaryDB]
GO
/****** Object:  Table [dbo].[Explanations]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanations](
	[ExplanationID] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [text] NOT NULL,
	[LanguageID] [int] NOT NULL,
	[WordID] [int] NOT NULL,
 CONSTRAINT [PK_Explanations] PRIMARY KEY CLUSTERED 
(
	[ExplanationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Language]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SpeechPart]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpeechPart](
	[SpeechPartID] [int] IDENTITY(1,1) NOT NULL,
	[SpeechPart] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_SpeechPart] PRIMARY KEY CLUSTERED 
(
	[SpeechPartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordID] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](200) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[SpeechPartID] [int] NOT NULL,
	[AntonymID] [int] NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordsHypernyms]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordsHypernyms](
	[WordID] [int] NOT NULL,
	[HypernymID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordsSynonyms]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordsSynonyms](
	[WordID] [int] IDENTITY(1,1) NOT NULL,
	[SynonymID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordsTranslations]    Script Date: 23.8.2014 г. 15:08:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordsTranslations](
	[WordID] [int] NOT NULL,
	[TranslationID] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Language] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Language] ([LanguageID])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Language]
GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Words]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Language] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Language] ([LanguageID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Language]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_SpeechPart] FOREIGN KEY([SpeechPartID])
REFERENCES [dbo].[SpeechPart] ([SpeechPartID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_SpeechPart]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Words] FOREIGN KEY([AntonymID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Words]
GO
ALTER TABLE [dbo].[WordsHypernyms]  WITH CHECK ADD  CONSTRAINT [FK_WordsHypernyms_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsHypernyms] CHECK CONSTRAINT [FK_WordsHypernyms_Words]
GO
ALTER TABLE [dbo].[WordsHypernyms]  WITH CHECK ADD  CONSTRAINT [FK_WordsHypernyms_Words1] FOREIGN KEY([HypernymID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsHypernyms] CHECK CONSTRAINT [FK_WordsHypernyms_Words1]
GO
ALTER TABLE [dbo].[WordsSynonyms]  WITH CHECK ADD  CONSTRAINT [FK_WordsSynonyms_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsSynonyms] CHECK CONSTRAINT [FK_WordsSynonyms_Words]
GO
ALTER TABLE [dbo].[WordsSynonyms]  WITH CHECK ADD  CONSTRAINT [FK_WordsSynonyms_Words1] FOREIGN KEY([SynonymID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsSynonyms] CHECK CONSTRAINT [FK_WordsSynonyms_Words1]
GO
ALTER TABLE [dbo].[WordsTranslations]  WITH CHECK ADD  CONSTRAINT [FK_WordsTranslations_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsTranslations] CHECK CONSTRAINT [FK_WordsTranslations_Words]
GO
ALTER TABLE [dbo].[WordsTranslations]  WITH CHECK ADD  CONSTRAINT [FK_WordsTranslations_Words1] FOREIGN KEY([TranslationID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsTranslations] CHECK CONSTRAINT [FK_WordsTranslations_Words1]
GO
USE [master]
GO
ALTER DATABASE [MultilingualDictionaryDB] SET  READ_WRITE 
GO