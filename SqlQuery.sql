/*create table ReparosAtivos 
(
	id int NOT NULL Identity (1,1),
	descricao varchar(30),
	numSerie varchar(30),	
	avaria varchar(200),
	idCliente int NOT NULL FOREIGN KEY REFERENCES Clientes(id),
	contacto varchar(30),
	dtEntrada datetime,
	primary key(id)
);*/


/*create table ReparosConcluidos 
(
	id int NOT NULL,
	descricao varchar(30),
	numSerie varchar(30),	
	avaria varchar(200),
	idCliente int NOT NULL,
	contacto varchar(20),
	dtEntrada datetime,
	dtReparacao datetime,
	dtEntrega datetime,
	precoSiva smallmoney,
	precoIva smallmoney,
	primary key(id)
); 

create table Clientes
(
	id int NOT NULL Identity (1,1),
	nome varchar(30) NOT NULL,
	contacto varchar(30) NOT NULL,
	primary key(id)
);*/


/*drop table ReparosAtivos

drop table ReparosConcluidos */

/*truncate table Clientes;*/

/*ALTER TABLE ReparosAtivos
ADD CONSTRAINT FK_idCliente
FOREIGN KEY (idCliente) REFERENCES Clientes(id);*/

/*INSERT INTO Clientes
VALUES
('Settimu Pizzaria', '916678863'),
('Foz Viana','258825279'),
('Foz Cabedelo','258325107')*/

/*truncate table ReparosAtivos;

DELETE FROM Clientes WHERE id = 4;

DBCC CHECKIDENT('Clientes', RESEED, 3);*/

/*INSERT INTO Clientes
VALUES
('Teste', '111111111')*/