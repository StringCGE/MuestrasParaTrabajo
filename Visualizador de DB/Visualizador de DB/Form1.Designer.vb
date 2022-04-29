<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_Exportar = New System.Windows.Forms.Button()
        Me.TB_ConsultaSQL = New System.Windows.Forms.TextBox()
        Me.BT_Abrir = New System.Windows.Forms.Button()
        Me.NRTB_ = New Visualizador_de_DB.NumberRichTextBox()
        Me.BT_MuestraC = New System.Windows.Forms.Button()
        Me.BT_Guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BT_Agregar = New System.Windows.Forms.Button()
        Me.BT_Cargar = New System.Windows.Forms.Button()
        Me.BT_Flecha_Izquierda = New System.Windows.Forms.Button()
        Me.BT_Flecha_Derecha = New System.Windows.Forms.Button()
        Me.BT_Ejecutar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.RTB_Comando = New System.Windows.Forms.RichTextBox()
        Me.OFD_ = New System.Windows.Forms.OpenFileDialog()
        Me.SFD_ = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogCGE1 = New Visualizador_de_DB.OpenFileDialogCGE()
        Me.BT_GenerarInsert = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.BT_Exportar)
        Me.Panel1.Controls.Add(Me.TB_ConsultaSQL)
        Me.Panel1.Controls.Add(Me.BT_Abrir)
        Me.Panel1.Controls.Add(Me.NRTB_)
        Me.Panel1.Controls.Add(Me.BT_MuestraC)
        Me.Panel1.Controls.Add(Me.BT_Guardar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BT_Agregar)
        Me.Panel1.Controls.Add(Me.BT_Cargar)
        Me.Panel1.Controls.Add(Me.BT_Flecha_Izquierda)
        Me.Panel1.Controls.Add(Me.BT_Flecha_Derecha)
        Me.Panel1.Controls.Add(Me.BT_Ejecutar)
        Me.Panel1.Controls.Add(Me.DGV)
        Me.Panel1.Controls.Add(Me.RTB_Comando)
        Me.Panel1.Location = New System.Drawing.Point(419, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 379)
        Me.Panel1.TabIndex = 33
        '
        'BT_Exportar
        '
        Me.BT_Exportar.Location = New System.Drawing.Point(3, 356)
        Me.BT_Exportar.Name = "BT_Exportar"
        Me.BT_Exportar.Size = New System.Drawing.Size(75, 19)
        Me.BT_Exportar.TabIndex = 38
        Me.BT_Exportar.Text = "Exportar"
        Me.BT_Exportar.UseVisualStyleBackColor = True
        '
        'TB_ConsultaSQL
        '
        Me.TB_ConsultaSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ConsultaSQL.Location = New System.Drawing.Point(82, 356)
        Me.TB_ConsultaSQL.Name = "TB_ConsultaSQL"
        Me.TB_ConsultaSQL.Size = New System.Drawing.Size(524, 20)
        Me.TB_ConsultaSQL.TabIndex = 37
        '
        'BT_Abrir
        '
        Me.BT_Abrir.Location = New System.Drawing.Point(209, 8)
        Me.BT_Abrir.Name = "BT_Abrir"
        Me.BT_Abrir.Size = New System.Drawing.Size(75, 23)
        Me.BT_Abrir.TabIndex = 36
        Me.BT_Abrir.Text = "Abrir"
        Me.BT_Abrir.UseVisualStyleBackColor = True
        Me.BT_Abrir.Visible = False
        '
        'NRTB_
        '
        Me.NRTB_.Location = New System.Drawing.Point(485, 251)
        Me.NRTB_.Name = "NRTB_"
        Me.NRTB_.Size = New System.Drawing.Size(118, 98)
        Me.NRTB_.TabIndex = 35
        Me.NRTB_.Visible = False
        '
        'BT_MuestraC
        '
        Me.BT_MuestraC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_MuestraC.Location = New System.Drawing.Point(371, 11)
        Me.BT_MuestraC.Name = "BT_MuestraC"
        Me.BT_MuestraC.Size = New System.Drawing.Size(19, 20)
        Me.BT_MuestraC.TabIndex = 32
        Me.BT_MuestraC.Text = "V"
        Me.BT_MuestraC.UseVisualStyleBackColor = True
        '
        'BT_Guardar
        '
        Me.BT_Guardar.Location = New System.Drawing.Point(290, 8)
        Me.BT_Guardar.Name = "BT_Guardar"
        Me.BT_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Guardar.TabIndex = 34
        Me.BT_Guardar.Text = "Guardar"
        Me.BT_Guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 35)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BT_Agregar
        '
        Me.BT_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Agregar.Location = New System.Drawing.Point(496, 3)
        Me.BT_Agregar.Name = "BT_Agregar"
        Me.BT_Agregar.Size = New System.Drawing.Size(110, 35)
        Me.BT_Agregar.TabIndex = 24
        Me.BT_Agregar.Text = "Agregar"
        Me.BT_Agregar.UseVisualStyleBackColor = True
        '
        'BT_Cargar
        '
        Me.BT_Cargar.Enabled = False
        Me.BT_Cargar.Location = New System.Drawing.Point(63, 3)
        Me.BT_Cargar.Name = "BT_Cargar"
        Me.BT_Cargar.Size = New System.Drawing.Size(50, 35)
        Me.BT_Cargar.TabIndex = 26
        Me.BT_Cargar.Text = "Cargar"
        Me.BT_Cargar.UseVisualStyleBackColor = True
        '
        'BT_Flecha_Izquierda
        '
        Me.BT_Flecha_Izquierda.BackgroundImage = Global.Visualizador_de_DB.My.Resources.Resources.Flecha_Izquierda_Negra_25px
        Me.BT_Flecha_Izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_Flecha_Izquierda.FlatAppearance.BorderSize = 0
        Me.BT_Flecha_Izquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen
        Me.BT_Flecha_Izquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.BT_Flecha_Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Flecha_Izquierda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BT_Flecha_Izquierda.Location = New System.Drawing.Point(123, 3)
        Me.BT_Flecha_Izquierda.Name = "BT_Flecha_Izquierda"
        Me.BT_Flecha_Izquierda.Size = New System.Drawing.Size(35, 35)
        Me.BT_Flecha_Izquierda.TabIndex = 29
        Me.BT_Flecha_Izquierda.UseVisualStyleBackColor = True
        '
        'BT_Flecha_Derecha
        '
        Me.BT_Flecha_Derecha.BackColor = System.Drawing.SystemColors.Control
        Me.BT_Flecha_Derecha.BackgroundImage = Global.Visualizador_de_DB.My.Resources.Resources.Flecha_Derecha_Negra_25px
        Me.BT_Flecha_Derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_Flecha_Derecha.FlatAppearance.BorderSize = 0
        Me.BT_Flecha_Derecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen
        Me.BT_Flecha_Derecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.BT_Flecha_Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Flecha_Derecha.Location = New System.Drawing.Point(164, 3)
        Me.BT_Flecha_Derecha.Name = "BT_Flecha_Derecha"
        Me.BT_Flecha_Derecha.Size = New System.Drawing.Size(35, 35)
        Me.BT_Flecha_Derecha.TabIndex = 30
        Me.BT_Flecha_Derecha.UseVisualStyleBackColor = False
        '
        'BT_Ejecutar
        '
        Me.BT_Ejecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Ejecutar.Location = New System.Drawing.Point(405, 4)
        Me.BT_Ejecutar.Name = "BT_Ejecutar"
        Me.BT_Ejecutar.Size = New System.Drawing.Size(75, 35)
        Me.BT_Ejecutar.TabIndex = 28
        Me.BT_Ejecutar.Text = "Ejecutar"
        Me.BT_Ejecutar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 43)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(603, 312)
        Me.DGV.TabIndex = 25
        '
        'RTB_Comando
        '
        Me.RTB_Comando.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_Comando.Location = New System.Drawing.Point(205, 11)
        Me.RTB_Comando.Name = "RTB_Comando"
        Me.RTB_Comando.Size = New System.Drawing.Size(169, 20)
        Me.RTB_Comando.TabIndex = 33
        Me.RTB_Comando.Text = ""
        '
        'SFD_
        '
        Me.SFD_.Filter = "Base de datos (*.db)|*.db"
        '
        'OpenFileDialogCGE1
        '
        Me.OpenFileDialogCGE1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OpenFileDialogCGE1.Location = New System.Drawing.Point(13, 13)
        Me.OpenFileDialogCGE1.MinimumSize = New System.Drawing.Size(300, 200)
        Me.OpenFileDialogCGE1.Name = "OpenFileDialogCGE1"
        Me.OpenFileDialogCGE1.Size = New System.Drawing.Size(400, 381)
        Me.OpenFileDialogCGE1.TabIndex = 0
        '
        'BT_GenerarInsert
        '
        Me.BT_GenerarInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_GenerarInsert.Location = New System.Drawing.Point(366, 0)
        Me.BT_GenerarInsert.Name = "BT_GenerarInsert"
        Me.BT_GenerarInsert.Size = New System.Drawing.Size(110, 22)
        Me.BT_GenerarInsert.TabIndex = 39
        Me.BT_GenerarInsert.Text = "Generar insert"
        Me.BT_GenerarInsert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 401)
        Me.Controls.Add(Me.BT_GenerarInsert)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OpenFileDialogCGE1)
        Me.MinimumSize = New System.Drawing.Size(1050, 440)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialogCGE1 As OpenFileDialogCGE
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BT_Agregar As Button
    Friend WithEvents BT_Cargar As Button
    Friend WithEvents BT_Flecha_Izquierda As Button
    Friend WithEvents BT_Flecha_Derecha As Button
    Friend WithEvents BT_Ejecutar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents OFD_ As OpenFileDialog
    Friend WithEvents SFD_ As SaveFileDialog
    Friend WithEvents RTB_Comando As RichTextBox
    Friend WithEvents BT_MuestraC As Button
    Friend WithEvents BT_Guardar As Button
    Friend WithEvents NRTB_ As NumberRichTextBox
    Friend WithEvents BT_Abrir As Button
    Friend WithEvents TB_ConsultaSQL As TextBox
    Friend WithEvents BT_Exportar As Button
    Friend WithEvents BT_GenerarInsert As Button
End Class
