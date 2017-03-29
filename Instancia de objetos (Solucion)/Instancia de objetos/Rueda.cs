using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class Rueda
    {
        private string marca;
        private int tamanio;

        public Rueda()
        {
           this.marca = "sin marca";
           this.tamanio = 0;
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }
       
        public Rueda(int tamanio):this()
        {
            this.tamanio = tamanio;
        }

        public Rueda(int tamanio, string marca):this(tamanio)
        {
            this.marca = marca;
        }
        
        public void mostrarRueda()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.tamanio);
        }



    }
}
