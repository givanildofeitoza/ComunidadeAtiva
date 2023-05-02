using ComunidadeAtiva.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class MoradorBeneficioSocial:Entidade
    {
        public int MoradorId { get; set; }
        public int BeneficioSocialId { get; set; }
        public string Ativo { get; set; }
        public Decimal Valor { get; set; }

    }
}
