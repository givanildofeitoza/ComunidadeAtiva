using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class BeneficioSocial : Entidade
    {
        public BeneficioSocial()
        {

        }
        public BeneficioSocial(string nomeBeneficioSocial, string descricaoBeneficioSocial)
        {
            NomeBeneficioSocial = nomeBeneficioSocial;
            DescricaoBeneficioSocial = descricaoBeneficioSocial;
        }

        public string NomeBeneficioSocial { get; set; }
        public string DescricaoBeneficioSocial { get; set; }
        public string Ativo { get; set; }

        public void Validar(ICapturarNotificacao notificacao)
        { 
            if (string.IsNullOrEmpty(NomeBeneficioSocial))
              notificacao.AddNotificacao("Nome do benefício não pode ser vazio!");
            
            if (string.IsNullOrEmpty(DescricaoBeneficioSocial))
              notificacao.AddNotificacao("Descrição do benefício não pode ser vazia!");            
        }
    }
}
