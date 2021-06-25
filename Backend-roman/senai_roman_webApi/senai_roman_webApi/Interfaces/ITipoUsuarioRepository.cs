using senai_roman_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista os tipos de usuários
        /// </summary>
        /// <returns>uma lista de tipos de usuários</returns>
        List<TipoUsuario> ListarTipos(); 
    }
}
