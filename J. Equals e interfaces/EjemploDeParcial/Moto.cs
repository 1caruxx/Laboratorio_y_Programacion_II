using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int _cilindrada;

        public Moto(string patente/* , DateTime fechaDeIngreso ,*/, int cilindrada): base(patente/* , fechaDeIngreso*/)
        {
            this._cilindrada = cilindrada;
        }

        //El metodo equals se pregunta si el objeto pasado por parametro es del mismo tipo que la instancia de la cual es invocado.
        public override bool Equals(object obj)
        {
            return (obj is Moto);
        }

        /*public override DateTime fechaDeIngreso
        {
            get { return this._fechaDeIngreso; }
        }*/
    }
}
