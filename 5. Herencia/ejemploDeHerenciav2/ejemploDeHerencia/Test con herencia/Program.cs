using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conHerencia;

namespace Test_con_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listado = new List<Persona>();

            listado.Add(new Persona(40793784));
            listado.Add(new Alumno(40856963 , "234986"));
            listado.Add(new AlumnoEgresado(40568712 , "567123" , new DateTime(2012 , 9 , 12)));
            listado.Add(new Profesor(40512784, "674123"));

            foreach (Persona item in listado)
            {
                item.Mostrar();
            }
        }
    }
}
