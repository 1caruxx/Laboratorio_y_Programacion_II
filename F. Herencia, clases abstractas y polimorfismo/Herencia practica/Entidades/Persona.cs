using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected int _dni;
        protected string _nombre;
        protected string _apellido;

        public Persona(int dni , string nombre , string apellido)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("Apellido y nombre: " + this._apellido);
            SB.AppendLine(", " + this._nombre);
            SB.AppendLine("DNI: " + this._dni);

            return SB.ToString();
        }

        public void mostrar()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
