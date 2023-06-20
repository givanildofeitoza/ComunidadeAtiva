using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServiceSegurancaIdentity : IServiceSegurancaIdentity
    {
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;
        private readonly ICapturarNotificacao _notificacao;
        private readonly ICorpoDirigenteAssociacao _CorpoDirigenteAssociacao;

        public ServiceSegurancaIdentity(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            ICapturarNotificacao notificacao,
            ICorpoDirigenteAssociacao CorpoDirigenteAssociacao)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
            _notificacao = notificacao;
            _CorpoDirigenteAssociacao = CorpoDirigenteAssociacao;
        }
        public Task CriarTokenJWT(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            throw new NotImplementedException();
        }
        public async Task CriarUsuario(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            _notificacao.LimparErros();

            if (dirigenteDto == null)
            {               
                _notificacao.AddNotificacao("Houve um erro ao tentar fazer o registro de usuário/membro !");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            if (string.IsNullOrEmpty(dirigenteDto.Nome))
            {               
                _notificacao.AddNotificacao("Informe o nome do usuário/membro !");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            var user = new IdentityUser
            {
                Email = dirigenteDto.Email,
                UserName = dirigenteDto.Email,
                EmailConfirmed = true               
            };
           
            var result = await _UserManager.CreateAsync(user, dirigenteDto.Senha);
            if (result.Succeeded)
            {
                user = await _UserManager.FindByEmailAsync(user.Email);
                dirigenteDto.UsuarioId = user.Id.ToString();
                await _CorpoDirigenteAssociacao.CadastrarDirigente(dirigenteDto);
            }
            else
            {
                _notificacao.LimparErros();
                foreach (var e in result.Errors)
                {
                    _notificacao.AddNotificacao(e.Description);
                    EmitirExcecoes.EmitirExcecao(_notificacao);                    
                }
            }
           
        }
        public async Task<string> FazerLoginForms(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {   
            var user = await _UserManager.FindByEmailAsync(dirigenteDto.Email);
            if(user == null)
            {
                _notificacao.LimparErros();
                _notificacao.AddNotificacao("Erro ao tentar entrar! Verifique usuário e senha!");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            var result = await _SignInManager.CheckPasswordSignInAsync(user, dirigenteDto.Senha, true);

            return user.Id;
        }
        public async Task<bool> FazerLoginWebApi(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
           
            var result = await _SignInManager.PasswordSignInAsync(dirigenteDto.Email, dirigenteDto.Senha, false, true);
            if (result.Succeeded)
            {
                /*  DtoCustomer AccountValues = await GetUserByEmail(UserLogin.Email);
                  AccountValues.StatusRegistro = "user logged successful!";
                  // UserLogin.TokenJWT = await GerarJwt(UserLogin.Email);
                  AccountValues.TokenJWT = await GerarJwt(UserLogin.Email);
                  return Ok(AccountValues);*/
            }
            else
            {
                _notificacao.LimparErros();
                _notificacao.AddNotificacao("Erro ao tentar entrar! Verifique usuário e senha!");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }

            return true;

        }

        public Task FazerLogoff(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            throw new NotImplementedException();
        }
    }
}
