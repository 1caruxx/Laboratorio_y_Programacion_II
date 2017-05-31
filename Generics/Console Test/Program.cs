using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<Television> containerDeTelevisiones = new Container<Television>(5);
            Container<Persona> containerDePersonas = new Container<Persona>(5);
            Container<Auto> containerDeAutos = new Container<Auto>(5);
            Container<Mueble> containerDeMuebles = new Container<Mueble>(5);
            Television television = new Television("Philips" , 30.5 , "1280x720");
            Television television2 = new Television("Philips", 30.5, "1280x720");
            bool estado;

            estado = containerDeTelevisiones + television;
            estado = containerDeTelevisiones + television2;

            foreach (Television item in containerDeTelevisiones)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(estado);

            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
