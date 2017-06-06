using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesArchivos
{
    public class AdministradorDeArchivos
    {
        /*
         * Declaracion de una constante.
         * Su indentificador siempre va en mayusculas para diferenciarlas facilmente de las variables.
         * Las expresiones regulares son textos que se interpretan como codigo, un ejemplo puede ser "\".
         *  -Para poder deshabilitar estas expresiones, utilizo un "\" o el "@" al principio del texto (deshabilita todas las expresiones del texto).
         */
        private const string RUTA_ARCHIVO = "C:\\Lareu\\dato.txt";

        public static void Saludar()
        {
            /*
             * Un objeto de tipo StreamWriter me permite escribir texto en un archivo.
             * Debere emplear el namespace system.IO.
             * Este archivo se guarda siempre en la misma carpeta del ejecutable, independientemente de donde este la biblioteca que lo creo (a menos que yo especifique otra ruta).
             * Este tipo de dato es necesario que lo cierre. Puedo utilizar el metodo .close() pero para evitar olvidarlo, utilizo la palabra clave using que cierra la instancia al encontrar uina llave de cierre.
             * Para pasarle la ruta en la que quiero que se guarde, en el constructor le paso como parametro un string especificandola.
             * Tambien puedo crear una constante y pasarsela.
             */
           
            try
            {
                //using (StreamWriter escritor = new StreamWriter(@"D:\Alumno\dato.txt))
                using (StreamWriter escritor = new StreamWriter(RUTA_ARCHIVO))
                {
                    escritor.WriteLine("Bienvenido");
                    escritor.Write("Este programa fue creado por: ");
                    escritor.WriteLine("Fernando Lareu");

                    //Mientras que sea texto, puedo pasarle cualquier dato, incluso los datos de una clase que fueron almacenados en un StringBuilder.
                    escritor.Write(DateTime.Now);
                }

                /*
                 * Un objeto de tipo StreamReader me permite leer texto desde un archivo.
                 * El metodo .ReadLine() devuelve un string con la linea que leyo desde el archivo.
                 * Cuando sea igual a null quiere decir que llego al final del archivo.
                 */
                using (StreamReader lector = new StreamReader(RUTA_ARCHIVO))
                {
                    string linea;

                    while ((linea = lector.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
