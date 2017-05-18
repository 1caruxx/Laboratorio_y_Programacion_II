using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractas
{
    public abstract class Moto : Vehiculo
    {
        public Moto(string fabricante, ConsoleColor color, int numeroDePatente) : base(fabricante, color, numeroDePatente)
        {
            numeroDeRuedas = 2;
        }

        public abstract void Traer();

    }
}
