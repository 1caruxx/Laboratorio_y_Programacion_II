using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sin_herencia
{
    public class Alumno_egresado
    {
        private int _dni;
        private string _legajo;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaDeEgreso;

        public Alumno_egresado(int dni, string legajo , DateTime fechaDeEgreso)
        {
            this._dni = dni;
            this._legajo = legajo;
            this._nombre = "Sin contenido";
            this._apellido = "Sin contenido";
            this._fechaDeEgreso  = fechaDeEgreso;
        }

        public void mostrar()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("DNI: " + this._dni);
            SB.AppendLine("Legajo:" + this._legajo);
            SB.AppendLine("Nombre" + this._nombre);
            SB.AppendLine("Apellido" + this._apellido);
            SB.AppendLine("Fecha de egreso: " + this._fechaDeEgreso);

            Console.WriteLine(SB.ToString());
        }
    }
}
