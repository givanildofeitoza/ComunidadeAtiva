﻿using ComunidadeAtiva.Dominio.Entidades;
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

    }
    
}
