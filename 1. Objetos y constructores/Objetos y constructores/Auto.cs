using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_constructores
{
    /*
    * Tarea:
      -----------------------------
    * El fabricante cargado se genere de manera random entre las tres opciones existentes.
    * Probar que genere tres onjetos diferente
    * Utilizar la clase random
    * Con un switch puedo asignar ese numero random a un enumerado.
    * Ocurrira un error en el que siempre se genera el mismo numero puesto que toma ese numero de los ciclos de reloj y al pasar tan rapido toma el mismo numero.
    * 
    * 2) creo un atributo  publico estatico de tipo random-
    *    inicializo el objeto en el contructor estatico
    *    lo coloco en el constructor de instancia.
    */
    class Auto
    {
        private eFabricante fabricante;
        public Rueda delanteraIzquierda;
        public Rueda delanteraDerecha;
        public Rueda traseraIzquierda;
        public Rueda traseraDerecha;
        public static int contadorDeObjetos;
        public static Random numeroRandom;

        /* 
        * Los atributos privados son accesibles para su escritura (asignarle un valor) a traves de los constructores publicos y los metodos publicos.
        * Pueden ser accedidos para lectura (devolver el valor del dato) a traves de metodos publicos.
        * En este lenguaje tambien se los puede acceder para lexctura y escritura a traves de las propiedades.
        */
        private int kilometrosRecorridos;
        private Tiempo tiempoDemorado;


        /*
         * No puede tener modificador de visibilidad.
         * No se puede utilizar el operador this.
         * No puede acceder a atributos de instancia pero si estaticos.
         */
        static Auto()
        {
            contadorDeObjetos = 0;
            numeroRandom = new Random();
        }

        /* Constructores de clase. 
        * Tienen el mismo nombre que la clase
        * Pueden tener modificador de visibilidad. (Public, private etc)
        * No tienen valor de rertorno.
        * Pueden tener parametros.
        * Se ejecutan al crear una instancia de la clase (objeto).
        * Se puede y debe usar el operador this.
        * Puede acceder a los atributos de instancia.
        * Puede acceder a los atribustos estaticos.
        */
        public Auto()
        {
            this.fabricante = (eFabricante)0;
            this.fabricante = (eFabricante)numeroRandom.Next(0 , 2);
            this.delanteraIzquierda = new Rueda();
            this.delanteraDerecha = new Rueda();
            this.traseraIzquierda = new Rueda();
            this.traseraDerecha = new Rueda();

            contadorDeObjetos += 1; 
        }

        public void agregarKilometros(int cantidad)
        {
            this.kilometrosRecorridos += cantidad;
        }

        public void volverACero()
        {
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado.cantidad = 0;
        }

        public int getKMS()
        {
            return this.kilometrosRecorridos;
        }

        public void mostrarAuto()
        {
            Console.WriteLine("Fabricante: " + this.fabricante);
            Console.WriteLine("Rueda delantera izquierda: ");
            this.delanteraIzquierda.mostrarRueda();
            Console.WriteLine("Rueda delantera derecha: ");
            this.delanteraDerecha.mostrarRueda();
            Console.WriteLine("Rueda trasera izquierda: ");
            this.traseraIzquierda.mostrarRueda();
            Console.WriteLine("Rueda trasera derecha: ");
            this.traseraDerecha.mostrarRueda();
        }

        public void agregarTiempo(int cantidad)
        {
            this.tiempoDemorado.cantidad = cantidad;
        }
    }
}
