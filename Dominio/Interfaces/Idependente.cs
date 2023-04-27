using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IdependenteService
    {
        public void CadastrarDependente(Dependente m);
        public void AlterarDependente(Dependente m);
        public IEnumerable<Dependente> ObterTodosDependente(int t, int s);
        public Dependente ObterDependenteId(int id);
    }
}
