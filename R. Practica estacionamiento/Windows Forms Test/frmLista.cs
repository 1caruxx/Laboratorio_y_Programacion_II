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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            
        }

        public void Listar(Estacionamiento estacionamiento)
        {
            foreach (Vehiculo item in estacionamiento.Listado)
            {
                this.rtbListado.Text += item.ToString();
            }
        }
    }
}
