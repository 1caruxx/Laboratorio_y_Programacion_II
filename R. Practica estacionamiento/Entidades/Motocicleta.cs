using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Motocicleta : Vehiculo
    {
        private bool _esCilindrada;

        #region Constructores

        public Motocicleta() : base() { }
        public Motocicleta(int patente) : base(patente){ }
        public Motocicleta(int patente, string nombre, string apellido) : base(patente, nombre, apellido) { }
        public Motocicleta(int patente, string nombre, string apellido, eMarca marca) : base(patente, nombre, apellido, marca) { }
        public Motocicleta(int patente, string nombre, string apellido, eMarca marca, bool esCilindrada) : base(patente, nombre, apellido, marca)
        {
            this._esCilindrada = esCilindrada;
        }

        #endregion

        #region Metodos

        protected override string Datos()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Tipo de vehiculo: Motocicleta");
            SB.AppendLine(base.ToString());

            if(this._esCilindrada)
            {
                SB.AppendLine("La moto es cilindrada.");
            }
            else
            {
                SB.AppendLine("La moto no es cilindrada.");
            }

            SB.AppendLine("=======================================");

            return SB.ToString();
        }

        public override string ToString()
        {
            return this.Datos();
        }

        public override bool Equals(object obj)
        {
            return (obj is Motocicleta);
        }

        #endregion

        public static explicit operator Motocicleta(int patente)
        {
            return new Motocicleta(patente);
        }
    }
}
