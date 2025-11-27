using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeDominioPractica
{
    internal class TipoProductos : Ubicaciones

    {
        public string NombreProducto { get; set; }
        public string TipoProducto { get; set; }

        public int CantidadProductos { get; set; }
    }
}
