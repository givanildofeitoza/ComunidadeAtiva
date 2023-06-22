using ComunidadeAtiva.Dominio.Comum;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Associacao:Entidade
    {
        public Associacao(string razaoSocial,
        string nomeFantasia,
        string cnpj, string? telefone,
        string? celular,
        string? email,
        string? site,
        string endereco,
        string bairro,
        string cidade,
        string estado,
        string representante1,
        string representante2)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj =  cnpj;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Site = site;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Representante1 = representante1;
            Representante2 = representante2;
        }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set;}
        public string Representante1 { get; set; }
        public string Representante2 { get; set; }
        public int AnoPosse { get; set; }
        public int AnoFimMandato { get; set; }

        public void Validar(ICapturarNotificacao notificacao)
        {
            Cnpj = Comuns.LimparString(new string[] { ".", "-", "/" }, Cnpj);
            Telefone = Comuns.LimparString(new string[] { ".", "-", "/" }, Telefone);

            notificacao.LimparErros();
            if (string.IsNullOrEmpty(RazaoSocial)) {
                notificacao.AddNotificacao("Razão é obrigatória !");            
            }
            if (string.IsNullOrEmpty(NomeFantasia))
            {
                notificacao.AddNotificacao("Nome Fantasia é obrigatório !");
            }
            if (string.IsNullOrEmpty(Representante1))
            {
                notificacao.AddNotificacao("Informe o nome do Presidente !");
            }
            if (string.IsNullOrEmpty(Representante2))
            {
                notificacao.AddNotificacao("Informe o nome do vice-presidente !");
            }
            if (string.IsNullOrEmpty(Cnpj))
            {
                notificacao.AddNotificacao("CNPJ é obrigatório");
            }
            if (string.IsNullOrEmpty(Telefone))
            {
                notificacao.AddNotificacao("Telefone é obrigatório !");
            }
            if (string.IsNullOrEmpty(Cidade))
            {
                notificacao.AddNotificacao("Cidade é obrigatória !");
            }
            if (string.IsNullOrEmpty(Estado))
            {
                notificacao.AddNotificacao("Estado é obrigatório !");
            }
        }

    }
}
