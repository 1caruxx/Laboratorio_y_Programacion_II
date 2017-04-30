using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sinHerencia
{
    public class Profesor
    {

        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _fichaDocente;
        private DateTime _fechaIngreso;
       


        public Profesor(int dni, string fichaDocente)
        {
            this._dni = dni;
            this._fichaDocente = fichaDocente;

        }
        public void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("DNI: " + this._dni);
            bloque.AppendLine("DNI: " + this._dni);
            bloque.AppendLine("DNI: " + this._dni);
            bloque.AppendLine("DNI: " + this._dni);
            bloque.AppendLine("DNI: " + this._dni);

            Console.WriteLine(bloque.ToString());
       


            
        
        }


    }
}
