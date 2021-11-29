--Inserindo informações no banco de dados SpMedGroup

-- Definindo Banco de Dados que será usado
USE Roman;
GO

--Inserindo informações na tabela Tipo de Usuário
INSERT INTO TipoUsuario (nomeTipoUsuario)
VALUES ('Administrador'), ('Professor');
GO

--Inserindo informações na tabela Usuário
INSERT INTO Usuario (idTipoUsuario, nomeUsuario, email, senha)
VALUES	('1', 'Rafael', 'rafael@email.com', 'rafael123'), ('1', 'Estevan', 'estevan@email.com', 'estevan123'), ('1', 'Lucas', 'lucasaluno@email.com', 'lucas123'),
		('2', 'Saulo', 'saulo@email.com', 'saulo123'), ('2', 'Lucas', 'lucas@email.com', 'lucas123');
GO

--Inserindo informações na tabela Situação
INSERT INTO Situacao (nomeSituacao)
VALUES ('Ativo'), ('Inativo');
GO

--Inserindo informações na tabela Tema
INSERT INTO Tema (nomeTema)
VALUES ('Gestão'), ('Desenvolvimento de Sistemas'), ('Infraestrutura'), ('Desing');
GO

--Inserindo informações na tabela Projeto
INSERT INTO Projeto (idTema, idSituacao, nomeProjeto, descricaoProjeto)
VALUES ('1', '1', 'Administração de Pessoas', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'), ('1', '2', 'Identidade Visual', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'),
		('2', '2', 'Código Limpo', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...'), ('3', '1', 'Equipamentos Periféricos', 'Lorem ipsum... Lorem ipsum... Lorem ipsum...');
GO