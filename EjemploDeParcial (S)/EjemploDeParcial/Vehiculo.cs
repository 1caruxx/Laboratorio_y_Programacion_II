using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private string _patente;

        #region Constructor

        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return (vehiculo._patente == vehiculo2._patente);
        }

        public static bool operator !=(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return !(vehiculo == vehiculo2);
        }

        #endregion
    }
}
