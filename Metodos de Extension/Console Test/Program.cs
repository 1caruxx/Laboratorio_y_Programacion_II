using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades_2;

namespace Console_Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("Fernando", 19, 3, false);
            int numero = 4;

            Console.WriteLine(alumno.MostrarDatos());

            alumno.SetLegajo(numero);

            Console.WriteLine(alumno.Legajo);

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }

    static class Extensora
    {
        public static string MostrarDatos(this Alumno alumno)
        {
            return "Hola";
        }

        public static int CantidaDeVocales(this string dato)
        {
            int cantidad = 0;

            foreach (char item in dato)
            {
                if (item == 2)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        public static void SetLegajo(this Alumno alumno, int dato)
        {
            alumno.Legajo = dato;
        }
    }
}
