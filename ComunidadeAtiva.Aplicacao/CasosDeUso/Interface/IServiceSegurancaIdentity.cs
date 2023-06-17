using ComunidadeAtiva.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServiceSegurancaIdentity
    {
        public Task CriarUsuario(UsuarioDTO usuario);
        public Task<bool> FazerLoginWebApi(UsuarioDTO usuario);
        public Task<bool> FazerLoginForms(UsuarioDTO usuario);
        public Task FazerLogoff(UsuarioDTO usuario);
        public Task CriarTokenJWT(UsuarioDTO usuario);
    }
}
