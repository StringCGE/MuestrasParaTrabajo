<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar
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
        Me.BT_AgregarDesdeArchivo = New System.Windows.Forms.Button()
        Me.BT_Agregar = New System.Windows.Forms.Button()
        Me.FLP_ = New System.Windows.Forms.FlowLayoutPanel()
        Me.TB_ComandoSQL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BT_AgregarDesdeArchivo
        '
        Me.BT_AgregarDesdeArchivo.Location = New System.Drawing.Point(250, 323)
        Me.BT_AgregarDesdeArchivo.Name = "BT_AgregarDesdeArchivo"
        Me.BT_AgregarDesdeArchivo.Size = New System.Drawing.Size(130, 23)
        Me.BT_AgregarDesdeArchivo.TabIndex = 5
        Me.BT_AgregarDesdeArchivo.Text = "Agregar desde archivo"
        Me.BT_AgregarDesdeArchivo.UseVisualStyleBackColor = True
        '
        'BT_Agregar
        '
        Me.BT_Agregar.Location = New System.Drawing.Point(169, 323)
        Me.BT_Agregar.Name = "BT_Agregar"
        Me.BT_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Agregar.TabIndex = 4
        Me.BT_Agregar.Text = "Agregar"
        Me.BT_Agregar.UseVisualStyleBackColor = True
        '
        'FLP_
        '
        Me.FLP_.AutoScroll = True
        Me.FLP_.Location = New System.Drawing.Point(12, 12)
        Me.FLP_.Name = "FLP_"
        Me.FLP_.Size = New System.Drawing.Size(480, 266)
        Me.FLP_.TabIndex = 3
        '
        'TB_ComandoSQL
        '
        Me.TB_ComandoSQL.Location = New System.Drawing.Point(13, 285)
        Me.TB_ComandoSQL.Multiline = True
        Me.TB_ComandoSQL.Name = "TB_ComandoSQL"
        Me.TB_ComandoSQL.Size = New System.Drawing.Size(479, 32)
        Me.TB_ComandoSQL.TabIndex = 6
        '
        'Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 350)
        Me.Controls.Add(Me.TB_ComandoSQL)
        Me.Controls.Add(Me.BT_AgregarDesdeArchivo)
        Me.Controls.Add(Me.BT_Agregar)
        Me.Controls.Add(Me.FLP_)
        Me.Name = "Editar"
        Me.Text = "Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_AgregarDesdeArchivo As Button
    Friend WithEvents BT_Agregar As Button
    Friend WithEvents FLP_ As FlowLayoutPanel
    Friend WithEvents TB_ComandoSQL As TextBox
End Class
