﻿using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
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
     

        public ServiceSegurancaIdentity(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ICapturarNotificacao notificacao
           )
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
            _notificacao = notificacao;          
        }

        public Task CriarTokenJWT(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public async Task CriarUsuario(UsuarioDTO usuario)
        {
            var user = new IdentityUser
            {
                Email = usuario.Email,
                UserName = usuario.Email,
                EmailConfirmed = true
            };
            var result = await _UserManager.CreateAsync(user, usuario.Senha);
            if (result.Succeeded)
            {
                //await _CustomerService.PostCustomer(_mapper.Map<Customer>(NewUserModel));
                //cria mendo da associação
                
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
        public async Task<bool> FazerLoginForms(UsuarioDTO usuario)
        {
            //var usermananger = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityFileDbContext()), null, null, null, null, null, null, null, null);

            //var user = await _UserManager.FindByLoginAsync(usuario.Email, usuario.Senha);
           var HttpContext = new DefaultHttpContext();
            // _SignInManager.Context = HttpContext;

            var usuarioId = new IdentityUser
            {
                Email = usuario.Email,
                UserName = usuario.Email,
                EmailConfirmed = true
            };

            var result = _SignInManager.CheckPasswordSignInAsync(usuarioId, usuario.Senha, true);


            return (result != null);
        }
        public async Task<bool> FazerLoginWebApi(UsuarioDTO usuario)
        {
           
            var result = await _SignInManager.PasswordSignInAsync(usuario.Email, usuario.Senha, false, true);
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

        public Task FazerLogoff(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}