using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Alumno)), XmlInclude(typeof(Profesor))]
    public class Persona :Humano
    {
        private string _apellido;
        private string _nombre;

        /*
         * Si yo quiero guardar en un archivo XML atributos que sean privados, debere previamente crear propiedades de lectura y escritura.
         * Si estas propiedades son solo de lectura o solo de escritura, estos atributos no se guardaran.
         */
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        /*
         * El constructor por defecto es obligatorio ya que para guardarse la informacion de mi objeto en un archivo XML.
         * primero se hace una copia de ese objeto y para ello es necesario un objeto que este vacio y reservado en memoria, la misma funcion que cumple un constructor por defecto.
         */
        public Persona() { }

        public Persona(string apellido , string nombre)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public Persona(string apellido, string nombre, int dni): this(apellido, nombre)
        {
            this.DNI = dni;
        }
    }
}
