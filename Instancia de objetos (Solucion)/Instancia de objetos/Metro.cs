using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class Metro
    {
        public int cantidad;

        private Metro(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Metro(kilometro cantidad)
        {
            return new Metro(cantidad*1000);
        }

        public static Metro operator + (Metro metro , kilometro kilometro)
        {
            Metro metroAuxiliar = new Metro(kilometro);
            metroAuxiliar.cantidad += metro.cantidad;
            return metroAuxiliar;
        }
    }
}
