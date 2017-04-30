using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        private float _peso;

        public Galletita(int codigoDeBarra, EMarcaProducto marca, float precio , float peso) : base(codigoDeBarra, marca, precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galletita)
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(Producto.MostrarProducto(galletita));
            SB.AppendLine("Peso: " + galletita._peso);

            return SB.ToString();
        }
    }
}
