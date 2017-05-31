using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _marca;
        private int _patente;
        private ConsoleColor _color;

        public Auto(string marca, int patente, ConsoleColor color)
        {
            this._marca = marca;
            this._patente = patente;
            this._color = color;
        }

        public override bool Equals(object obj)
        {
            //return (this._marca==((Auto)obj._marca));
            return (this == (Auto)obj);
        }

        public static bool operator ==(Auto auto, Auto auto2)
        {
            return (auto._marca == auto2._marca && auto._patente == auto2._patente && auto._color == auto2._color);
        }

        public static bool operator !=(Auto auto, Auto auto2)
        {
            return !(auto == auto2);
        }
    }
}
