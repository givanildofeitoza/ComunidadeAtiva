using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociacaoProgramaService
    {
        public void CadastrarAssociacaoPrograma(AssociacaoPrograma m);
        public void AlterarAssociacaoPrograma(AssociacaoPrograma m);
        public IEnumerable<AssociacaoPrograma> ObterTodosAssociacaoPrograma(int t, int s);
        public AssociacaoPrograma ObterAssociacaoProgramaId(int id);
    }
}
