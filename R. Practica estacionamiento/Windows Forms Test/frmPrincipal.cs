using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace Windows_Forms_Test
{
    public delegate void Asignar(string dato);

    public partial class frmPrincipal : Form
    {
        private Estacionamiento _estacionamiento;
        private const string RUTA = "estacionamiento.bin";

        public frmPrincipal()
        {
            InitializeComponent();
            //this.InicializadorDeManejadoresDeEventos(); ----> MAL
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //this.InicializadorDeManejadoresDeEventos(); ----> MAL
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem_Click(this, new EventArgs());
            Thread hilo = new Thread(this.Cronometro);

            hilo.Start();
        }

        private void Cronometro()
        {
            int minutos = 0;
            int horas = 0;

            for (int segundos = 0; segundos < 60; segundos++)
            {
                if(segundos == 59)
                {
                    minutos++;
                    segundos = 0;

                    if(minutos==59 )
                    {
                        horas++;
                        minutos = 0;
                    }
                }

                this.AsignarValor("Tiempo: " + horas.ToString() + " : " + minutos.ToString() + " : " + segundos.ToString());
                Thread.Sleep(1000);
            }
        }

        private void AsignarValor(string dato)
        {
            //Si yo cierro mi programa, este metodo tratara de devolver un dato al hilo principal que no existe por que fue cerrado
            //Como resultado dara una excepcion que debo atrapar
            try
            {
                if (this.lblCronometro.InvokeRequired)
                {
                    Asignar delegado = new Asignar(this.AsignarValor);
                    this.lblCronometro.Invoke(delegado, new object[] { dato });
                }
                else
                {
                    this.lblCronometro.Text = dato;
                }
            }
            catch (Exception excepcion)
            {
                Environment.Exit(0);
            }

        }

        private void darDeAltaUnNuevoEstacionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaEstacionamiento frm = new frmAltaEstacionamiento();

            try
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this._estacionamiento = frm.Estacionamiento;
                }

                this.ActualizarDatos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void darDeAltaUnNuevoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlta frm = new frmAlta();

            try
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.InicializadorDeManejadoresDeEventos();

                    if (frm.tipo == "Automovil")
                    {
                        this._estacionamiento += frm.Automovil;
                    }
                    else
                    {
                        this._estacionamiento += frm.Motocicleta;
                    }

                    this.ActualizarDatos();
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void darDeBajaUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaja frm = new frmBaja();

            try
            {
                this.InicializadorDeManejadoresDeEventos();
                this._estacionamiento.DisparadorDeEventos();

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if(frm.tipo == "Automovil")
                    {
                        this._estacionamiento -= frm.Automovil;
                    }
                    else
                    {
                        this._estacionamiento -= frm.Motocicleta;
                    }

                    this.ActualizarDatos();
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Estacionamiento.GuardarBinario(this._estacionamiento, RUTA);
                MessageBox.Show("Se ha guardado correctamente.");
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }           
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Estacionamiento.CargarBinario(out this._estacionamiento, RUTA);
                MessageBox.Show("Se ha cargado correctamente.");
                this.ActualizarDatos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista frm = new frmLista();

            frm.Listar(this._estacionamiento);
            frm.ShowDialog();
        }

        private void ActualizarDatos()
        {
            this.lblNombre.Text = "Nombre del estacionamiento: " + this._estacionamiento.Nombre;
            this.lblEspacioOcupado.Text = "Vehiculos aparcados: " + this._estacionamiento.Listado.Count.ToString();
            this.lblCapacidadTotal.Text = "Capacidad total: " + this._estacionamiento.Capacidad.ToString();
            this.lblEspacioDisponible.Text = "Espacio disponible: " + this._estacionamiento.EspacioLibre.ToString();
        }

        private void InicializadorDeManejadoresDeEventos()
        {
            //Como aniado referencia a un atributo de esta clase, tendre problemas para guardar en binario, ya que debo marcar como serializable esta clase y de las que herede (imposible por que form no se puede alterar).
            this._estacionamiento.evento_1 += new Estacionamiento.Delegado(AdvertenciaSinEspacio);
            this._estacionamiento.evento_2 += new Estacionamiento.Delegado(AdvertenciaPrimerVehiculoCargado);
            //this._estacionamiento.evento_3 += new Estacionamiento.Delegado(AdvertenciaPrimerVehiculoCargado);
            //this._estacionamiento.evento_3 += new Estacionamiento.Delegado(AdvertenciaSinEspacio);
            //this._estacionamiento.evento_3 += new Estacionamiento.Delegado(AdvertenciaSinElemenetos);
            this._estacionamiento.evento_3 += new Estacionamiento.Delegado(AdvertenciaSinElemenetos);
        }

        #region Manejadores de eventos

        private void AdvertenciaSinEspacio()
        {
            MessageBox.Show("Ya no podra cargar ningun vehiculo mas a menos que borre uno.");
            //Environment.Exit(0);
        }

        private void AdvertenciaPrimerVehiculoCargado()
        {
            MessageBox.Show("Felicidades, este es el primer auto que carga.");
        }

        private void AdvertenciaSinElemenetos()
        {
            throw new Exception("No hay autos cargados.");
        }

        #endregion
    }
}
