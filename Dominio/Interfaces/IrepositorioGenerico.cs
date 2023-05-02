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
        public  Task<T> ObterPorId(int id);
        public  Task<IEnumerable<T>> ObterTodos(int take, int skip);
        public  Task Cadastrar(T morador);
        public  Task Alterar(T morador);
        public  Task Deletar(T morador);
       
     
    }
}
