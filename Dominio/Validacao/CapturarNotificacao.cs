using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Validacao
{
    public class CapturarNotificacao:ICapturarNotificacao
    {
        private List<string> Erros = new List<string>();

        public void LimparErros()
        => Erros.Clear();
        
        public void AddNotificacao(string erros)
        => Erros.Add(erros);
        
        public int QuantidadeErros()
         => Erros.Count;        

        public string ObterErros()
        {
            string messagens = null;
            Erros.ForEach(r => messagens += r.ToString()+"\r\n" );
            return messagens.ToString();
        }
    }
}
