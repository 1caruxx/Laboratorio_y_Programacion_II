using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conHerencia;

namespace ejemploProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEgresado aluEgresado = new AlumnoEgresado(32323, "123", new DateTime(2017, 4, 25));
           // Alumno alumnoUno = new Alumno(23312, "3232");
            aluEgresado.Apellido = "perez";
            aluEgresado.Mostrar();



        }
    }
}
