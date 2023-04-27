using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IruaService
    {
        public void CadastrarRua(Rua m);
        public void AlterarRua(Rua m);
        public IEnumerable<Rua> ObterTodosRua(int t, int s);
        public Rua ObterRuaId(int id);
    }
}
