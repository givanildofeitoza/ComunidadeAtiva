using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface Imorador
    {
        public void CadastrarMorador(Morador m);
        public void AlterarMorador(Morador m);
        public IEnumerable<Morador> ObterTodosMorador(int t, int s);
        public Morador ObterMoradorId(int id);
    }
}
