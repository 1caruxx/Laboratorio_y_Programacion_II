using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro:Mascota
    {
        private int _edad;
        public int edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        private bool _esAlfa;
        public bool esAlfa
        {
            get { return this._esAlfa; }
            set { this._esAlfa = value; }
        }

        public Perro(string nombre, string raza): base(nombre , raza)
        {
            this._edad = 0;
            this._esAlfa = false;
        }

        public Perro(string nombre, string raza , int edad , bool esAlfa) : base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(base.DatosCompletos());
            if(this._esAlfa)
            {
                SB.Append(" Alfa de la manada, ");
            }
            SB.Append(string.Format("Edad: " + this._edad));

            return SB.ToString();
        }

        public static bool operator ==(Perro perro , Perro perro2)
        {
            return (perro.nombre==perro2.nombre && perro.raza==perro2.raza && perro._edad==perro2._edad);
        }

        public static bool operator !=(Perro perro, Perro perro2)
        {
            return !(perro == perro2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro._edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return ((Perro)obj == this);
        }
    }
}
