USE [WomenTechsters]
GO
/****** Object:  StoredProcedure [dbo].[INSERTINTOCUSTOMERACTIONS]    Script Date: 2021/08/15 04:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE  [dbo].[INSERTINTOCUSTOMERACTIONS]
@firstName VARCHAR(120), @lastName VARCHAR(120),@email VARCHAR(120), @password VARCHAR (120),@otherName VARCHAR(120)
	
AS
BEGIN
	
	       SET NOCOUNT ON;
INSERT INTO CustomerActions VALUES(@firstName, @lastName, @email, @password,@otherName)
END
