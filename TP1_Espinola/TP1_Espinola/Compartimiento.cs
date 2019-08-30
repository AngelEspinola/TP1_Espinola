using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Espinola
{
    public class Compartimiento
    {
        public int ID { get; set; }
        public Producto Producto { get; set; }
        public CodigoDescripcion Categoria { get; set; } //EJ: Materia prima / Producto terminado / Cuarentena
    }
}
