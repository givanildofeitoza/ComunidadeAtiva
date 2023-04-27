using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociacaoEventoService
    {
        public void CadastrarAssociacaoEvento(AssociacaoEvento m);
        public void AlterarAssociacaoEventoo(AssociacaoEvento m);
        public IEnumerable<AssociacaoEvento> ObterTodosAssociacaoEvento(int t, int s);
        public AssociacaoEvento ObterAssociacaoEventoId(int id);
    }
}
