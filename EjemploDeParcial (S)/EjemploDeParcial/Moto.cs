using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int _cilindrada;

        public Moto(string patente, int cilindrada): base(patente)
        {
            this._cilindrada = cilindrada;
        }
    }
}
