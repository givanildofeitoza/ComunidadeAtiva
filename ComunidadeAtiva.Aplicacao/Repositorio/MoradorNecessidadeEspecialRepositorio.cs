using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Infra.Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.Repositorio
{
    public class MoradorNecessidadeEspecialRepositorio : RepositorioGenerico<MoradorNecessidadeEspecial>, ImoradorNecessidadeEspecialRepositorio
    {
        public MoradorNecessidadeEspecialRepositorio(DbContext BancoDados) : base(BancoDados)
        {
        }

        public async Task DeletarNecessidadePorIdNecessidade(int Id)
        {
            var n = await  _Entidade.Where(x => x.NecessidadeId == Id).ToArrayAsync();
            _Entidade.RemoveRange(n);
            await _BancoDados.SaveChangesAsync();

        }

        /*  public async Task<MoradorNecessidadeEspecial> ObterNecessidadeRelacional(int Id)
          {

              _Entidade
              .Where(x => x.id == id)
              .Include(r => r.rua)
              .Include(n => n.necessidadeEspecial)
              .Include(b => b.moradorBeneficioSocial)
              .AsNoTracking().FirstOrDefaultAsync();

              _Entidade.Where(x=> x.id == Id).Include(n=> n.NecessidadeId)

          }*/

    }

}
