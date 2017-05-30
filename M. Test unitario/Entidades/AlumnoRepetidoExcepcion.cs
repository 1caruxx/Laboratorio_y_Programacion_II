using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoRepetidoExcepcion:Exception
    {
        public AlumnoRepetidoExcepcion() : base() { }
        public AlumnoRepetidoExcepcion(string mensaje) : base(mensaje) { }
        public AlumnoRepetidoExcepcion(string mensaje, Exception excepcion) : base(mensaje, excepcion) { }
    }
}
