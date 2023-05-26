using ComunidadeAtiva.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class RuaDTO
    {
        [Required]
        public string Nome1 { get; set; }
        [Required]
        public string Nome2 { get; set; }
        [Required]
        public string Cep { get; private set; }

        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string Calcada { get; set; }
        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string Energia { get; set; }
        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string Agua { get; set; }
        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string Saneamento { get; set; }
        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string ColetaLixo { get; set; }
        [StringLength(1, ErrorMessage = "Texto maior que o esperado")]
        public string AgenteSaudeResponsval { get; set; }
    }
}
