namespace CapaPresentacion {
    partial class ucAdministrador {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdministrador));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbPsw = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.lbNombre_persona = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(205, 285);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(39, 29);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(451, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 28);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Location = new System.Drawing.Point(154, 197);
            this.dtpFechanacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(140, 20);
            this.dtpFechanacimiento.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(154, 259);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(140, 20);
            this.txtNacionalidad.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(4, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumero.Location = new System.Drawing.Point(4, 232);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(49, 13);
            this.lbNumero.TabIndex = 58;
            this.lbNumero.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(154, 228);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 20);
            this.txtTelefono.TabIndex = 59;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoto.BackgroundImage")));
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoto.Location = new System.Drawing.Point(395, 144);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(49, 30);
            this.btnFoto.TabIndex = 56;
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(348, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 90);
            this.panel1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Foto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(6, 47);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 43;
            this.lbUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(154, 43);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtUsuario.TabIndex = 44;
            // 
            // lbPsw
            // 
            this.lbPsw.AutoSize = true;
            this.lbPsw.BackColor = System.Drawing.Color.Transparent;
            this.lbPsw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPsw.Location = new System.Drawing.Point(6, 78);
            this.lbPsw.Name = "lbPsw";
            this.lbPsw.Size = new System.Drawing.Size(27, 13);
            this.lbPsw.TabIndex = 45;
            this.lbPsw.Text = "Psw";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(154, 74);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(140, 20);
            this.txtPsw.TabIndex = 46;
            // 
            // lbNombre_persona
            // 
            this.lbNombre_persona.AutoSize = true;
            this.lbNombre_persona.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre_persona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre_persona.Location = new System.Drawing.Point(6, 109);
            this.lbNombre_persona.Name = "lbNombre_persona";
            this.lbNombre_persona.Size = new System.Drawing.Size(44, 13);
            this.lbNombre_persona.TabIndex = 47;
            this.lbNombre_persona.Text = "Nombre";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(154, 105);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(140, 20);
            this.txtNombres.TabIndex = 48;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellido.Location = new System.Drawing.Point(6, 140);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 49;
            this.lbApellido.Text = "Apellido";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(154, 136);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(140, 20);
            this.txtApellidos.TabIndex = 50;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.BackColor = System.Drawing.Color.Transparent;
            this.lbCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCedula.Location = new System.Drawing.Point(6, 171);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(40, 13);
            this.lbCedula.TabIndex = 51;
            this.lbCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(154, 167);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(140, 20);
            this.txtCedula.TabIndex = 52;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dtpFechanacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.lbNombre_persona);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucAdministrador";
            this.Size = new System.Drawing.Size(489, 325);
            this.Load += new System.EventHandler(this.ucAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbPsw;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label lbNombre_persona;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}