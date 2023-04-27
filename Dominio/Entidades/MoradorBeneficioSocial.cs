using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class MoradorBeneficioSocial:Entidade
    {
        public int IdMorador { get; set; }
        public int IdBeneficioSocial { get; set; }
        public string Ativo { get; set; }

        public Decimal Valor { get; set; }
    }
}
