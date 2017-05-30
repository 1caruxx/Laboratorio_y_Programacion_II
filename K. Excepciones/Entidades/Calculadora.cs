using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisExcepciones;

namespace Entidades
{
    public class Calculadora
    {
        //Esta funcion captura la excepcion lanzada por el metodo GenerarExcepcion() y lanza una nueva excepcion en el catch, concatenando la informacion de la excepcion de la excepcion que atrapo.
        public static void Calcular()
        {
            Calculadora calculadora = new Calculadora();

            try
            {
                calculadora.GenerarExcepcion();
            }
            catch(Exception ex)
            {
                throw new Exception("Static calcular" + ex.Message+ex);
            }
        }

        //Esta funcion genera una excepcion, no importa el tipo.
        public void GenerarExcepcion()
        {
            throw new PrimeraExcepcion("Error...");
        }
    }
}
