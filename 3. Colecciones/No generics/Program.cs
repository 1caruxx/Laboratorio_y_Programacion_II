using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array;
            Producto producto;

            array = new ArrayList(2);
            producto = new Producto();
            array.Add(producto);
            array.Add(3);
            array.Add(12);
            array.Add(9);
            array.Add(6);
            //array.Sort();

            /*foreach (Producto item in array)
            {
                //item.mostrar(); esto genera un error al no ser todos los elementos del array de tipo producto
            }*/

            Stack pila = new Stack();
            pila.Push(1);
            pila.Pop();
            //pila.Peek();

            Queue cola = new Queue();
            cola.Enqueue(7);
            cola.Enqueue("Hola mundo");
            cola.Dequeue();
        }
    }
}
