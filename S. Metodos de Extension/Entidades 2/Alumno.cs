using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades_2
{
    public sealed class Alumno:Persona
    {
        private bool _egresado;
        private int _legajo;

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public Alumno(string nombre, int dni, int legajo, bool esEgresado):base(nombre, dni)
        {
            this._legajo = legajo;
            this._egresado = esEgresado;
        }
    }
}
