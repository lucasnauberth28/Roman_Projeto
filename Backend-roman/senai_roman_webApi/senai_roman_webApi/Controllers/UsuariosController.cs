using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_roman_webApi.Domains;
using senai_roman_webApi.Interfaces;
using senai_roman_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.Controllers
{
    /// <summary>
    /// Controle responsável pelos endpoints referentes aos usuários
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    [Authorize]
    public class UsuariosController : ControllerBase
    {

        /// <summary>
        /// Objeto _usuarioRepository vai receber os métodos da interface
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuariosController()
        {
            /// <summary>
            /// Instancia o objeto _usuarioRepository para que haja a referência aos métodos no repositório
            /// </summary
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">objeto com as informações do novo usuaário que será cadastrado</param>

        [HttpPost]

        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);

                return StatusCode(201);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cria uma lista de usuários
        /// </summary>
        /// <returns>uma lista de usuários</returns>

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.ListaUsuario());
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        /// <summary>
        /// Deleta um usuário através do seu id
        /// </summary>
        /// <param name="id">id do usuário que será deletado</param>


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _usuarioRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
