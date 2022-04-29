namespace CapaPresentacion {
    partial class ucEquipoConsultar {
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
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolEquipo_Jugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEscudo = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbId_equipo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.colID_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.btnTodoJugador = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNombreDeEquipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colcolEquipo_Jugadores,
            this.colEscudo});
            this.dgvEquipo.Location = new System.Drawing.Point(3, 98);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.RowHeadersVisible = false;
            this.dgvEquipo.RowHeadersWidth = 72;
            this.dgvEquipo.RowTemplate.Height = 50;
            this.dgvEquipo.Size = new System.Drawing.Size(338, 411);
            this.dgvEquipo.TabIndex = 0;
            this.dgvEquipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 9;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 40;
            // 
            // colcolEquipo_Jugadores
            // 
            this.colcolEquipo_Jugadores.HeaderText = "Nombre";
            this.colcolEquipo_Jugadores.MinimumWidth = 9;
            this.colcolEquipo_Jugadores.Name = "colcolEquipo_Jugadores";
            this.colcolEquipo_Jugadores.ReadOnly = true;
            this.colcolEquipo_Jugadores.Width = 175;
            // 
            // colEscudo
            // 
            this.colEscudo.HeaderText = "Escudo";
            this.colEscudo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colEscudo.MinimumWidth = 99;
            this.colEscudo.Name = "colEscudo";
            this.colEscudo.ReadOnly = true;
            this.colEscudo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEscudo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbId_equipo
            // 
            this.lbId_equipo.AutoSize = true;
            this.lbId_equipo.BackColor = System.Drawing.Color.Transparent;
            this.lbId_equipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbId_equipo.Location = new System.Drawing.Point(16, 20);
            this.lbId_equipo.Name = "lbId_equipo";
            this.lbId_equipo.Size = new System.Drawing.Size(44, 13);
            this.lbId_equipo.TabIndex = 2;
            this.lbId_equipo.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(373, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 31);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(423, 15);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(64, 23);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(273, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(323, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(37, 31);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(223, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 31);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(930, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 28);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.loteria;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 74);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(360, 333);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 176);
            this.panel1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(51, 59);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero de Equipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(62, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sorteo";
            // 
            // dgvJugador
            // 
            this.dgvJugador.AllowUserToAddRows = false;
            this.dgvJugador.AllowUserToDeleteRows = false;
            this.dgvJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Persona,
            this.colNombres,
            this.colApellidos,
            this.colCedula,
            this.colFechaNacimiento,
            this.colTelefono,
            this.colNacionalidad,
            this.colFoto,
            this.colNumero,
            this.clID_equipo});
            this.dgvJugador.Location = new System.Drawing.Point(360, 98);
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.ReadOnly = true;
            this.dgvJugador.RowHeadersVisible = false;
            this.dgvJugador.RowHeadersWidth = 72;
            this.dgvJugador.Size = new System.Drawing.Size(603, 234);
            this.dgvJugador.TabIndex = 12;
            this.dgvJugador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugador_CellClick);
            // 
            // colID_Persona
            // 
            this.colID_Persona.HeaderText = "ID";
            this.colID_Persona.Name = "colID_Persona";
            this.colID_Persona.ReadOnly = true;
            this.colID_Persona.Width = 40;
            // 
            // colNombres
            // 
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colApellidos
            // 
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.HeaderText = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.ReadOnly = true;
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
            this.colFoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // clID_equipo
            // 
            this.clID_equipo.HeaderText = "ID Equipo";
            this.clID_equipo.Name = "clID_equipo";
            this.clID_equipo.ReadOnly = true;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarJugador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarJugador.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregarJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarJugador.Location = new System.Drawing.Point(781, 69);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarJugador.TabIndex = 40;
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarJugador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarJugador.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificarJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarJugador.Location = new System.Drawing.Point(826, 69);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(35, 23);
            this.btnModificarJugador.TabIndex = 41;
            this.btnModificarJugador.UseVisualStyleBackColor = false;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarJugador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarJugador.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscarJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarJugador.Location = new System.Drawing.Point(735, 69);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarJugador.TabIndex = 38;
            this.btnBuscarJugador.UseVisualStyleBackColor = false;
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarJugador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarJugador.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminarJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarJugador.Location = new System.Drawing.Point(872, 69);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarJugador.TabIndex = 42;
            this.btnEliminarJugador.UseVisualStyleBackColor = false;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // btnTodoJugador
            // 
            this.btnTodoJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodoJugador.Location = new System.Drawing.Point(918, 69);
            this.btnTodoJugador.Name = "btnTodoJugador";
            this.btnTodoJugador.Size = new System.Drawing.Size(46, 23);
            this.btnTodoJugador.TabIndex = 39;
            this.btnTodoJugador.Text = "Todo";
            this.btnTodoJugador.UseVisualStyleBackColor = true;
            this.btnTodoJugador.Click += new System.EventHandler(this.btnTodoJugador_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(629, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            // 
            // lbNombreDeEquipo
            // 
            this.lbNombreDeEquipo.AutoSize = true;
            this.lbNombreDeEquipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreDeEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDeEquipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombreDeEquipo.Location = new System.Drawing.Point(478, 71);
            this.lbNombreDeEquipo.Name = "lbNombreDeEquipo";
            this.lbNombreDeEquipo.Size = new System.Drawing.Size(60, 18);
            this.lbNombreDeEquipo.TabIndex = 36;
            this.lbNombreDeEquipo.Text = "Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(366, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Jugadores de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Equipo";
            // 
            // ucEquipoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.btnModificarJugador);
            this.Controls.Add(this.btnBuscarJugador);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.btnTodoJugador);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbNombreDeEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvJugador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_equipo);
            this.Controls.Add(this.dgvEquipo);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucEquipoConsultar";
            this.Size = new System.Drawing.Size(968, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo_Id_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo_Jugadores;
        private System.Windows.Forms.Label lbId_equipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolEquipo_Jugadores;
        private System.Windows.Forms.DataGridViewImageColumn colEscudo;
        private System.Windows.Forms.DataGridView dgvJugador;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.Button btnTodoJugador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNombreDeEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacionalidad;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID_equipo;
    }
}