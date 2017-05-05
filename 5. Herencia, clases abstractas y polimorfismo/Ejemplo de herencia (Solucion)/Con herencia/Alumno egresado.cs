using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_herencia
{
    public class Alumno_egresado : Alumno
    {
        private DateTime _fechaDeEgreso;

        public Alumno_egresado(int dni, string legajo, DateTime fechaDeEgreso) : base(dni, legajo)
        {
            this._fechaDeEgreso = fechaDeEgreso;
        }

        public override void mostrar()
        {
            base.mostrar();
            StringBuilder SB = new StringBuilder();
            SB.AppendLine("Fecha de egreso: " + this._fechaDeEgreso);
        }
    }
}