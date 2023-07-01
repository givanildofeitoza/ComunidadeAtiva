using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComunidadeAtiva.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/V1/[controller]/")]   
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
        [HttpGet("obter-todos-moradores/{Take}/{Skip}")]
        public async Task<ActionResult<IEnumerable<MoradorDTO>>> GetAllMoradores(int Take, int Skip)
        {
            var Moradores = await _ServicoMorador.ObterMradorTodos(Take, Skip);           
            return Ok(Moradores); 
        }
   
        [HttpGet("obter-moradores-por-id/{Id}")]
        public async Task<ActionResult<MoradorDTO>> GetMoradoresById(int Id)
        {
            var Moradores = await _ServicoMorador.ObterMoradorRelacionalRuaId(Id);
            return Ok(Moradores);
        }
        [HttpDelete("excluir-morador/{Id}")]
        public async Task<ActionResult> DeleteMorador(int Id)
        {
            var Morador = await _ServicoMorador.ObterMoradorId(Id);
            try {
                await _ServicoMorador.DeletarMorador(Morador);
                return Ok();
            }
            catch(ExcecoesCustomizadas ex) {
                return BadRequest(ex.Message);
            }            
            
        }
        [HttpPut("atualizar-Moradores/")]
        public async Task<ActionResult> UpdateMorador(MoradorCadastroDto morador)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            MoradorDTO moradorDTO = new MoradorDTO()
            {
                Cpf = morador.Cpf,
                Nome = morador.Nome,
                Nascimento = morador.Nascimento,
                NumeroCasa = morador.NumeroCasa,
                Rg = morador.Rg,
                RuaId = morador.RuaId,
                Situacao = morador.Situacao,
                EstadoCivil = morador.EstadoCivil,
                id = morador.id
            };
            
            try
            {
                await _ServicoMorador.AlterarMorador(moradorDTO);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }
        
        }
        [HttpPost("criar-morador/")]
        public async Task<ActionResult> AddMorador([FromBody] MoradorCadastroDto morador)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            MoradorDTO moradorDTO = new MoradorDTO()
            {   
                Cpf = morador.Cpf,
                Nome = morador.Nome,
                Nascimento= morador.Nascimento,
                NumeroCasa = morador.NumeroCasa,
                Rg = morador.Rg,
                RuaId = morador.RuaId,
                Situacao = morador.Situacao,
                EstadoCivil = morador.EstadoCivil,
                id = morador.id
            };
            try
            {
                await _ServicoMorador.CadastrarMorador(moradorDTO);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }            
          
        }
        [HttpPost("adicionar-beneficio-morador/")]
        public async Task<ActionResult> AddMoradorBeneficio([FromBody] BeneficosMoradorDTO beneficio)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _ServicoBeneficoSocialMorador.CadastrarBeneficioMorador(beneficio);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }           
         
        }
        [HttpDelete("excluir-beneficio-morador/")]
        public async Task<ActionResult> ExcluirMoradorBeneficio([FromBody] BeneficosMoradorDTO beneficio)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _ServicoBeneficoSocialMorador.DeletarBeneficioMorador(beneficio);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("excluir-necessidade-morador/")]
        public async Task<ActionResult> ExcluirMoradorNecessidade([FromBody] NecessidadesMoradorDTO necessidade)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _ServicoNecessidadeMorador.DeletarNecessidadeMorador(necessidade);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost("cadastrar-necessidade-morador/")]
        public async Task<ActionResult> AdicionarMoradorNecessidade([FromBody] NecessidadesMoradorDTO necessidade)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _ServicoNecessidadeMorador.CadastrarNecessidadeMorador(necessidade);
                return Ok();
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }

}