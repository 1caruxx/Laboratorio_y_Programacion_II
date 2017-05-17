using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_interfaces_y_abstractas
{
    public class _4:_1,Iimprimible,Imostrable
    {
        /*Solo puedo implementar los metodos y propiedades de las interfaces que este heredandon directamente.
         * Una clase padre hereda de la interfaz Iguardable, sin embargo no puedo implementar sus metodos o propiedades ya que esta clase no hereda esa interfaz
        */
        /*
        void Iguardable.Guardar()
        {
            throw new NotImplementedException();
        }*/

        //Forma explicita de implementar los metodos.
        void Iimprimible.Imprimir()
        {
            throw new NotImplementedException();
        }

        void Iimprimible.MetodoConElMismoNombre()
        {
            throw new NotImplementedException();
        }

        void Imostrable.Mostrar()
        {
            throw new NotImplementedException();
        }

        void Imostrable.MetodoConElMismoNombre()
        {
            throw new NotImplementedException();
        }

        //Forma implicita de implementar los metodos.
      /*public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public void MetodoConElMismoNombre()
        {
            throw new NotImplementedException();
        }

        public void Mostrar()
        {
            throw new NotImplementedException();
        }*/
        
    }
}
