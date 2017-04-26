using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Alumno:Persona
    {
        protected string _legajo;
       
        public Alumno(int dni , string legajo ):base(dni)
        {  
            this._legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("Legajo: " + this._legajo);

            return Bloque.ToString();
        }

        public static bool operator ==(Alumno alumno, Alumno alumno2)
        {
            if (alumno._dni == alumno2._dni && alumno._legajo == alumno2._legajo)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Alumno alumno, Alumno alumno2)
        {
            return !(alumno == alumno2);
        }

        public override bool Equals(object obj)
        {
            return (obj is Alumno);
        }
    }
}
