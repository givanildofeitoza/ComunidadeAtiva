using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Infra.Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.Repositorio
{
    public class CorpoDirigenteAssociacaoRepositorio : RepositorioGenerico<CorpoDirigenteAssociacao>, IcorpoDirigenteAssociacaoRepositorio
    {
        public CorpoDirigenteAssociacaoRepositorio(DbContext BancoDados) : base(BancoDados)
        {
        }

        public async Task<CorpoDirigenteAssociacao> ObterDirigenteRelacional(string Id)
        {
          return await _BancoDados.Set<CorpoDirigenteAssociacao>().Where(x => x.UsuarioId == Id).FirstOrDefaultAsync();
        }
    }
}
