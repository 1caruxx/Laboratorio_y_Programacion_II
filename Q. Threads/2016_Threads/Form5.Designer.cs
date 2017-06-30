namespace Pelotita_Con_Threads
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnInciciarHilos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(78, 24);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(13, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "0";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(16, 59);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(16, 88);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 3;
            this.btnSaludar.Text = "&Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnInciciarHilos
            // 
            this.btnInciciarHilos.Location = new System.Drawing.Point(110, 88);
            this.btnInciciarHilos.Name = "btnInciciarHilos";
            this.btnInciciarHilos.Size = new System.Drawing.Size(75, 23);
            this.btnInciciarHilos.TabIndex = 4;
            this.btnInciciarHilos.Text = "&Iniciar hilos";
            this.btnInciciarHilos.UseVisualStyleBackColor = true;
            this.btnInciciarHilos.Click += new System.EventHandler(this.btnInciciar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 123);
            this.Controls.Add(this.btnInciciarHilos);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button btnInciciarHilos;
    }
}