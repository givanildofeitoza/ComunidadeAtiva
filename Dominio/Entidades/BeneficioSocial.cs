using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class BeneficioSocial : Entidade
    {
        public string NomeBeneficioSocial { get; set; }
        public string DescricaoBeneficioSocial { get; set; }
        public string Ativo { get; set; }
    }
}
