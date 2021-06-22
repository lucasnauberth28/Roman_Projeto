CREATE DATABASE Roman;

use Roman

GO
-- Cria tabela Tipo Usuario
CREATE TABLE TipoUsuario(
	IdTipoUsuario INT IDENTITY PRIMARY KEY NOT NULL,
	NomeTipoUsuario VARCHAR(20)
);
GO

-- Cria tabela Usuario
CREATE TABLE Usuario(
	IdUsuario INT IDENTITY PRIMARY KEY NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Senha VARCHAR(100),
	IdTipoUsuario  INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario)
);

GO

-- Cria tabela Tema
CREATE TABLE Tema(
	IdTema INT IDENTITY PRIMARY KEY NOT NULL,
	NomeTema VARCHAR(100) NOT NULL 
);

GO

-- Cria tabela Projeto
CREATE TABLE Projeto(
	IdProjeto INT IDENTITY PRIMARY KEY NOT NULL,
	NomeProjeto VARCHAR(100),
	Descricao VARCHAR(255),
	IdTema INT FOREIGN KEY REFERENCES Tema(IdTema)
);

