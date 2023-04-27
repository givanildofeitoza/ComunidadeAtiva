using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface InecessidadeEspecialService
    {
        public void CadastrarNecessidadeEspecial(NecessidadeEspecial m);
        public void AlterarNecessidadeEspecial(NecessidadeEspecial m);
        public IEnumerable<NecessidadeEspecial> ObterTodosNecessidadeEspecial(int t, int s);
        public NecessidadeEspecial ObterNecessidadeEspecialId(int id);
    }
}
