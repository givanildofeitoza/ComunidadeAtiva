﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public class MoradorPrograma:Entidade
    {
        public int MoradorId { get; set; }
        public int ProgramaId { get; set; }
        public string Ativo { get; set; }

    }
}
