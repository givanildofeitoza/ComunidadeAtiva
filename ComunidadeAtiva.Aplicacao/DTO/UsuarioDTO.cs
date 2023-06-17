using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        [Required(ErrorMessage ="E-mail é Obrigatório !")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é Obrigatória !")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirmação de senha é Obrigatória !")]
        public string ConfirmaSenha { get; set; }
        public string TokenJWT { get; set; }
        public string Erro { get; set; }
    }
}
