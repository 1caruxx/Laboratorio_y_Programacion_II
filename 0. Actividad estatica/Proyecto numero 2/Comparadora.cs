using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_numero_2
{
    class Comparadora
    {    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static int retornarMayor(int numero1 , int numero2)
        {
            int retorno=0;

            if (numero1 > numero2)
            {
                retorno = numero1;
            }

            else
            {
                retorno = numero2;
            }

            return retorno;
        }
        /// <summary>
        /// Esto tiene que retornar el valor del medio
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="numero3"></param>
        /// <returns></returns>
        public static int mostrarElDelMedio(int numero1, int numero2 , int numero3)
        {
            int retorno = numero2;

            /*if (numero1 > numero2)
            {
                retorno = numero1;
            }

            else
            {
                retorno = numero2;
            }*/

            return retorno;
        }
    }
}
