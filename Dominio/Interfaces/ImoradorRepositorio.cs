using ComunidadeAtiva.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunidadeAtiva.Dominio.ObjetoValor;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorRepositorio : IrepositorioGenerico<Morador>
    {
        public Task<IEnumerable<Morador>> ObterTodosRelacionalMorador(int t, int s, BuscaObject pMorador);
        public Task<Morador> ObterMoradorRelacionalRuaId(int id);

    }
}
