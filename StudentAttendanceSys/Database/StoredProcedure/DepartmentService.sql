USE [StudentAttendanceDB]
GO

/****** Object:  StoredProcedure [dbo].[Add_Department]    Script Date: 7/14/2025 5:17:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Add_Department]
@Department_ID int,
@Department_Name nvarchar(255)
AS
BEGIN
INSERT INTO tbl_Department (Department_ID, Department_Name)
VALUES (@Department_ID,@Department_Name)
END
GO

