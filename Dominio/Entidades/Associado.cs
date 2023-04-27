using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Associado : Entidade
    {

        public string IdMorador { get; set; }
        public string NumeroItentificacao { get; set; }
        public string Ativo { get; set; }

    }
}
