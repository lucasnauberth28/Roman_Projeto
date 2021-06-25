using senai_roman_webApi.Contexts;
using senai_roman_webApi.Domains;
using senai_roman_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        RomanContext ctx = new RomanContext();

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">objeto com as informações do novo usuaário que será cadastrado</param>

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um usuário através do seu id
        /// </summary>
        /// <param name="id">id do usuário que será deletado</param>

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarioBuscado);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Cria uma lista de usuários
        /// </summary>
        /// <returns>uma lista de usuários</returns>

        public List<Usuario> ListaUsuario()
        {
            return ctx.Usuarios.ToList();
        }

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi buscado</returns>

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.Email == email && e.Senha == senha);
        }
    }
}
