using ComunidadeAtiva.Dominio.Entity;

namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociacaoService
    {
        public void CadastrarAssociacao(Associacao a);
        public void AlterarAssociacao(Associacao a);
        public IEnumerable<Associacao> ObterTodosAssociacao(int t, int s);
        public Associacao ObterAssociacaoId(int id);
    }
}
