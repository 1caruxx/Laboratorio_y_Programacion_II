using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Propiedades
{
    /// <summary>
    /// En esta clase realizaremos la practica sobre el concepto de propiedades
    /// </summary>
    public class Aula
    {
        private int _numero;
        //private int _NumeroLegajo;

        public int NumeroLegajo
        {
            set 
            {
                bool esta = false;
                if (value > 0)
                {
                    foreach (Alumno alumnoAux in this.listaDeAlumnos)
                    {
                        if (alumnoAux == value)
                        {
                            esta = true;
                        }
                    }
                    if (!esta)
                    {

                        this.listaDeAlumnos.Add(new Alumno("n", "n", value));
                    }
                }
                //nada
            
            
            }
        }

        public int numero
        {
            get { return this._numero; }
        }

        private string _profesor;
        public string profesor
        {           
            set { this._profesor = value; }
        }

        
        private int _capacidad;
        
        public int lugaresLibres
        {
            get
            {
                int cantidadLugares=0;

                cantidadLugares = this._capacidad - this.listaDeAlumnos.Count;

                return cantidadLugares;
            }
        }

        private List<Alumno> listaDeAlumnos;


        /*public int getterCapacidad()
        {
            return this.capacidad;
        }

        public void setterCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }*/

        public Aula()
        {
            this.listaDeAlumnos = new List<Alumno>();

        }

        
    }
}
