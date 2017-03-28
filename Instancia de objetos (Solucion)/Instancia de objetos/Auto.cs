using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class Auto
    {
        Rueda dd;
        Rueda di;
        Rueda ti;
        Rueda td;

        /* Constructores de clase. 
         * Tienen el mismo nombre que la clase
         * Pueden tener modificador de visivbilidad. (Public, private etc)
         * No tienen valor de rertorno.
         * Pueden tener parametros.
         * Se ejecutan al crear una instancia de la clase (objeto).
         * Se puede y debe usar el operador this.
         * Puede acceder a los atributos de instancia.
         * Puede acceder a los atribustos estaticos.
         */ 
        public Auto()
        {
            this.dd = new Rueda();
            this.di = new Rueda();
            this.ti = new Rueda();
            this.td = new Rueda();
        }
        
    }
}
