using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ICapturarNotificacao
    {
        public void AddNotificacao(string erros);
        public int QuantidadeErros();
        public string ObterErros();
        public void LimparErros();

    }
}
