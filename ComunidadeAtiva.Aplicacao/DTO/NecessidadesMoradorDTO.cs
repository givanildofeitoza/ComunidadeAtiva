using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class NecessidadesMoradorDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int MoradorId { get; set; }
        [Required]
        public int NecessidadeId { get; set; }
        public string? Ativo { get; set; }
     
        [Required]
        [StringLength(30,ErrorMessage ="Nome muito extenso!")]
        public string DescricaoNecessidade { get; set; }
    }
}
