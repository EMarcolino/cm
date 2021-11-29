-- Script de criação do Banco de Dados e suas Tabelas - DDL

-- Criando Banco de Dados
CREATE DATABASE Roman;
GO

-- Definindo Banco de Dados que será usado
USE Roman;
GO

--Criando tabela Tipo de Usuário
CREATE TABLE TipoUsuario (
	idTipoUsuario			INT PRIMARY KEY IDENTITY,
	nomeTipoUsuario			VARCHAR(200) NOT NULL	
);
GO

-- Criando tabela de Usuário
CREATE TABLE Usuario (
	idUsuario				INT PRIMARY KEY IDENTITY,	
	idTipoUsuario			INT FOREIGN KEY REFERENCES TipoUsuario (idTipoUsuario),
	nomeUsuario				VARCHAR(200) NOT NULL,
	email					VARCHAR(100) UNIQUE NOT NULL,
	senha					VARCHAR(18) NOT NULL
);
GO

--Criando tabela de Situação 
CREATE TABLE Situacao (
	idSituacao				INT PRIMARY KEY IDENTITY,
	nomeSituacao			VARCHAR(15) NOT NULL
);
GO

--Criando tabela Tipo Tema
CREATE TABLE Tema (
	idTema					INT PRIMARY KEY IDENTITY,
	nomeTema				VARCHAR(200) NOT NULL	
);
GO

--Criando tabela Tipo Projeto
CREATE TABLE Projeto (
	idProjeto				INT PRIMARY KEY IDENTITY,
	idTema					INT FOREIGN KEY REFERENCES Tema (idTema),
	idSituacao				INT FOREIGN KEY REFERENCES Situacao (idSituacao),
	nomeProjeto				VARCHAR(200) NOT NULL,
	descricaoProjeto		VARCHAR(200) NOT NULL
);
GO

