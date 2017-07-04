using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private int _dni;

        public Persona(string nombre, int dni)
        {
            this._nombre = nombre;
            this._dni = dni;
        }
    }
}
