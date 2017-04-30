using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        private string _fichaDoncente;
        private DateTime _FechaDeIngreso;

        public Profesor(int dni , string nombre , string apellido , string fichaDocente , DateTime FechaDeIngreso):base(dni , nombre , apellido)
        {
            this._fichaDoncente = fichaDocente;
            this._FechaDeIngreso = FechaDeIngreso;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(base.ToString());
            SB.AppendLine("Fecha de ingreso: " + this._FechaDeIngreso);

            return SB.ToString();
        }
    }
}
