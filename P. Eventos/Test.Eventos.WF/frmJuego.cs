using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades.Eventos;

namespace Test.Eventos.WF
{
    public partial class frmJuego : Form
    {
        private Juego _juego;
        private int _cantidadExitos;
        private int _cantidadFracasos;

        public frmJuego()
        {
            InitializeComponent();

            //CARGO EL COMBOBOX CON LAS DISTINTAS ENUMERACIONES
            foreach (EDificultad item in Enum.GetValues(typeof(EDificultad)))
            {
                this.cboDificultad.Items.Add(item);    
            }
            //IMPIDO QUE SE PUEDAN EDITAR LOS ITEMS
            this.cboDificultad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SELECCIONO UN NIVEL DE DIFICULTAD POR DEFECTO
            this.cboDificultad.SelectedItem = EDificultad.MuyFacil;
            
            //HAGO INVISIBLE LA OPCION DE INGRESO DE NUMEROS
            this.miPanel.Visible = false;
        }

        private void bntIniciar_Click(object sender, EventArgs e)
        {
            //GENERO UNA INSTANCIA DE JUEGO
            this._juego = new Juego((EDificultad)this.cboDificultad.SelectedItem);

            //AGREGO LOS MANEJADORES DE EVENTOS
            this.InicializarManejadoresDeEventos();

            //CONFIGURO PARA JUGAR
            this.Inicializar();
            this.bntIniciar.Visible = false;
            this.btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cuando le dot click a este boton, lo hago invisible y hago visible el boton de iniciar.
            this.btnCancelar.Visible = false;
            this.bntIniciar.Visible = true;
        }

        private void InicializarManejadoresDeEventos()
        {
            //AL OBJETO.EVENTO LE AGREGO SU MANEJADOR (DEBEN COINCIDIR LAS FIRMAS!!!)
            this._juego.Ganar += new JuegoGanado(Ganaste);
            this._juego.Perder += new JuegoPerdido(Perdiste);
            this._juego.Segir += new JuegoContinua(SeguiParticipando);
            this._juego.Proximo += new Proximidad(ProximoAGanar);
        }

        private void Inicializar()
        {
            //HAGO VISIBLE LA OPCION DE INGRESO DE NUMEROS
            this.miPanel.Visible = true;
            
            //LIMPIO Y PONGO EN FOCO...
            this.txtNumero.Clear();
            this.txtNumero.Focus();

            //INICIALIZO LA CANTIDAD DE INTENTOS REALIZADOS
            this.lblIntentos.Text = "Intentos " + this._juego.CantidadIntentos;

        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            //SI LA TECLA PULSADA ES EL 'ENTER'...
            if (e.KeyCode == Keys.Enter)
            {
                //PASO EL NUMERO A LA PROPIEDAD
                this._juego.Numero = int.Parse(this.txtNumero.Text);
                ((TextBox)sender).Clear();
            }
        }

        #region MANEJADORES DE EVENTOS

        private void ProximoAGanar(int dato)
        {
            //this.lblPista.Text = "Te queda un:" + dato + "%";
            this.lblPista.Text = "Estas a " + dato + " numeros de distancia";
        }

        private void Ganaste(object obj, EventArgs e)
        {
            this.lblIntentos.Text = "Intentos " + this._juego.CantidadIntentos + " / " + this._juego.CantidadMaximaDeIntentos;
            this._cantidadExitos++;
            this.lblCantExitos.Text = this._cantidadExitos.ToString();
            this.lblPista.Text = "Pista:";

            if (MessageBox.Show("Ganaste!!\nOtro??", "Exito", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.bntIniciar_Click(obj, e);
            }
            else
            {
                this.miPanel.Visible = false;
            }
        }
        
        private void Perdiste(object obj, JuegoEventArgs e)
        {
            this.lblIntentos.Text = "Intentos " + this._juego.CantidadIntentos + " / " + this._juego.CantidadMaximaDeIntentos;
            this._cantidadFracasos++;
            this.lblCantFracasos.Text = this._cantidadFracasos.ToString();

            MessageBox.Show("Perdiste!!", "Fracaso!!!");

            //OBTENGO EL NUMERO SECRETO A PARTIR DEL OBJETO 'JUEGOEVENTARGS'
            if (MessageBox.Show("El número secreto era: " + e.NumeroSecreto+"\nOtro??", "Fail!!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.bntIniciar_Click(obj, e);
            }
            else
            {
                this.miPanel.Visible = false;
            }
        }

        private void SeguiParticipando(object obj, EventArgs e)
        {
            this.lblIntentos.Text = "Intentos " + this._juego.CantidadIntentos + " / " + this._juego.CantidadMaximaDeIntentos;

            MessageBox.Show("Uno más!!");
        }

        #endregion
    }
}
