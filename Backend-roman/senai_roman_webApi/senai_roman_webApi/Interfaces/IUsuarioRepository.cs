using senai_roman_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Cria uma lista de usuários
        /// </summary>
        /// <returns>uma lista de usuários</returns>
        List<Usuario> ListaUsuario();

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">objeto com as informações do novo usuaário que será cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Deleta um usuário através do seu id
        /// </summary>
        /// <param name="id">id do usuário que será deletado</param>
        void Deletar(int id);


        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi buscado</returns>
        Usuario Login(string email, string senha);
    }
}
