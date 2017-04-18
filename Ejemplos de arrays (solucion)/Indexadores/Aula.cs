using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Aula
    {
        private int _numeroDeAula;
        private List<Alumno> _listadoDeAlumnos;

        public List<Alumno> retornarListado
        {
            get{return this._listadoDeAlumnos;}
        }

        public Aula()
        {
            _listadoDeAlumnos = new List<Alumno>();
        }

        public Alumno this[int indice]
        {
            get { return this._listadoDeAlumnos[indice]; }
            set { }

        }
    }
}
