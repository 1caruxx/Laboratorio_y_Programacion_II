using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_constructores
{
    class Rueda
    {
        public string marca;
        public int tamaño;

        /// <summary>
        /// Constructor por defecto que inicializa el atributo marca con 'sin marca'.
        /// </summary>
        public Rueda()
        {
            this.marca = "Sin marca";
        }

        /// <summary>
        /// Constructor que inicializa el atributo marca con el string que se le pasa por parametro.
        /// </summary>
        /// <param name="marca">Marca de la rueda.</param>
        public Rueda(string marca)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Constructor que inicializa el atributo tamaño con el int que se le pasa por parametro.
        /// </summary>
        /// <param name="tamaño">Tamaño de la rueda.</param>
        public Rueda(int tamaño) :this()
        {
            this.tamaño = tamaño;
        }

        public Rueda(string marca , int tamaño):this(tamaño)
        {
            this.marca = marca;
        }

        public Rueda(int tamaño , string marca):this(marca , tamaño)
        {
        }

        public void mostrarRueda()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.tamaño);
        }
    }
}
