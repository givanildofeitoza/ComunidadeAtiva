using ComunidadeAtiva.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoNecessidadeMorador
    {
        public Task<NecessidadesMoradorDTO> ObterNecessidadeMoradorId(int Id);
        public Task<IEnumerable<NecessidadesMoradorDTO>> ObterNecessidadeMoradorTodos(int take, int skip);
        public Task CadastrarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto);
        public Task AlterarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto);
        public Task DeletarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto);
    }
}
