using ComunidadeAtiva.Dominio.Entity;

namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociacaoCargoService
    {
        public void CadastrarAssociacaoCargo(AssociacaoCargo m);
        public void AlterarAssociacaoCargo(AssociacaoCargo m);
        public IEnumerable<AssociacaoCargo> ObterTodosAssociacaoCargo(int t, int s);
        public AssociacaoCargo ObterAssociacaoCargoId(int id);
    }
}
