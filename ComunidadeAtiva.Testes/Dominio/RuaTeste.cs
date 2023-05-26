using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Testes.Dominio
{
    [TestClass]
    public class RuaTeste
    {
        [TestMethod]
        public void GerarErroSeNomeVazio()
        {
            CapturarNotificacao notificacao = new CapturarNotificacao();
            Rua ruaTeste = new Rua("", "Nome2 teste", "S", "S", "S", "S", "S", "Agente teste");
            ruaTeste.setCep("56.506.660");
            Assert.ThrowsException<Exception>(()=> ruaTeste.IsValid(notificacao));
            
            /*foreach(var message in notificacao.ObterErros())
            {
                Assert.IsNotNull(message)
            }*/

            //Assert.Equals(notificacao.)
        }
    }
}
