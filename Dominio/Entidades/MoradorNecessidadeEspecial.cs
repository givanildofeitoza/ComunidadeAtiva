using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class MoradorNecessidadeEspecial : Entidade
    {
        public int MoradorId { get; set;}
        public int NecessidadeId { get; set;}
        public string? Ativo { get; set;}

        public void Validar(ICapturarNotificacao notificacao)
        {
            if (MoradorId == 0)
                notificacao.AddNotificacao("Id Morador não foi definido!");

            if (NecessidadeId == 0)
                notificacao.AddNotificacao("Id Necessidade não foi definido!");

        }


    }
}
