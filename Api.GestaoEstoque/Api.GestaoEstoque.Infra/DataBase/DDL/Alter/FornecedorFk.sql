use GestaoEstoque
go

ALTER TABLE Fornecedor
ADD CONSTRAINT FK_Fornecedor_RamoAtividade
FOREIGN KEY (FkRamoAtividade)
REFERENCES RamoAtividade (Id);

-- Criando a chave estrangeira para a coluna FkIdEndereco
ALTER TABLE Fornecedor
ADD CONSTRAINT FK_Fornecedor_Endereco
FOREIGN KEY (FkIdEndereco)
REFERENCES Endereco (Id);

-- Criando a chave estrangeira para a coluna FkResponsavel
ALTER TABLE Fornecedor
ADD CONSTRAINT FK_Fornecedor_Responsavel
FOREIGN KEY (FkResponsavel)
REFERENCES Responsavel (Id);

-- Criando a chave estrangeira para a coluna FkEmail
ALTER TABLE Fornecedor
ADD CONSTRAINT FK_Fornecedor_Email
FOREIGN KEY (FkEmail)
REFERENCES Email (Id);