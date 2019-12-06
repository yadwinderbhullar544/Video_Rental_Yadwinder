USE [master]
GO
/****** Object:  Database [RentedVideos]    Script Date: 04-12-2019 11:22:20 PM ******/
CREATE DATABASE [RentedVideos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentedVideos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentedVideos.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RentedVideos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentedVideos_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RentedVideos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentedVideos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentedVideos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentedVideos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentedVideos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentedVideos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentedVideos] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentedVideos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RentedVideos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentedVideos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentedVideos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentedVideos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentedVideos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentedVideos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentedVideos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentedVideos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentedVideos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RentedVideos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentedVideos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentedVideos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentedVideos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentedVideos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentedVideos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentedVideos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentedVideos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentedVideos] SET  MULTI_USER 
GO
ALTER DATABASE [RentedVideos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentedVideos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentedVideos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentedVideos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RentedVideos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RentedVideos]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [date] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_Movies]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Movies] AS
Select [MovieID]
      ,[Title]
      ,[Rating]
      ,[Year]
	  ,Genre
	  ,Plot
      ,[Rental_Cost] from Movies

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

GO
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Nirmal', N'Singh', N'Abcd', N'1234567890')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

GO
INSERT [dbo].[Login] ([ID], [LoginID], [Password]) VALUES (1, N'admin', N'Admin@123')
GO
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

GO
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (1, NULL, N'Hum Tum', NULL, 5.0000, NULL, N'utir', N'dgfhd', NULL)
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

GO
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 1, 0, CAST(N'2019-12-04 23:19:44.857' AS DateTime), NULL)
GO
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (2, 1, 1, CAST(N'2019-12-04 23:20:30.417' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetMoviesRentalList]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMoviesRentalList]
(
@rentalType char(1)
)
AS
BEGIN
IF(@rentalType='A')
BEGIN
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID 
END
else
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID where DateReturned is  null
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomers]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteCustomers]
@customerID int
AS
BEGIN

delete from Customer where CustID=@customerID

END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMovies]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMovies]
@movieID int
AS
BEGIN

delete from Movies where MovieID=@movieID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerList]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCustomerList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SELECT [CustID]
      ,[FirstName]
      ,[LastName]
      ,[Address]
      ,[Phone]
  FROM [dbo].[Customer]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetMovieList]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetMovieList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT [MovieID]
      ,[Title]
	  ,[Genre]
      ,[Rental_Cost]
      ,Plot
  FROM [dbo].[Movies]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetRentalList]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetRentalList]
AS
BEGIN

SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID


END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRentalIssueMovie]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertRentalIssueMovie]
(
@customerID int,
@movieID int
)
AS

BEGIN


INSERT INTO [dbo].[RentedMovies]
           ([MoviesIDFK]
           ,[CustIDFK]
           ,[DateRented]
           )
     VALUES
           (@movieID
           ,@customerID
           ,GETDATE()
           )
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateCustomer]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateCustomer]
@FirstName nvarchar(255)
,@LastName nvarchar(255)
,@Address nvarchar(255)
,@Phone nvarchar(255)
,@CustID int=0
AS
BEGIN
IF(@CustID >0)
BEGIN
UPDATE [dbo].[Customer]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Address] = @Address
      ,[Phone] = @Phone
 WHERE CustID = @CustID
END
ELSE
BEGIN
INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName]
           ,[Address]
           ,[Phone])
     VALUES
           (@FirstName
           ,@LastName
           ,@Address
           ,@Phone)

END


END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateMovies]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateMovies]
(
@Rating nvarchar(50)=null
,@Title nvarchar(255)
,@Year nvarchar(255)=null
,@Rental_Cost money
,@Copies nvarchar(50)=null
,@Plot ntext
,@Genre nvarchar(50)
,@MovieID int =0
)
AS
BEGIN

if(@MovieID >0)
BEGIN

UPDATE [dbo].[Movies]
   SET [Rating] = @Rating
      ,[Title] = @Title
      ,[Year] = @Year
      ,[Rental_Cost] = @Rental_Cost
      ,[Copies] = @Copies
      ,[Plot] = @Plot
      ,[Genre] = @Genre
 WHERE MovieID = @MovieID

END
ELSE
BEGIN



INSERT INTO [dbo].[Movies]
           ([Rating]
           ,[Title]
           ,[Year]
           ,[Rental_Cost]
           ,[Copies]
           ,[Plot]
           ,[Genre])
     VALUES
           (@Rating
           ,@Title
           ,@Year
           ,@Rental_Cost
           ,@Copies
           ,@Plot
           ,@Genre)
END
END


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRentalReturnMovie]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateRentalReturnMovie]
(
@rentalID int
)
AS

BEGIN


UPDATE [dbo].[RentedMovies]
   SET  [DateReturned] = GETDATE()
 WHERE RMID =@rentalID
END

GO
/****** Object:  StoredProcedure [dbo].[userLogin]    Script Date: 04-12-2019 11:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec userLogin 'mk','welcome'
CREATE procedure [dbo].[userLogin] 
@userID varchar(100),
@pwd Nvarchar(510)
as
Begin
		
select * from Login where LoginID=@userID and Password=@pwd

	
End

GO
USE [master]
GO
ALTER DATABASE [RentedVideos] SET  READ_WRITE 
GO
