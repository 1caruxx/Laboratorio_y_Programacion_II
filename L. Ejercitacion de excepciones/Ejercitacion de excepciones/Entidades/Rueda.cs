using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_excepciones;

namespace Entidades
{
    public class Rueda
    {
        public string marca;
        public ERueda posicion;

        public Rueda()
        {
            this.marca = "Sin marca";
        }

        public Rueda(string marca, ERueda posicion)
        {
            this.marca = marca;
            this.posicion = posicion;
        }

        public void Pinchar()
        {
            int numero = Carrera.random.Next(1 , 10);

            if (numero == 7)
            {
                throw new RuedaExcepcion("Problema: La rueda se ha pinchado. Marca: " + this.marca + "\n", this.posicion);
            }
        }
    }
}
