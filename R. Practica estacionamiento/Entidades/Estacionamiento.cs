using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using Interfaces;

namespace Entidades
{
    //public delegate void SinEspacio();
    [Serializable]
    public class Estacionamiento
    {
        public delegate void Delegado();
        private string _nombre;
        private int _capacidad;
        private List<Vehiculo> _listado;
        public event Delegado evento_1;
        public event Delegado evento_2;
        public event Delegado evento_3;

        #region Propiedades

        public List<Vehiculo> Listado
        {
            get { return this._listado; }
        }

        public int EspacioLibre
        {
            get { return this._capacidad - this._listado.Count; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Capacidad
        {
            get { return this._capacidad; }
        }

        #endregion

        #region Constructores

        private Estacionamiento()
        {
            this._listado = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int capacidad) : this()
        {
            this._nombre = nombre;
            this._capacidad = capacidad;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Nombre del estacionamiento: " + this._nombre);
            SB.AppendLine("Capacidad actual: " + this._listado.Count + " / " + this._capacidad);

            foreach (Vehiculo item in this._listado)
            {
                SB.AppendLine(item.ToString());
            }

            return SB.ToString();
        }

        public static void GuardarTexto(string estacionamiento, string ruta)
        {
            Texto archivo = new Texto();

            try
            {
                archivo.Guardar(estacionamiento, ruta);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public static void CargarTexto(out string estacionamiento, string ruta)
        {
            Texto archivo = new Texto();

            try
            {
                archivo.Cargar(out estacionamiento, ruta);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public static void GuardarXML(Estacionamiento estacionamiento, string ruta)
        {
            XML<Estacionamiento> archivo = new XML<Estacionamiento>();

            try
            {
                archivo.Guardar(estacionamiento, ruta);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public static void CargarXML(out Estacionamiento estacionamiento, string ruta)
        {
            XML<Estacionamiento> archivo = new XML<Estacionamiento>();

            try
            {
                archivo.Cargar(out estacionamiento, ruta);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public static void GuardarBinario(Estacionamiento estacionamiento, string ruta)
        {
            Binario<Estacionamiento> archivo = new Binario<Estacionamiento>();

            try
            {
                archivo.Guardar(estacionamiento, ruta);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public static void CargarBinario(out Estacionamiento estacionamiento, string ruta)
        {
            Binario<Estacionamiento> archivo = new Binario<Estacionamiento>();

            archivo.Cargar(out estacionamiento, ruta);
        }

        public void DisparadorDeEventos()
        {
            if(this._listado.Count == this._capacidad)
            {
                this.evento_1();
            }
            else
            {
                if(this._listado.Count == 1)
                {
                    this.evento_2();
                }
                else
                {
                    if(this._listado.Count == 0)
                    {
                        this.evento_3();
                    }
                }
            }
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo item in estacionamiento._listado)
            {
                if(item == vehiculo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                throw new VehiculoYaCargadoException();
            }
            else
            {
                if (estacionamiento.EspacioLibre == 0)
                {
                    throw new EstacionamientoLlenoException();
                }
                else
                {
                    estacionamiento._listado.Add(vehiculo);
                    estacionamiento.DisparadorDeEventos();
                }
            }

            return estacionamiento;
        }

        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            int contador = 0;

            foreach (Vehiculo item in estacionamiento._listado)
            {
                if(item == vehiculo)
                {
                    estacionamiento._listado.RemoveAt(contador);
                    //estacionamiento._listado.Remove(item);
                    contador = -1;
                    break;
                }

                contador++;
            }

            if(contador == estacionamiento._listado.Count)
            {
                throw new NoExisteElVehiculoException("El vehiculo no esta cargado en el estacionamiento.");
            }

            return estacionamiento;
        }

        #endregion
    }
}
