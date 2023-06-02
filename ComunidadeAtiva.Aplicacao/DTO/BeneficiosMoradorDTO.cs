using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class BeneficosMoradorDTO
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int MoradorId { get; set; }
        [Required]
        public int BeneficioSocialId { get; set; }
        public string? Ativo { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="Nome muito extenso!")]
        public string DescricaoBeneficio { get; set; }
        [Range(10,2)]
        public decimal Valor { get; set; }

      
    }
}
