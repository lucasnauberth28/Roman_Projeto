using senai_roman_webApi.Contexts;
using senai_roman_webApi.Domains;
using senai_roman_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
      
        RomanContext ctx = new RomanContext();


        /// <summary>
        /// Lista os tipos de usuários
        /// </summary>
        /// <returns>uma lista de tipos de usuários</returns>
        
        public List<TipoUsuario> ListarTipos()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
