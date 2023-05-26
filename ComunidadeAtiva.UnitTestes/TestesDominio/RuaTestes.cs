using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Validacao;
using System.Security.Cryptography;

namespace ComunidadeAtiva.UnitTestes.TestesDominio
{
    public class RuaTestes
    {
        [Fact]
        public void RetornarErroSeNomeDoisVazio()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Nome 01", "", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            Assert.Throws<Exception>(() => ruaTeste.IsValid(notificacao));

        }
        [Fact]
        public void RetornarSucessoSeNomeDoisInformado()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Nome 01", "Nome 02", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            Assert.True(ruaTeste.IsValid(notificacao));

        }
        [Fact]
        public void RetornarErroSeNomeUmVazio()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("", "Nome2 teste", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            Assert.Throws<Exception>(() => ruaTeste.IsValid(notificacao));
           
        }
        [Fact]
        public void RetornarSucessoSeNomeUmInformado()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Rua teste 01", "Nome 02", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            Assert.True(ruaTeste.IsValid(notificacao));

        }
        [Fact]
        public void RetornarErroSeNaoSetarCepValido()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Nome 01 teste", "Nome2 teste", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("");
            Assert.Throws<Exception>(() => ruaTeste.IsValid(notificacao));
          
        }
        [Fact]
        public void RetornarSucessoSeSetarCepValido()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Nome 01 teste", "Nome2 teste", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            Assert.True(ruaTeste.IsValid(notificacao));

        }
        [Fact]
        public void RetornarErroSeCepNulo()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("Nome 01 teste", "Nome2 teste", "S", "S", "S", "S", "S", "Agente teste");
            Assert.Throws<Exception>(() => ruaTeste.IsValid(notificacao));

        }
    }
}