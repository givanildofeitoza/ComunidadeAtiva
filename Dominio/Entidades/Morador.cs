﻿using ComunidadeAtiva.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Morador : Entidade
    {
        public string?  Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int     RuaId { get; set; }
        public string?  NumeroCasa { get; set; }
        public string?  Cpf { get; set; }
        public string?  Rg { get; set; }
        public string? Situacao { get; set; }
        public string?  EstadoCivil { get; set; }
        public Rua rua { get; set; }
        public IEnumerable<MoradorNecessidadeEspecial> necessidadeEspecial { get; set; }
        public IEnumerable<MoradorBeneficioSocial>   moradorBeneficioSocial { get; set; }
        public IEnumerable<MoradorPrograma> programa { get; set; }

      

    }
}
