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
            Aula aula = new Aula(305, 40);

            aula.agregar(new Persona(40793784, "Fernando", "Lareu"));
            aula.agregar(new Alumno(40325612, "Juan", "Perez", "205254"));
            aula.agregar(new Alumno_egresado(40798555, "Pedro", "Gimenez", "206701", new DateTime(2012, 4, 15)));
            aula.agregar(new Profesor(39222678, "Octavio", "Villegas", "666", new DateTime(2011, 3, 15)));

            /*foreach (Persona item in aula.obtenerListado)
            {
                item.mostrar();
            }*/

            aula.mostrar();

            Console.WriteLine("Capacidad del aula: " + aula.capacidad);
            Console.WriteLine("Espacio libre: " + aula.espacioLibre);
            Console.WriteLine("Numero de personas: " + aula.cantidadDePersonas);
            Console.WriteLine("Numero de alumnos: " + aula.cantidadDeAlumnos);
            Console.WriteLine("Numero de profesores: " + aula.cantidadDeProfesores);

            aula.eliminar(new Profesor(39222678, "Octavio", "Villegas", "666", new DateTime(2011, 3, 15)));

            aula.mostrar();
        }
    }
}
