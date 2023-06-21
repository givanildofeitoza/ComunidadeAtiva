using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoAssociacao
    {
        public Task CadastrarAssociacao(AssociacaoDTO associacao);
        public Task AlterarAssociacao(AssociacaoDTO associacao);
        public Task DeletarAssociacao(AssociacaoDTO associacao);
        public Task<AssociacaoDTO> ObterAssociacaoPorId(int Id);        
        public Task<IEnumerable<AssociacaoDTO>> ObterAssociacaoTodos(int task, int skip);

    }
}
