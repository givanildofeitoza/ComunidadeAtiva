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
    public class MoradorBeneficioSocialRepositorio : RepositorioGenerico<MoradorBeneficioSocial>, ImoradorBeneficioSocialRepositorio
    {
        public MoradorBeneficioSocialRepositorio(DbContext BancoDados) : base(BancoDados)
        {
        }

        public  async Task DeletarPorIdBbeneficio(int Id)
        {
            var b = await _Entidade.Where(x => x.BeneficioSocialId == Id).ToArrayAsync();
            _Entidade.RemoveRange(b);
            await _BancoDados.SaveChangesAsync();
        }
    }

}
