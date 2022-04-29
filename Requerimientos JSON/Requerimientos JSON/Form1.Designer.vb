<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BT_Agregar = New System.Windows.Forms.Button()
        Me.FLP_ = New System.Windows.Forms.FlowLayoutPanel()
        Me.CMS_ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD_ = New System.Windows.Forms.OpenFileDialog()
        Me.SFD_ = New System.Windows.Forms.SaveFileDialog()
        Me.BT_Reenumerar = New System.Windows.Forms.Button()
        Me.TB_Base = New System.Windows.Forms.TextBox()
        Me.BT_MinimizarTodo = New System.Windows.Forms.Button()
        Me.BT_MaximizarTodo = New System.Windows.Forms.Button()
        Me.BT_AgrandarTodo = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TB_NumInicio = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CHB_PorNivel = New System.Windows.Forms.RadioButton()
        Me.CHB_Continuo = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Fin = New System.Windows.Forms.TextBox()
        Me.CHB_EnterComentario = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Separador = New System.Windows.Forms.TextBox()
        Me.TB_Desde = New System.Windows.Forms.TextBox()
        Me.CHB_Numerar = New System.Windows.Forms.CheckBox()
        Me.BT_GenerarInforme = New System.Windows.Forms.Button()
        Me.RTB_ = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_Agregar
        '
        Me.BT_Agregar.Location = New System.Drawing.Point(3, 3)
        Me.BT_Agregar.Name = "BT_Agregar"
        Me.BT_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Agregar.TabIndex = 0
        Me.BT_Agregar.Text = "Agregar"
        Me.BT_Agregar.UseVisualStyleBackColor = True
        '
        'FLP_
        '
        Me.FLP_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FLP_.AutoScroll = True
        Me.FLP_.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FLP_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLP_.ContextMenuStrip = Me.CMS_
        Me.FLP_.Location = New System.Drawing.Point(3, 32)
        Me.FLP_.Name = "FLP_"
        Me.FLP_.Size = New System.Drawing.Size(836, 545)
        Me.FLP_.TabIndex = 1
        '
        'CMS_
        '
        Me.CMS_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegarToolStripMenuItem})
        Me.CMS_.Name = "CMS_"
        Me.CMS_.Size = New System.Drawing.Size(105, 26)
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'OFD_
        '
        Me.OFD_.Filter = "Archivos Json (*.json)|*.json|Archivos de texto (*.txt)|*.txt|Todos los archivos " &
    "(*.*)|*.*"
        '
        'SFD_
        '
        Me.SFD_.Filter = "Archivos Json (*.json)|*.json|Archivos de texto (*.txt)|*.txt|Todos los archivos " &
    "(*.*)|*.*"
        '
        'BT_Reenumerar
        '
        Me.BT_Reenumerar.Location = New System.Drawing.Point(84, 3)
        Me.BT_Reenumerar.Name = "BT_Reenumerar"
        Me.BT_Reenumerar.Size = New System.Drawing.Size(81, 23)
        Me.BT_Reenumerar.TabIndex = 1
        Me.BT_Reenumerar.Text = "Reenumerar"
        Me.BT_Reenumerar.UseVisualStyleBackColor = True
        '
        'TB_Base
        '
        Me.TB_Base.Location = New System.Drawing.Point(171, 5)
        Me.TB_Base.Name = "TB_Base"
        Me.TB_Base.Size = New System.Drawing.Size(88, 20)
        Me.TB_Base.TabIndex = 2
        Me.TB_Base.Text = "RF-"
        '
        'BT_MinimizarTodo
        '
        Me.BT_MinimizarTodo.Location = New System.Drawing.Point(590, 4)
        Me.BT_MinimizarTodo.Name = "BT_MinimizarTodo"
        Me.BT_MinimizarTodo.Size = New System.Drawing.Size(63, 23)
        Me.BT_MinimizarTodo.TabIndex = 6
        Me.BT_MinimizarTodo.Text = "Minimizar"
        Me.BT_MinimizarTodo.UseVisualStyleBackColor = True
        '
        'BT_MaximizarTodo
        '
        Me.BT_MaximizarTodo.Location = New System.Drawing.Point(659, 4)
        Me.BT_MaximizarTodo.Name = "BT_MaximizarTodo"
        Me.BT_MaximizarTodo.Size = New System.Drawing.Size(63, 23)
        Me.BT_MaximizarTodo.TabIndex = 7
        Me.BT_MaximizarTodo.Text = "Maximizar"
        Me.BT_MaximizarTodo.UseVisualStyleBackColor = True
        '
        'BT_AgrandarTodo
        '
        Me.BT_AgrandarTodo.Location = New System.Drawing.Point(728, 4)
        Me.BT_AgrandarTodo.Name = "BT_AgrandarTodo"
        Me.BT_AgrandarTodo.Size = New System.Drawing.Size(63, 23)
        Me.BT_AgrandarTodo.TabIndex = 8
        Me.BT_AgrandarTodo.Text = "Agrabdar"
        Me.BT_AgrandarTodo.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TB_NumInicio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FLP_)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TB_Fin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BT_Agregar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BT_AgrandarTodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BT_MaximizarTodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BT_MinimizarTodo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TB_Base)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BT_Reenumerar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHB_EnterComentario)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TB_Separador)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TB_Desde)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHB_Numerar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BT_GenerarInforme)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RTB_)
        Me.SplitContainer1.Size = New System.Drawing.Size(1306, 580)
        Me.SplitContainer1.SplitterDistance = 843
        Me.SplitContainer1.TabIndex = 9
        '
        'TB_NumInicio
        '
        Me.TB_NumInicio.Location = New System.Drawing.Point(287, 5)
        Me.TB_NumInicio.Name = "TB_NumInicio"
        Me.TB_NumInicio.Size = New System.Drawing.Size(40, 20)
        Me.TB_NumInicio.TabIndex = 12
        Me.TB_NumInicio.Text = "1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CHB_PorNivel)
        Me.Panel1.Controls.Add(Me.CHB_Continuo)
        Me.Panel1.Location = New System.Drawing.Point(385, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 30)
        Me.Panel1.TabIndex = 11
        '
        'CHB_PorNivel
        '
        Me.CHB_PorNivel.AutoSize = True
        Me.CHB_PorNivel.Checked = True
        Me.CHB_PorNivel.Location = New System.Drawing.Point(3, 6)
        Me.CHB_PorNivel.Name = "CHB_PorNivel"
        Me.CHB_PorNivel.Size = New System.Drawing.Size(66, 17)
        Me.CHB_PorNivel.TabIndex = 4
        Me.CHB_PorNivel.TabStop = True
        Me.CHB_PorNivel.Text = "Por nivel"
        Me.CHB_PorNivel.UseVisualStyleBackColor = True
        '
        'CHB_Continuo
        '
        Me.CHB_Continuo.AutoSize = True
        Me.CHB_Continuo.Location = New System.Drawing.Point(75, 6)
        Me.CHB_Continuo.Name = "CHB_Continuo"
        Me.CHB_Continuo.Size = New System.Drawing.Size(67, 17)
        Me.CHB_Continuo.TabIndex = 5
        Me.CHB_Continuo.Text = "Continuo"
        Me.CHB_Continuo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "#"
        '
        'TB_Fin
        '
        Me.TB_Fin.Location = New System.Drawing.Point(339, 5)
        Me.TB_Fin.Name = "TB_Fin"
        Me.TB_Fin.Size = New System.Drawing.Size(40, 20)
        Me.TB_Fin.TabIndex = 3
        Me.TB_Fin.Text = "."
        '
        'CHB_EnterComentario
        '
        Me.CHB_EnterComentario.AutoSize = True
        Me.CHB_EnterComentario.Location = New System.Drawing.Point(347, 8)
        Me.CHB_EnterComentario.Name = "CHB_EnterComentario"
        Me.CHB_EnterComentario.Size = New System.Drawing.Size(107, 17)
        Me.CHB_EnterComentario.TabIndex = 14
        Me.CHB_EnterComentario.Text = "Enter Comentario"
        Me.CHB_EnterComentario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Separador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Desde:"
        '
        'TB_Separador
        '
        Me.TB_Separador.Location = New System.Drawing.Point(301, 5)
        Me.TB_Separador.Name = "TB_Separador"
        Me.TB_Separador.Size = New System.Drawing.Size(40, 20)
        Me.TB_Separador.TabIndex = 11
        Me.TB_Separador.Text = ")  "
        '
        'TB_Desde
        '
        Me.TB_Desde.Location = New System.Drawing.Point(191, 5)
        Me.TB_Desde.Name = "TB_Desde"
        Me.TB_Desde.Size = New System.Drawing.Size(40, 20)
        Me.TB_Desde.TabIndex = 10
        Me.TB_Desde.Text = "1"
        '
        'CHB_Numerar
        '
        Me.CHB_Numerar.AutoSize = True
        Me.CHB_Numerar.Location = New System.Drawing.Point(84, 7)
        Me.CHB_Numerar.Name = "CHB_Numerar"
        Me.CHB_Numerar.Size = New System.Drawing.Size(66, 17)
        Me.CHB_Numerar.TabIndex = 9
        Me.CHB_Numerar.Text = "Numerar"
        Me.CHB_Numerar.UseVisualStyleBackColor = True
        '
        'BT_GenerarInforme
        '
        Me.BT_GenerarInforme.Location = New System.Drawing.Point(3, 3)
        Me.BT_GenerarInforme.Name = "BT_GenerarInforme"
        Me.BT_GenerarInforme.Size = New System.Drawing.Size(75, 23)
        Me.BT_GenerarInforme.TabIndex = 4
        Me.BT_GenerarInforme.Text = "Generar"
        Me.BT_GenerarInforme.UseVisualStyleBackColor = True
        '
        'RTB_
        '
        Me.RTB_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_.Location = New System.Drawing.Point(3, 32)
        Me.RTB_.Name = "RTB_"
        Me.RTB_.Size = New System.Drawing.Size(453, 545)
        Me.RTB_.TabIndex = 0
        Me.RTB_.Text = ""
        Me.RTB_.WordWrap = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1311, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 625)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CMS_.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_Agregar As Button
    Friend WithEvents FLP_ As FlowLayoutPanel
    Friend WithEvents OFD_ As OpenFileDialog
    Friend WithEvents SFD_ As SaveFileDialog
    Friend WithEvents BT_Reenumerar As Button
    Friend WithEvents TB_Base As TextBox
    Friend WithEvents BT_MinimizarTodo As Button
    Friend WithEvents BT_MaximizarTodo As Button
    Friend WithEvents BT_AgrandarTodo As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RTB_ As RichTextBox
    Friend WithEvents BT_GenerarInforme As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHB_Numerar As CheckBox
    Friend WithEvents TB_Separador As TextBox
    Friend WithEvents TB_Desde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Fin As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CHB_PorNivel As RadioButton
    Friend WithEvents CHB_Continuo As RadioButton
    Friend WithEvents TB_NumInicio As TextBox
    Friend WithEvents CHB_EnterComentario As CheckBox
    Friend WithEvents CMS_ As ContextMenuStrip
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
End Class
