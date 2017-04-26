using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    class Aula
    {
        private int _numero;
        private string _nombre;
        private List<Persona> ListadoDePersonas;
        private int capacidad;

        public Aula(int numero, string nombre,int capacidad)
        {
            this._nombre = nombre;
            this._numero = numero;
            ListadoDePersonas = new List<Persona>();
        }

        public int cantidadDePersonas
        {
            get
            {
                return ListadoDePersonas.Count; ;
            }
        }

        public int cantidadDeAlumnos
        {
            get 
            {
                int contador=0;
                
                foreach (Persona item in this.ListadoDePersonas)
                {
                    if (item is Alumno || item is AlumnoEgresado)
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
               
                foreach (Persona item in this.ListadoDePersonas)
                {
                    if (item is Profesor)
                    {
                        contador++;
                    }
                }
                return contador;
            }
        }

        public bool agregarPersona(Persona unaPersona)
        {
            if (this.ListadoDePersonas.Count <= this.capacidad)
            { 
                ListadoDePersonas.Add(unaPersona);
                return true;
            }
           
            return false;
        }

        public bool borrarPersona(Persona unaPersona)
        {
            foreach (Persona item in this.ListadoDePersonas)
            {
                if (unaPersona is AlumnoEgresado)
                {
                    if (((AlumnoEgresado)unaPersona).Equals(item) && (AlumnoEgresado)unaPersona == (AlumnoEgresado)item)
                    {
                        this.ListadoDePersonas.Remove(item);
                    }
                }
            }

            return true;
        }
    }
}
