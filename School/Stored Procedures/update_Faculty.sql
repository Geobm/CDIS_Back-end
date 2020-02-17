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
-- Description: Stored procedure for update
-- =============================================
CREATE PROCEDURE update_Faculty
	-- Add the parameters for the stored procedure here
	@pID_Faculty INT,
	@pCode VARCHAR(20),
	@pName VARCHAR(100),
	@pCreation_Date DATE,
	@pUniversity INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Faculty
	SET Code = @pCode,
		Name = @pName,
		Creation_date = @pCreation_Date,
		University = @pUniversity
	WHERE ID_Faculty = @pID_Faculty

END
GO
