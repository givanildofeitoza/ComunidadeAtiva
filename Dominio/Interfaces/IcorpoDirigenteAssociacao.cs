using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IcorpoDirigenteAssociacaoService
    {
        public void CadastrarCorpoDirigenteAssociacao(CorpoDirigenteAssociacao m);
        public void AlterarCorpoDirigenteAssociacao(CorpoDirigenteAssociacao m);
        public IEnumerable<CorpoDirigenteAssociacao> ObterTodosCorpoDirigenteAssociacao(int t, int s);
        public CorpoDirigenteAssociacao ObterCorpoDirigenteAssociacaoId(int id);
    }
}
