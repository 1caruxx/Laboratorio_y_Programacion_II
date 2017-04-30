using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_parte_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto formularioDeProcucto = new frmProducto();

            //formularioDeProcucto.Show();
            formularioDeProcucto.Show(this);
        }
    }
}
