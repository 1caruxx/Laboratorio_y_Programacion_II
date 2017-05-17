using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bicicleta:Iimprimible,Iguardable
    {

        string Iimprimible.dameElTicket()
        {
            throw new NotImplementedException();
        }

        void Iimprimible.MostrarPago()
        {
            throw new NotImplementedException();
        }

        void Iguardable.MostrarPago()
        {
            throw new NotImplementedException();
        }
    }
}
