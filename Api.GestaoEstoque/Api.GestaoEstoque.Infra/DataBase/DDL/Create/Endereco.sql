use GestaoEstoque
go

create table Endereco
(
Id int identity(1,1) primary key,
Cep varchar(8) not null,
Rua varchar(400) not null,
Bairro varchar(100) not null,
Cidade varchar(50) not null,
Estado varchar (50) not null
)