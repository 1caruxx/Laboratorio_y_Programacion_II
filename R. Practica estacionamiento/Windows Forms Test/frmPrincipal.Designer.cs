namespace Windows_Forms_Test
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblEspacioOcupado = new System.Windows.Forms.Label();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.lblEspacioDisponible = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM de estacionamientos";
            // 
            // lblEspacioOcupado
            // 
            this.lblEspacioOcupado.AutoSize = true;
            this.lblEspacioOcupado.Location = new System.Drawing.Point(-2, 82);
            this.lblEspacioOcupado.Name = "lblEspacioOcupado";
            this.lblEspacioOcupado.Size = new System.Drawing.Size(109, 13);
            this.lblEspacioOcupado.TabIndex = 1;
            this.lblEspacioOcupado.Text = "Vehiculos aparcados:";
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(-2, 128);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(84, 13);
            this.lblCapacidadTotal.TabIndex = 2;
            this.lblCapacidadTotal.Text = "Capacidad total:";
            // 
            // lblEspacioDisponible
            // 
            this.lblEspacioDisponible.AutoSize = true;
            this.lblEspacioDisponible.Location = new System.Drawing.Point(-2, 176);
            this.lblEspacioDisponible.Name = "lblEspacioDisponible";
            this.lblEspacioDisponible.Size = new System.Drawing.Size(101, 13);
            this.lblEspacioDisponible.TabIndex = 3;
            this.lblEspacioDisponible.Text = "Espacio disponible: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(-2, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(145, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del Estacionamiento:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem,
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem,
            this.darDeBajaUnVehiculoToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "&ABM";
            // 
            // darDeAltaUnNuevoEstacionamientoToolStripMenuItem
            // 
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem.Name = "darDeAltaUnNuevoEstacionamientoToolStripMenuItem";
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem.Text = "&Dar de alta un nuevo estacionamiento...";
            this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaUnNuevoEstacionamientoToolStripMenuItem_Click);
            // 
            // darDeAltaUnNuevoVehiculoToolStripMenuItem
            // 
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem.Name = "darDeAltaUnNuevoVehiculoToolStripMenuItem";
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem.Text = "&Dar de alta un nuevo vehiculo...";
            this.darDeAltaUnNuevoVehiculoToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaUnNuevoVehiculoToolStripMenuItem_Click);
            // 
            // darDeBajaUnVehiculoToolStripMenuItem
            // 
            this.darDeBajaUnVehiculoToolStripMenuItem.Name = "darDeBajaUnVehiculoToolStripMenuItem";
            this.darDeBajaUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.darDeBajaUnVehiculoToolStripMenuItem.Text = "&Dar de baja un vehiculo...";
            this.darDeBajaUnVehiculoToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaUnVehiculoToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar...";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "&Cargar...";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.listarToolStripMenuItem.Text = "&Listar...";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 203);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEspacioDisponible);
            this.Controls.Add(this.lblCapacidadTotal);
            this.Controls.Add(this.lblEspacioOcupado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "ABM de estacionamiento";
            this.Load += new System.EventHandler(this.frmEstacionamiento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEspacioOcupado;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.Label lblEspacioDisponible;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaUnNuevoVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaUnNuevoEstacionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
    }
}

