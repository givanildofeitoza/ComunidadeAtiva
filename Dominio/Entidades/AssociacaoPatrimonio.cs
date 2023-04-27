using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class AssociacaoPatrimonio : Entidade
    {
        public string DescricaoPatrimonio { get; set; }
        public int Tipo { get; set; }
        public decimal ValorEstimado { get; set; }
        public DateTime DataAquisicao { get; set; }
    }
}
