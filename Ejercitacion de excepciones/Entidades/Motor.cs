using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_excepciones;

namespace Entidades
{
    public class Motor
    {
        public string marca;

        public Motor()
        {
            marca = "Sin marca";
        }

        public Motor(string marca)
        {
            this.marca = marca;
        }

        public void Fallar()
        {
            int numero = Carrera.random.Next(1, 10);

            if (numero == 7)
            {
                throw new MotorExcepcion("Problema: El motor a fallado. Marca: " + this.marca + "\n");
            }
        }
    }
}
