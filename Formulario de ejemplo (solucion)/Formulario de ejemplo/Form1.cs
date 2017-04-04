using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            string miVariable;

            miVariable = this.txtnombre.Text;
            MessageBox.Show("Hola mundo" + miVariable);
            this.lblnombre.Text = miVariable;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
