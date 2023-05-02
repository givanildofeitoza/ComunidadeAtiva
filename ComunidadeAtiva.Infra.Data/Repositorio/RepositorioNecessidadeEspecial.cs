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
    public class RepositorioNecessidadeEspecial : RepositorioGenerico<NecessidadeEspecial>, InecessidadeEspecial
    {
        public RepositorioNecessidadeEspecial(DbContext BancoDados) : base(BancoDados)
        {
        }

      /* public async Task<Morador> ObterMoradorRelacionalId(int id)
        {
          return await _Entidade.Where(x => x.id == id)
                .Include(r => r.rua)
                .Include(n => n.necessidadeEspecial)
                .Include(b => b.beneficioSocial)
                .Include(p => p.programa)
                .AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Morador>> ObterTodosRelacionalMorador(int t, int s)
            =>  _Entidade.Include(r=> r.rua).AsNoTracking().ToList().Take(t).Skip(s);*/
    }
    
}
