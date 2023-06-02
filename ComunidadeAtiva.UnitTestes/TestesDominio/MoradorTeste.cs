using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.Dominio.ObjetoValor;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.UnitTestes.TestesDominio
{
    public class MoradorTeste
    {
        [Fact]
        public void RetornarErroSeNomeVazio()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("",DateTime.Now,"10","6857008","Ativo","Solteiro");           
            moradorTeste.SetCpf ("00568446785");
            Assert.Throws<ExcecoesCustomizadas>(() => moradorTeste.Validar(notificacao));

        }
        [Fact]
        public void RetornarSucessoSeNomeInformado()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("Morador Teste", DateTime.Now, "10", "6857008", "Ativo", "Solteiro");
            moradorTeste.SetCpf("00568446785");
            Rua ruaTeste = new Rua("Nome 01", "Nome 02", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            ruaTeste.id = 1;

            moradorTeste.SetCpf("07389445210");
            moradorTeste.SetRua(1);
            Assert.True(moradorTeste.Validar(notificacao));

        }
        [Fact]
        public void RetornarErroSeCPFInvalido()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("Morador Teste", DateTime.Now, "10", "6857008", "Ativo", "Solteiro");
            moradorTeste.SetCpf("sdd255");
            Assert.Throws<ExcecoesCustomizadas>(() => moradorTeste.Validar(notificacao));

        }
        [Fact]
        public void RetornarSucessoSeCPFCorreto()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("Morador Teste", DateTime.Now, "10", "6857008", "Ativo", "Solteiro");
            Rua ruaTeste = new Rua("Nome 01", "Nome 02", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            ruaTeste.id = 1;

            moradorTeste.SetCpf("07389445210");
            moradorTeste.SetRua(1);
            Assert.True(moradorTeste.Validar(notificacao));

        }
        [Fact]
        public void RetornarErroSeNaoMandarRua()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("Morador Teste", DateTime.Now,  "10", "6857008", "Ativo", "Solteiro");
            moradorTeste.SetCpf("sdd255");
            Assert.Throws<ExcecoesCustomizadas>(() => moradorTeste.Validar(notificacao));

        }
        [Fact]
        public void RetornarSucessoSeMandarRua()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Morador moradorTeste = new Morador("Morador Teste", DateTime.Now, "10", "6857008", "Ativo", "Solteiro");
            Rua ruaTeste = new Rua("Nome 01", "Nome 02", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.508.660");
            ruaTeste.id = 1;

            moradorTeste.SetCpf("07389445210");
            moradorTeste.SetRua(2);
            Assert.True(moradorTeste.Validar(notificacao));

        }
    }
}
