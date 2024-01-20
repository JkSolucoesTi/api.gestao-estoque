use GestaoEstoque
go

create table RamoAtividade
(
	Id  int identity(1,1) primary key,
	Nome varchar(20) not null
)
