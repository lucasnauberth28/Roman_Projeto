use Roman

GO
-- Insere Informa��es do Tipo de Usuario
INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES ('Professor');

GO

-- Insere Informa��es do Usuario
INSERT INTO Usuario (Email, Senha, IdTipoUsuario)
VALUES ('Saulo@email.com', 'Saulo123', 1), ('Thiago@email.com', 'Thiago123', 1), ('Paulo@email.com', 'Paulo123', 1);

GO

-- Insere Informa��es do Tema
INSERT INTO Tema (NomeTema)
VALUES ('Gest�o'), ('HQ'), ('Medicina'), ('Jogo');

GO
-- Insere Informa��es do Projeto
INSERT INTO Projeto (NomeProjeto, Descricao, IdTema)
VALUES ('Eplayer', 'Site para o publico gamer', 4), ('SpMedGroup', 'Site de Consultas Medicas',3);

