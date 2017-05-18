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
            Grupo grupo = new Grupo("Cambridge");
            grupo.tipo = TipoManada.Mixta;

            grupo += new Perro("Timoteo", "San bernardo", 4, true);
            grupo += new Perro("Timoteo", "San bernardo", 4, true);
            grupo += new Gato("Bola de nieve II", "Siames");

            grupo -= new Perro("Timoteo", "San bernardo", 4, true);
            Console.WriteLine((int)new Perro("Prueba", "Sin raza", 8, false));
            Console.WriteLine((string)grupo);

            Console.ReadKey();

        }
    }
}
