<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrrorMsg
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
        Me.TB_ErrrorMsg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TB_ErrrorMsg
        '
        Me.TB_ErrrorMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ErrrorMsg.Location = New System.Drawing.Point(12, 12)
        Me.TB_ErrrorMsg.Multiline = True
        Me.TB_ErrrorMsg.Name = "TB_ErrrorMsg"
        Me.TB_ErrrorMsg.Size = New System.Drawing.Size(374, 131)
        Me.TB_ErrrorMsg.TabIndex = 0
        '
        'ErrrorMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 155)
        Me.Controls.Add(Me.TB_ErrrorMsg)
        Me.Name = "ErrrorMsg"
        Me.Text = "ErrrorMsg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_ErrrorMsg As TextBox
End Class
