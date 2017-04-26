using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conHerencia
{
    public class Profesor:Persona
    {      
        private string _fichaDocente;
        private int _fechaIngreso;    

        public Profesor(int dni, string fichaDocente):base(dni)
        {          
            this._fichaDocente = fichaDocente;

        }
      
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("Fecha de ingreso: " + this._fechaIngreso);
            Bloque.AppendLine("Ficha docente: " + this._fichaDocente);

            return Bloque.ToString();
        }

        public static bool operator ==(Profesor profesor, Profesor profesor2)
        {
            if (profesor._dni == profesor2._dni && profesor._fichaDocente == profesor2._fichaDocente)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Profesor profesor, Profesor profesor2)
        {
            return !(profesor == profesor2);
        }

        public override bool Equals(object obj)
        {
            return (obj is Profesor);
        }
    }
}
