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
                Program.DeserializarPersonaXML();
                Program.DeserializarPersonaBinaria();
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
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

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

        static void DeserializarPersonaXML()
        {
            Persona persona = new Persona();
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            try
            {
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

        //binario guarda el objeto que esta almacenado en memoria, puedo guardarlo

        static void DeserializarPersonaBinaria()
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

        static void SerializarPersonaBinaria()
        {
            
            IFormatter formateador = new BinaryFormatter();

            try
            {
                using (Stream archivo = new FileStream("Persona.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Persona persona =(Persona)formateador.Deserialize(archivo);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

