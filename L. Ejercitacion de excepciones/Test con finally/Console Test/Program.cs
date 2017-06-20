using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxiliar=0;

            try
            {
                auxiliar = Program.GenerarExcepcion2();
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message+"Y fue controlada en el main.");
                Console.WriteLine("La variable auxiliar ahora vale: " + auxiliar);
                //La unica forma de que no se ejecute el bloque Finally es cuando se sale de la aplicacion.
                //Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("Pulse una tecla para finalizar...");
                Console.ReadKey();
            }
        }

        public static int GenerarExcepcion2()
        {
            try
            {
                Program.GenerarExcepcion();
            }
            catch (Exception excepcion)
            {
                throw new Exception(excepcion.Message+"Que luego paso por el metodo GenerarExcepcion2()");
                //Este return es inaccesible
                return 5;
            }
            /*
             * A pesar de haber lanzado una excepcion previamente, primer se ejecuta el finally y luego se lanza la excepcion, saliendo del metodo en el proceso.
             * Si hay un return valido dentro del catch, el bloque Finally se ejecutara de todas formas.
             */
            finally
            {
                Console.WriteLine("El finally del metodo GenerarExcepcion2() se ha ejecutado.");
                /*
                 * No puede haber return dentro de un bloque finally
                 * return 0;
                 */
            }

            //Estas lineas de codigo no se ejecutaran.
            Console.WriteLine("Codigo inaccesible.");
            return 1;
        }

        public static int GenerarExcepcion()
        {
            throw new Exception("Excepcion generada en el metodo GenerarExcepcion.");
        }
    }
}
