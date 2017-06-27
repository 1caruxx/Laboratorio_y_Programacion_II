using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Automovil : Vehiculo
    {
        private ConsoleColor _color;

        #region Constructores

        public Automovil() : base() { }
        public Automovil(int patente) : base(patente){ }
        public Automovil(int patente, string nombre, string apellido) : base(patente, nombre, apellido) { }
        public Automovil(int patente, string nombre, string apellido, eMarca marca) : base(patente, nombre, apellido, marca) { }
        public Automovil(int patente, string nombre, string apellido, eMarca marca, ConsoleColor color) : base(patente, nombre, apellido, marca)
        {
            this._color = color;
        }

        #endregion

        #region Metodos

        protected override string Datos()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Tipo de vehiculo: Automovil");
            SB.AppendLine(base.ToString());
            SB.AppendLine("Color: " + this._color);
            SB.AppendLine("=======================================");

            return SB.ToString();
        }

        public override string ToString()
        {
            return this.Datos();
        }

        public override bool Equals(object obj)
        {
            return (obj is Automovil);
        }

        #endregion

        public static explicit operator Automovil(int patente)
        {
            return new Automovil(patente);
        }
    }
}
