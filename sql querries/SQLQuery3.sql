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
-- Author:		Fatimah Hassan
-- Create date: 08/15/2021
-- Description:	To execute insert statement
-- =============================================

CREATE PROCEDURE  INSERTINTOCUSTOMERACTIONS
@firstName VARCHAR(120), @lastName VARCHAR(120),@email VARCHAR(120), @password VARCHAR (120),@otherName VARCHAR(120)
	
AS
BEGIN
	
	       SET NOCOUNT ON;
INSERT INTO CustomerActions VALUES(@firstName, @lastName, @email, @password,@otherName)
END
GO
