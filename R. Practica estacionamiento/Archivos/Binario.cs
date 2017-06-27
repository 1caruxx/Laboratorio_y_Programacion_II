using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Archivos
{
    public class Binario<T> : iArchivos<T>
    {
        public bool Cargar(out T objeto, string ruta)
        {
            IFormatter desserializador = new BinaryFormatter();

            try
            {
                using (Stream escritor = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    objeto = (T)desserializador.Deserialize(escritor);
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
            IFormatter serializador = new BinaryFormatter();

            try
            {
                using (Stream escritor = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None))
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
