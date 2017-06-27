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
    public partial class frmAltaEstacionamiento : Form
    {
        private Estacionamiento _estacionamiento;

        public Estacionamiento Estacionamiento
        {
            get { return this._estacionamiento; }
        }

        public frmAltaEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmAltaEstacionamiento_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entrada = 0;

            if (!(int.TryParse(this.txtCapacidad.Text, out entrada)))
            {
                throw new Exception("Capacidad ingresada no valida, reintente...");
            }

            this._estacionamiento = new Estacionamiento(this.txtNombre.Text, entrada);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
