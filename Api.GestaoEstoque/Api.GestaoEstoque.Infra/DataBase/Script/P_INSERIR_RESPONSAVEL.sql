USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_INSERIR_REPONSAVEL]    Script Date: 05/11/2023 01:21:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_INSERIR_REPONSAVEL]
    @Funcao VARCHAR(255),
	@Nome VARCHAR(255),
    @ID INT OUTPUT
AS
BEGIN
    INSERT INTO Responsavel(Funcao,Nome)
	VALUES (@Funcao,@Nome);

    SET @ID = SCOPE_IDENTITY();
END
GO


