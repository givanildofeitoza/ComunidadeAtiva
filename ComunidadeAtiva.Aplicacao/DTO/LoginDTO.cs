using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TokenJwt { get; set; }
        public string Status { get; set; }
    }
}
