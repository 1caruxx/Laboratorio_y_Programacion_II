using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class kilometro
    {
        public int cantidad;

        private kilometro(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public static kilometro sumar(kilometro kilometro1 , kilometro kilometro2)
        {
            kilometro kilometroAuxiliar = new kilometro(0);

            kilometroAuxiliar.cantidad = kilometro1.cantidad + kilometro2.cantidad;

            return kilometroAuxiliar;
        }
        public static kilometro operator + (kilometro kilometro1, kilometro kilometro2)
        {
            kilometro kilometroAuxiliar = new kilometro(0);

            kilometroAuxiliar.cantidad = kilometro1.cantidad + kilometro2.cantidad;

            return kilometroAuxiliar;
        }

        public static int operator + (kilometro kilometro , int numero)
        {
            int resultado;

            resultado = kilometro.cantidad + numero;
            return resultado;
        }

        public static bool operator ==(kilometro kilometro1 , kilometro kilometro2)
        {
            bool comparacion = false;
            if (kilometro1.cantidad == kilometro2.cantidad)
            {
                return comparacion = true;
            }
            else 
            {
                return comparacion;
            }
        }

        public static bool operator !=(kilometro kilometro1 , kilometro kilometro2)
        {
          return !(kilometro1 == kilometro2);
        }


        public static implicit operator kilometro(int numero)
        {
            return new kilometro(numero);
        }

        /*public static explicit operator kilometro(int numero)
        {
           kilometro kilometro = new kilometro(numero);
           
           return kilometro;
        }*/

        public static implicit operator int(kilometro kilometro)
        {
            return kilometro.cantidad;
        }
    }
}
