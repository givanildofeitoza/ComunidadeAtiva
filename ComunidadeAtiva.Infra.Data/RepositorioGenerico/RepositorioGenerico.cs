using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ComunidadeAtiva.Infra.Data.RepositorioGenerico
{
        
    public class RepositorioGenerico<T> : IrepositorioGenerico<T> where T :Entidade
    {
        protected readonly DbContext _BancoDados;
        protected readonly DbSet<T> _Entidade;
        public RepositorioGenerico(DbContext BancoDados)
        {
            _BancoDados = BancoDados;
            _Entidade = _BancoDados.Set<T>();
        }
        
        public async Task Alterar(T ModelParametro)
        {
            if (ModelParametro.id != 0)
            {
                _Entidade.Update(ModelParametro);
                _BancoDados.SaveChangesAsync();
            }                
            
        }

        public async Task Cadastrar(T ModelParametro)
        {

            if (ModelParametro != null)
            {
                _Entidade.Add(ModelParametro);
                _BancoDados.SaveChangesAsync();
            }
            
        }

        public async Task Deletar(T ModelParametro)
        {
            if (ModelParametro.id != 0)
            {
                _Entidade.Remove(ModelParametro);
                _BancoDados.SaveChangesAsync();
            }
        }

        public async Task<T> ObterPorId(int id)
        {
            return await _Entidade.Where(x=>x.id==id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ObterTodos(int take, int skip)
        {            
            return await _Entidade.Take(take).Skip(skip).ToListAsync();
        }
    }
}
