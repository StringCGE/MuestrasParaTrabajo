<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Requerimiento
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Codigo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_Baja_Opcional = New System.Windows.Forms.RadioButton()
        Me.RB_Media_Deseado = New System.Windows.Forms.RadioButton()
        Me.RB_Alta_Esencial = New System.Windows.Forms.RadioButton()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Fuente = New System.Windows.Forms.TextBox()
        Me.RB_Requisito = New System.Windows.Forms.RadioButton()
        Me.RB_Restriccion = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BT_Agregar = New System.Windows.Forms.Button()
        Me.BT_Min = New System.Windows.Forms.Button()
        Me.BT_Cerrar = New System.Windows.Forms.Button()
        Me.BT_Max = New System.Windows.Forms.Button()
        Me.BT_Agrandar = New System.Windows.Forms.Button()
        Me.FLP_ = New System.Windows.Forms.FlowLayoutPanel()
        Me.TB_Comentario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BT_Down = New System.Windows.Forms.Button()
        Me.BT_Up = New System.Windows.Forms.Button()
        Me.BT_AgrandarHorizontal = New System.Windows.Forms.Button()
        Me.BT_AchicarHorizontal = New System.Windows.Forms.Button()
        Me.CMS_ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreescribirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_Interno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CMS_.SuspendLayout()
        Me.CMS_Interno.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de requerimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de requisito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fuente del requisito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prioridad del requisito"
        '
        'TB_Codigo
        '
        Me.TB_Codigo.Location = New System.Drawing.Point(192, 3)
        Me.TB_Codigo.Name = "TB_Codigo"
        Me.TB_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.TB_Codigo.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RB_Baja_Opcional)
        Me.Panel1.Controls.Add(Me.RB_Media_Deseado)
        Me.Panel1.Controls.Add(Me.RB_Alta_Esencial)
        Me.Panel1.Location = New System.Drawing.Point(192, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 20)
        Me.Panel1.TabIndex = 6
        '
        'RB_Baja_Opcional
        '
        Me.RB_Baja_Opcional.AutoSize = True
        Me.RB_Baja_Opcional.Location = New System.Drawing.Point(205, 1)
        Me.RB_Baja_Opcional.Name = "RB_Baja_Opcional"
        Me.RB_Baja_Opcional.Size = New System.Drawing.Size(93, 17)
        Me.RB_Baja_Opcional.TabIndex = 14
        Me.RB_Baja_Opcional.TabStop = True
        Me.RB_Baja_Opcional.Text = "Baja/Opcional"
        Me.RB_Baja_Opcional.UseVisualStyleBackColor = True
        '
        'RB_Media_Deseado
        '
        Me.RB_Media_Deseado.AutoSize = True
        Me.RB_Media_Deseado.Location = New System.Drawing.Point(97, 1)
        Me.RB_Media_Deseado.Name = "RB_Media_Deseado"
        Me.RB_Media_Deseado.Size = New System.Drawing.Size(102, 17)
        Me.RB_Media_Deseado.TabIndex = 13
        Me.RB_Media_Deseado.TabStop = True
        Me.RB_Media_Deseado.Text = "Media/Deseado"
        Me.RB_Media_Deseado.UseVisualStyleBackColor = True
        '
        'RB_Alta_Esencial
        '
        Me.RB_Alta_Esencial.AutoSize = True
        Me.RB_Alta_Esencial.Location = New System.Drawing.Point(3, 1)
        Me.RB_Alta_Esencial.Name = "RB_Alta_Esencial"
        Me.RB_Alta_Esencial.Size = New System.Drawing.Size(88, 17)
        Me.RB_Alta_Esencial.TabIndex = 12
        Me.RB_Alta_Esencial.TabStop = True
        Me.RB_Alta_Esencial.Text = "Alta/Esencial"
        Me.RB_Alta_Esencial.UseVisualStyleBackColor = True
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Nombre.Location = New System.Drawing.Point(192, 29)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(305, 20)
        Me.TB_Nombre.TabIndex = 7
        '
        'TB_Fuente
        '
        Me.TB_Fuente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Fuente.Location = New System.Drawing.Point(192, 81)
        Me.TB_Fuente.Name = "TB_Fuente"
        Me.TB_Fuente.Size = New System.Drawing.Size(305, 20)
        Me.TB_Fuente.TabIndex = 9
        '
        'RB_Requisito
        '
        Me.RB_Requisito.AutoSize = True
        Me.RB_Requisito.Location = New System.Drawing.Point(3, 1)
        Me.RB_Requisito.Name = "RB_Requisito"
        Me.RB_Requisito.Size = New System.Drawing.Size(69, 17)
        Me.RB_Requisito.TabIndex = 10
        Me.RB_Requisito.TabStop = True
        Me.RB_Requisito.Text = "Requisito"
        Me.RB_Requisito.UseVisualStyleBackColor = True
        '
        'RB_Restriccion
        '
        Me.RB_Restriccion.AutoSize = True
        Me.RB_Restriccion.Location = New System.Drawing.Point(78, 1)
        Me.RB_Restriccion.Name = "RB_Restriccion"
        Me.RB_Restriccion.Size = New System.Drawing.Size(78, 17)
        Me.RB_Restriccion.TabIndex = 11
        Me.RB_Restriccion.TabStop = True
        Me.RB_Restriccion.Text = "Restricción"
        Me.RB_Restriccion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RB_Restriccion)
        Me.Panel2.Controls.Add(Me.RB_Requisito)
        Me.Panel2.Location = New System.Drawing.Point(192, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 20)
        Me.Panel2.TabIndex = 16
        '
        'BT_Agregar
        '
        Me.BT_Agregar.Location = New System.Drawing.Point(6, 153)
        Me.BT_Agregar.Name = "BT_Agregar"
        Me.BT_Agregar.Size = New System.Drawing.Size(62, 63)
        Me.BT_Agregar.TabIndex = 17
        Me.BT_Agregar.Text = "Agregar"
        Me.BT_Agregar.UseVisualStyleBackColor = True
        '
        'BT_Min
        '
        Me.BT_Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Min.Location = New System.Drawing.Point(420, 0)
        Me.BT_Min.Name = "BT_Min"
        Me.BT_Min.Size = New System.Drawing.Size(24, 23)
        Me.BT_Min.TabIndex = 18
        Me.BT_Min.Text = "_"
        Me.BT_Min.UseVisualStyleBackColor = True
        '
        'BT_Cerrar
        '
        Me.BT_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Cerrar.Location = New System.Drawing.Point(473, 0)
        Me.BT_Cerrar.Name = "BT_Cerrar"
        Me.BT_Cerrar.Size = New System.Drawing.Size(24, 23)
        Me.BT_Cerrar.TabIndex = 19
        Me.BT_Cerrar.Text = "X"
        Me.BT_Cerrar.UseVisualStyleBackColor = True
        '
        'BT_Max
        '
        Me.BT_Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Max.Location = New System.Drawing.Point(447, 0)
        Me.BT_Max.Name = "BT_Max"
        Me.BT_Max.Size = New System.Drawing.Size(24, 23)
        Me.BT_Max.TabIndex = 20
        Me.BT_Max.Text = "█"
        Me.BT_Max.UseVisualStyleBackColor = True
        '
        'BT_Agrandar
        '
        Me.BT_Agrandar.Location = New System.Drawing.Point(0, 109)
        Me.BT_Agrandar.Name = "BT_Agrandar"
        Me.BT_Agrandar.Size = New System.Drawing.Size(24, 23)
        Me.BT_Agrandar.TabIndex = 21
        Me.BT_Agrandar.Text = "V"
        Me.BT_Agrandar.UseVisualStyleBackColor = True
        '
        'FLP_
        '
        Me.FLP_.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FLP_.AutoScroll = True
        Me.FLP_.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FLP_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLP_.ContextMenuStrip = Me.CMS_Interno
        Me.FLP_.Location = New System.Drawing.Point(6, 222)
        Me.FLP_.Name = "FLP_"
        Me.FLP_.Size = New System.Drawing.Size(491, 349)
        Me.FLP_.TabIndex = 22
        '
        'TB_Comentario
        '
        Me.TB_Comentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Comentario.Location = New System.Drawing.Point(74, 133)
        Me.TB_Comentario.Multiline = True
        Me.TB_Comentario.Name = "TB_Comentario"
        Me.TB_Comentario.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB_Comentario.Size = New System.Drawing.Size(423, 83)
        Me.TB_Comentario.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Comentario"
        '
        'BT_Down
        '
        Me.BT_Down.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Down.Location = New System.Drawing.Point(394, 0)
        Me.BT_Down.Name = "BT_Down"
        Me.BT_Down.Size = New System.Drawing.Size(20, 23)
        Me.BT_Down.TabIndex = 26
        Me.BT_Down.Text = "V"
        Me.BT_Down.UseVisualStyleBackColor = True
        '
        'BT_Up
        '
        Me.BT_Up.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Up.Location = New System.Drawing.Point(368, 0)
        Me.BT_Up.Name = "BT_Up"
        Me.BT_Up.Size = New System.Drawing.Size(20, 23)
        Me.BT_Up.TabIndex = 25
        Me.BT_Up.Text = "∧"
        Me.BT_Up.UseVisualStyleBackColor = True
        '
        'BT_AgrandarHorizontal
        '
        Me.BT_AgrandarHorizontal.Location = New System.Drawing.Point(329, 1)
        Me.BT_AgrandarHorizontal.Name = "BT_AgrandarHorizontal"
        Me.BT_AgrandarHorizontal.Size = New System.Drawing.Size(20, 23)
        Me.BT_AgrandarHorizontal.TabIndex = 28
        Me.BT_AgrandarHorizontal.Text = ">"
        Me.BT_AgrandarHorizontal.UseVisualStyleBackColor = True
        '
        'BT_AchicarHorizontal
        '
        Me.BT_AchicarHorizontal.Location = New System.Drawing.Point(303, 1)
        Me.BT_AchicarHorizontal.Name = "BT_AchicarHorizontal"
        Me.BT_AchicarHorizontal.Size = New System.Drawing.Size(20, 23)
        Me.BT_AchicarHorizontal.TabIndex = 27
        Me.BT_AchicarHorizontal.Text = "<"
        Me.BT_AchicarHorizontal.UseVisualStyleBackColor = True
        '
        'CMS_
        '
        Me.CMS_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.SobreescribirToolStripMenuItem})
        Me.CMS_.Name = "ContextMenuStrip1"
        Me.CMS_.Size = New System.Drawing.Size(143, 70)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'SobreescribirToolStripMenuItem
        '
        Me.SobreescribirToolStripMenuItem.Name = "SobreescribirToolStripMenuItem"
        Me.SobreescribirToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SobreescribirToolStripMenuItem.Text = "Sobreescribir"
        '
        'CMS_Interno
        '
        Me.CMS_Interno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegarToolStripMenuItem})
        Me.CMS_Interno.Name = "CMS_Interno"
        Me.CMS_Interno.Size = New System.Drawing.Size(153, 48)
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'UC_Requerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ContextMenuStrip = Me.CMS_
        Me.Controls.Add(Me.BT_AgrandarHorizontal)
        Me.Controls.Add(Me.BT_AchicarHorizontal)
        Me.Controls.Add(Me.BT_Down)
        Me.Controls.Add(Me.BT_Up)
        Me.Controls.Add(Me.TB_Comentario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FLP_)
        Me.Controls.Add(Me.BT_Agrandar)
        Me.Controls.Add(Me.BT_Max)
        Me.Controls.Add(Me.BT_Cerrar)
        Me.Controls.Add(Me.BT_Min)
        Me.Controls.Add(Me.BT_Agregar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TB_Fuente)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB_Codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_Requerimiento"
        Me.Size = New System.Drawing.Size(501, 574)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CMS_.ResumeLayout(False)
        Me.CMS_Interno.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Codigo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RB_Baja_Opcional As RadioButton
    Friend WithEvents RB_Media_Deseado As RadioButton
    Friend WithEvents RB_Alta_Esencial As RadioButton
    Friend WithEvents TB_Nombre As TextBox
    Friend WithEvents TB_Fuente As TextBox
    Friend WithEvents RB_Requisito As RadioButton
    Friend WithEvents RB_Restriccion As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BT_Agregar As Button
    Friend WithEvents BT_Min As Button
    Friend WithEvents BT_Cerrar As Button
    Friend WithEvents BT_Max As Button
    Friend WithEvents BT_Agrandar As Button
    Friend WithEvents FLP_ As FlowLayoutPanel
    Friend WithEvents TB_Comentario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BT_Down As Button
    Friend WithEvents BT_Up As Button
    Friend WithEvents BT_AgrandarHorizontal As Button
    Friend WithEvents BT_AchicarHorizontal As Button
    Friend WithEvents CMS_ As ContextMenuStrip
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreescribirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMS_Interno As ContextMenuStrip
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
End Class
