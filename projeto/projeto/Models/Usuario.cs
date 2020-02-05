using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Nome é Obrigatorio")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage ="A Idade tem que esta entre 18 a 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um Email Valido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras de 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este Login ja Existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é Obrigatoria")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As Senhas não são iguais!")]
        public string ConfirmarSenha { get; set; }
        
    }
}