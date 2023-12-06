CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listaTipo`()
BEGIN
	SELECT * FROM tipo;
END