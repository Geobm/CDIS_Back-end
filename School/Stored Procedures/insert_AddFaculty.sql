-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geovani Benita
-- Create date: 02/10/2020
-- Description: Stored procedure for inserting values
-- =============================================
CREATE PROCEDURE insert_AddFaculty
	-- Add the parameters for the stored procedure here
	@pCode VARCHAR,
	@pName VARCHAR,
	@pCreation_Date DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Inserting corresponding values in fields of the faculty table
	INSERT INTO Faculty(Code,Name,Creation_date) 
	VALUES(@pCode, @pName, @pCreation_Date)
END
GO
