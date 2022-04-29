<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desde_Archivo
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
        Me.BT_Accion = New System.Windows.Forms.Button()
        Me.BT_Abrir = New System.Windows.Forms.Button()
        Me.RTB_ = New System.Windows.Forms.RichTextBox()
        Me.OFD_ = New System.Windows.Forms.OpenFileDialog()
        Me.TB_Consulta = New System.Windows.Forms.TextBox()
        Me.BT_Generar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BT_Accion
        '
        Me.BT_Accion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Accion.Location = New System.Drawing.Point(245, 12)
        Me.BT_Accion.Name = "BT_Accion"
        Me.BT_Accion.Size = New System.Drawing.Size(75, 23)
        Me.BT_Accion.TabIndex = 10
        Me.BT_Accion.Text = "Accion"
        Me.BT_Accion.UseVisualStyleBackColor = True
        '
        'BT_Abrir
        '
        Me.BT_Abrir.Location = New System.Drawing.Point(12, 12)
        Me.BT_Abrir.Name = "BT_Abrir"
        Me.BT_Abrir.Size = New System.Drawing.Size(75, 23)
        Me.BT_Abrir.TabIndex = 7
        Me.BT_Abrir.Text = "Abrir"
        Me.BT_Abrir.UseVisualStyleBackColor = True
        '
        'RTB_
        '
        Me.RTB_.AcceptsTab = True
        Me.RTB_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_.Location = New System.Drawing.Point(3, 41)
        Me.RTB_.Name = "RTB_"
        Me.RTB_.Size = New System.Drawing.Size(329, 181)
        Me.RTB_.TabIndex = 6
        Me.RTB_.Text = ""
        '
        'TB_Consulta
        '
        Me.TB_Consulta.Location = New System.Drawing.Point(1, 224)
        Me.TB_Consulta.Name = "TB_Consulta"
        Me.TB_Consulta.Size = New System.Drawing.Size(331, 20)
        Me.TB_Consulta.TabIndex = 11
        Me.TB_Consulta.Text = "Aqui se mostrara su consulta"
        '
        'BT_Generar
        '
        Me.BT_Generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Generar.Location = New System.Drawing.Point(164, 12)
        Me.BT_Generar.Name = "BT_Generar"
        Me.BT_Generar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Generar.TabIndex = 12
        Me.BT_Generar.Text = "Generar"
        Me.BT_Generar.UseVisualStyleBackColor = True
        '
        'Desde_Archivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 244)
        Me.Controls.Add(Me.BT_Generar)
        Me.Controls.Add(Me.TB_Consulta)
        Me.Controls.Add(Me.BT_Accion)
        Me.Controls.Add(Me.BT_Abrir)
        Me.Controls.Add(Me.RTB_)
        Me.Name = "Desde_Archivo"
        Me.Text = "Desde_Archivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_Accion As Button
    Friend WithEvents BT_Abrir As Button
    Friend WithEvents RTB_ As RichTextBox
    Friend WithEvents OFD_ As OpenFileDialog
    Friend WithEvents TB_Consulta As TextBox
    Friend WithEvents BT_Generar As Button
End Class
