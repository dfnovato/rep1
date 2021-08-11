create database db_livraria

use db_livraria

create table tbl_atendente
(
cd_atendente int primary key identity,
ds_login varchar(20) not null,
ds_senha varchar(8) not null,
nm_atendente varchar(60) not null
)

insert into tbl_atendente
(ds_login,ds_senha,nm_atendente)
values('marcos', 'pato1234', 'Marcos Aurelio')


create table tbl_cliente
(
cd_cliente int primary key identity,
nm_cliente varchar(60) not null,
ds_email varchar(60) not null,
no_CPF char(11) null,
no_CNPJ char(14) null,
nm_logradouro varchar(60) not null,
no_logradouro varchar(5) not null,
ds_complemento varchar(20) null,
nm_bairro varchar(20) not null,
nm_cidade varchar(20) not null,
sg_UF char(2) not null,
no_CEP char(8) not null
)

create table tbl_telefone
(
 cd_cliente int,
 no_telefone char(11)
 primary key(cd_cliente,no_telefone)
 foreign key(cd_cliente) references tbl_cliente(cd_cliente)
)

delete from tbl_atendente
where cd_atendente = 5

alter table tbl_atendente
add ds_status bit not null default(1)

update tbl_atendente
set ds_status = 0
where cd_atendente = 4


--ativos
select * from tbl_atendente
where ds_status = 1
--inativos
select * from tbl_atendente
where ds_status = 0