using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractas
{
    public class Auto : Vehiculo
    {
        public Auto(string fabricante, ConsoleColor color, int numeroDePatente) : base(fabricante, color, numeroDePatente)
        {
            numeroDeRuedas = 4;
        }

        public override string Mostrar()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(base.ToString());
            SB.AppendLine("Numero de ruedas: " + Auto.numeroDeRuedas);

            return SB.ToString();
        }
    }
}
