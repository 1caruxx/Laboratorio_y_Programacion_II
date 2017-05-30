using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClasesAbstractas
{
   public sealed class  AlumnoEgresado:Alumno
    {
        protected DateTime _fechaDeEgreso; //Utilizar el modificador de visivilidad "protected" en una clase sellada da por resultado un warning.

        public AlumnoEgresado(string nombre, string dni, int legajo , DateTime fechaDeEgreso):base(nombre , dni , legajo)
        {
            this._fechaDeEgreso = fechaDeEgreso;
        }
    }
}
