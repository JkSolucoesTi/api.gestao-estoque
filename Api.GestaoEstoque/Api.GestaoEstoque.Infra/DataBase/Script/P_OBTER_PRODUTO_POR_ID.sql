USE [GestaoEstoque]
GO
/****** Object:  StoredProcedure [dbo].[P_OBTER_PRODUTO_POR_ID]    Script Date: 25/11/2023 10:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_OBTER_PRODUTO_POR_ID]
(
	@ProdutoId int
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
	where id = @ProdutoId
	order by Codigo
END
