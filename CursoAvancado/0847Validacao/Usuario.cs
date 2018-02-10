using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0847Validacao.Idiomas;

namespace _0847Validacao
{
    class Usuario
    {
        [Required(ErrorMessage = "Campo obrigatório."), MinhaValidacao(ErrorMessage = "O campo {0} precisa ter mais de 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO"), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(12, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
