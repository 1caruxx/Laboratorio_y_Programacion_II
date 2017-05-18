using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static TipoManada _tipo;
        public TipoManada tipo
        {
            set { _tipo = value; }
        }

        static Grupo()
        {
            _tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre):this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre , TipoManada tipo) : this(nombre)
        {
            _tipo = tipo;
        }

        public static bool operator ==(Grupo grupo , Mascota mascota)
        {
            foreach (Mascota item in grupo._manada)
            {
                if(item is Perro && ((Perro)item).Equals(mascota))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Grupo grupo , Mascota mascota)
        {
            return !(grupo == mascota);
        }

        public static Grupo operator +(Grupo grupo , Mascota mascota)
        {
            if(grupo != mascota)
            {
                grupo._manada.Add(mascota);
            }

            return grupo;
        }

        public static Grupo operator -(Grupo grupo , Mascota mascota)
        {
            if (grupo == mascota)
            {
                grupo._manada.Remove(mascota);
            }

            return grupo;
        }

        public static implicit operator string(Grupo grupo)
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("**" + grupo._nombre);

            if(_tipo == TipoManada.Unica)
            {
                SB.AppendLine(" Unica**");
            }
            else
            {
                SB.AppendLine(" Mixta**");
            }

            SB.AppendLine("Integrantes:");

            foreach (Mascota item in grupo._manada)
            {
                SB.AppendLine(item.ToString());
            }

            return SB.ToString();
        }
    }
}
