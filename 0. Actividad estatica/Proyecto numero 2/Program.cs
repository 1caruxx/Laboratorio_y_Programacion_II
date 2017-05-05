using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_numero_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int elMayor;
            string dato; 

            Console.WriteLine("Hola mundo, mori en el intento.");
            elMayor =  Comparadora.retornarMayor(10, 5);
            Sello.mensaje = "Nuevo mensaje";
            dato = Sello.imprimir();
            Sello.color = ConsoleColor.DarkRed;
            Sello.imprimirEnColor();
        }
    }
}
