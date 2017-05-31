using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mueble
    {
        private int _tamanio;
        private string _material;
        private double _peso;

        public Mueble(int tamanio , string material , double peso)
        {
            this._material = material;
            this._peso = peso;
            this._tamanio = tamanio;
        }

        public override bool Equals(object obj)
        {
            //return (this._marca==((Mueble)obj._marca));
            return (this == (Mueble)obj);
        }

        public static bool operator ==(Mueble mueble, Mueble mueble2)
        {
            return (mueble._tamanio == mueble2._tamanio && mueble._material == mueble2._material && mueble._peso == mueble2._peso);
        }

        public static bool operator !=(Mueble mueble, Mueble mueble2)
        {
            return !(mueble == mueble2);
        }
    }
}
