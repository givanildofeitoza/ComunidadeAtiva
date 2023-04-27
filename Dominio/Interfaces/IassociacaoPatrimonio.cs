using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociacaoPatrimonioService
    {
        public void CadastrarAssociacaoPatrimonio(AssociacaoPatrimonio m);
        public void AlterarAssociacaoPatrimonio(AssociacaoPatrimonio m);
        public IEnumerable<AssociacaoPatrimonio> ObterTodosAssociacaoPatrimonio(int t, int s);
        public AssociacaoPatrimonio ObterAssociacaoPatrimonioId(int id);
    }
}
