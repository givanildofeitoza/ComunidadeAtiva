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
        public Task CriarUsuario(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task<bool> FazerLoginWebApi(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task<string> FazerLoginForms(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task FazerLogoff(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task CriarTokenJWT(CorpoDirigenteAssociacaoDTO dirigenteDto);
    }
}
