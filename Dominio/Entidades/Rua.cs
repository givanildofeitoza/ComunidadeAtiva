using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Rua : Entidade
    {
        public string Nome1 { get; set; }
        
        public string Nome2 { get; set; }

        public string Cep { get; set; }

        public string Calcada { get; set; }
        
        public string Energia { get; set; }

        public string Agua { get; set; }

        public string Saneamento { get; set; }

        public string ColetaLixo { get; set; }

        public string AgenteSaudeResponsval { get; set; }

    }
}
