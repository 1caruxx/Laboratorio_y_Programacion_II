using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;
            int resultado=0;

            //Atrapo la excepcion generada
            try
            {
                Program.CapturarExcepcion();
                //Calculadora.Calcular();
                //calculadora.GenerarExcepcion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*
             * Un bloque try puede contener mas de una linea que genere una excepcion.
             * dependiendo de su clase, sera atrapada por un catch o por otro. 
             * Cuando se genera una excepcion y es atrapada, todo el codigo que esta por debajo de la linea causante de la excepcion en el try no se ejecutara.
             * Los catch mas especificos iran por encima del cactch mas general, puesto que en el caso contrario, jamas se ejecutarian.
             * Solo puede haber un cath general (el de clase Exception que atrapa cualquier excepcion) por cada bloque try.
             */
            try
            {
                Console.Write("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());
                resultado = num2 / num1;
            }
            //Primer catch especifico.
            catch (DivideByZeroException ex)
            {
                Console.Write(ex.Message);
                Console.Write(" (No se puede dividir por 0).");
                num1 = 1;
            }
            //Segundo catch especifico.
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
                Console.Write(" (Debe introducir un numero entero).");
                num1 = 1;
            }
            //Catch general.
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                num1 = 1;
            }
            finally
            {
                Console.WriteLine(resultado);
            }

            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }

        public static void CapturarExcepcion()
        {
            Calculadora.Calcular();
        }
    }
}
