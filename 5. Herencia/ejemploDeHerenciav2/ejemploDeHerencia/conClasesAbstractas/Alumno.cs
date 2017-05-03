using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
    public class Alumno:Persona
    {
        private int _legajo;

         public Alumno(string nombre, string dni , int legajo): base(nombre , dni)
         {
            this._legajo = legajo;
         }

         public override void mostrar()// Puedo implementar o no un metodo de la clase abstracta que ya fue implementado por la clase base de esta clase.
         {
             base.mostrar();
         }
    }
}
