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
    /// Controle responsável pelos endpoints referentes aos temas
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    [Authorize]
    public class TemasController : ControllerBase
    {
        /// <summary>
        /// Objeto _temaRepository vai receber os métodos da interface
        /// </summary>
        private ITemaRepository _temaRepository { get;set; }

        public TemasController()
        {
            /// <summary>
            /// Instancia o objeto _temaRepository para que haja a referência aos métodos no repositório
            /// </summary
            _temaRepository = new TemaRepository();
        }

        /// <summary>
        /// Busca um tema pelo seu nome
        /// </summary>
        /// <param name="nomeBuscado">nome do tema que será procurado</param>
        /// <returns>um tema encontrado</returns>

        [HttpGet("{nomeBuscado}")]
        
        public IActionResult Get(string nomeBuscado)
        {
            try
            {
                return Ok(_temaRepository.BuscarTema(nomeBuscado));
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }


        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">informações do novo tema que será cadastrado</param>
        

        [HttpPost]
        
        public IActionResult Post(Tema novoTema)
        {
            try
            {
                _temaRepository.Cadastrar(novoTema);

                return StatusCode(201);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        /// <summary>
        /// Apaga um tema através do seu id
        /// </summary>
        /// <param name="id">id do tema que será excluido</param>
      
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _temaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
