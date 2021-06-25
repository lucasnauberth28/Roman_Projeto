using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webApi.ViewModels
{
    /// <summary>
    /// Classe responsável por definir como vai ser o modelo do login
    /// </summary>
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
