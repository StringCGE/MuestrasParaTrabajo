<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registros
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
        Me.RTB_ = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_Registro = New System.Windows.Forms.Label()
        Me.LB_Tipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RTB_
        '
        Me.RTB_.Location = New System.Drawing.Point(3, 32)
        Me.RTB_.Name = "RTB_"
        Me.RTB_.Size = New System.Drawing.Size(464, 81)
        Me.RTB_.TabIndex = 0
        Me.RTB_.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de columna:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo: "
        '
        'LB_Registro
        '
        Me.LB_Registro.AutoSize = True
        Me.LB_Registro.Location = New System.Drawing.Point(114, 3)
        Me.LB_Registro.Name = "LB_Registro"
        Me.LB_Registro.Size = New System.Drawing.Size(19, 13)
        Me.LB_Registro.TabIndex = 3
        Me.LB_Registro.Text = "-0-"
        '
        'LB_Tipo
        '
        Me.LB_Tipo.AutoSize = True
        Me.LB_Tipo.Location = New System.Drawing.Point(114, 16)
        Me.LB_Tipo.Name = "LB_Tipo"
        Me.LB_Tipo.Size = New System.Drawing.Size(19, 13)
        Me.LB_Tipo.TabIndex = 4
        Me.LB_Tipo.Text = "-0-"
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LB_Tipo)
        Me.Controls.Add(Me.LB_Registro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RTB_)
        Me.Name = "Registros"
        Me.Size = New System.Drawing.Size(470, 118)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTB_ As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LB_Registro As Label
    Friend WithEvents LB_Tipo As Label
End Class
