﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class MoradorCadastroDto
    {
        [Required]
        public string? id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int RuaId { get; set; }
        public string? NumeroCasa { get; set; }
        [Required]
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public string? Situacao { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
