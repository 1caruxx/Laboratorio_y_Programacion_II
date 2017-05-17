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
       /* protected DateTime _fechaDeIngreso;
        public abstract DateTime fechaDeIngreso
        {
            get;
        }*/

        #region Constructor

        public Vehiculo(string patente/* , DateTime fechaDeIngreso*/)
        {
            this._patente = patente;
            /*this._fechaDeIngreso = fechaDeIngreso;*/
        }

        #endregion

        #region Operadores

       /*
        * Aqui sobrecargo el operador == para que se pregunte si el objeto es del mismo tipo y si su atributo tambien es el mismo.
        * Para preguntar si son del mismo tipo uso el equals que sobrcarge en cada uno de los objetos que heredan de la clase abstracta vehiculo.
        * Segun el tipo de objeto que sea vehiculo, ira al equals de moto o auto y ahi sera cuando se pregunte si el objeto pasado por parametro es del mismo tipo de la instancia que invoca al metodo equals.
        * Debo sobrecargarlo en la clase vehiculo, ya que la clase estacionamiento utiliza esta comparacion en multiple sitios.
        */
        public static bool operator ==(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return (vehiculo.Equals(vehiculo2) && vehiculo._patente == vehiculo2._patente);
        }

        public static bool operator !=(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return !(vehiculo == vehiculo2);
        }

        #endregion
    }
}
