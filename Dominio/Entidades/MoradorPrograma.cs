using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class MoradorPrograma:Entidade
    {
        public int IdMorador { get; set; }
        public int IdPrograma { get; set; }
        public string Ativo { get; set; }

    }
}
