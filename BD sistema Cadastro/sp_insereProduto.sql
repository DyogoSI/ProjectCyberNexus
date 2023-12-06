CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereProduto`(nome VARCHAR(50), id_tipo INT, quantidade INT, preco DOUBLE)
BEGIN
INSERT INTO produto
(nome,
id_tipo,
quantidade,
preco)
VALUES
(nome,
id_tipo,
quantidade,
preco);
END