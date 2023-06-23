using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorNecessidadeEspecialRepositorio : IrepositorioGenerico<MoradorNecessidadeEspecial>
    {
        public Task DeletarNecessidadePorIdNecessidade(int Id);
    }
}
