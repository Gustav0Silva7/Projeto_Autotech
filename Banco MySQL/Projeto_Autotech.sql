create database db_autotech;

use db_autotech;

alter table vendedor modify column email varchar(60) unique;
create table cliente(
id_cliente int primary key auto_increment,
nome varchar(30),
sobrenome varchar(50),
data_nascimento date,
logradouro varchar(80),
estado varchar(2),
email varchar(60) unique,
senha varchar(30)
);


create table loja(
id_loja int primary key auto_increment,
unidade varchar (30),
endereco varchar(80),
estado varchar(2)
);

create table vendedor(
id_vendedor int primary key,
nome varchar(30),
sobrenome varchar(50),
data_nascimento date,
logradouro varchar(80),
estado varchar(2),
fk_loja int not null,
email varchar(60) unique,
senha varchar(30),

foreign key(fk_loja) references loja(id_loja)
);

create table produtos(
id_produtos int primary key auto_increment,
nome varchar(30),
marca varchar(30),
data_producao date,
garantia_anos int,
estoque int,
preco float,
fk_loja int not null,

foreign key(fk_loja) references loja(id_loja)
);

create table pedido(
id_pedido int primary key auto_increment,
fk_produtos int not null,
preco_unitario float,
quantidade int,
preco_total float,
data_pedido date,
fk_cliente int not null,

foreign key(fk_cliente) references cliente(id_cliente)
);

create table comprovante(
id_comprovante int primary key auto_increment,
fk_cliente int not null,
fk_produtos int not null,
fk_vendedor int not null,
fk_pedido int not null,
data_emissao date,

foreign key(fk_cliente) references cliente(id_cliente),
foreign key(fk_produtos) references produtos(id_produtos),
foreign key(fk_vendedor) references vendedor(id_vendedor),
foreign key(fk_pedido) references pedido(id_pedido)
);
/*Insert do Vendedor*/

insert into vendedor(id_vendedor, nome, sobrenome, data_nascimento, logradouro, estado, fk_loja, email, senha) values(1, 'Augusto', ' Fernandes de Souza', str_to_date('26-08-1998','%d-%m-%Y'), 'Rua Padre Dictino de la parte Abia, 444', 'SP', 3, 'fernandessouzaaugusto@gmail.com', '1234567890');
insert into vendedor(id_vendedor, nome, sobrenome, data_nascimento, logradouro, estado, fk_loja, email, senha) values(2, 'Kelvyn', 'Augusto Nonato', str_to_date('26-08-1998','%d-%m-%Y'), 'R. Narciso Roman, 44-25 - Centro, Auriflama', 'SP', 2, 'kelvynawn@gmail.com', '1234567890');
insert into vendedor(id_vendedor, nome, sobrenome, data_nascimento, logradouro, estado, fk_loja, email, senha) values(3, 'Caio', 'Eduardo da Silva', str_to_date('20-10-1994','%d-%m-%Y'), 'Av. Engenheiro Eusébio Stevaux, 823','SP', 5, 'caiofelipe128@gmail.com', '1234567890');



/**/
/*Inserts da Loja*/

insert into loja(id_loja, unidade, endereco, estado) values ('1', 'Vila Maria', 'Rua Guaranésia, 425', 'SP');
insert into loja(id_loja, unidade, endereco, estado) values ('2', 'Vila Prudente', 'Avenida Professor Luiz Ignácio Anhaia Mello, 1363', 'SP');
insert into loja(id_loja, unidade, endereco, estado) values ('3', 'Vergueiro', 'Rua Vergueiro, 235/249', 'SP');
insert into loja(id_loja, unidade, endereco, estado) values ('4', 'Memorial', 'Av. Dr. Adolpho Pinto, 109', 'SP');
insert into loja(id_loja, unidade, endereco, estado) values ('5', 'Santo Amaro', 'R. Amador Bueno, 389/491', 'SP');
insert into loja(id_loja, unidade, endereco, estado) values ('6', 'Méier', 'Rua Vensceslau, 192', 'RJ');
insert into loja(id_loja, unidade, endereco, estado) values ('7', 'Rio Comprido', 'Av. Paulo de Frontin, 568', 'RJ');
insert into loja(id_loja, unidade, endereco, estado) values ('8', 'Bento Ribeiro', 'Rua Divisória, n° 79', 'RJ');

/**/

/*Inserts do produto*/

insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('1', 'Filtro de Óleo Gol 00/05',  'Volkswagen', STR_TO_DATE('04-07-2019','%d-%m-%Y'), '1', '200', '64.99', '1');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('2', 'Correia Dentada GM Corsa',  'Contitech', STR_TO_DATE('26-10-2022','%d-%m-%Y'), '1', '180', '59.99', '1');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('3', 'Bateria M50JR',  'Moura', STR_TO_DATE('30-09-2021','%d-%m-%Y'), '5', '60', '469.99', '4');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('4', 'Disco de freio dianteiro',  'Fremax', STR_TO_DATE('28-03-2022','%d-%m-%Y'), '5', '250', '134.99', '2');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('5', 'Filtro de Óleo PSL714',  'tecfil', STR_TO_DATE('16-11-2021','%d-%m-%Y'), '2', '200', '469.99', '6');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('6', 'Kit Correia Dentada +  Tensor',  'ACDelco', STR_TO_DATE('01-09-2020','%d-%m-%Y'), '2', '160', '64.99', '8');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('7', 'Bateria 60 ah',  'Cral', STR_TO_DATE('22-09-2019','%d-%m-%Y'), '4', '45', '249.99', '8');
insert into produtos(id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco, fk_loja) values ('8', 'Disco de Freio Ventilado 915c',  'Hipper Freios', STR_TO_DATE('24-05-2021','%d-%m-%Y'), '4', '190', '106.99', '7');



Select * from produtos;
/**/

/*inserts do cliente*/
insert into cliente(id_cliente,nome,sobrenome,data_nascimento,logradouro,estado,email,senha) values(1, 'Gustavo', 'Lopes da Silva', STR_TO_DATE('26/08/1998','%d/%m/%Y'), 'Rua Guaranésia, 425','SP','lopesdasilvagustavo@uni9.edu.br','#FairladyZ');

select * from cliente;
select * from loja;