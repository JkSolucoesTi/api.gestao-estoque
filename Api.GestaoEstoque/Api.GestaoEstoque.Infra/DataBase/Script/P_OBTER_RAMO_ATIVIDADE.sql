USE [GestaoEstoque]
GO

/****** Object:  StoredProcedure [dbo].[P_OBTER_RAMO_ATIVIDADE]    Script Date: 04/10/2023 00:00:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[P_OBTER_RAMO_ATIVIDADE]
AS
BEGIN

SELECT 
Id,
Nome
FROM RamoAtividade
ORDER BY Id

END
GO


