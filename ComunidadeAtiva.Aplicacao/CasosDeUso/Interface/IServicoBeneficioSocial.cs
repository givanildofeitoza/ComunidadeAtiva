using ComunidadeAtiva.Aplicacao.DTO;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoBeneficioSocial
    {
        public Task<BeneficiosDTO> ObterBeneficioID(int Id);
        public Task<IEnumerable<BeneficiosDTO>> ObterBeneficioTodos(int take, int skip);
        public Task CadastrarBeneficio(BeneficiosDTO beneficoDTO);
        public Task AlterarBeneficio(BeneficiosDTO beneficoDTO);
        public Task DeletarBeneficio(BeneficiosDTO beneficoDTO);
    }
}
