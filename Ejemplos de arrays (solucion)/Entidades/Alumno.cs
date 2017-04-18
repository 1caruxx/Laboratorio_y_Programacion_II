using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private int legajo;

        public Alumno(string nombre , string apellido , int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public static bool operator ==(Alumno alumno , Alumno alumno2)
        {
            if (alumno.legajo == alumno2.legajo && alumno.nombre == alumno2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }

           // return (alumno.apellido == alumno2.apellido && alumno.legajo == alumno2.legajo);
        }

        public static bool operator ==(Alumno alumno, int legajo)
        {
            if (alumno.legajo == legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Alumno alumno, int legajo)
        {
            return !(alumno == legajo);
        }

        public static bool operator !=(Alumno alumno, Alumno alumno2)
        { 
            return !(alumno==alumno2);
        }



    }
}
