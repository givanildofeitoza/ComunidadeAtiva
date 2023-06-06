using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoBeneficoSocialMorador
    {
        public Task<BeneficosMoradorDTO> ObterBeneficioMoradorID(int Id);
        public Task<IEnumerable<BeneficosMoradorDTO>> ObterBeneficioMoradorTodos(int take, int skip);
        public Task CadastrarBeneficioMorador(BeneficosMoradorDTO beneficoDTO);
        public Task AlterarBeneficioMorador(BeneficosMoradorDTO beneficoDTO);
        public Task DeletarBeneficioMorador(BeneficosMoradorDTO beneficoDTO);
    }
}
