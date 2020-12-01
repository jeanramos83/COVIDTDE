create database Covid 

use Covid



create table Login(
	id int not null,
	usuario char(50) not null,
	senha char(50) not null,
	role char
)

create table Paciente(
	id int not null, 
	nome char(50) not null,
	idade int not null,
	cidade char(20) not null, 
	estado char(20) not null,
	uf char(2) not null,
	sexo char(10) not null,
	estadoCivil char(20) not null,
	flComorbidade bit,
	dataRegistro date not null,
	cpf char not null
)