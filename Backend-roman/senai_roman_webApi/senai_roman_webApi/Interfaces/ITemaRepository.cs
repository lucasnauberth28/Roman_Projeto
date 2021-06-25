using senai_roman_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Interfaces
{
    interface ITemaRepository
    {
        /// <summary>
        /// Busca um tema pelo seu nome
        /// </summary>
        /// <param name="nomeBuscado">nome do tema que será procurado</param>
        /// <returns>um tema encontrado</returns>
        Tema BuscarTema(string nomeBuscado);

        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">informações do novo tema que será cadastrado</param>
        void Cadastrar(Tema novoTema);

        /// <summary>
        /// Apaga um tema através do seu id
        /// </summary>
        /// <param name="id">id do tema que será excluido</param>
        void Deletar(int id);
    }
}
