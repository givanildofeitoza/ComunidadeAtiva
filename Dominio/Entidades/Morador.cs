using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.ObjetoValor;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Morador : Entidade
    {
        public Morador(string? nome, DateTime nascimento, string? numeroCasa, string? rg, string? situacao, string? estadoCivil)
        {
            Nome = nome;
            Nascimento = nascimento;
            NumeroCasa = numeroCasa;
            Rg = rg;
            Situacao = situacao;
            EstadoCivil = estadoCivil;
            
        }

        public string?  Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public int  RuaId { get; private set; }
        public string?  NumeroCasa { get; private set; }
        public Cpf  Cpf { get; private set; }
        public string?  Rg { get; private set; }
        public string? Situacao { get; private set; }
        public string?  EstadoCivil { get; private set; }
        public Rua rua { get; set; }

        public IEnumerable<MoradorNecessidadeEspecial> necessidadeEspecial { get; set; }
        public IEnumerable<MoradorBeneficioSocial>   moradorBeneficioSocial { get; set; }
        public IEnumerable<MoradorPrograma> programa { get; set; }

        public void SetRua(int ruaId)
        {
            RuaId = ruaId;
           
        }
        public void SetCpf(string c)
         => Cpf = new Cpf(c);
        
        public bool Validar(ICapturarNotificacao notificacao)
        {
            notificacao.LimparErros();

            if(Cpf is null)
              notificacao.AddNotificacao("CPF não pode ser vazio!");

            if (Nome == string.Empty)
                notificacao.AddNotificacao("Nome não pode ser vazio!");

            if (RuaId == 0)
                notificacao.AddNotificacao("É necessário informar a Rua!");

            EmitirExcecoes.EmitirExcecao(notificacao);


            return true;
        }

    }
}
