using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _nombreCompleto;
        private string _legajo;

        public Alumno(string nombreCompleto, string legajo)
        {
            this._nombreCompleto = nombreCompleto;
            this._legajo = legajo;
        }

        public static bool operator ==(Alumno alumno, Alumno alumno2)
        {
            return (alumno._legajo == alumno2._legajo && alumno._nombreCompleto == alumno2._nombreCompleto);
        }

        public static bool operator !=(Alumno alumno, Alumno alumno2)
        {
            return !(alumno == alumno2);
        }
    }
}
