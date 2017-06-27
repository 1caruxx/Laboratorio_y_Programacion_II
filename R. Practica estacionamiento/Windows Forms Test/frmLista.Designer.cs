namespace Windows_Forms_Test
{
    partial class frmLista
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
            this.rtbListado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbListado
            // 
            this.rtbListado.Location = new System.Drawing.Point(0, 0);
            this.rtbListado.Name = "rtbListado";
            this.rtbListado.Size = new System.Drawing.Size(284, 263);
            this.rtbListado.TabIndex = 0;
            this.rtbListado.Text = "";
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.rtbListado);
            this.Name = "frmLista";
            this.Text = "frmLista";
            this.Load += new System.EventHandler(this.frmLista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListado;
    }
}