
/*create table ReparosAtivos 
(
	id int NOT NULL Identity (1,1),
	descricao varchar(30),
	numSerie varchar(30),	
	avaria varchar(200),
	cliente varchar(30),
	contacto varchar(30),
	dtEntrada datetime
	primary key(id)
);

create table ReparosConcluidos 
(
	id int NOT NULL,
	descricao varchar(30),
	numSerie varchar(30),	
	avaria varchar(200),
	cliente varchar(30),
	contacto varchar(20),
	dtEntrada datetime,
	dtReparacao datetime,
	dtEntrega datetime,
	precoSiva smallmoney,
	precoIva smallmoney,
	primary key(id)
); */

truncate table ReparosAtivos