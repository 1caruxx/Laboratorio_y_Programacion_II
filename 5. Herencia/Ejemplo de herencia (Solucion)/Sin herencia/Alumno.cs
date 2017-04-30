using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sin_herencia
{
    public class Alumno
    {
        private int _dni ;
        private string _legajo;
        private string _nombre;
        private string _apellido;

        public Alumno(int dni , string legajo)
        {
            this._dni = dni;
            this._legajo = legajo;
            this._nombre = "Sin contenido";
            this._apellido = "Sin contenido";
        }

        public void mostrar()
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
