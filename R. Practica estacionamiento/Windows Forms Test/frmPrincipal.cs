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

namespace Windows_Forms_Test
{
    public partial class frmPrincipal : Form
    {
        private Estacionamiento _estacionamiento;
        private const string RUTA = "estacionamiento.bin";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem_Click(this, new EventArgs());
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
                    if(frm.tipo == "Automovil")
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
    }
}
