use GestaoEstoque
go

create table Responsavel
(
	Id int identity(1,1) primary key,
	Funcao varchar(200) not null,
)