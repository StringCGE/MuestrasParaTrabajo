namespace CapaPresentacion {
    partial class ucCampeonatoConsultar {
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
            this.dgvCampeonato = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolCampeonato_Nombre_campeonado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_campeonato = new System.Windows.Forms.TextBox();
            this.lbId_campeonato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvFecha = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombreDeCampeonato = new System.Windows.Forms.Label();
            this.lbNombreDeFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarFecha = new System.Windows.Forms.Button();
            this.btnModificarFecha = new System.Windows.Forms.Button();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.btnEliminarFecha = new System.Windows.Forms.Button();
            this.btnTodoFecha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.btnModificarPartido = new System.Windows.Forms.Button();
            this.btnBuscarPartidos = new System.Windows.Forms.Button();
            this.btnEliminarPartido = new System.Windows.Forms.Button();
            this.btnTodoPartido = new System.Windows.Forms.Button();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.flp_Partidos = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampeonato
            // 
            this.dgvCampeonato.AllowUserToAddRows = false;
            this.dgvCampeonato.AllowUserToDeleteRows = false;
            this.dgvCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colcolCampeonato_Nombre_campeonado});
            this.dgvCampeonato.Location = new System.Drawing.Point(6, 45);
            this.dgvCampeonato.Name = "dgvCampeonato";
            this.dgvCampeonato.ReadOnly = true;
            this.dgvCampeonato.RowHeadersVisible = false;
            this.dgvCampeonato.RowHeadersWidth = 72;
            this.dgvCampeonato.Size = new System.Drawing.Size(228, 429);
            this.dgvCampeonato.TabIndex = 0;
            this.dgvCampeonato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampeonato_CellClick);
            this.dgvCampeonato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampeonato_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 9;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 40;
            // 
            // colcolCampeonato_Nombre_campeonado
            // 
            this.colcolCampeonato_Nombre_campeonado.HeaderText = "Nombre";
            this.colcolCampeonato_Nombre_campeonado.MinimumWidth = 9;
            this.colcolCampeonato_Nombre_campeonado.Name = "colcolCampeonato_Nombre_campeonado";
            this.colcolCampeonato_Nombre_campeonado.ReadOnly = true;
            this.colcolCampeonato_Nombre_campeonado.Width = 175;
            // 
            // txtId_campeonato
            // 
            this.txtId_campeonato.Location = new System.Drawing.Point(172, 8);
            this.txtId_campeonato.Name = "txtId_campeonato";
            this.txtId_campeonato.Size = new System.Drawing.Size(100, 20);
            this.txtId_campeonato.TabIndex = 1;
            // 
            // lbId_campeonato
            // 
            this.lbId_campeonato.AutoSize = true;
            this.lbId_campeonato.Location = new System.Drawing.Point(121, 12);
            this.lbId_campeonato.Name = "lbId_campeonato";
            this.lbId_campeonato.Size = new System.Drawing.Size(44, 13);
            this.lbId_campeonato.TabIndex = 2;
            this.lbId_campeonato.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(289, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(426, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(472, 7);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(46, 23);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(766, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 28);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(335, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(380, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvFecha
            // 
            this.dgvFecha.AllowUserToAddRows = false;
            this.dgvFecha.AllowUserToDeleteRows = false;
            this.dgvFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colNumero,
            this.colInicio,
            this.colFin});
            this.dgvFecha.Location = new System.Drawing.Point(262, 73);
            this.dgvFecha.Name = "dgvFecha";
            this.dgvFecha.ReadOnly = true;
            this.dgvFecha.RowHeadersVisible = false;
            this.dgvFecha.RowHeadersWidth = 72;
            this.dgvFecha.Size = new System.Drawing.Size(536, 157);
            this.dgvFecha.TabIndex = 8;
            this.dgvFecha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFecha_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colInicio
            // 
            this.colInicio.HeaderText = "Inicio";
            this.colInicio.Name = "colInicio";
            this.colInicio.ReadOnly = true;
            // 
            // colFin
            // 
            this.colFin.HeaderText = "Fin";
            this.colFin.Name = "colFin";
            this.colFin.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Campeonato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(259, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fechas de:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNombreDeCampeonato
            // 
            this.lbNombreDeCampeonato.AutoSize = true;
            this.lbNombreDeCampeonato.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreDeCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDeCampeonato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombreDeCampeonato.Location = new System.Drawing.Point(351, 47);
            this.lbNombreDeCampeonato.Name = "lbNombreDeCampeonato";
            this.lbNombreDeCampeonato.Size = new System.Drawing.Size(104, 18);
            this.lbNombreDeCampeonato.TabIndex = 11;
            this.lbNombreDeCampeonato.Text = "Campeonato";
            this.lbNombreDeCampeonato.Click += new System.EventHandler(this.lbNombreDeCampeonato_Click);
            // 
            // lbNombreDeFecha
            // 
            this.lbNombreDeFecha.AutoSize = true;
            this.lbNombreDeFecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreDeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDeFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombreDeFecha.Location = new System.Drawing.Point(358, 244);
            this.lbNombreDeFecha.Name = "lbNombreDeFecha";
            this.lbNombreDeFecha.Size = new System.Drawing.Size(54, 18);
            this.lbNombreDeFecha.TabIndex = 14;
            this.lbNombreDeFecha.Text = "Fecha";
            this.lbNombreDeFecha.Click += new System.EventHandler(this.lbNombreDeFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(259, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Partidos de:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAgregarFecha
            // 
            this.btnAgregarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarFecha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarFecha.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarFecha.Location = new System.Drawing.Point(618, 45);
            this.btnAgregarFecha.Name = "btnAgregarFecha";
            this.btnAgregarFecha.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarFecha.TabIndex = 18;
            this.btnAgregarFecha.UseVisualStyleBackColor = false;
            this.btnAgregarFecha.Click += new System.EventHandler(this.btnAgregarFecha_Click);
            // 
            // btnModificarFecha
            // 
            this.btnModificarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarFecha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarFecha.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarFecha.Location = new System.Drawing.Point(663, 45);
            this.btnModificarFecha.Name = "btnModificarFecha";
            this.btnModificarFecha.Size = new System.Drawing.Size(35, 23);
            this.btnModificarFecha.TabIndex = 19;
            this.btnModificarFecha.UseVisualStyleBackColor = false;
            this.btnModificarFecha.Click += new System.EventHandler(this.btnModificarFecha_Click);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFecha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarFecha.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFecha.Location = new System.Drawing.Point(572, 45);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarFecha.TabIndex = 16;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // btnEliminarFecha
            // 
            this.btnEliminarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarFecha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarFecha.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarFecha.Location = new System.Drawing.Point(709, 45);
            this.btnEliminarFecha.Name = "btnEliminarFecha";
            this.btnEliminarFecha.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarFecha.TabIndex = 20;
            this.btnEliminarFecha.UseVisualStyleBackColor = false;
            this.btnEliminarFecha.Click += new System.EventHandler(this.btnEliminarFecha_Click);
            // 
            // btnTodoFecha
            // 
            this.btnTodoFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodoFecha.Location = new System.Drawing.Point(755, 45);
            this.btnTodoFecha.Name = "btnTodoFecha";
            this.btnTodoFecha.Size = new System.Drawing.Size(46, 23);
            this.btnTodoFecha.TabIndex = 17;
            this.btnTodoFecha.Text = "Todo";
            this.btnTodoFecha.UseVisualStyleBackColor = true;
            this.btnTodoFecha.Click += new System.EventHandler(this.btnTodoFecha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(466, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPartido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarPartido.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregarPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPartido.Location = new System.Drawing.Point(615, 242);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarPartido.TabIndex = 24;
            this.btnAgregarPartido.UseVisualStyleBackColor = false;
            this.btnAgregarPartido.Click += new System.EventHandler(this.btnAgregarPartido_Click);
            // 
            // btnModificarPartido
            // 
            this.btnModificarPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPartido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarPartido.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificarPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPartido.Location = new System.Drawing.Point(660, 242);
            this.btnModificarPartido.Name = "btnModificarPartido";
            this.btnModificarPartido.Size = new System.Drawing.Size(35, 23);
            this.btnModificarPartido.TabIndex = 25;
            this.btnModificarPartido.UseVisualStyleBackColor = false;
            this.btnModificarPartido.Click += new System.EventHandler(this.btnModificarPartido_Click);
            // 
            // btnBuscarPartidos
            // 
            this.btnBuscarPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPartidos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarPartidos.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscarPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPartidos.Location = new System.Drawing.Point(569, 242);
            this.btnBuscarPartidos.Name = "btnBuscarPartidos";
            this.btnBuscarPartidos.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarPartidos.TabIndex = 22;
            this.btnBuscarPartidos.UseVisualStyleBackColor = false;
            this.btnBuscarPartidos.Click += new System.EventHandler(this.btnBuscarPartidos_Click);
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPartido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarPartido.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminarPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPartido.Location = new System.Drawing.Point(706, 242);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarPartido.TabIndex = 26;
            this.btnEliminarPartido.UseVisualStyleBackColor = false;
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // btnTodoPartido
            // 
            this.btnTodoPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodoPartido.Location = new System.Drawing.Point(752, 242);
            this.btnTodoPartido.Name = "btnTodoPartido";
            this.btnTodoPartido.Size = new System.Drawing.Size(46, 23);
            this.btnTodoPartido.TabIndex = 23;
            this.btnTodoPartido.Text = "Todo";
            this.btnTodoPartido.UseVisualStyleBackColor = true;
            this.btnTodoPartido.Click += new System.EventHandler(this.btnTodoPartido_Click);
            // 
            // txtPartido
            // 
            this.txtPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartido.Location = new System.Drawing.Point(463, 243);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(100, 20);
            this.txtPartido.TabIndex = 21;
            // 
            // flp_Partidos
            // 
            this.flp_Partidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Partidos.Location = new System.Drawing.Point(262, 269);
            this.flp_Partidos.Name = "flp_Partidos";
            this.flp_Partidos.Size = new System.Drawing.Size(536, 205);
            this.flp_Partidos.TabIndex = 27;
            // 
            // ucCampeonatoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.flp_Partidos);
            this.Controls.Add(this.btnAgregarPartido);
            this.Controls.Add(this.btnModificarPartido);
            this.Controls.Add(this.btnBuscarPartidos);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.btnTodoPartido);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.btnAgregarFecha);
            this.Controls.Add(this.btnModificarFecha);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.btnEliminarFecha);
            this.Controls.Add(this.btnTodoFecha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNombreDeFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNombreDeCampeonato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_campeonato);
            this.Controls.Add(this.txtId_campeonato);
            this.Controls.Add(this.dgvCampeonato);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ucCampeonatoConsultar";
            this.Size = new System.Drawing.Size(804, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCampeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Id_campeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Nombre_campeonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Fechas;
        private System.Windows.Forms.TextBox txtId_campeonato;
        private System.Windows.Forms.Label lbId_campeonato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolCampeonato_Nombre_campeonado;
        private System.Windows.Forms.DataGridView dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNombreDeCampeonato;
        private System.Windows.Forms.Label lbNombreDeFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarFecha;
        private System.Windows.Forms.Button btnModificarFecha;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Button btnEliminarFecha;
        private System.Windows.Forms.Button btnTodoFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarPartido;
        private System.Windows.Forms.Button btnModificarPartido;
        private System.Windows.Forms.Button btnBuscarPartidos;
        private System.Windows.Forms.Button btnEliminarPartido;
        private System.Windows.Forms.Button btnTodoPartido;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.FlowLayoutPanel flp_Partidos;
    }
}