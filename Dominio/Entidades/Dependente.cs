using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Dependente : Entidade
    {
        public int IdMoradorMaster { get; set; }
        public int IdMoradorDependente { get; set; }
        public string Ativo { get; set; }
    }
}
