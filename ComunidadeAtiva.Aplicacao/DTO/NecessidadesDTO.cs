using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class NecessidadesDTO
    {
        public int Id { get; set; }
        [Required]
        public string DescricaoNecessidadeEspecial { get; set; }
        [Required]
        [StringLength(1,ErrorMessage ="Aceito apena 01 caractere")]
        public string Permanete { get; set; }
        [Required]
        public string NecessitaRemedioControlado { get; set; }
    }
}
