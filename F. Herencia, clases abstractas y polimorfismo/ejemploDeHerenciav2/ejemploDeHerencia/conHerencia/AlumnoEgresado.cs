using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conHerencia
{
    public class AlumnoEgresado:Alumno
    {
        private DateTime _fechaEgreso;

        public AlumnoEgresado(int dni, string legajo, DateTime fechaEgreso):base(dni,legajo)
        {
            this._fechaEgreso = fechaEgreso;

        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());
         
            Bloque.AppendLine("Fecha de egreso: " + this._fechaEgreso);

            return Bloque.ToString();

        }

        public static bool operator ==(AlumnoEgresado alumno, AlumnoEgresado alumno2)
        {
            if (alumno._dni == alumno2._dni && alumno._legajo == alumno2._legajo && alumno._fechaEgreso == alumno2._fechaEgreso)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AlumnoEgresado alumno, AlumnoEgresado alumno2)
        {
            return !(alumno == alumno2);
        }

        public override bool Equals(object obj)
        {
            return (obj is AlumnoEgresado);
        }
    }
}
