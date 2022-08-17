CREATE DATABASE [fullstackDotNetAngularJS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'fullstackDotNetAngularJS', FILENAME = N'/var/opt/mssql/data/fullstackDotNetAngularJS.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'fullstackDotNetAngularJS_log', FILENAME = N'/var/opt/mssql/data/fullstackDotNetAngularJS_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET COMPATIBILITY_LEVEL = 140
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET ARITHABORT OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF)
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET  READ_WRITE 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET RECOVERY FULL 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET  MULTI_USER 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [fullstackDotNetAngularJS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [fullstackDotNetAngularJS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = On;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
USE [fullstackDotNetAngularJS]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [fullstackDotNetAngularJS] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
