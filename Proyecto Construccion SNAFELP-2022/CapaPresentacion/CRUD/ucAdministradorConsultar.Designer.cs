namespace CapaPresentacion {
    partial class ucAdministradorConsultar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdministradorConsultar));
            this.dgvAdministrador = new System.Windows.Forms.DataGridView();
            this.txtId_persona = new System.Windows.Forms.TextBox();
            this.lbId_persona = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.col_Id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolAdministrador_Nombre_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolAdministrador_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolAdministrador_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolAdministrador_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolAdministrador_Psw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdministrador
            // 
            this.dgvAdministrador.AllowUserToAddRows = false;
            this.dgvAdministrador.AllowUserToDeleteRows = false;
            this.dgvAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id_persona,
            this.colcolAdministrador_Nombre_persona,
            this.colcolAdministrador_Apellido,
            this.colcolAdministrador_Cedula,
            this.colFecha,
            this.colTelefono,
            this.colNacionalidad,
            this.colFoto,
            this.colcolAdministrador_Usuario,
            this.colcolAdministrador_Psw,
            this.Column1});
            this.dgvAdministrador.Location = new System.Drawing.Point(3, 49);
            this.dgvAdministrador.Name = "dgvAdministrador";
            this.dgvAdministrador.ReadOnly = true;
            this.dgvAdministrador.RowHeadersWidth = 72;
            this.dgvAdministrador.Size = new System.Drawing.Size(764, 363);
            this.dgvAdministrador.TabIndex = 0;
            // 
            // txtId_persona
            // 
            this.txtId_persona.Location = new System.Drawing.Point(101, 20);
            this.txtId_persona.Name = "txtId_persona";
            this.txtId_persona.Size = new System.Drawing.Size(100, 20);
            this.txtId_persona.TabIndex = 1;
            // 
            // lbId_persona
            // 
            this.lbId_persona.AutoSize = true;
            this.lbId_persona.BackColor = System.Drawing.Color.Transparent;
            this.lbId_persona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbId_persona.Location = new System.Drawing.Point(19, 22);
            this.lbId_persona.Name = "lbId_persona";
            this.lbId_persona.Size = new System.Drawing.Size(40, 13);
            this.lbId_persona.TabIndex = 2;
            this.lbId_persona.Text = "Cedula";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(225, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(438, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(509, 11);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(37, 23);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(732, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 28);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(296, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(367, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(37, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // col_Id_persona
            // 
            this.col_Id_persona.HeaderText = "ID";
            this.col_Id_persona.Name = "col_Id_persona";
            this.col_Id_persona.ReadOnly = true;
            // 
            // colcolAdministrador_Nombre_persona
            // 
            this.colcolAdministrador_Nombre_persona.HeaderText = "Nombre";
            this.colcolAdministrador_Nombre_persona.MinimumWidth = 9;
            this.colcolAdministrador_Nombre_persona.Name = "colcolAdministrador_Nombre_persona";
            this.colcolAdministrador_Nombre_persona.ReadOnly = true;
            this.colcolAdministrador_Nombre_persona.Width = 175;
            // 
            // colcolAdministrador_Apellido
            // 
            this.colcolAdministrador_Apellido.HeaderText = "Apellido";
            this.colcolAdministrador_Apellido.MinimumWidth = 9;
            this.colcolAdministrador_Apellido.Name = "colcolAdministrador_Apellido";
            this.colcolAdministrador_Apellido.ReadOnly = true;
            this.colcolAdministrador_Apellido.Width = 175;
            // 
            // colcolAdministrador_Cedula
            // 
            this.colcolAdministrador_Cedula.HeaderText = "Cedula";
            this.colcolAdministrador_Cedula.MinimumWidth = 9;
            this.colcolAdministrador_Cedula.Name = "colcolAdministrador_Cedula";
            this.colcolAdministrador_Cedula.ReadOnly = true;
            this.colcolAdministrador_Cedula.Width = 175;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Nacimiento";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colNacionalidad
            // 
            this.colNacionalidad.HeaderText = "Nacionalidad";
            this.colNacionalidad.Name = "colNacionalidad";
            this.colNacionalidad.ReadOnly = true;
            // 
            // colFoto
            // 
            this.colFoto.HeaderText = "Foto";
            this.colFoto.Name = "colFoto";
            this.colFoto.ReadOnly = true;
            // 
            // colcolAdministrador_Usuario
            // 
            this.colcolAdministrador_Usuario.HeaderText = "Usuario";
            this.colcolAdministrador_Usuario.MinimumWidth = 9;
            this.colcolAdministrador_Usuario.Name = "colcolAdministrador_Usuario";
            this.colcolAdministrador_Usuario.ReadOnly = true;
            this.colcolAdministrador_Usuario.Width = 175;
            // 
            // colcolAdministrador_Psw
            // 
            this.colcolAdministrador_Psw.HeaderText = "Psw";
            this.colcolAdministrador_Psw.MinimumWidth = 9;
            this.colcolAdministrador_Psw.Name = "colcolAdministrador_Psw";
            this.colcolAdministrador_Psw.ReadOnly = true;
            this.colcolAdministrador_Psw.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Puesto";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // ucAdministradorConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_persona);
            this.Controls.Add(this.txtId_persona);
            this.Controls.Add(this.dgvAdministrador);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucAdministradorConsultar";
            this.Size = new System.Drawing.Size(770, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdministrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador_Psw;
        private System.Windows.Forms.TextBox txtId_persona;
        private System.Windows.Forms.Label lbId_persona;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolAdministrador_Nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolAdministrador_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolAdministrador_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolAdministrador_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolAdministrador_Psw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}