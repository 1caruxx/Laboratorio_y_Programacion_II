using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_constructores
{
    public class Carrera
    {
        private Auto auto;
        private Auto auto2;
        private Auto auto3;
        private Auto auto4;
        private Auto auto5;
        private Auto auto6;
        private Kilometro kilometrosRecorridos;
        private Tiempo tiempoTranscurrido;

        public Carrera()
        {
            auto = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();
            auto6 = new Auto();
        }

        public void mostrarCarrera()
        {
            Console.WriteLine("Auto 1:\nMarca de rueda: {0}\nTamaño de rueda: {1}\nKilometros recorridos: {2}", this.auto.delanteraDerecha.marca);
        }

        /* Se recibe un entero que representa la cantidad de iteraciones que se realizaran asignandole a cada auto una cantidad de kilometros random.
        * Al terminar las iteraciones, mostrar que auto recorrio màs y gano la carrera.
        */
        public void porTiempo(int minutos)
        {
            int contador;
            Random kilometros;

            kilometros = new Random();

            for(contador=0;contador<minutos;contador++)
            {
                this.auto.agregarKilometros(kilometros.Next(0 , 101));
                this.auto2.agregarKilometros(kilometros.Next(0 , 101));
                this.auto3.agregarKilometros(kilometros.Next(0 , 101));
                this.auto4.agregarKilometros(kilometros.Next(0 , 101));
                this.auto5.agregarKilometros(kilometros.Next(0 , 101));
                this.auto6.agregarKilometros(kilometros.Next(0 , 101));
            }

            if(this.auto.getKMS()>this.auto2.getKMS() && this.auto.getKMS() > this.auto3.getKMS() && this.auto.getKMS() > this.auto4.getKMS() && this.auto.getKMS() > this.auto5.getKMS() && this.auto.getKMS() > this.auto6.getKMS())
            {
                Console.WriteLine("El ganador es el auto 1.");
            }
        }

        public void correrCarrera(Tiempo tiempo)
        {
            int contador;
            Random kilometros = new Random();

            for(contador=0;contador<tiempo.cantidad;contador++)
            {
                this.auto.agregarKilometros(kilometros.Next(10, 101));
                this.auto2.agregarKilometros(kilometros.Next(10, 101));
                this.auto3.agregarKilometros(kilometros.Next(10, 101));
                this.auto4.agregarKilometros(kilometros.Next(10, 101));
                this.auto5.agregarKilometros(kilometros.Next(10, 101));
                this.auto6.agregarKilometros(kilometros.Next(10, 101));
            }
        }

        public void correrCarrera(Kilometro kilometros)
        {
            int contador;
            Random tiempo = new Random();

            for (contador = 0; contador < kilometros.cantidad; contador++)
            {
                this.auto.agregarTiempo(tiempo.Next(10, 101));
                this.auto2.agregarTiempo(tiempo.Next(10, 101));
                this.auto3.agregarTiempo(tiempo.Next(10, 101));
                this.auto4.agregarTiempo(tiempo.Next(10, 101));
                this.auto5.agregarTiempo(tiempo.Next(10, 101));
                this.auto6.agregarTiempo(tiempo.Next(10, 101));
            }
        }

    }
}
