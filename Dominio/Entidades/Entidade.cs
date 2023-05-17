using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Dominio.Entidades
{
    public abstract class Entidade
    {
        [Key]
        public int id;        
    }
}
