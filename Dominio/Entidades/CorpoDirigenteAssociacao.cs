using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class CorpoDirigenteAssociacao:Entidade
    {
        public int IdAssociacao { get; set; }
        public int IdCargo { get; set; }
        public string Nome { get; set; }
        public string? Apelido { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Ativo { get; set; }

    }
}
