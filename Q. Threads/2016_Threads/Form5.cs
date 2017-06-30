using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pelotita_Con_Threads
{
    delegate void AsignarNumeroDelegado(string texto);
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                this.lblNumero.Text = i.ToString();
            }
        }

        private void Hacer()
        {
            for (int i = 0; i < 100000000; i++)
            {
                this.AsignarNumero(i.ToString());
            }
        }

        private void btnInciciar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.Hacer);

            hilo.Start();
        }

        private void AsignarNumero(string texto)
        {
            //Devuelve true si los hilos son distintos.
            //Como este metodo es llamado por el metodo Hacer() ejecutado en un hilo diferente, ejecutara las sentencias.
            //Es importante que este dentro de un try y un catch, ya que al cerrar el programa arrojara una excepcion. Esto se debe a que mi segundo hilo esta colocando informacion en alguna parte de mi hilo priuncipal.
            //Cuando cierro la venta, el hilo secundario intentara insertar informacion en el hilo principal que ya fue cerrado y como resultado lanza la excepcion.
            try
            {
                if (this.lblNumero.InvokeRequired)
                {
                    AsignarNumeroDelegado delegado = new AsignarNumeroDelegado(this.AsignarNumero);
                    //Este comando se encarga de invocar un delegado, llamare devuelta a este metodo, AsignarNumero() pero estando dentro del mismo hilo.
                    //Como entro por segunda vez a este metodo por el hilo que yo cree, entrara al else y le asignara al label los numeros que le pase por parametro al metodo AsignarNumero().
                    this.Invoke(delegado, new Object[] { texto });
                }
                else
                {
                    this.lblNumero.Text = texto;
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
