using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        
        public int contador = 0;
        public int maximo = 0;
        static Random kilometros;

       /* static Carrera()
        {
            kilometros = new Random();
        }
        */ // no es necesario ya que puedo instanciarlo en el metodo
        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
        }

        /* Se recibe un entero que representa la cantidad de iteraciones que se realizaran asignandole a cada auto una cantidad de kilometros random.
         * Al terminar las iteraciones, mostrar que auto recorrio màs y gano la carrera.
        */

        public void porTiempo(int minutos)
        {

            Random kmRandom = new Random();
            for(contador=0 ; contador<minutos ; contador++)
            {
                this.auto1.agregarKilometros(kmRandom.Next(0 , 100));
                this.auto2.agregarKilometros(kilometros.Next(0 , 100));
                this.auto3.agregarKilometros(kilometros.Next(0 , 100));
                this.auto4.agregarKilometros(kilometros.Next(0 , 100));
                this.auto5.agregarKilometros(kilometros.Next(0 , 100));
                this.auto6.agregarKilometros(kilometros.Next(0 , 100));
            }

            /*Terminar con if y elses*/
        }

    }
}
