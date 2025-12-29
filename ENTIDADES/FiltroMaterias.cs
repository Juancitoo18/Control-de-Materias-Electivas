using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class FiltroMaterias
    {
        public string Nombre { get; set; }
        public int CarreraId { get; set; }
        public string NumeroResolucion { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
    }

}
