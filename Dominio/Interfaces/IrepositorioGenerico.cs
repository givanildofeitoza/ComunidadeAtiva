using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IrepositorioGenerico<T> 
    {
        public T ObterPorId(int id);
        public IEnumerable<T> ObterTodos(int take, int skip);
        public void Cadastrar(T morador);
        public void Alterar(T morador);
        public void Deletar(T morador);
       
     
    }
}
