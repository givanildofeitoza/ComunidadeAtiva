using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorProgramaService
    {
        public void CadastrarMoradorPrograma(MoradorPrograma m);
        public void AlterarMoradorPrograma(MoradorPrograma m);
        public IEnumerable<MoradorPrograma> ObterTodosMoradorProgramar(int t, int s);
        public MoradorPrograma ObterMoradorProgramaId(int id);
    }
}
