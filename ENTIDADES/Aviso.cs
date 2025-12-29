using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class AvisoMateria
    {
        public int IdAviso { get; set; }
        public int MateriaId { get; set; }
        public int TipoAviso { get; set; } // 6 o 12
        public DateTime FechaProgramada { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string Estado { get; set; } // Pendiente, Enviado, Cancelado
    }
}
