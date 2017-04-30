using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinHerencia
{
    class Alumno
    {
        private int _dni;
        private string _nombre;
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _legajo;

        public Alumno(int dni , string legajo )
        {
            this._dni = dni;
            this._legajo = legajo;

        }

        public void Mostrar()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this._dni);
            Bloque.AppendLine("Legajo: " + this._legajo);
            Bloque.AppendLine("Apellido: " + this._apellido);
            Bloque.AppendLine("Nombre: " + this._nombre);

            Console.Write(Bloque.ToString());

        }

    }
}
