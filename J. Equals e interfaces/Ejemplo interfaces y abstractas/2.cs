using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_interfaces_y_abstractas
{
    public abstract class _2:_1,Iguardable
    {
        //Si yo heredo una interfaz y a su vez herodo una clase que herda esa misma interfaz, puedo implementar sus metodos y propiedades, pero no es obligatorio.
        void Iguardable.Guardar()
        {
            throw new NotImplementedException();
        }
    }
}
