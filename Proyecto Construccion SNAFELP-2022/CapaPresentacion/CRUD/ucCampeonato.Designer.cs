namespace CapaPresentacion {
    partial class ucCampeonato {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCampeonato));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbNombre_campeonado = new System.Windows.Forms.Label();
            this.txtNombre_campeonado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(109, 54);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(49, 33);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbNombre_campeonado
            // 
            this.lbNombre_campeonado.AutoSize = true;
            this.lbNombre_campeonado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNombre_campeonado.Location = new System.Drawing.Point(5, 30);
            this.lbNombre_campeonado.Name = "lbNombre_campeonado";
            this.lbNombre_campeonado.Size = new System.Drawing.Size(44, 13);
            this.lbNombre_campeonado.TabIndex = 2;
            this.lbNombre_campeonado.Text = "Nombre";
            // 
            // txtNombre_campeonado
            // 
            this.txtNombre_campeonado.Location = new System.Drawing.Point(63, 28);
            this.txtNombre_campeonado.Name = "txtNombre_campeonado";
            this.txtNombre_campeonado.Size = new System.Drawing.Size(140, 20);
            this.txtNombre_campeonado.TabIndex = 3;
            this.txtNombre_campeonado.TextChanged += new System.EventHandler(this.txtNombre_campeonado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(88, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Campeonato";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(224, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 28);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ucCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombre_campeonado);
            this.Controls.Add(this.txtNombre_campeonado);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucCampeonato";
            this.Size = new System.Drawing.Size(262, 152);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Id_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Partidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Numero_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechafin;
        private System.Windows.Forms.Label lbNombre_campeonado;
        private System.Windows.Forms.TextBox txtNombre_campeonado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
    }
}