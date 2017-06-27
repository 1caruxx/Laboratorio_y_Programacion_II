using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoExisteElVehiculoException : Exception
    {
        public NoExisteElVehiculoException(string message) : base(message) { } 
    }
}
