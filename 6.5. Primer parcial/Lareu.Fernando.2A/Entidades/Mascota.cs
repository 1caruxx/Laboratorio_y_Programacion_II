using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        public string nombre
        {
            get { return this._nombre; }
        }

        private string _raza;
        public string raza
        {
            get { return this._raza; }
        }

        public Mascota(string nombre , string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(string.Format("Nombre: " + this._nombre));
            SB.Append(string.Format(" Raza: " + this._raza));

            return SB.ToString();
        }
    }
}
