using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class NecessidadeEspecial : Entidade
    {
        public string DescricaoNecessidadeEspecial { get; set; }
        public string Permanete { get; set; }
        public string NecessitaRemedioControlado { get; set; }


    }
}
