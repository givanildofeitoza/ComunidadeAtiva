using ComunidadeAtiva.Dominio.Comum;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.ObjetoValor
{
    public class Cpf:ObjetoValor
    {
        public Cpf()
        {
            
        }

        public Cpf(string cpf)
        {
            CPF = cpf;
        }

        public string CPF { get;  set; }

        public void Validar(ICapturarNotificacao notificacao)
        {
            CPF = Comuns.LimparString(new string[] { ".", "-","/" }, CPF);
            
            notificacao.LimparErros();
            
            if (CPF.Length != 11)
                notificacao.AddNotificacao("CPF deve conter 11 caracteres!");

            if (!CPF.All(char.IsDigit))
                notificacao.AddNotificacao("Para o CPF são aceitos apenas números!");
            
        }
    }
}
