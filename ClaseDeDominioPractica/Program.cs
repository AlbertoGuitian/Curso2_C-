using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeDominioPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pasillo p1 = new Pasillo();
            p1.Nombre = "Norlog";
            p1.NumeroPasillo = 3;

            PasilloClientePrivado pcp1 = new PasilloClientePrivado();
            pcp1.Nombre = "andreani";
            pcp1.NumeroPasillo = 4;

            TipoProductos tp1 = new TipoProductos();
            tp1.NombreProducto = "cablesCoaxial";
            tp1.CantidadProductos = 100;//bobinas en un solo pallet.
            tp1.NumeroPasillo = 7; //porque hay 10 pasillos.
            tp1.Ubicacion = 4; 
            tp1.Altura = 2; //se encuentra en el segundo nivel.
            tp1.Posicion = 2; //se encuentra en el centro.
            //es una breve estructura que despues se puede ampliar a solicitar al usuario que cargue toda la data,
            //o cargarlo nosotros, conectar una base de datos, etc etc. lo continuaremos mas adelante.

        }
    }
}
