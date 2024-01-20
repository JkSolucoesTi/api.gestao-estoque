USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_INSERIR_FORNECEDOR]    Script Date: 05/11/2023 01:21:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[P_INSERIR_FORNECEDOR]
    @Cnpj NVARCHAR(20),
    @InscricaoEstadual NVARCHAR(20),
    @RazaoSocial NVARCHAR(100),
    @IdRamoAtividade INT,
    @Cep NVARCHAR(10),
    @Rua NVARCHAR(100),
    @Bairro NVARCHAR(100),
    @Cidade NVARCHAR(100),
    @Estado NVARCHAR(50),
    @Nome NVARCHAR(100),
    @Funcao NVARCHAR(100),
    @Email NVARCHAR(100)
AS
BEGIN

DECLARE @EmailId INT
DECLARE @ResponsavelId INT
DECLARE @EnderecoId INT

    INSERT INTO Email (Email) 
    VALUES (@Email);

    SET @EmailId = SCOPE_IDENTITY()

    INSERT INTO Responsavel(Funcao, Nome)
    VALUES (@Funcao, @Nome);

	SET @ResponsavelId = SCOPE_IDENTITY()

    INSERT INTO Endereco(Cep,Rua,Bairro,Cidade,Estado)
    VALUES (@Cep,@Rua,@Bairro,@Cidade,@Estado);

	SET @EnderecoId = SCOPE_IDENTITY()

	INSERT INTO Fornecedor(Cnpj,IE,FkRamoAtividade,FkIdEndereco,FkResponsavel,FkEmail,RazaoSocial)
	VALUES(@Cnpj,@InscricaoEstadual,@IdRamoAtividade,@EnderecoId,@ResponsavelId,@EmailId,@RazaoSocial)

END








GO


