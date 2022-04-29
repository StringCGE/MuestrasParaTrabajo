namespace CapaPresentacion {
    partial class Inicio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeControlArbitroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalla = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCampeonato = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnArbitro = new System.Windows.Forms.Button();
            this.btnActa = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.uC_Login1 = new CapaPresentacion.UC_Login();
            this.uC_Session1 = new CapaPresentacion.Login.UC_Session();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presentacionToolStripMenuItem,
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.presentacionToolStripMenuItem.Text = "Presentacion";
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.consolaToolStripMenuItem,
            this.panelDeControlArbitroToolStripMenuItem,
            this.calendarioToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.propiedadesToolStripMenuItem.Text = "Ventana";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Conexion a la base";
            // 
            // consolaToolStripMenuItem
            // 
            this.consolaToolStripMenuItem.Name = "consolaToolStripMenuItem";
            this.consolaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.consolaToolStripMenuItem.Text = "Panel de control Administrador";
            this.consolaToolStripMenuItem.Click += new System.EventHandler(this.consolaToolStripMenuItem_Click);
            // 
            // panelDeControlArbitroToolStripMenuItem
            // 
            this.panelDeControlArbitroToolStripMenuItem.Name = "panelDeControlArbitroToolStripMenuItem";
            this.panelDeControlArbitroToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.panelDeControlArbitroToolStripMenuItem.Text = "Panel de control Arbitro";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupoDeTrabajoToolStripMenuItem,
            this.detallesToolStripMenuItem,
            this.licenciaToolStripMenuItem});
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de";
            // 
            // grupoDeTrabajoToolStripMenuItem
            // 
            this.grupoDeTrabajoToolStripMenuItem.Name = "grupoDeTrabajoToolStripMenuItem";
            this.grupoDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.grupoDeTrabajoToolStripMenuItem.Text = "Grupo de trabajo";
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.detallesToolStripMenuItem.Text = "Detalles";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            // 
            // pantalla
            // 
            this.pantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pantalla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pantalla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pantalla.Location = new System.Drawing.Point(140, 25);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(144, 400);
            this.pantalla.TabIndex = 1;
            this.pantalla.Paint += new System.Windows.Forms.PaintEventHandler(this.pantalla_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.uC_Session1);
            this.flowLayoutPanel1.Controls.Add(this.btnCampeonato);
            this.flowLayoutPanel1.Controls.Add(this.btnEquipo);
            this.flowLayoutPanel1.Controls.Add(this.btnJugador);
            this.flowLayoutPanel1.Controls.Add(this.btnArbitro);
            this.flowLayoutPanel1.Controls.Add(this.btnActa);
            this.flowLayoutPanel1.Controls.Add(this.btnAdministrador);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 400);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCampeonato
            // 
            this.btnCampeonato.AutoSize = true;
            this.btnCampeonato.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCampeonato.Location = new System.Drawing.Point(3, 229);
            this.btnCampeonato.Name = "btnCampeonato";
            this.btnCampeonato.Size = new System.Drawing.Size(125, 30);
            this.btnCampeonato.TabIndex = 36;
            this.btnCampeonato.Text = "Campeonato";
            this.btnCampeonato.Click += new System.EventHandler(this.btnCampeonato_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.AutoSize = true;
            this.btnEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEquipo.Location = new System.Drawing.Point(3, 265);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(125, 30);
            this.btnEquipo.TabIndex = 38;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnJugador
            // 
            this.btnJugador.AutoSize = true;
            this.btnJugador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnJugador.Location = new System.Drawing.Point(3, 301);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(125, 30);
            this.btnJugador.TabIndex = 34;
            this.btnJugador.Text = "Jugador";
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // btnArbitro
            // 
            this.btnArbitro.AutoSize = true;
            this.btnArbitro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnArbitro.Location = new System.Drawing.Point(3, 337);
            this.btnArbitro.Name = "btnArbitro";
            this.btnArbitro.Size = new System.Drawing.Size(125, 30);
            this.btnArbitro.TabIndex = 35;
            this.btnArbitro.Text = "Arbitro";
            this.btnArbitro.Click += new System.EventHandler(this.btnArbitro_Click);
            // 
            // btnActa
            // 
            this.btnActa.AutoSize = true;
            this.btnActa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActa.Location = new System.Drawing.Point(3, 373);
            this.btnActa.Name = "btnActa";
            this.btnActa.Size = new System.Drawing.Size(125, 30);
            this.btnActa.TabIndex = 37;
            this.btnActa.Text = "Acta";
            this.btnActa.Click += new System.EventHandler(this.btnActa_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.AutoSize = true;
            this.btnAdministrador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdministrador.Location = new System.Drawing.Point(3, 409);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(125, 30);
            this.btnAdministrador.TabIndex = 33;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // uC_Login1
            // 
            this.uC_Login1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Login1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uC_Login1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_Login1.Inicio = null;
            this.uC_Login1.Location = new System.Drawing.Point(206, 34);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Login1.MinimumSize = new System.Drawing.Size(280, 400);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(280, 400);
            this.uC_Login1.TabIndex = 2;
            // 
            // uC_Session1
            // 
            this.uC_Session1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_Session1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_Session1.Location = new System.Drawing.Point(3, 3);
            this.uC_Session1.Name = "uC_Session1";
            this.uC_Session1.Size = new System.Drawing.Size(135, 220);
            this.uC_Session1.TabIndex = 39;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 424);
            this.Controls.Add(this.uC_Login1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(298, 463);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeControlArbitroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
        private System.Windows.Forms.Panel pantalla;
        private UC_Login uC_Login1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCampeonato;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Button btnArbitro;
        private System.Windows.Forms.Button btnActa;
        private System.Windows.Forms.Button btnAdministrador;
        private Login.UC_Session uC_Session1;
    }
}