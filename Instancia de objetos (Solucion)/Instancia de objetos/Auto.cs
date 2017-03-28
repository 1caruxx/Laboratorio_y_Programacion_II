using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
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
        Rueda dd;
        Rueda di;
        Rueda ti;
        Rueda td;
         static int CanrtidaDeInstancias;
         eFabricante fabricante;

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
            this.dd = new Rueda();
            this.di = new Rueda();
            this.ti = new Rueda();
            this.td = new Rueda();
            Auto.CanrtidaDeInstancias++;
            this.fabricante = (eFabricante)0;
        }

        /*
         * No puede tener modificador de visibilidad.
         * No se puede utilizar el operador this.
         * No puede acceder a atributos de instancia pero si estaticos.
         */
        static Auto()
        {
            Auto.CanrtidaDeInstancias = 0;
        }
        
    }
}
