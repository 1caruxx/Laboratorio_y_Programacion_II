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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        public Listado(Aula aula):this()
        {
            foreach (Alumno alumnoRecorrido in aula.listaDeAlumnos)
            {
                this.listBox1.Items.Add(alumnoRecorrido.nombre);
            }
        }

        private void Listado_Load(object sender, EventArgs e)
        {

        }
    }
}
