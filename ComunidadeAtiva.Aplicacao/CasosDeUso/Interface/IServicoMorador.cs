using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Aplicacao.Repositorio;
using ComunidadeAtiva.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoMorador 
    {
        public Task CadastrarMorador(MoradorDTO m);

        public Task AlterarMorador(MoradorDTO m);

        public Task DeletarMorador(MoradorDTO m);
        
        public Task<MoradorDTO> ObterMoradorId(int Id);

        public Task<IEnumerable<MoradorDTO>> ObterMradorTodos(int skip, int take);
        public  Task<MoradorDTO> ObterMoradorRelacionalRuaId(int id);
        public  Task<IEnumerable<MoradorDTO>> ObterTodosRelacionalMorador(int t, int s);

    }
}
