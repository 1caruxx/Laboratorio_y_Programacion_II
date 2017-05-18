using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private string _nombre;
        private List<Vehiculo> _listado;

        #region Constructores

        public Estacionamiento()
        {
            this._listado = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre):this()
        {
            this._nombre = nombre;
        }

        #endregion

        #region Operadores

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                return estacionamiento;
            }

            estacionamiento._listado.Add(vehiculo);

            return estacionamiento;
        }

        //Es necesario remover con un indice puesto que el metodo Remove() solo compara por punteros.
        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento._listado.RemoveAt(Estacionamiento.retornarIndice(estacionamiento , vehiculo));
                /*Otra forma de hacerlo podria ser
                 * estacionamiento._listado.RemoveAt(estacionamiento._listado.IndexOf(item));                
                 * estacionamiento._listado.RemoveAt(estacionamiento._listado.IndexOf(vehiculo)); //Pasarle vehiculo dara como resultado un error ya que le estoy pasando un puntero de un objeto que no esta en mi lista. En cambio item es el puntero del objeto que si lo esta.
                 */
            }

            return estacionamiento;
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculoRecorrido in estacionamiento._listado)
            {
                if (vehiculoRecorrido == vehiculo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static implicit operator Estacionamiento(string nombre)
        {
            return new Estacionamiento(nombre);
        }

        #endregion

        public static int retornarIndice(Estacionamiento estacionamiento , Vehiculo vehiculo)
        {
            int indice = -1;
            int contador = 0;

            foreach (Vehiculo item in estacionamiento._listado)
            {
                if (item == vehiculo)
                {
                    indice = contador;
                    break;
                }
                contador++;
            }

            return indice;
        }
    }
}
