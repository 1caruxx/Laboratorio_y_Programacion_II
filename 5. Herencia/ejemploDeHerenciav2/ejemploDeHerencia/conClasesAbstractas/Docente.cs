using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
    public class Docente:Empleado
    {
        public Empleado(String nombre): base(nombre)
        {
        }

        //Se implementara con el get, set o ambos segun como lo haya definido yo en mi clase abstracta
        public override float sueldo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //Si la clase empleado implementa este metodo, no es obligatorio que lo haga en esta clase.
        public override void mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
