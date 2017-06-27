using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Archivos
{
    public class Texto : iArchivos<string>
    {
        public bool Cargar(out string objeto, string ruta)
        {
            StringBuilder SB = new StringBuilder();
            string linea;

            try
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    while ((linea = lector.ReadLine()) != null)
                    {
                        SB.AppendLine(linea);
                    }

                    objeto = SB.ToString();
                }
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }

            return true;
        }

        public bool Guardar(string objeto, string ruta)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta))
                {
                    escritor.WriteLine(objeto);
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
