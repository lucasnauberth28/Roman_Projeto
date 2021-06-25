using senai_roman_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Interfaces
{
    interface IProjetoRepository
    {
        /// <summary>
        /// Busca um projeto pelo nome
        /// </summary>
        /// <param name="nomeBuscado">nome do projeto que será buscado</param>
        /// <returns>o nome de projeto, caso exista</returns>
        Projeto BuscarPorNome(string nomeBuscado);

        /// <summary>
        /// Cadastra um novo projeto
        /// </summary>
        /// <param name="novoProjeto">informações do novo projeto que será cadastrado</param>
        void Cadastrar(Projeto novoProjeto);

        /// <summary>
        /// Apaga um projeto através do seu id
        /// </summary>
        /// <param name="id">id do projeto que será excluido</param>
        void Deletar(int id);
    }
}
