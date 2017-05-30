using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_generics;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeEnteros = new List<int>();
            List <string> listaDeStrings = new List<string>();
            List<Producto> ListaDeProductos = new List<Producto>();
            Stack<Producto> ListaDeProductosCola = new Stack<Producto>();
            int contador;

            listaDeEnteros.Add(5);
            listaDeStrings.Add("Hola mundo");

            for (contador = 0; contador < 5; contador++)
            {
                ListaDeProductos.Add(new Producto("Galleta"));
            }

            for (contador = 0; contador < 5; contador++)
            {
                ListaDeProductosCola.Push(new Producto("Chocolate"));
            }

            foreach (Producto item in ListaDeProductosCola)
            {
               item.mostrar();
            }
        }
    }
}
