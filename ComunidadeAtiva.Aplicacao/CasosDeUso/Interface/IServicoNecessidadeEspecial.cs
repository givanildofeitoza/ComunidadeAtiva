using ComunidadeAtiva.Aplicacao.DTO;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoNecessidadeEspecial
    {
        public Task<NecessidadesDTO> ObterNecessidadeID(int Id);
        public Task<IEnumerable<NecessidadesDTO>> ObterNecessidadeTodos(int take, int skip);
        public Task CadastrarNecessidade(NecessidadesDTO necessidadeDTO);
        public Task AlterarNecessidade(NecessidadesDTO necessidadeDTO);
        public Task DeletarNecessidade(NecessidadesDTO necessidadeDTO);
    }
}
