using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        private ESaborJugo _sabor;

        public Jugo(int codigoDeBarra, EMarcaProducto marca, float precio , ESaborJugo sabor):base(codigoDeBarra , marca , precio)
        {
            this._sabor = sabor;
        }

        public string MostrarJugo()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(Producto.MostrarProducto(this));
            SB.AppendLine("Sabor: " + this._sabor);

            return SB.ToString();
        }
    }
}
