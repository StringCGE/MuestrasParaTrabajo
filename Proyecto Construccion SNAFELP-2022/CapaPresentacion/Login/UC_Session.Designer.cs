namespace CapaPresentacion.Login {
    partial class UC_Session {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Session));
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lbPuesto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(29, 33);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(80, 80);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(2, 153);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(131, 67);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(6, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(125, 23);
            this.btnCerrarSesion.TabIndex = 30;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lbPuesto
            // 
            this.lbPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuesto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPuesto.Location = new System.Drawing.Point(2, 116);
            this.lbPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(131, 37);
            this.lbPuesto.TabIndex = 31;
            this.lbPuesto.Text = "Puesto";
            this.lbPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pbUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "UC_Session";
            this.Size = new System.Drawing.Size(135, 220);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lbPuesto;
    }
}
