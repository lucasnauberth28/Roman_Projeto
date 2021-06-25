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
    public class TemaRepository : ITemaRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        RomanContext ctx = new RomanContext();

        /// <summary>
        /// Busca um tema pelo seu nome
        /// </summary>
        /// <param name="nomeBuscado">nome do tema que será procurado</param>
        /// <returns>um tema encontrado</returns>
        public Tema BuscarTema(string nomeBuscado)
        {
            return ctx.Temas
                .Include(e => e.Projetos)
                .FirstOrDefault(e => e.NomeTema == nomeBuscado);
        }

        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">informações do novo tema que será cadastrado</param>
        public void Cadastrar(Tema novoTema)
        {
            ctx.Temas.Add(novoTema);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Apaga um tema através do seu id
        /// </summary>
        /// <param name="id">id do tema que será excluido</param>
        public void Deletar(int id)
        {
            Tema temaBuscado = ctx.Temas.Find(id);

            ctx.Temas.Remove(temaBuscado);

            ctx.SaveChanges();
        }
    }
}
