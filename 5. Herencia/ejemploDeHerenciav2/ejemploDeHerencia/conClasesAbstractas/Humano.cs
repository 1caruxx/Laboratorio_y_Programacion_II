using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
    //no se puede instanciar una clase abstracta.
    public abstract class Humano
    {
        protected string _nombre;

        public Humano(string nombre)
        {
            this._nombre = nombre;
        }

        public abstract void mostrar();


    }
}
