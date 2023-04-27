using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Infra.Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;


namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Servicos
{
    public class RuaService : RepositorioGenerico<Rua>,Irua
    {
        public RuaService(DbContext BancoDados) : base(BancoDados)
        {
        }

        public void CadastrarRua(Rua m)
           => Cadastrar(m);
        
        public void AlterarRua(Rua m)
           => Alterar(m);
        
        public Rua ObterRuaId(int id)
           => ObterPorId(id);
        
        public IEnumerable<Rua> ObterTodosRua(int t, int s)
           => ObterTodos(t, s);   

   

       
    }
}
