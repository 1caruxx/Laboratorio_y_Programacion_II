using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDeAbstractas
{
    public class Camion:Vehiculo
    {
        public Camion(string fabricante, ConsoleColor color, int numeroDePatente): base(fabricante, color, numeroDePatente)
        {
        }

        public override string Mostrar()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(base.ToString());
            SB.AppendLine("Numero de ruedas: " + Camion.numeroDeRuedas);

            return SB.ToString();
        }
    }
}
