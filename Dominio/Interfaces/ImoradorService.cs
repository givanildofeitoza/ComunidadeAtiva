using ComunidadeAtiva.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorService : IrepositorioGenerico<Morador>
    {
        public Task<IEnumerable<Morador>> ObterTodosRelacionalMorador(int t, int s);
        public Task<Morador> ObterMoradorRelacionalRuaId(int id);

    }
}
