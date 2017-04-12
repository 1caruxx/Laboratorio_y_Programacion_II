using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula miAula;
            int contador;

            miAula = new Aula();

            for (contador = 0; contador < 12; contador++)
            { 
                miAula.agregarAlumno(new Alumno("Juan" , "Sanchez" , contador));
            }

            miAula.borrarAlumno(new Alumno("Juan", "Sanchez", 5));
        }
    }
}
