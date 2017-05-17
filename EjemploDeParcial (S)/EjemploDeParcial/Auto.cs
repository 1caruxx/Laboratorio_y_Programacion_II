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

        public Auto(string patente/*, DateTime fechaDeIngreso,*/, int cantidadDePuertas): base(patente/* , fechaDeIngreso*/)
        {
            this._cantidadDePuertas = cantidadDePuertas;
        }

        public override bool Equals(object obj)
        {
            return (obj is Auto);
        }

       /* public override DateTime fechaDeIngreso
        {
            get { return this._fechaDeIngreso; }
        }*/
    }
}
