using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Container<T>:IEnumerable<T>
    {
        private List<T> _elementos;
        private int _cantidadMaxima;

        public Container(int cantidadMaxima)
        {
            this._elementos = new List<T>();
            this._cantidadMaxima = cantidadMaxima;
        }

        private bool EstaLleno()
        {
            return (this._elementos.Count == this._cantidadMaxima); 
        }

        private bool EstaElElemento(T objeto)
        {
            foreach (T item in this._elementos)
            {
                if (item.Equals(objeto))
                {
                    return true;
                } 
            }

            return false;
        }

        public bool Agregar(T objeto)
        {
            /*if (!(this.EstaLleno()))
            {
                return true;
            }*/

            this._elementos.Add(objeto);
            return true;
        }

        public static bool operator +(Container<T> deposito, T objeto)
        {
            if (!(deposito.EstaLleno()) && !(deposito.EstaElElemento(objeto)))
            {
                deposito.Agregar(objeto);
                return true;
            }
           
           return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            /*foreach (T item in this._elementos)
            {
                yield return item;
            }
             */
            return this._elementos.GetEnumerator();

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}
