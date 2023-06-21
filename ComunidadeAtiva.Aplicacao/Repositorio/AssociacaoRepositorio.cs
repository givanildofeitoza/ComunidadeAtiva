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
    public class AssociacaoRepositorio : RepositorioGenerico<Associacao>, IassociacaoRepositorio
    {
        public AssociacaoRepositorio(DbContext BancoDados) : base(BancoDados)
        {
        }
    }
}
