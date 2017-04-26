using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        private float _litros;

        public Gaseosa(int codigoBarra, EMarcaProducto marca, float precio , float litros):base(codigoBarra ,  marca ,  precio)
        {
            this._litros = litros;
        }

        /*public Gaseosa(Producto producto, float litros): base(producto._codigoBarra)
        {
            this._litros = litros;
        }*/

        public string MostrarGaseosa()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(Producto.MostrarProducto(this));
            SB.AppendLine("Litros: " + this._litros);

            return SB.ToString();
        }
    }
}
