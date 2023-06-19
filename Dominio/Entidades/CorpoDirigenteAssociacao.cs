using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
       
        public string UsuarioId { get; set; }

        public void Validar(ICapturarNotificacao notificacao)
        {
            if(string.IsNullOrEmpty(Nome))
            {
                notificacao.LimparErros();
                notificacao.AddNotificacao("Nome não pode ser vazio!");
            }
            if (string.IsNullOrEmpty(UsuarioId))
            {
                notificacao.LimparErros();
                notificacao.AddNotificacao("UsuarioId não pode ser vazio!");
            }
        }

    }
}
