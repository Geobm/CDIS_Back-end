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
-- Create date: 02/07/2020
-- Description:	Delete Stored Procedure
-- =============================================
CREATE PROCEDURE Delete_Faculty
	-- Add the parameters for the stored procedure here
	@pID_Faculty INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Faculty 
	WHERE ID_Faculty = @pID_Faculty
END
GO
