using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComunidadeAtiva.Api.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class SecurityIdentityController : MainController
    {
       private readonly IServiceSegurancaIdentity _ServiceSegurancaIdentity;

        public SecurityIdentityController(IServiceSegurancaIdentity serviceSegurancaIdentity)
        {
            _ServiceSegurancaIdentity = serviceSegurancaIdentity;
        }
        [HttpPost("registrar-novo-usuario")]
        public async Task<ActionResult> RegistrarUsuario([FromBody]CorpoDirigenteAssociacaoDTO usuario)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _ServiceSegurancaIdentity.CriarUsuario(usuario);
                return Ok();
            }catch(ExcecoesCustomizadas ex) {
                return BadRequest(ex.Message); 
            }
             
        }
        [HttpPost("login-usuario")]
        public async Task<ActionResult> LoginUsuario([FromBody] LoginDTO usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _ServiceSegurancaIdentity.FazerLoginWebApi(usuario);
                return Ok(usuario);
            }
            catch (ExcecoesCustomizadas ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
