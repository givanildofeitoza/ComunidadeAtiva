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

namespace ComunidadeAtiva.Infra.Data.Repositorio
{
    public class RepositorioMoradorNecessidadeEspecial : RepositorioGenerico<MoradorNecessidadeEspecial>, ImoradorNecessidadeEspecial
    {
        public RepositorioMoradorNecessidadeEspecial(DbContext BancoDados) : base(BancoDados)
        {
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
