using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_excepciones;
using Entidades;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();

            carrera.listadoAutos.Add(new Auto("Toyota"));
            carrera.listadoAutos.Add(new Auto("Fiat"));
            carrera.listadoAutos.Add(new Auto("Chevrolet"));
            carrera.listadoAutos.Add(new Auto("Renault"));
            carrera.listadoAutos.Add(new Auto("Honda"));
            carrera.listadoAutos.Add(new Auto("Ford"));

            try
            {
                carrera.Correr();
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
            finally
            { 
            
            }

            Console.WriteLine("Pulse una tecla no mas...");
            Console.ReadKey();
        }
    }
}
