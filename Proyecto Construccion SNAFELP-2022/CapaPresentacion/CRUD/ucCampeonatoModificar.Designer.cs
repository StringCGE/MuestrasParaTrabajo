namespace CapaPresentacion {
    partial class ucCampeonatoModificar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCampeonatoModificar));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNombre_campeonado = new System.Windows.Forms.Label();
            this.txtNombre_campeonado = new System.Windows.Forms.TextBox();
            this.lbFechas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(117, 94);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(49, 38);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(230, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 27);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Campeonato";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 69);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lbNombre_campeonado
            // 
            this.lbNombre_campeonado.AutoSize = true;
            this.lbNombre_campeonado.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre_campeonado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNombre_campeonado.Location = new System.Drawing.Point(13, 38);
            this.lbNombre_campeonado.Name = "lbNombre_campeonado";
            this.lbNombre_campeonado.Size = new System.Drawing.Size(44, 13);
            this.lbNombre_campeonado.TabIndex = 15;
            this.lbNombre_campeonado.Text = "Nombre";
            // 
            // txtNombre_campeonado
            // 
            this.txtNombre_campeonado.Location = new System.Drawing.Point(71, 36);
            this.txtNombre_campeonado.Name = "txtNombre_campeonado";
            this.txtNombre_campeonado.Size = new System.Drawing.Size(140, 20);
            this.txtNombre_campeonado.TabIndex = 16;
            // 
            // lbFechas
            // 
            this.lbFechas.AutoSize = true;
            this.lbFechas.BackColor = System.Drawing.Color.Transparent;
            this.lbFechas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechas.Location = new System.Drawing.Point(13, 69);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(37, 13);
            this.lbFechas.TabIndex = 17;
            this.lbFechas.Text = "Fecha";
            // 
            // ucCampeonatoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNombre_campeonado);
            this.Controls.Add(this.txtNombre_campeonado);
            this.Controls.Add(this.lbFechas);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucCampeonatoModificar";
            this.Size = new System.Drawing.Size(268, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Id_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Partidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Numero_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechafin;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNombre_campeonado;
        private System.Windows.Forms.TextBox txtNombre_campeonado;
        private System.Windows.Forms.Label lbFechas;
    }
}