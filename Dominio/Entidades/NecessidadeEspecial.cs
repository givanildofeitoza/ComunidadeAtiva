using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class NecessidadeEspecial : Entidade
    {
        public NecessidadeEspecial() { 
        
        }
        public NecessidadeEspecial(string descricaoNecessidadeEspecial, string permanete, string necessitaRemedioControlado)
        {
            DescricaoNecessidadeEspecial = descricaoNecessidadeEspecial;
            Permanete = permanete;
            NecessitaRemedioControlado = necessitaRemedioControlado;
        }

        public string DescricaoNecessidadeEspecial { get; set; }
        public string Permanete { get; set; }
        public string NecessitaRemedioControlado { get; set; }

        public void Validar(ICapturarNotificacao notificacao)
        {
            notificacao.LimparErros();

           if (string.IsNullOrEmpty(DescricaoNecessidadeEspecial))
             notificacao.AddNotificacao("Descrição não pode ser vazia!");

            if (string.IsNullOrEmpty(Permanete))
                notificacao.AddNotificacao("Informe se a necessidade é Permanete S/N");

            if (string.IsNullOrEmpty(NecessitaRemedioControlado))
                notificacao.AddNotificacao("Informe se necessita de medicamento S/N");

        }


    }
}
