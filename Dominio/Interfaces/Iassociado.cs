using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IassociadoService
    {
        public void CadastrarAssociado(Associado a);
        public void AlterarAssociado(Associado a);
        public IEnumerable<Associado> ObterTodosAssociado(int t, int s);
        public Associado ObterAssociadoId(int id);
    }
}
