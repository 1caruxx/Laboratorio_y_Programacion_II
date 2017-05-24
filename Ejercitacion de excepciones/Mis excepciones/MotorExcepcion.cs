using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_excepciones
{
    public class MotorExcepcion:MiExcepcion
    {
        public MotorExcepcion() : base() { }
        public MotorExcepcion(String mensaje) : base(mensaje) { }
        public MotorExcepcion(String mensaje, Exception ex) : base(mensaje, ex) { }
    }
}
