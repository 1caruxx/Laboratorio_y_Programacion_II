using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto:Vehiculo
    {
        private int _cantidadDePuertas;

        public Auto(string patente, int cantidadDePuertas): base(patente)
        {
            this._cantidadDePuertas = cantidadDePuertas;
        }
    }
}
