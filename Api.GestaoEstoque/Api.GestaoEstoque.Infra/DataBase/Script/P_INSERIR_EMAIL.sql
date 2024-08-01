USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_INSERIR_EMAIL]    Script Date: 05/11/2023 01:20:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[P_INSERIR_EMAIL]
    @Email NVARCHAR(255),
    @ID INT OUTPUT
AS
BEGIN
    INSERT INTO Email(Email)
	VALUES (@Email);

    SET @ID = SCOPE_IDENTITY();
END
GO


