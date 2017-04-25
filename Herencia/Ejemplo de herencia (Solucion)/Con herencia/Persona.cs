using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_herencia
{
    class Persona
    {
        protected int _dni;
        protected string _nombre;
        protected string _apellido;

        public Persona(int dni , string nombre , string apellido)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
