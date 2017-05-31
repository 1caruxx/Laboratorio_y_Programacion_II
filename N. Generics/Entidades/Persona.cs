using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private int _DNI;

        public Persona(int DNI , string nombre)
        {
            this._DNI = DNI;
            this._nombre = nombre;
        }

        public override bool Equals(object obj)
        {
            //return (this._marca==((Persona)obj._marca));
            return (this == (Persona)obj);
        }

        public static bool operator ==(Persona persona, Persona persona2)
        {
            return (persona._nombre == persona2._nombre && persona._DNI == persona2._DNI);
        }

        public static bool operator !=(Persona persona, Persona persona2)
        {
            return !(persona == persona2);
        }
    }
}
