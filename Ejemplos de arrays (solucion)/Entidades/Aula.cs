using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
         private int numero;
         private Alumno[] misAlumnos;

         public Aula()
         {
             misAlumnos = new Alumno[10];
         }

        /// <summary>
        /// Agrega un alumno a mi array.
        /// </summary>
        /// <param name="alumno"></param>
         public void agregarAlumno(Alumno alumno)
         {
             if (this.obtenerLugarLibre() != -1)
             {
                 this.misAlumnos[this.obtenerLugarLibre()] = alumno;
             }
             else 
             {
                 Console.WriteLine("No hay espacio.");
             }
         }

         public void borrarAlumno(Alumno alumno)
         {
             int indice = this.retornarIndiceDeObjeto(alumno);

             if (indice != -1)
             { 
                misAlumnos[indice] = null;
             }
             
         }

         /// <summary>
         /// Retorna el indice del objeto pasado por parametro.,
         /// Retorna -1 si no lo encuentra.
         /// </summary>
         /// <param name="alumno"></param>
         /// <returns>Indice o -1.</returns>
         private int retornarIndiceDeObjeto(Alumno alumno)
         {
             int retorno = -1;

             for (int i = 0; i < 10; i++)
             {
                 if (this.misAlumnos[i]!=null && alumno == this.misAlumnos.GetValue(i))
                 {
                     retorno = i;
                     break;
                 }
             }

             return retorno;
         }

         /// <summary>
         /// Obtiene el indice del primer lugar ene NULL.,
         /// Retorna -1 si no hay lugar.
         /// </summary>
         /// <returns>El indice o -1.</returns>
         public int obtenerLugarLibre()
         {
             int retorno=-1;
             int contador = 0;

             foreach (Alumno alumnoRecorrido in this.misAlumnos)
             {
                 if ((object)alumnoRecorrido == null)
                 {
                    // retorno = contador;
                    // break;
                     return contador;
                 }
                 contador++;
             }

             return retorno;
         }

    }
}
