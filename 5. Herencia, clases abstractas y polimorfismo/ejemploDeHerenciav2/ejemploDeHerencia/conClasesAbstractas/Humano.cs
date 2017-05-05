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

        //La terminacion de los metodos abstractos es el punto y coma (;) y no tienen implementacion en la clase abstracta, sin embargo, puedo crear metodos que no sean abstractos en una clase abstracta y que si tengan una implementacion.
        public abstract void mostrar();
    }
}
