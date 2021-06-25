using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_roman_webApi.Domains;
using senai_roman_webApi.Interfaces;
using senai_roman_webApi.Repositories;
using senai_roman_webApi.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_roman_webApi.Controllers
{
    /// <summary>
    /// Controle responsável pelos endpoints referentes ao login
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Objeto _usuarioRepository vai receber os métodos da interface
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            /// <summary>
            /// Instancia o objeto _usuarioRepository para que haja a referência aos métodos no repositório
            /// </summary
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Realiza o login do usuário, validando email e senha 
        /// </summary>
        /// <param name="login">objeto que possui o email e senha</param>
        /// <returns>um token com as informações do usuário</returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                // faz o método de login
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);

                // e se não for encontrado nenhum usuário com o e-mail e senha informados
                if (usuarioBuscado == null)
                {
                    return NotFound("E-mail ou senha inválidos!");
                }

                // se for, prossegue com a criação do token

                //diz quais os dados que serão fornecidos no token - payload
                var claims = new[]
                {
                    
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),

                    
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),

                    
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),

                };

                // chave de acesso 
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("roman-chave-autenticacao"));

                // credenciais - Header
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // Gera o token
                var token = new JwtSecurityToken(
                    issuer: "roman.webApi",                 // emissor do token
                    audience: "roman.webApi",               // destinatário do token
                    claims: claims,                        // dados definidos acima
                    expires: DateTime.Now.AddMinutes(30),  // tempo de expiração
                    signingCredentials: creds              // credenciais do token
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
