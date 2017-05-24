using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_excepciones;

namespace Entidades
{
    public class Carrera
    {
        public List<Auto> listadoAutos;
        public static Random random;

        static Carrera()
        {
            random = new Random();
        }

        public Carrera()
        {
            this.listadoAutos = new List<Auto>();
        }

        public void Correr()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    foreach (Auto item in this.listadoAutos)
                    {
                        item.Andar();
                    }
                }
                catch (MiExcepcion excepcion)
                {
                    throw new Exception(excepcion.Message + "En la vuelta numero: " + (i+1) , excepcion);
                }
            }
        }
    }
}
