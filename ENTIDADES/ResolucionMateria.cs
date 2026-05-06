using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ResolucionMateria
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public int NumeroResolucion { get; set; }
        public int Anio { get; set; }
        public string NombreArchivo { get; set; }
        public string UrlArchivo { get; set; }
        public DateTime FechaCarga { get; set; }
    }
}
