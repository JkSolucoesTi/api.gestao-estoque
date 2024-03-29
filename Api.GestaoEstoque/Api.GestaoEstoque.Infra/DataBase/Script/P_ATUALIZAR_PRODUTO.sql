USE [GestaoEstoque]
GO
/****** Object:  StoredProcedure [dbo].[P_ATUALIZAR_PRODUTO]    Script Date: 25/11/2023 10:03:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_ATUALIZAR_PRODUTO]
	@Id INT,
    @Codigo INT,
    @Nome NVARCHAR(255),
    @FornecedorId INT,
    @Quantidade INT,
    @Compra DECIMAL(18, 2)
AS
BEGIN
    UPDATE Produto
    SET
        Nome = @Nome,
        FornecedorId = @FornecedorId,
        Quantidade = @Quantidade,
        Compra = @Compra,
		Codigo = @Codigo
    WHERE
        Id = @Id;

    -- Você pode adicionar mais lógica aqui, se necessário

    -- Retornar algum valor, se desejado
    SELECT @@ROWCOUNT AS 'LinhasAfetadas';
END