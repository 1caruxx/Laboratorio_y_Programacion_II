using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Television
    {
        private string _marca;
        private double _pulgada;
        private string _resolucion;

        public Television(string marca, double pulgada, string resolucion)
        {
            this._marca = marca;
            this._pulgada = pulgada;
            this._resolucion = resolucion;
        }

        public override bool Equals(object obj)
        {
            //return (this._marca==((Television)obj._marca));
            return (this == (Television)obj);
        }

        public static bool operator ==(Television television, Television television2)
        {
            return (television._marca==television2._marca && television._pulgada==television2._pulgada && television._resolucion==television2._resolucion);
        }

        public static bool operator !=(Television television, Television television2)
        {
            return !(television == television2);
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Marca: " + this._marca);
            SB.AppendLine("Pulgada: " + this._pulgada);
            SB.AppendLine("Resolucion: " + this._resolucion);

            return SB.ToString();
        }
    }
}
