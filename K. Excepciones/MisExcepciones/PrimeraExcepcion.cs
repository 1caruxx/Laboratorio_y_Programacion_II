using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    public class PrimeraExcepcion:Exception
    {
        public PrimeraExcepcion(): base() { }
        public PrimeraExcepcion(string mensaje): base(mensaje){}
        public PrimeraExcepcion(string mensaje , Exception ex): base(mensaje , ex){}
    }
}
