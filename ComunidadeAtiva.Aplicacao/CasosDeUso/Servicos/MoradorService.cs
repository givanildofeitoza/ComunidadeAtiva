using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Infra.Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;


namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Servicos
{
    public class MoradorService : RepositorioGenerico<Morador>,Imorador
    {
        public MoradorService(DbContext BancoDados) : base(BancoDados)
        {
        }

        public void CadastrarMorador(Morador m)
           => Cadastrar(m);
        
        public void AlterarMorador(Morador m)
           => Alterar(m);
        
        public Morador ObterMoradorId(int id)
           => ObterPorId(id);
        
        public IEnumerable<Morador> ObterTodosMorador(int t, int s)
           => ObterTodos(t, s);
    }
}
