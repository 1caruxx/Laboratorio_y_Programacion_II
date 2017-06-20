using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_excepciones
{
    public class MiExcepcion:Exception
    {
        public MiExcepcion() : base() { }
        public MiExcepcion(String mensaje) : base(mensaje) { }
        public MiExcepcion(String mensaje , Exception ex) : base(mensaje , ex) {}
    }
}
