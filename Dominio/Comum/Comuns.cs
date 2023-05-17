using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Comum
{
    public abstract class Comuns
    {
        public static string LimparString(string[] carateres,string textoAntigo)
        {            
            foreach (string car in carateres) 
                textoAntigo = textoAntigo.Replace(car, "");
         
            return textoAntigo; 
        }

    }
}
