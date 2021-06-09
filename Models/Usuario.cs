using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web;

namespace ProjetoApp.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres")]
        public string Observacao { get; set;}

        [Range(18, 70, ErrorMessage = "Insira a idade de 18 a 70 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O campo login é obrigatório")]
        [Remote("LoginUnico", "usuario", ErrorMessage = "Este Login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfSenha { get; set; }
    }
}