using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_roman_webApi.Interfaces;
using senai_roman_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Controllers
{
    /// <summary>
    /// Controle responsável pelos endpoints referentes aos tipos de usuários
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    [Authorize]
    public class TipoUsuariosController : ControllerBase
    {


        /// <summary>
        /// Objeto _tipoRepository vai receber os métodos da interface
        /// </summary>
        private ITipoUsuarioRepository _tipoRepository { get; set; }

        public TipoUsuariosController()
        {
            /// <summary>
            /// Instancia o objeto _tipoRepository para que haja a referência aos métodos no repositório
            /// </summary
            _tipoRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista os tipos de usuários
        /// </summary>
        /// <returns>uma lista de tipos de usuários</returns>

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoRepository.ListarTipos());
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
