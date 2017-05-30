using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sinHerencia
{
    public class AlumnoEgresado
    {

        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private DateTime _fechaEgreso;


        public AlumnoEgresado(int dni, string legajo, DateTime fechaEgreso)
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

            Bloque.AppendLine("Fecha de egreso: " + this._fechaEgreso);

            Console.Write(Bloque.ToString());

        }

       
    }
}
