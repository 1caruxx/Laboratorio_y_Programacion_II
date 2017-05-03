using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
    public abstract class Empleado:Humano
    {
        public abstract float sueldo
        {
            get;
            set;
        }

        public Empleado(String nombre): base(nombre)
        {
        }

        //Se puede implementar pero no es obligatorio.
        /*public override void mostrar()
        {
            throw new NotImplementedException();
        }*/
    }
}
