using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeDominioPractica
{                                             //ubi     pos1 pos 2 pos 3
                                      //    "            |                  "
                                      //                 |
    internal class Ubicaciones : Pasillo // "||| - - - || - - - || - - -|||" //altura 2
                                         // "||| - - - || - - - || - - -|||" //altura 1
    {                                    // "|||       ||       ||      |||"//piso
        public int Ubicacion { get; set; } //comienza con el 1 desde el inicio del pasillo para el final.
                                           //se subdivide una ubicacion en tres
        public int Altura { get; set; } //el pasillo tiene 3 niveles, el 1,2,3 de alto.
        public int Posicion { get; set; } //puede ser 1, 2 o 3 or izq, centro, derecha 
    }
}
