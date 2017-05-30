using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Aula
    {
        private int _numero;
        private List<Alumno> _listaDeAlumnos;
        public List<Alumno> listaDeAlumnos
        {
            get { return this._listaDeAlumnos; }
        }

        public Aula()
        {
            this._listaDeAlumnos = new List<Alumno>();
        }

        public Aula(int numero):this()
        {
            this._numero = numero;
        }
    }
}
