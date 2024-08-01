USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_INSERIR_PRODUTO]    Script Date: 05/11/2023 01:21:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[P_INSERIR_PRODUTO]	
	@Codigo int,
    @Nome NVARCHAR(100),
    @FornecedorId INT,
    @Quantidade INT,
    @Compra DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Produto (Codigo,Nome, FornecedorId, Quantidade, Compra)
    VALUES (@Codigo,@Nome, @FornecedorId, @Quantidade, @Compra);
END
GO


