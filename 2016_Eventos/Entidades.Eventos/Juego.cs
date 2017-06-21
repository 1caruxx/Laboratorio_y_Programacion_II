using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Eventos
{

    //DECLARO DELEGADOS PARA INTERACTUAR CON LOS EVENTOS. DECLARARLOS EN UN CODEFILE
    public delegate void JuegoGanado(object sender, EventArgs e);
    public delegate void JuegoContinua(object sender, EventArgs e);
    public delegate void JuegoPerdido(object sender, JuegoEventArgs e);
    public delegate void Proximidad(int dato);

    public class Juego
    {
        //DECLARO LOS EVENTOS DE LA CLASE
        public event JuegoGanado Ganar;
        public event JuegoContinua Segir;
        public event JuegoPerdido Perder;
        public event Proximidad Proximo;

        private static Random _generadorDeNumeros;

        private int _numeroSecreto;
        private int _cantidadIntentos;
        private EDificultad _dificultad;

        private int _numero;

        public int Numero
        {
            get { return this._numero; }
            set 
            { 
                this._numero = value;
                this._cantidadIntentos++;
                this.AdministrarJugada();               
            }
        }

        public int CantidadIntentos
        {
            get { return this._cantidadIntentos; }
        }

        public int CantidadMaximaDeIntentos
        {
            get { return (int)this._dificultad; }
        }

        public string Pista
        {
            get
            {
                string pista = "";

                if (Math.Abs(this._numero - this._numeroSecreto) < 10)
                {
                    this.Proximo(10);
                }

                if (this._numero > this._numeroSecreto)
                {
                    pista = "Te pasaste";
                }
                else
                 {
                     if (this._numero < this._numeroSecreto)
                     {
                         pista = "Te falta";
                     }
                     else
                     {
                         if (this._numeroSecreto - this._numero <= 5 || this._numeroSecreto - this._numero <= -5)
                         {
                             pista = "Estas cerca.";
                         }
 
                     }
                 }

                return pista;
            }
        }

        static Juego() 
        {
            Juego._generadorDeNumeros = new Random();
        }

        public Juego(EDificultad dificultad)
        {
            this._numeroSecreto = Juego._generadorDeNumeros.Next(11);
            this._dificultad = dificultad;
            this._cantidadIntentos = 0;
        }

        private void AdministrarJugada()
        {
            if (this._cantidadIntentos == (int)this._dificultad)
            {
                if (this.Gano())
                {
                    //GANO
                    this.Ganar(this, new EventArgs());
                }
                else
                {
                    //PERDIO
                    this.Perder(this, new JuegoEventArgs(this._numeroSecreto));
                }
            }
            else if (this._cantidadIntentos < (int)this._dificultad)
            {
                if (this.Gano())
                {
                    //GANO
                    this.Ganar(this, new EventArgs());
                }
                else
                {
                    //SIGUE PARTICIPANDO
                    this.Segir(this, new EventArgs());
                }
            }
            else
            {
                //PERDIO...
                this.Perder(this, new JuegoEventArgs(this._numeroSecreto));
            }
        }

        private bool Gano()
        {
            bool gano = false;
            if (this._numero == this._numeroSecreto)
            {
                gano = true;
            }
            return gano;
        }
    }
}
