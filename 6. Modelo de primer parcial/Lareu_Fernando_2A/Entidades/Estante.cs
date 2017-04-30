using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get
            {
                float total=0;

                foreach (Producto item in this._productos)
                {
                    total += item.precio;
                }

                return total;
            }
        }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        private Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        /*public static string MostrarEstante(Estante estante)
        {
            StringBuilder SB = new StringBuilder();

            foreach (Producto item in estante._productos)
            {
                if(item is Producto)
                {
                    SB.AppendLine(((Producto)item).);
                }
            }

            return "equisde";
        }*/

        public static bool operator ==(Estante estante , Producto producto)
        {
            foreach (Producto item in estante._productos)
            {
                if(item == producto)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante , Producto producto)
        {
            if(estante._capacidad>estante._productos.Count && !(estante==producto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public static Estante operator -(Estante estante , Producto producto)
        {
            Estante auxiliar = new Estante(); ;

            if(estante == producto)
            {
                foreach (Producto item in estante._productos)
                {
                    if(item == producto)
                    {
                        estante._productos.CopyTo(auxiliar._productos);
                        auxiliar._productos.Remove(item);

                        return auxiliar;
                    }
                }
            }

            return auxiliar;
        }*/
    }
}
