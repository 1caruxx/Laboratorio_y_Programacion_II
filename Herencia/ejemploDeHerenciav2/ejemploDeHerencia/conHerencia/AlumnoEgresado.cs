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

       
    }
}
