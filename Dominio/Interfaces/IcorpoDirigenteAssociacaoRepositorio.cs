using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IcorpoDirigenteAssociacaoRepositorio : IrepositorioGenerico<CorpoDirigenteAssociacao>
    {
        public Task<CorpoDirigenteAssociacao> ObterDirigenteRelacional(string Id);

    }
    
}
