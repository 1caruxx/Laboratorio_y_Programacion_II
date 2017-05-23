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

            try
            {
                Console.Write("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());
                resultado = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.Write(ex.Message);
                Console.Write(" (No se puede dividir por 0).");
                num1 = 1;
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
                Console.Write(" (Debe introducir un numero entero).");
                num1 = 1;
            }
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
