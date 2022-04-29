namespace CapaPresentacion.PanelDeControl {
    partial class UC_PanelDeControlGeneral {
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
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnArbitro = new System.Windows.Forms.Button();
            this.btnCampeonato = new System.Windows.Forms.Button();
            this.btnActa = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.AutoSize = true;
            this.btnAdministrador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdministrador.Location = new System.Drawing.Point(582, 142);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(229, 42);
            this.btnAdministrador.TabIndex = 26;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnJugador
            // 
            this.btnJugador.AutoSize = true;
            this.btnJugador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnJugador.Location = new System.Drawing.Point(282, 142);
            this.btnJugador.Margin = new System.Windows.Forms.Padding(6);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(229, 42);
            this.btnJugador.TabIndex = 27;
            this.btnJugador.Text = "Jugador";
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // btnArbitro
            // 
            this.btnArbitro.AutoSize = true;
            this.btnArbitro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnArbitro.Location = new System.Drawing.Point(282, 249);
            this.btnArbitro.Margin = new System.Windows.Forms.Padding(6);
            this.btnArbitro.Name = "btnArbitro";
            this.btnArbitro.Size = new System.Drawing.Size(229, 42);
            this.btnArbitro.TabIndex = 28;
            this.btnArbitro.Text = "Arbitro";
            this.btnArbitro.Click += new System.EventHandler(this.btnArbitro_Click);
            // 
            // btnCampeonato
            // 
            this.btnCampeonato.AutoSize = true;
            this.btnCampeonato.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCampeonato.Location = new System.Drawing.Point(23, 142);
            this.btnCampeonato.Margin = new System.Windows.Forms.Padding(6);
            this.btnCampeonato.Name = "btnCampeonato";
            this.btnCampeonato.Size = new System.Drawing.Size(229, 42);
            this.btnCampeonato.TabIndex = 29;
            this.btnCampeonato.Text = "Campeonato";
            this.btnCampeonato.Click += new System.EventHandler(this.btnCampeonato_Click);
            // 
            // btnActa
            // 
            this.btnActa.AutoSize = true;
            this.btnActa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActa.Location = new System.Drawing.Point(23, 249);
            this.btnActa.Margin = new System.Windows.Forms.Padding(6);
            this.btnActa.Name = "btnActa";
            this.btnActa.Size = new System.Drawing.Size(229, 42);
            this.btnActa.TabIndex = 30;
            this.btnActa.Text = "Acta";
            this.btnActa.Click += new System.EventHandler(this.btnActa_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.AutoSize = true;
            this.btnEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEquipo.Location = new System.Drawing.Point(582, 249);
            this.btnEquipo.Margin = new System.Windows.Forms.Padding(6);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(229, 42);
            this.btnEquipo.TabIndex = 32;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_regresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(762, 6);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(68, 47);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // UC_PanelDeControlGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnJugador);
            this.Controls.Add(this.btnArbitro);
            this.Controls.Add(this.btnCampeonato);
            this.Controls.Add(this.btnActa);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.btn_regresar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_PanelDeControlGeneral";
            this.Size = new System.Drawing.Size(847, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Button btnArbitro;
        private System.Windows.Forms.Button btnCampeonato;
        private System.Windows.Forms.Button btnActa;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btn_regresar;
    }
}
