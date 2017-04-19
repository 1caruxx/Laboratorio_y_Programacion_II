using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAula;

namespace UI_aulas
{
    public partial class frmPrincipal : Form
    {
        private Aula _aula;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            //frm.Show();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this._aula.listaDeAlumnos.Add(frm.alumno);
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado lista = new Listado(_aula);

            lista.Show();
        }
    }
}
