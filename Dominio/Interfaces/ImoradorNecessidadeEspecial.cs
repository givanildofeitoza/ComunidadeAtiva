using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorNecessidadeEspecialService
    {
        public void CadastrarMoradorNecessidadeEspecial(MoradorNecessidadeEspecial m);
        public void AlterarMoradorNecessidadeEspecial(MoradorNecessidadeEspecial m);
        public IEnumerable<MoradorNecessidadeEspecial> ObterTodosMorador(int t, int s);
        public MoradorNecessidadeEspecial ObterMoradorNecessidadeEspecialId(int id);
    }
}
