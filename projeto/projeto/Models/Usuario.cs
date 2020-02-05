using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projeto.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Nome é Obrigatorio")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }

        public int Idade { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        
    }
}