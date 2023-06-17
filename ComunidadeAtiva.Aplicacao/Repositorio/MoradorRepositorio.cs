﻿using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Infra.Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.Repositorio
{
    public class MoradorRepositorio : RepositorioGenerico<Morador>, ImoradorRepositorio
    {
        public MoradorRepositorio(DbContext BancoDados) : base(BancoDados)
        {
        }

        public async Task<Morador> ObterMoradorRelacionalRuaId(int id)
        {
            return await _Entidade
            .Where(x => x.id == id)
            .Include(r => r.rua)
            .Include(n => n.necessidadeEspecial)
            .Include(b => b.moradorBeneficioSocial)
            .AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Morador>> ObterTodosRelacionalMorador(int t, int s)
            => _Entidade.Include(r => r.rua).
            Include(n=>n.necessidadeEspecial).
            Include(b => b.moradorBeneficioSocial).
            AsNoTracking().ToList().Take(t).Skip(s);

    }

}

