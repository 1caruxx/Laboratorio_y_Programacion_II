using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conHerencia
{
    public class Persona
    {
        protected int _dni;
        protected string _nombre;
        protected string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _legajo;

        public Persona(int dni  )
        {
            this._dni = dni; 
        }
      
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this._dni);
            Bloque.AppendLine("Apellido: " + this._apellido);
            Bloque.AppendLine("Nombre: " + this._nombre);
            return Bloque.ToString();
        }

        public void Mostrar()
        {           
            Console.Write(this.ToString());
        }
    }
}
