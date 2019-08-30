using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Espinola
{
    public class Producto
    {
        public int ID { get; set; }
        public CodigoDescripcion Categoria { get; set; }// EJ: Vestimenta / Comestibles / Rodados / Inmuebles
        public Cliente Propietario { get; set; }

    }
}
