USE [master]
GO
/****** Object:  Database [StudentAttendanceDB]    Script Date: 7/10/2025 11:48:20 AM ******/
CREATE DATABASE [StudentAttendanceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentAttendanceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentAttendanceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentAttendanceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentAttendanceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StudentAttendanceDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentAttendanceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentAttendanceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentAttendanceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentAttendanceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentAttendanceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentAttendanceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentAttendanceDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentAttendanceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentAttendanceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentAttendanceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentAttendanceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentAttendanceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentAttendanceDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentAttendanceDB', N'ON'
GO
ALTER DATABASE [StudentAttendanceDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StudentAttendanceDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StudentAttendanceDB]
GO
/****** Object:  Table [dbo].[tbl_Attendance]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Attendance](
	[Attendance_ID] [int] NOT NULL,
	[Lecture_ID] [int] NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Status] [nvarchar](255) NOT NULL,
	[Notes] [nvarchar](255) NULL,
 CONSTRAINT [tbl_attendance_attendance_id_primary] PRIMARY KEY CLUSTERED 
(
	[Attendance_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Course]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Course](
	[Course_ID] [int] NOT NULL,
	[Course_Name] [nvarchar](255) NOT NULL,
	[Course_code] [nvarchar](255) NOT NULL,
	[User_ID] [int] NOT NULL,
 CONSTRAINT [tbl_course_course_id_primary] PRIMARY KEY CLUSTERED 
(
	[Course_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Course_Department]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Course_Department](
	[Course_ID] [int] NOT NULL,
	[Department_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Department]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Department](
	[Department_ID] [int] NOT NULL,
	[Department_Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [tbl_department_department_id_primary] PRIMARY KEY CLUSTERED 
(
	[Department_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Faculty_department]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Faculty_department](
	[User_ID] [int] NOT NULL,
	[Department_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_lectures]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_lectures](
	[Lecture_ID] [int] NOT NULL,
	[Lecture_number] [int] NOT NULL,
	[Course_ID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [tbl_lectures_lecture_id_primary] PRIMARY KEY CLUSTERED 
(
	[Lecture_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Student]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Student](
	[Student_ID] [int] NOT NULL,
	[Student_Name] [nvarchar](255) NOT NULL,
	[Department_ID] [int] NOT NULL,
 CONSTRAINT [tbl_student_student_id_primary] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Student_Course]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Student_Course](
	[Student_ID] [int] NOT NULL,
	[Course_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Users]    Script Date: 7/10/2025 11:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Users](
	[User_ID] [int] NOT NULL,
	[User_Type] [nvarchar](255) NOT NULL,
	[User_Name] [nvarchar](255) NOT NULL,
	[User_Password] [nvarchar](255) NOT NULL,
	[User_Full_Name] [nvarchar](255) NOT NULL,
	[User_Telphone] [varchar](255) NULL,
	[User_Email] [nvarchar](255) NULL,
 CONSTRAINT [tbl_users_user_id_primary] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [tbl_users_user_name_unique]    Script Date: 7/10/2025 11:48:21 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [tbl_users_user_name_unique] ON [dbo].[tbl_Users]
(
	[User_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_Attendance]  WITH CHECK ADD  CONSTRAINT [tbl_attendance_lecture_id_foreign] FOREIGN KEY([Lecture_ID])
REFERENCES [dbo].[tbl_lectures] ([Lecture_ID])
GO
ALTER TABLE [dbo].[tbl_Attendance] CHECK CONSTRAINT [tbl_attendance_lecture_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Attendance]  WITH CHECK ADD  CONSTRAINT [tbl_attendance_student_id_foreign] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[tbl_Student] ([Student_ID])
GO
ALTER TABLE [dbo].[tbl_Attendance] CHECK CONSTRAINT [tbl_attendance_student_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Course]  WITH CHECK ADD  CONSTRAINT [tbl_course_user_id_foreign] FOREIGN KEY([User_ID])
REFERENCES [dbo].[tbl_Users] ([User_ID])
GO
ALTER TABLE [dbo].[tbl_Course] CHECK CONSTRAINT [tbl_course_user_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Course_Department]  WITH CHECK ADD  CONSTRAINT [tbl_course_department_course_id_foreign] FOREIGN KEY([Course_ID])
REFERENCES [dbo].[tbl_Course] ([Course_ID])
GO
ALTER TABLE [dbo].[tbl_Course_Department] CHECK CONSTRAINT [tbl_course_department_course_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Course_Department]  WITH CHECK ADD  CONSTRAINT [tbl_course_department_department_id_foreign] FOREIGN KEY([Department_ID])
REFERENCES [dbo].[tbl_Department] ([Department_ID])
GO
ALTER TABLE [dbo].[tbl_Course_Department] CHECK CONSTRAINT [tbl_course_department_department_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Faculty_department]  WITH CHECK ADD  CONSTRAINT [tbl_faculty_department_department_id_foreign] FOREIGN KEY([Department_ID])
REFERENCES [dbo].[tbl_Department] ([Department_ID])
GO
ALTER TABLE [dbo].[tbl_Faculty_department] CHECK CONSTRAINT [tbl_faculty_department_department_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Faculty_department]  WITH CHECK ADD  CONSTRAINT [tbl_faculty_department_user_id_foreign] FOREIGN KEY([User_ID])
REFERENCES [dbo].[tbl_Users] ([User_ID])
GO
ALTER TABLE [dbo].[tbl_Faculty_department] CHECK CONSTRAINT [tbl_faculty_department_user_id_foreign]
GO
ALTER TABLE [dbo].[tbl_lectures]  WITH CHECK ADD  CONSTRAINT [tbl_lectures_course_id_foreign] FOREIGN KEY([Course_ID])
REFERENCES [dbo].[tbl_Course] ([Course_ID])
GO
ALTER TABLE [dbo].[tbl_lectures] CHECK CONSTRAINT [tbl_lectures_course_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Student]  WITH CHECK ADD  CONSTRAINT [tbl_student_department_id_foreign] FOREIGN KEY([Department_ID])
REFERENCES [dbo].[tbl_Department] ([Department_ID])
GO
ALTER TABLE [dbo].[tbl_Student] CHECK CONSTRAINT [tbl_student_department_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Student_Course]  WITH CHECK ADD  CONSTRAINT [tbl_student_course_course_id_foreign] FOREIGN KEY([Course_ID])
REFERENCES [dbo].[tbl_Course] ([Course_ID])
GO
ALTER TABLE [dbo].[tbl_Student_Course] CHECK CONSTRAINT [tbl_student_course_course_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Student_Course]  WITH CHECK ADD  CONSTRAINT [tbl_student_course_student_id_foreign] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[tbl_Student] ([Student_ID])
GO
ALTER TABLE [dbo].[tbl_Student_Course] CHECK CONSTRAINT [tbl_student_course_student_id_foreign]
GO
ALTER TABLE [dbo].[tbl_Users]  WITH CHECK ADD CHECK  (([User_Type]=N'Admin' OR [User_Type]=N'Doctor'))
GO
USE [master]
GO
ALTER DATABASE [StudentAttendanceDB] SET  READ_WRITE 
GO
