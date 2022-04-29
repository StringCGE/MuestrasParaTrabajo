namespace CapaPresentacion {
    partial class ucActaConsultar {
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
            this.dgvActa = new System.Windows.Forms.DataGridView();
            this.colcolActa_Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolActa_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolActa_Marcador_acta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolActa_Equipoa_acta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolActa_Equipob_acta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_acta = new System.Windows.Forms.TextBox();
            this.lbId_acta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActa
            // 
            this.dgvActa.AllowUserToAddRows = false;
            this.dgvActa.AllowUserToDeleteRows = false;
            this.dgvActa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcolActa_Partido,
            this.colcolActa_Fecha,
            this.colcolActa_Marcador_acta,
            this.colcolActa_Equipoa_acta,
            this.colcolActa_Equipob_acta});
            this.dgvActa.Location = new System.Drawing.Point(3, 49);
            this.dgvActa.Name = "dgvActa";
            this.dgvActa.ReadOnly = true;
            this.dgvActa.RowHeadersWidth = 72;
            this.dgvActa.Size = new System.Drawing.Size(546, 363);
            this.dgvActa.TabIndex = 0;
            // 
            // colcolActa_Partido
            // 
            this.colcolActa_Partido.HeaderText = "Partido";
            this.colcolActa_Partido.MinimumWidth = 9;
            this.colcolActa_Partido.Name = "colcolActa_Partido";
            this.colcolActa_Partido.ReadOnly = true;
            this.colcolActa_Partido.Width = 175;
            // 
            // colcolActa_Fecha
            // 
            this.colcolActa_Fecha.HeaderText = "Fecha";
            this.colcolActa_Fecha.MinimumWidth = 9;
            this.colcolActa_Fecha.Name = "colcolActa_Fecha";
            this.colcolActa_Fecha.ReadOnly = true;
            this.colcolActa_Fecha.Width = 175;
            // 
            // colcolActa_Marcador_acta
            // 
            this.colcolActa_Marcador_acta.HeaderText = "Marcador";
            this.colcolActa_Marcador_acta.MinimumWidth = 9;
            this.colcolActa_Marcador_acta.Name = "colcolActa_Marcador_acta";
            this.colcolActa_Marcador_acta.ReadOnly = true;
            this.colcolActa_Marcador_acta.Width = 175;
            // 
            // colcolActa_Equipoa_acta
            // 
            this.colcolActa_Equipoa_acta.HeaderText = "Equipo A";
            this.colcolActa_Equipoa_acta.MinimumWidth = 9;
            this.colcolActa_Equipoa_acta.Name = "colcolActa_Equipoa_acta";
            this.colcolActa_Equipoa_acta.ReadOnly = true;
            this.colcolActa_Equipoa_acta.Width = 175;
            // 
            // colcolActa_Equipob_acta
            // 
            this.colcolActa_Equipob_acta.HeaderText = "Equipo B";
            this.colcolActa_Equipob_acta.MinimumWidth = 9;
            this.colcolActa_Equipob_acta.Name = "colcolActa_Equipob_acta";
            this.colcolActa_Equipob_acta.ReadOnly = true;
            this.colcolActa_Equipob_acta.Width = 175;
            // 
            // txtId_acta
            // 
            this.txtId_acta.Location = new System.Drawing.Point(101, 20);
            this.txtId_acta.Name = "txtId_acta";
            this.txtId_acta.Size = new System.Drawing.Size(100, 20);
            this.txtId_acta.TabIndex = 1;
            // 
            // lbId_acta
            // 
            this.lbId_acta.AutoSize = true;
            this.lbId_acta.BackColor = System.Drawing.Color.Transparent;
            this.lbId_acta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbId_acta.Location = new System.Drawing.Point(28, 22);
            this.lbId_acta.Name = "lbId_acta";
            this.lbId_acta.Size = new System.Drawing.Size(40, 13);
            this.lbId_acta.TabIndex = 2;
            this.lbId_acta.Text = "Partido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(225, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(355, 11);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(64, 23);
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
            this.btnRegresar.Location = new System.Drawing.Point(546, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnAgregar.Location = new System.Drawing.Point(290, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ucActaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_acta);
            this.Controls.Add(this.txtId_acta);
            this.Controls.Add(this.dgvActa);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "ucActaConsultar";
            this.Size = new System.Drawing.Size(584, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Id_acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Marcador_acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Equipoa_acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActa_Equipob_acta;
        private System.Windows.Forms.TextBox txtId_acta;
        private System.Windows.Forms.Label lbId_acta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolActa_Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolActa_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolActa_Marcador_acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolActa_Equipoa_acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolActa_Equipob_acta;
    }
}