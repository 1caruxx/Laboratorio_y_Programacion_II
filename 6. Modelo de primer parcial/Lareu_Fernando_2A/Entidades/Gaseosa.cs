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

        public Gaseosa(int codigoDeBarra, EMarcaProducto marca, float precio , float litros) : base(codigoDeBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto , float litros):this((int)producto , producto.marca , producto.precio , litros)
        {
            /*this._codigoDeBarra = (int)producto;
            this._marca = producto.marca;
            this._precio = producto.precio;
            this._litros = litros;*/
        }

        public string MostrarGaseosa()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(Producto.MostrarProducto(this));
            SB.AppendLine("Litros: " + this._litros);

            return SB.ToString();
        }
    }
}
