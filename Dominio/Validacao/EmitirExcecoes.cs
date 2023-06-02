using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Validacao
{
    public class EmitirExcecoes 
    {

        public static void EmitirExcecao(ICapturarNotificacao notificacao)
        {
            if (notificacao.QuantidadeErros() > 0)
                throw new ExcecoesCustomizadas(notificacao.ObterErros());
        }

      /*public static void EmitirExcecaoSeNull(object objeto,string mensagem)
        {
            if (objeto is null)
                throw new Exception(mensagem);
        }*/
    }
}
