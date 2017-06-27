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
    public partial class frmBaja : Form
    {
        private Automovil _automovil;
        private Motocicleta _motocicleta;
        public string tipo = "";

        public Automovil Automovil
        {
            get { return this._automovil; }
        }

        public Motocicleta Motocicleta
        {
            get { return this._motocicleta; }
        }

        public frmBaja()
        {
            InitializeComponent();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entrada = 0;

            if(!(int.TryParse(this.txtPatente.Text, out entrada)))
            {
                throw new Exception("Patente ingresada invalida.");
            }

            this.tipo = this.cmbTipo.Text;

            if(this.cmbTipo.Text == "Automovil")
            {
                this._automovil = new Automovil(entrada);
            }
            else
            {
                this._motocicleta = new Motocicleta(entrada);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
