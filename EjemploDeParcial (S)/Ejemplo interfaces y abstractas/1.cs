using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_interfaces_y_abstractas
{
    public abstract class _1:Iguardable
    {
        //Si yo heredo una interfaz estoy obligado a implementar sus metodos y propiedades.
        void Iguardable.Guardar()
        {
            throw new NotImplementedException();
        }

        public virtual void MetodoA()
        {
            Console.WriteLine("Se ha ejecutado el metodo A.");
        }

        public virtual void MetodoB()
        {
            Console.WriteLine("Se ha ejecutado el metodo B.");
        }
    }
}
