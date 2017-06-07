using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        private string _legajo;

        public string Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        //public Alumno() { }
    }
}
