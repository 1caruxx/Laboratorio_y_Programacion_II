using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato:Mascota
    {
        public Gato(string nombre, string raza): base(nombre , raza)
        {
        }

        protected override string Ficha()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(base.DatosCompletos());

            return SB.ToString();
        }

        public static bool operator ==(Gato gato , Gato gato2)
        {
            return (gato.nombre==gato2.nombre && gato.raza==gato2.raza);
        }

        public static bool operator !=(Gato gato, Gato gato2)
        {
            return !(gato == gato2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return ((Gato)obj == this);
        }
    }
}
