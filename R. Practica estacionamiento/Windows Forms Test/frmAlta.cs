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
    public partial class frmAlta : Form
    {
        private Automovil _automovil;
        private Motocicleta _motocicleta;
        public string tipo;

        public Automovil Automovil
        {
            get { return this._automovil; }
        }

        public Motocicleta Motocicleta
        {
            get { return this._motocicleta; }
        }

        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            foreach (eMarca item in Enum.GetValues(typeof(eMarca)))
            {
                this.cmbMarca.Items.Add(item);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entrada = 0;

            if(!(int.TryParse(this.txtPatente.Text, out entrada)))
            {
                throw new Exception("Patente ingresada invalida.");
            }

            this.tipo = this.cmbTipo.Text;

            if (this.cmbTipo.Text == "Automovil")
            {
                this._automovil = new Automovil(entrada, this.txtNombre.Text, this.txtApellido.Text, (eMarca)this.cmbMarca.SelectedItem);
            }
            else
            {
                this._motocicleta = new Motocicleta(entrada, this.txtNombre.Text, this.txtApellido.Text, (eMarca)this.cmbMarca.SelectedItem);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
