using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ComunidadeAtiva.Dominio.Comum;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;

namespace ComunidadeAtiva.Dominio.ObjetoValor
{
    public class Cep : ObjetoValor
    {
        public Cep()
        {
        }

        public Cep(string cep)
        {
           CEP = cep;            
        }
        public string CEP { get; private set; }

        public void IsValid(ICapturarNotificacao notificacao)
        {
            CEP = Comuns.LimparString(new string[] {".","-"},CEP);

            if (CEP.Length != 8)
                notificacao.AddNotificacao("Número de carcteres deve ser igual a 8");
            
            if (!CEP.All(char.IsDigit))
                notificacao.AddNotificacao("Informe caracteres numéricos");
        }


    }
}
