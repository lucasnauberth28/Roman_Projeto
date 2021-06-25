using Microsoft.EntityFrameworkCore;
using senai_roman_webApi.Contexts;
using senai_roman_webApi.Domains;
using senai_roman_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        RomanContext ctx = new RomanContext();

        /// <summary>
        /// Busca um projeto pelo nome
        /// </summary>
        /// <param name="nomeBuscado">nome do projeto que será buscado</param>
        /// <returns>o nome de projeto, caso exista</returns>

        public Projeto BuscarPorNome(string nomeBuscado)
        {
            return ctx.Projetos
                .Include(e => e.IdTemaNavigation)
                .FirstOrDefault(e => e.NomeProjeto == nomeBuscado);
        }

        /// <summary>
        /// Cadastra um novo projeto
        /// </summary>
        /// <param name="novoProjeto">informações do novo projeto que será cadastrado</param>

        public void Cadastrar(Projeto novoProjeto)
        {
            ctx.Projetos.Add(novoProjeto);

            ctx.SaveChanges();
        }


        /// <summary>
        /// Apaga um projeto através do seu id
        /// </summary>
        /// <param name="id">id do projeto que será excluido</param>
        
        public void Deletar(int id)
        {
            Projeto projetoBuscado = ctx.Projetos.Find(id);

            ctx.Projetos.Remove(projetoBuscado);

            ctx.SaveChanges();
        }
    }
}
