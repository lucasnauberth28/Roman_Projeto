use Roman

GO
-- Insere Informações do Tipo de Usuario
INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES ('Professor');

GO

-- Insere Informações do Usuario
INSERT INTO Usuario (Email, Senha, IdTipoUsuario)
VALUES ('Saulo@email.com', 'Saulo123', 1), ('Thiago@email.com', 'Thiago123', 1), ('Paulo@email.com', 'Paulo123', 1);

GO

-- Insere Informações do Tema
INSERT INTO Tema (NomeTema)
VALUES ('Gestão'), ('HQ'), ('Medicina'), ('Jogo');

GO
-- Insere Informações do Projeto
INSERT INTO Projeto (NomeProjeto, Descricao, IdTema)
VALUES ('Eplayer', 'Site para o publico gamer', 4), ('SpMedGroup', 'Site de Consultas Medicas',3);

