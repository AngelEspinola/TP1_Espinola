using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Espinola
{
    class Empleado : Persona
    {
        public int Legajo { get; set; }
        public CodigoDescripcion Categoria  { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
    }
}
