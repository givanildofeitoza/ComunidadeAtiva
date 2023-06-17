using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class BeneficiosDTO
    {
        public int Id { get; set; }
        [Required]
        public string NomeBeneficioSocial { get; set; }
        [Required]
        public string DescricaoBeneficioSocial { get; set; }
        public string Ativo { get; set; }
    }
}
