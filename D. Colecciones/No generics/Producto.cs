using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_generics
{
    public class Producto
    {
        public int codigo;
        public string descripcion;

        public Producto()
        {
            this.codigo = 0;
            this.descripcion = "Sin descripcion";
        }

        public Producto(string descripcion)
        {
            this.codigo = 0;
            this.descripcion = descripcion;
        }

        public void mostrar()
        {
            Console.WriteLine(this.descripcion);
            Console.WriteLine(this.codigo);
        }
    }
}
