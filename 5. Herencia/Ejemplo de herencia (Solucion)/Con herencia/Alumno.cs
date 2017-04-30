using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_herencia
{
    public class Alumno:Persona
    {
        protected string _legajo;


        public Alumno(int dni, string nombre, string apellido, string legajo): base(dni, nombre, apellido)   
        {
            this._legajo = legajo;
        }

        public virtual void mostrar()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("DNI: " + this._dni);
            SB.AppendLine("Legajo:" + this._legajo);
            SB.AppendLine("Nombre" + this._nombre);
            SB.AppendLine("Apellido" + this._apellido);

            Console.WriteLine(SB.ToString());
        }
    }
}