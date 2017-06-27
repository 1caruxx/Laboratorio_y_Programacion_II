using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude (typeof(Automovil)), XmlInclude(typeof(Motocicleta))]
    public abstract class Vehiculo
    {
        private int _patente;
        private string _nombreDelDuenio;
        private string _apellidoDelDuenio;
        private eMarca _marca;

        #region Constructores

        public Vehiculo()
        {
            this._apellidoDelDuenio = "Sin asignar";
            this._nombreDelDuenio = "Sin asignar";
        }

        public Vehiculo(int patente):this()
        {
            this._patente = patente;
        }

        public Vehiculo(int patente, string nombre, string apellido):this(patente)
        {
            this._nombreDelDuenio = nombre;
            this._apellidoDelDuenio = apellido;
        }

        public Vehiculo(int patente, string nombre, string apellido, eMarca marca):this(patente, nombre, apellido)
        {
            this._marca = marca;
        }

        #endregion

        #region Metodos

        protected abstract string Datos();

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("Apellido y nombre del duenio: " + this._apellidoDelDuenio);
            SB.AppendLine(", " + this._nombreDelDuenio);
            SB.AppendLine("Patente: " + this._patente);
            SB.AppendLine("Marca: " +this._marca);

            return SB.ToString();
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return (vehiculo.Equals(vehiculo2) && vehiculo._patente==vehiculo2._patente);
        }

        public static bool operator !=(Vehiculo vehiculo, Vehiculo vehiculo2)
        {
            return !(vehiculo == vehiculo2);
        }

        #endregion
    }
}
