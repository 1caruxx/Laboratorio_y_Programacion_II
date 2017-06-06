using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using EntidadesArchivos;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program.Saludar();
                AdministradorDeArchivos.Saludar();
                Program.SerializarPersonaXML();
                Program.DesSerializarPersonaXML();
                Program.SerializarPersonaBinaria();
                Program.DesSerializarPersonaBinaria();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para finalizar...");
                Console.ReadKey();
            }
        }

        static void Saludar()
        {
            using (StreamWriter escritor = new StreamWriter("datosprogram.txt"))
            {
                escritor.Write("hola");
            }
        }

        static void SerializarPersonaXML()
        {
            Persona persona = new Persona();

            /*
             * El tipo de dato XmlSerializer posee los metodos necesario para serializar o desserializar un objeto, es decir, traducir sus datos a lenguaje XML.
             * En su constructor le pasare como parametro el tipo de el objeto que quiero serializar.
             * Finalmente a traves del metodo .Serialize() serializare la informacion que contenga mi objeto, es decir, la traducire al lenguaje XML.
             *      - Para ello, le pasare como parametros la instanciacion de mi escritor y de mi objeto.
             * De esta forma guardo en un archivo la informacion de mi objeto traducida al lenguaje XML.
             * Si los atributos de mi objeto no son publicos, no podre verlos en el archivo fisico.
             */
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            persona.apellido = "Gomez";
            persona.nombre = "Franco";

            try
            {
                using (StreamWriter escritor = new StreamWriter("Persona.xml"))
                {
                    serializador.Serialize(escritor, persona);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        static void DesSerializarPersonaXML()
        {
            Persona persona = new Persona();
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            try
            {
                /*
                 * Para desserializar un archivo XML, el procedimiento es muy similar, con la diferencia que utilizare el metodo .Deserialize().
                 *      Debere pasarle como paramero la instanciacion de mi lector.
                 *      Debere castearlo al tipo de objeto al cual lo asignare, ya que este metodo retorna un objeto del tipo Object.
                 */
                using (StreamReader lector = new StreamReader("Persona.xml"))
                {
                    persona= (Persona)serializador.Deserialize(lector);
                    Console.WriteLine(persona.apellido);
                    Console.WriteLine(persona.nombre);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         * Cuando guardo en formato binario, guardo el propio objeto que esta almacenado en memoria.
         * Debere utilizar los siguientes namespaces ya que es necesario emplear la interfaz IFormatter y el tipo de dato BinaryFormatter: 
         *      System.Runtime.Serialization
         *      System.Runtime.Serialization.Formatters.Binary
         * La extencion de estos archivos sera .bin (la mas usada) o .dat para reconocer que es un archivo binario.
         * En lugar de instanciar un escritor, simplemente declarare un Stream al que le asignare un FileStream.
         * Dentro del constructor de este FileStream le pasare como parametros:
         *      1) La ruta en donde se debera crear mi archivo mi archivo.
         *      2) El modo del archivo (si quiero crearlo, abrirlo, aniadirle informacion, crear uno nuevo sin reemplazar, crear o abrir).
         *      3) El modo de accesos (Lectura, escritura o ambas (si serializo sera escritura)).
         *      4) El FileShare.
         * La diferencia entre guardar un archivo de texto con formato XML y uno binario es que los atributos privados en el archivo fisico XML no los vere. Un archivo binario en cambio es imposible de leer a simple vista, pero los atributos privados estaran expuestos.
         */
        
        static void SerializarPersonaBinaria()
        {
            
            Persona persona = new Persona();
            IFormatter formateador = new BinaryFormatter();

            persona.apellido = "Lopez";
            persona.nombre = "Natalia";

            try
            {
                using(Stream archivo = new FileStream("Persona.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formateador.Serialize(archivo, persona);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         * El proceso para la deserializacion de un archivo binario es muy similar, pero los parametros que le paso al constructor del FileStream difieren
         *      1) El modo del archivo sera de apertura ya que el archivo debe existir si yo quiero desserializarlo.
         *      2) Su acceso sera de lectura asi como ttambien el FileShare.
         * Debo castearlo e instanciarlo en un objeto al igual que se hacia con la desserializacion de archivos XML.
         */
        static void DesSerializarPersonaBinaria()
        {
            IFormatter formateador = new BinaryFormatter();
            
            try
            {
                using (Stream archivo = new FileStream("Persona.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Persona persona =(Persona)formateador.Deserialize(archivo);

                    Console.WriteLine("Desserializacion Binaria:");
                    Console.WriteLine(persona.nombre);
                    Console.WriteLine(persona.apellido);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

