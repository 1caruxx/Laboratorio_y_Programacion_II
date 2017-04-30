using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Alumno
    {
        private string _nombre;
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        private int _legajo;
        public int legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        private eSexo _sexo;
        public eSexo sexo
        {
            get { return this._sexo; }
            set { this._sexo = value; }
        }
        
        public Alumno()
        {
            this._nombre = "Sin asignar";
        }

        public Alumno(string nombre, int legajo, eSexo sexo)
        {
            this._nombre = nombre;
            this._legajo = legajo;
            this._sexo = sexo;
        }
    }
}
