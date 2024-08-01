USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_OBTER_PRODUTOS]    Script Date: 05/11/2023 01:22:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_OBTER_PRODUTOS]
AS
BEGIN
    SELECT 
	Id
   ,Codigo
   ,Nome
   ,FornecedorId
   ,Quantidade
   ,Compra
	FROM Produto
	order by Codigo
END
GO


