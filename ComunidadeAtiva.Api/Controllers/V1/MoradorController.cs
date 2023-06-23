using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ComunidadeAtiva.Api.Controllers
{
    [ApiController]
    [Route("api/V1/moradores/")]
    public class MoradorController : MainController
    {
        protected readonly IServicoMorador _ServicoMorador;
        protected readonly IServicoBeneficoSocialMorador _ServicoBeneficoSocialMorador;
        protected readonly IServicoNecessidadeMorador _ServicoNecessidadeMorador;

        public MoradorController(IServicoMorador servicoMorador,
            IServicoBeneficoSocialMorador servicoBeneficoSocialMorador, 
            IServicoNecessidadeMorador servicoNecessidadeMorador)
        {
            _ServicoMorador = servicoMorador;
            _ServicoBeneficoSocialMorador = servicoBeneficoSocialMorador;
            _ServicoNecessidadeMorador = servicoNecessidadeMorador;
        }

        [HttpGet("GetAll/{Take}/{Skip}")]
        public async Task<ActionResult<IEnumerable<MoradorDTO>>> GetAllMoradores(int Take, int Skip)
        {
            var Moradores = await _ServicoMorador.ObterMradorTodos(Take, Skip);
           
            return Ok(Moradores); 
        }
        [HttpGet("GetMoradoresById/{Id}")]
        public async Task<ActionResult<MoradorDTO>> GetMoradoresById(int Id)
        {
            var Moradores = await _ServicoMorador.ObterMoradorRelacionalRuaId(Id);

            return Ok(Moradores);
        }

    }

}