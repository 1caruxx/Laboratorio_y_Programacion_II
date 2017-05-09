using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Facultad
    {
        static int _numero;
        private int _numeroInstancia;

        //Solo puede ver atributos de tipo estatico, no recibe parametros. No puedo utilizar el this.
        public Facultad()
        {
            _numero = 22;
        }

        //Si puede ver atributos estaticos, pero no se deben utilizar el this en ellos.
        static Facultad()
        {
            _numero = 33;
        }

        /*Static: Todos los operadores son static.
         * Especifico si es explicit o implicit.
         * La palabra operator seguida del tipo de dato que retorna.
         * Siempre deben recibir un parametro
         */
        public static implicit operator int(Facultad facultad) 
        {
            return 0;
        }

        /*No puedo usar el this en un metodo estatico
         * Utilizo el objeto que me pasan por parametro.
         * El objeto que me pasan por parametro al ser una instancia de la clase, no podra ver atributos estaticos.
         */
        public static void Mostrar(Facultad aux)
        {
            Console.WriteLine("El numero es: " + /*this.*/aux._numeroInstancia);
        }
    }
}