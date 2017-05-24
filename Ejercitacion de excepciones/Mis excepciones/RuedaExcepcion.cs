using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_excepciones
{
    public enum ERueda
    {
        Delantera_derecha,
        Delantera_izquierda,
        Trasera_derecha,
        Trasera_izquierda
    }

    public class RuedaExcepcion:MiExcepcion
    {
        public ERueda posicion;

        public RuedaExcepcion() : base() { }
        public RuedaExcepcion(String mensaje) : base(mensaje) { }
        public RuedaExcepcion(String mensaje, Exception ex) : base(mensaje, ex) { }

        public RuedaExcepcion(String mensaje , ERueda posicion) : base(mensaje)
        {
            this.posicion = posicion;
        }

    }
}
