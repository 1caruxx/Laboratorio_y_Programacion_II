using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private List<Alumno> _alumnos;
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
        }

        private int _espacio;
        public int Espacio
        {
            set 
            {
                if (value > 0 && value < 51)
                {
                    this._espacio = value;
                }
                else
                {
                    if (value < 1)
                    {
                        this._espacio = 1;
                    }
                    else
                    {
                        this._espacio = 50;
                    }
                }
            }
        }
        public int EspacioDisponible
        {
            get { return this._espacio - this._alumnos.Count; }
        }

        private Aula()
        {
            this._alumnos = new List<Alumno>();
        }

        public Aula(int espacio): this()
        {
            this.Espacio = espacio;
        }

        public static Aula operator +(Aula aula , Alumno alumno)
        {
            if (aula.EspacioDisponible > 0)
            {
                aula._alumnos.Add(alumno);
            }
            else
            {
                if(aula == alumno)
                {
                    throw new AlumnoRepetidoExcepcion();
                }

                throw new AulaLlenaExcepcion("El aula esta llena.");
            }
            
            return aula;
        }

        public static bool operator ==(Aula aula, Alumno alumno)
        {
            foreach (Alumno item in aula.Alumnos)
            {
                if (item == alumno)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Aula aula, Alumno alumno)
        {
            return !(aula == alumno);
        }
    }
}
