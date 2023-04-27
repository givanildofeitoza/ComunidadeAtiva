using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class AssociacaoCargo : Entidade
    {
        public string DescricaoCargo { get; set; }
        public int NivelAcesso { get; set; }
        
    }
}
