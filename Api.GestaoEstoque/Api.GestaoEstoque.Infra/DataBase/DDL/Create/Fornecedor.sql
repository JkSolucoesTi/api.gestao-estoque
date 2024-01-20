use GestaoEstoque
go

create table Fornecedor
(
	Id int identity(1,1) primary key,
	Cnpj varchar(14) not null,
	IE varchar(12) not null,
	FkRamoAtividade int not null,
	FkIdEndereco int not null,
	FkResponsavel int not null,
	FkEmail int not null
)