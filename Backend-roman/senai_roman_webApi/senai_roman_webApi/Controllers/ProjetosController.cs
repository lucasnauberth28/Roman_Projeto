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
    /// Controle responsável pelos endpoints referentes aos projetos
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    [Authorize]
    public class ProjetosController : ControllerBase
    {
        /// <summary>
        /// Objeto _projetoRepository vai receber os métodos da interface
        /// </summary>
        private IProjetoRepository _projetoRepository { get; set; }

        public ProjetosController()
        {
            /// <summary>
            /// Instancia o objeto _projetoRepository para que haja a referência aos métodos no repositório
            /// </summary
            _projetoRepository = new ProjetoRepository();
        }

        /// <summary>
        /// Busca um projeto pelo nome
        /// </summary>
        /// <param name="nomeBuscado">nome do projeto que será buscado</param>
        /// <returns>o nome de projeto, caso exista</returns>

        
        [HttpGet("{nomeBuscado}")]

        public IActionResult Get(string nomeBuscado)
        {
            try
            {
                return Ok(_projetoRepository.BuscarPorNome(nomeBuscado));
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cadastra um novo projeto
        /// </summary>
        /// <param name="novoProjeto">informações do novo projeto que será cadastrado</param>

        [HttpPost]

        public IActionResult Post(Projeto novoProjeto)
        {
            try
            {
                _projetoRepository.Cadastrar(novoProjeto);

                return StatusCode(201);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        /// <summary>
        /// Apaga um projeto através do seu id
        /// </summary>
        /// <param name="id">id do projeto que será excluido</param>

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _projetoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
