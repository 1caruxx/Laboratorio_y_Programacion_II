using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conClasesAbstractas;

namespace ejemploConAbstractos
{
    class Program
    {
        static void Main(string[] args)
        {
           // Humano humano = new Humano();
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona("Fernando", "40793784"));
            personas.Add(new Alumno("Hernesto", "40589632" , 204216));

            foreach (Humano item in personas)
            {
                item.mostrar();
            }
        }
    }
}
