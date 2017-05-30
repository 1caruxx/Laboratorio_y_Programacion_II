using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AulaLlenaExcepcion:Exception
    {
        public AulaLlenaExcepcion() : base() { }
        public AulaLlenaExcepcion(string mensaje) : base(mensaje) { }
        public AulaLlenaExcepcion(string mensaje, Exception excepcion) : base(mensaje, excepcion) { }
    }
}
