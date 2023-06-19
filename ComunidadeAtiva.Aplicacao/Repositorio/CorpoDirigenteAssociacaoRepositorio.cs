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
    }
}
