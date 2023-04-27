using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class AssociacaoEvento : Entidade
    {
        public string DescricaoEvento { get; set; }
        public string MoradorSolicitante { get; set; }
        public int AnoEvento { get; set; }
        public int MesEvento { get; set; }
        public int DelegadoAssociacao { get; set; }
        public int NumeroParticipanteEstimado { get; set; }
        public decimal CustoEstimado { get; set; }
    }
}
