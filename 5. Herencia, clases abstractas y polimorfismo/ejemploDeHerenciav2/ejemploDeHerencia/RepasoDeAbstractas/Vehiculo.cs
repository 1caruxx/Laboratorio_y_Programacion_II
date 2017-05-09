using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Lo que va en el parcial: 
 * Clases abstractas.
 * Metodos abstractos.
 * Metodos virtualos .
 * Metodo ToString() y su override.
 * Operadores ==, + -.
 * Conversion implicita o explicita.
 */

namespace RepasoDeAbstractas
{
    public abstract class Vehiculo
    {
        protected string _fabricante;
        protected ConsoleColor _color;
        protected int _numeroDePatente;
        protected static int numeroDeRuedas;

        public Vehiculo(string fabricante , ConsoleColor color , int numeroDePatente)
        {
            this._fabricante = fabricante;
            this._color = color;
            this._numeroDePatente = numeroDePatente;
        }

        public abstract string Mostrar();

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Fabricante: " + this._fabricante);
            SB.AppendLine("Color: " + this._color);
            SB.AppendLine("Numero de patente: " + this._numeroDePatente);

            return SB.ToString();
        }
    }
}
