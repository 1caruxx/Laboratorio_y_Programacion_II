using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sin_herencia
{
    class Profesor
    {
        private int _dni;
        private string _fichaDocente;
        private DateTime _fechaDeIngreso;
        private string _nombre;
        private string _apellido;

        public Profesor(int dni , string fichaDocente , DateTime fechaDeIngreso)
        {
            this._dni = dni;
            this._fichaDocente = fichaDocente;
            this._fechaDeIngreso = fechaDeIngreso;
            this._nombre = "Sin contenido";
            this._apellido = "Sin contenido";
        }

        public void mostrar()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("DNI: " + this._dni);
            SB.AppendLine("Ficha docente:" + this._fichaDocente);
            SB.AppendLine("Nombre" + this._nombre);
            SB.AppendLine("Apellido" + this._apellido);
            SB.AppendLine("Fecha de ingreso: " + this._fechaDeIngreso);

            Console.WriteLine(SB.ToString());
        }
    }
}
