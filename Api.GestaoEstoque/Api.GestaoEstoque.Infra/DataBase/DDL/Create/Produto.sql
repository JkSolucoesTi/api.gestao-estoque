USE [GestaoEstoque]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 05/11/2023 01:23:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Nome] [nvarchar](100) NULL,
	[FornecedorId] [int] NULL,
	[Quantidade] [int] NULL,
	[Compra] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Produto] FOREIGN KEY([FornecedorId])
REFERENCES [dbo].[Fornecedor] ([Id])
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Fornecedor_Produto]
GO


