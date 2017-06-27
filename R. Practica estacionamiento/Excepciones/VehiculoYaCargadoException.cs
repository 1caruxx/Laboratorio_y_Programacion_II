using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class VehiculoYaCargadoException:Exception
    {
        private static string _mensajeBase = "El vehiculo ya ha sido cargado en el estacionamiento.";

        public VehiculoYaCargadoException(): base(VehiculoYaCargadoException._mensajeBase) { }
    }
}
