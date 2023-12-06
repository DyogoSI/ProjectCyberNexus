CREATE DATABASE cadastraProduto;

USE cadastraProduto;

CREATE TABLE tipo(
id_tipo INT NOT NULL AUTO_INCREMENT,
tipo VARCHAR(30),
PRIMARY KEY(id_tipo)
);


INSERT INTO tipo
VALUE(1, 'Computador'),
(2, 'Monitor'),
(3, 'Teclado'),
(4, 'Notebook'),
(5, 'Mouse'),
(6, 'Mouse Pad'),
(7, 'Baginete');

select * from produto;

CREATE TABLE produto(
id_produto INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(50),
id_tipo INT NOT NULL,
quantidade INT NOT NULL,
preco DOUBLE(7,2) NOT NULL,
PRIMARY KEY(id_produto),
FOREIGN KEY(id_tipo) REFERENCES tipo (id_tipo)
);