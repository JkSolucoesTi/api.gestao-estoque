USE GestaoEstoque
GO

CREATE Procedure [dbo].[P_OBTER_LOGIN]	
	@Email nvarchar(300),
	@Senha nvarchar(10)
AS

Select Nome from Login
where Email = @Email and Senha = @Senha
GO