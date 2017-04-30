using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Alumno
    {
        private int legajo;
        private string nombre;

        public Alumno(int legajo)
        {
            this.legajo = legajo;
        }

        public Alumno(int legajo , string nombre):this(legajo)
        {
            this.nombre = nombre;
        }
    }
}
