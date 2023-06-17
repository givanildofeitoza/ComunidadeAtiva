using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ComunidadeAtiva.FormsUI.Classes
{
    public class ValidarNumeros
    {
        public static bool ValidarDecimal(string digito, string campo)
        {
            Regex regra = new Regex(@"[1234567890.]", RegexOptions.None);
            Regex regraPonto = new Regex(@"[.]", RegexOptions.None);
            
            if (regraPonto.IsMatch(campo) && digito == ".")
                return false;

            return regra.IsMatch(digito);

        }
    }
}
