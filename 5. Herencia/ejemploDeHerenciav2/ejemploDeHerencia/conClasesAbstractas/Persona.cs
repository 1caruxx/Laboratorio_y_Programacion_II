using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
    public class Persona:Humano
    {
        protected string _dni;

        //Los metodos abstractos, solo van en clases abstractas
        //public abstract void mostrar();
        public override void mostrar()
        {
            throw new NotImplementedException();
        }

        public Persona(string nombre, string dni): base(nombre)
        {
            this._dni = dni;
        }
    }
}
