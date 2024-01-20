use GestaoEstoque
go

create table Email
(
	Id int identity(1,1) primary key,
	Email varchar(300) not null
)