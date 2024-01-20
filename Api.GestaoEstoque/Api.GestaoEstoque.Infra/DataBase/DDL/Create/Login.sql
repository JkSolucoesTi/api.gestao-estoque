use GestaoEstoque
go

CREATE TABLE [dbo].[Login](
	[Nome] [varchar](100) NOT NULL,
	[Email] [nvarchar](300) NOT NULL,
	[Senha] [nvarchar](10) NOT NULL,
)

select * from login

exec P_OBTER_LOGIN 'marco','1234'


select * from EMAIL