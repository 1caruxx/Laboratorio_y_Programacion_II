﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int _codigoBarra;
        
        protected EMarcaProducto _marca;
        public EMarcaProducto marca
        {
            get { return this._marca; }
        }

        protected float _precio;
        public float precio
        {
            get { return this._precio; }
        }

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        protected static string MostrarProducto(Producto producto)
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Marca: " + producto._marca);
            SB.AppendLine("Precio: " + producto._precio);
            SB.AppendLine("Codigo de barra: " + producto._codigoBarra);

            return SB.ToString();
        }

        public static bool operator ==(Producto producto, Producto producto2)
        {
            return (producto._marca==producto2._marca && producto._codigoBarra==producto2._codigoBarra);
        }

        public static bool operator !=(Producto producto, Producto producto2)
        {
            return !(producto == producto2);
        }

        public static bool operator ==(Producto producto, EMarcaProducto marca)
        {
            return (producto._marca == marca);
        }

        public static bool operator !=(Producto producto, EMarcaProducto marca)
        {
            return !(producto == marca);
        }

        public static explicit operator int(Producto producto)
        {
            return producto._codigoBarra;
        }
    }
}
