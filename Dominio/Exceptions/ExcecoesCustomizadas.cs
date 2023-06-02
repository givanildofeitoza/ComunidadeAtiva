using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Exceptions
{
    public class ExcecoesCustomizadas : Exception
    {
        public ExcecoesCustomizadas(string mensagem)
            : base(mensagem) { }
        
    }
}
