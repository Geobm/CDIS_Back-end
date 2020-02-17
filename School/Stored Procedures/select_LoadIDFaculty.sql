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
-- Description: Stored procedure for selecting ID_Faculty to Update
-- =============================================
CREATE PROCEDURE select_LoadIDFaculty
	-- Add the parameters for the stored procedure here
	@pID_Faculty INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Faculty
	WHERE ID_Faculty = @pID_Faculty
END
GO
