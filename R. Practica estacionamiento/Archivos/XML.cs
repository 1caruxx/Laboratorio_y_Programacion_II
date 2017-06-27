using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Xml.Serialization;
using System.IO;

namespace Archivos
{
    public class XML<T> : iArchivos<T>
    {
        public bool Cargar(out T objeto, string ruta)
        {
            XmlSerializer desSerializador = new XmlSerializer(typeof(T));

            try
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    objeto = (T)desSerializador.Deserialize(lector);
                }
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }

            return true;
        }

        public bool Guardar(T objeto, string ruta)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta))
                {
                    serializador.Serialize(escritor, objeto);
                }
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }

            return true;
        }
    }
}
