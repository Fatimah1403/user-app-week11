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
-- Description:	To execute querries
-- =============================================

CREATE PROCEDURE INSERTINTOSTOREDETAILS
@storeName VARCHAR(120), @storeNumber INT, @storeType VARCHAR(120),@productPrice INT
AS
BEGIN
	
	 SET NOCOUNT ON;
INSERT INTO StoreDetails VALUES(@storeName,@storeNumber,@storeType, ,@productPrice) 
END
GO
