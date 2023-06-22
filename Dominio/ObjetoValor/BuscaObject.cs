using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.ObjetoValor
{
    public class BuscaObject
    {
        public BuscaObject(string id, string nome, string cpf, string nomeBeneficio, string nomeNecessidade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            NomeBeneficio = nomeBeneficio;
            NomeNecessidade = nomeNecessidade;
            
        }

        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NomeBeneficio { get; set; }
        public string NomeNecessidade { get; set; }
        public string TextoBusca { get; set; }


    }
}
