using ComunidadeAtiva.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoRua
    {
        public Task CadastrarRua(RuaDTO ruaDTO);

        public Task AlterarRua(RuaDTO ruaDTO);

        public Task ApagarRua(RuaDTO ruaDTO);        

        public Task<RuaDTO> ObterRuaPorId(int Id);

        public Task<IEnumerable<RuaDTO>> ObterRuaTodas(int take, int skip);
        
    }
}
