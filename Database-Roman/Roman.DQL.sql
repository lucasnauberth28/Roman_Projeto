Use Roman

GO
Select  Email, Senha, NomeTipoUsuario
FROM Usuario INNER JOIN 
TipoUsuario ON Usuario.IdTipoUsuario = 
TipoUsuario.IdTipoUsuario

Select NomeProjeto, Descricao, NomeTema 
FROM Projeto INNER JOIN 
Tema ON Projeto.IdProjeto = 
Tema.IdTema