<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_contenido
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
        Me.RTB_ = New System.Windows.Forms.RichTextBox()
        Me.BT_Guardar = New System.Windows.Forms.Button()
        Me.BT_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTB_
        '
        Me.RTB_.Location = New System.Drawing.Point(12, 12)
        Me.RTB_.Name = "RTB_"
        Me.RTB_.Size = New System.Drawing.Size(498, 310)
        Me.RTB_.TabIndex = 0
        Me.RTB_.Text = ""
        '
        'BT_Guardar
        '
        Me.BT_Guardar.Location = New System.Drawing.Point(12, 328)
        Me.BT_Guardar.Name = "BT_Guardar"
        Me.BT_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Guardar.TabIndex = 1
        Me.BT_Guardar.Text = "Guardar"
        Me.BT_Guardar.UseVisualStyleBackColor = True
        '
        'BT_Salir
        '
        Me.BT_Salir.Location = New System.Drawing.Point(435, 326)
        Me.BT_Salir.Name = "BT_Salir"
        Me.BT_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BT_Salir.TabIndex = 2
        Me.BT_Salir.Text = "Salir"
        Me.BT_Salir.UseVisualStyleBackColor = True
        '
        'Ver_contenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 361)
        Me.Controls.Add(Me.BT_Salir)
        Me.Controls.Add(Me.BT_Guardar)
        Me.Controls.Add(Me.RTB_)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Ver_contenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver_contenido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTB_ As RichTextBox
    Friend WithEvents BT_Guardar As Button
    Friend WithEvents BT_Salir As Button
End Class
