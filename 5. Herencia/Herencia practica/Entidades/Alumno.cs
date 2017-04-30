using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        protected string _legajo;

        public Alumno(int dni, string nombre, string apellido , string legajo):base(dni , nombre , apellido)
        {
            this._legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(base.ToString());
            SB.AppendLine("Legajo: " + this._legajo);

            return SB.ToString();
        }
    }
}
