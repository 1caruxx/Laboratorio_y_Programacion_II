using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private int _numero;
        private int _capacidad;
        private List<Persona> _listado;

        public List<Persona> obtenerListado
        {
            get { return this._listado; }
        }

        public int capacidad
        {
            get { return this._capacidad; }
        }

        public int espacioLibre
        {
            get
            {
                return this._capacidad - this._listado.Count;
            }
        }

        public int cantidadDePersonas
        {
            get { return this._listado.Count; }
        }

        public int cantidadDeAlumnos
        {
            get
            {
                int contador = 0;

                foreach (Persona item in this._listado)
                {
                    if(item is Alumno || item is Alumno_egresado)
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        public int cantidadDeProfesores
        {
            get
            {
                int contador = 0;

                foreach (Persona item in this._listado)
                {
                    if(item is Profesor)
                    {
                        contador++;
                    }
                }
                return contador;
            }
        }

        public Aula(int numero , int capacidad)
        {
            this._numero = numero;
            this._capacidad = capacidad;
            _listado = new List<Persona>();
        }

        public void mostrar()
        {
            foreach (Persona item in this._listado)
            {
                item.mostrar();
            }
        }

        public bool agregar(Persona persona)
        {
            if(this._listado.Count < this._capacidad)
            {
                this._listado.Add(persona);
                return true;
            }

            return false;
        }

        public bool eliminar(Persona persona)
        {
            foreach (Persona item in this._listado)
            {
                if(this._listado.Contains(item))
                {
                    this._listado.Remove(item);
                    return true;
                }
            }

            return false;
        }
    }
}
