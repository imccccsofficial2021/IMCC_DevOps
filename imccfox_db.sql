USE [master]
GO
/****** Object:  Database [imccfox_db]    Script Date: 12/05/2022 2:08:20 pm ******/
CREATE DATABASE [imccfox_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'imccfox_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\imccfox_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'imccfox_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\imccfox_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [imccfox_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [imccfox_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [imccfox_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [imccfox_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [imccfox_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [imccfox_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [imccfox_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [imccfox_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [imccfox_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [imccfox_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [imccfox_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [imccfox_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [imccfox_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [imccfox_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [imccfox_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [imccfox_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [imccfox_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [imccfox_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [imccfox_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [imccfox_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [imccfox_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [imccfox_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [imccfox_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [imccfox_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [imccfox_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [imccfox_db] SET  MULTI_USER 
GO
ALTER DATABASE [imccfox_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [imccfox_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [imccfox_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [imccfox_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [imccfox_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [imccfox_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [imccfox_db] SET QUERY_STORE = OFF
GO
USE [imccfox_db]
GO
/****** Object:  Table [dbo].[Classrooms]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classrooms](
	[ROOMNO] [nvarchar](50) NULL,
	[NAME] [nvarchar](50) NULL,
	[BLDGCODE] [nvarchar](50) NULL,
	[BLDGNAME] [nvarchar](50) NULL,
	[TYPE] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DEPTNO] [smallint] NOT NULL,
	[ABBREVIATIONS] [nvarchar](50) NULL,
	[DESCRIPTION] [nvarchar](50) NULL,
	[TYPE] [nvarchar](1) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DEPTNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OfferedSubjects]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfferedSubjects](
	[DEPTNO] [smallint] NULL,
	[OFFERNO] [int] NOT NULL,
	[SUBJCODE] [nvarchar](50) NULL,
	[SUBJDESC] [nvarchar](100) NULL,
	[TIME] [nvarchar](1) NULL,
	[DAYS] [nvarchar](1) NULL,
	[LAB] [nvarchar](1) NULL,
	[LEC] [nvarchar](1) NULL,
	[UNITS] [nvarchar](1) NULL,
	[TEACHID] [nvarchar](1) NULL,
	[ROOMNO] [nvarchar](1) NULL,
	[SECNO] [nvarchar](1) NULL,
	[SEMCODE] [nvarchar](1) NULL,
	[SYR] [nvarchar](1) NULL,
 CONSTRAINT [PK_OfferedSubjects] PRIMARY KEY CLUSTERED 
(
	[OFFERNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[STUDNO] [int] NOT NULL,
	[LASTNAME] [nvarchar](50) NULL,
	[FIRSTNAME] [nvarchar](50) NULL,
	[MI] [nvarchar](50) NULL,
	[DEPTNO] [nvarchar](1) NULL,
	[GENDER] [nvarchar](1) NULL,
	[RELIKGION] [nvarchar](1) NULL,
	[SCHOLAR] [nvarchar](1) NULL,
	[SCHCODE] [nvarchar](1) NULL,
	[AWARDNO] [nvarchar](1) NULL,
	[SLOTNO] [nvarchar](1) NULL,
	[CLAIMNO] [nvarchar](1) NULL,
	[CREDITNO] [nvarchar](1) NULL,
	[GRANTNO] [nvarchar](1) NULL,
	[SCHGRANT] [nvarchar](1) NULL,
	[SCHAPP] [nvarchar](1) NULL,
	[REGION] [nvarchar](1) NULL,
	[SCHACCT] [nvarchar](1) NULL,
	[SCHADD] [nvarchar](1) NULL,
	[SCHVET] [nvarchar](1) NULL,
	[STATUS] [nvarchar](1) NULL,
	[PTAG] [nvarchar](1) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[STUDNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SUBJCODE] [nvarchar](50) NULL,
	[SUBJDESC] [nvarchar](100) NULL,
	[LAB] [tinyint] NULL,
	[LEC] [tinyint] NULL,
	[UNITS] [tinyint] NULL,
	[CATEGORY] [nvarchar](1) NULL,
	[STATUS] [nvarchar](50) NULL,
	[PREREQ] [nvarchar](50) NULL,
	[DEPTNO] [nvarchar](50) NULL,
	[SEMESTER] [nvarchar](50) NULL,
	[SEMCODE] [nvarchar](50) NULL,
	[YRLEVEL] [nvarchar](50) NULL,
	[COURSENO] [nvarchar](50) NULL,
	[TYPE] [nvarchar](50) NULL,
	[ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubmittedGrades]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubmittedGrades](
	[STUDNO] [smallint] NULL,
	[LASTNAME] [nvarchar](50) NULL,
	[FIRSTNAME] [nvarchar](50) NULL,
	[MI] [nvarchar](50) NULL,
	[YRLEVEL] [tinyint] NULL,
	[SEMESTER] [tinyint] NULL,
	[SYR] [smallint] NULL,
	[OFFERNO] [int] NULL,
	[SUBJCODE] [nvarchar](50) NULL,
	[SUBJDESC] [nvarchar](50) NULL,
	[UNITS] [tinyint] NULL,
	[DEPTNO] [tinyint] NULL,
	[PRELIM] [float] NULL,
	[MIDTERM] [float] NULL,
	[PREFINAL] [float] NULL,
	[FINAL] [float] NULL,
	[AVERAGE] [time](7) NULL,
	[RETAKE] [nvarchar](50) NULL,
	[TEACHID] [smallint] NULL,
	[DATE] [date] NULL,
	[TIME] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherClasses]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherClasses](
	[CLASSID] [int] NOT NULL,
	[STIME] [time](7) NULL,
	[ETIME] [time](7) NULL,
	[TYPE] [nvarchar](50) NULL,
	[DAYS] [nvarchar](50) NULL,
	[TEACHID] [smallint] NULL,
	[SUBJCODE] [nvarchar](50) NULL,
	[OFFERNO] [int] NULL,
	[SESSION] [nvarchar](50) NULL,
 CONSTRAINT [PK_TeacherClasses] PRIMARY KEY CLUSTERED 
(
	[CLASSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 12/05/2022 2:08:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TEACHID] [int] NOT NULL,
	[LASTNAME] [nvarchar](50) NULL,
	[FIRSTNAME] [nvarchar](50) NULL,
	[MI] [nvarchar](50) NULL,
	[POSITION] [nvarchar](50) NULL,
	[DIVISION] [nvarchar](50) NULL,
	[DEGREE] [nvarchar](50) NULL,
	[MAJOR] [nvarchar](50) NULL,
	[SCHOOL] [nvarchar](50) NULL,
	[DATEHIRE] [date] NULL,
	[YEARGRAD] [smallint] NULL,
	[SALARY] [int] NULL,
	[LOAD] [tinyint] NULL,
	[STATUS] [nvarchar](50) NULL,
	[CURRLOAD] [tinyint] NULL,
	[MAXLOAD] [tinyint] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TEACHID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [imccfox_db] SET  READ_WRITE 
GO
