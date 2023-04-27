using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class AssociacaoPrograma : Entidade
    {
        public string NomePrograma { get; set; }
        public string DescricaoPrograma { get; set; }
        public string Ativo { get; set; }

    }
}
