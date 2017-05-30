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
    public partial class frmAlumno : Form
    {
        private Alumno _alumno;
        public Alumno alumno
        {
            get { return this._alumno; }
        }

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Items.Add(eSexo.FEMALE);
            this.cmbSexo.Items.Add(eSexo.MALE);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _alumno = new Alumno(this.txtNombre.Text , int.Parse(this.txtLegajo.Text) , (eSexo)this.cmbSexo.SelectedItem);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
