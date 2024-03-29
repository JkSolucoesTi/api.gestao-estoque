USE [GestaoEstoque]
GO
/****** Object:  StoredProcedure [dbo].[P_OBTER_PRODUTO_POR_CODIGO]    Script Date: 25/11/2023 10:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_OBTER_PRODUTO_POR_CODIGO]
(
	@CodigoProduto int
)
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
	where Codigo = @CodigoProduto
END
