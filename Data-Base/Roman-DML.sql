--Inserindo informa��es no banco de dados SpMedGroup

-- Definindo Banco de Dados que ser� usado
USE Roman;
GO

--Inserindo informa��es na tabela Tipo de Usu�rio
INSERT INTO TipoUsuario (nomeTipoUsuario)
VALUES ('Administrador'), ('Professor');
GO

--Inserindo informa��es na tabela Usu�rio
INSERT INTO Usuario (idTipoUsuario, nomeUsuario, email, senha)
VALUES	('1', 'Rafael', 'rafael@email.com', 'rafael123'), ('1', 'Estevan', 'estevan@email.com', 'estevan123'), ('1', 'Lucas', 'lucasaluno@email.com', 'lucas123'),
		('2', 'Saulo', 'saulo@email.com', 'saulo123'), ('2', 'Lucas', 'lucas@email.com', 'lucas123');
GO

--Inserindo informa��es na tabela Situa��o
INSERT INTO Situacao (nomeSituacao)
VALUES ('Ativo'), ('Inativo');
GO

--Inserindo informa��es na tabela Tema
INSERT INTO Tema (nomeTema)
VALUES ('Gest�o'), ('Desenvolvimento de Sistemas'), ('Infraestrutura'), ('Desing');
GO

--Inserindo informa��es na tabela Projeto
INSERT INTO Projeto (idTema, idSituacao, nomeProjeto, descricaoProjeto)
VALUES ('1', '1', 'Administra��o de Pessoas', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'), ('1', '2', 'Identidade Visual', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'),
		('2', '2', 'C�digo Limpo', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'), ('3', '1', 'Equipamentos Perif�ricos', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...');
GO