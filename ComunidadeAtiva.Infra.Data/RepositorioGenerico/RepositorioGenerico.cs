using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ComunidadeAtiva.Infra.Data.RepositorioGenerico
{
        
    public class RepositorioGenerico<T> : IrepositorioGenerico<T> where T :Entidade
    {
        private readonly DbContext _BancoDados;
        private readonly DbSet<T> _EntidadeGenerica;
        public RepositorioGenerico(DbContext BancoDados)
        {
            _BancoDados = BancoDados;
            _EntidadeGenerica = _BancoDados.Set<T>();
        }
        
        public void Alterar(T ModelParametro)
        {
            if (ModelParametro.id != 0)
            {
                _EntidadeGenerica.Update(ModelParametro);
                _BancoDados.SaveChanges();
            }                
            
        }

        public void Cadastrar(T ModelParametro)
        {

            if (ModelParametro != null)
            {
                _EntidadeGenerica.Add(ModelParametro);
                _BancoDados.SaveChanges();
            }
            
        }

        public void Deletar(T ModelParametro)
        {
            if (ModelParametro.id != 0)
            {
                _EntidadeGenerica.Remove(ModelParametro);
                _BancoDados.SaveChanges();
            }
        }

        public T ObterPorId(int id)
        {
            return _EntidadeGenerica.Where(x=>x.id==id).FirstOrDefault();
        }

        public IEnumerable<T> ObterTodos(int take, int skip)
        {
            return _EntidadeGenerica.Take(take).Skip(skip).ToList();
        }
    }
}
