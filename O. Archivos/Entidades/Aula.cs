using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Aula
    {
        private int _numero;
        private string _nombre;
        private bool _internet;
        private List<Persona> _listado;

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public bool Internet
        {
            set { this._internet = value; }
        }

        public List<Persona> Listado
        {
            get { return this._listado; }
            set { this._listado = value; }
        }

        public Aula()
        {
            this._listado = new List<Persona>();
        }

        public Aula(int numero, string nombre, bool internet): this()
        {
            this._numero = numero;
            this._nombre = nombre;
            this._internet = internet;
        }

        public bool Serializar()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                using (StreamWriter escritor = new StreamWriter("Serializacion.xml"))
                {
                    serializador.Serialize(escritor, this);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DesSerializar()
        {

            try
            {
                Aula aulaAuxiliar;
                XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                using (StreamReader lector = new StreamReader("Serializacion.xml"))
                {
                    aulaAuxiliar = (Aula)serializador.Deserialize(lector);
                    this.Listado = aulaAuxiliar.Listado;
                    this._nombre = aulaAuxiliar._nombre;
                    this._numero = aulaAuxiliar._numero;
                    this._internet = aulaAuxiliar._internet;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
