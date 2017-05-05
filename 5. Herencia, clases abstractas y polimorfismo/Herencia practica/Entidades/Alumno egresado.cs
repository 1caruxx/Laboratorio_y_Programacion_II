using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno_egresado:Alumno
    {
        private DateTime _fechaDeEgreso;

        public Alumno_egresado(int dni, string nombre, string apellido, string legajo , DateTime fechaDeEgreso) : base(dni, nombre, apellido , legajo)
        {
            this._fechaDeEgreso = fechaDeEgreso;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(base.ToString());
            SB.AppendLine("Fecha de egreso: " + this._fechaDeEgreso);

            return SB.ToString();
        }
    }
}
