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
        Me.BT_Info = New System.Windows.Forms.Button()
        Me.BT_Comunicar = New System.Windows.Forms.Button()
        Me.Monitor_serial2 = New UserControl_MonitorSerial.Monitor_serial()
        Me.Monitor_serial1 = New UserControl_MonitorSerial.Monitor_serial()
        Me.SuspendLayout()
        '
        'BT_Info
        '
        Me.BT_Info.Location = New System.Drawing.Point(537, 13)
        Me.BT_Info.Name = "BT_Info"
        Me.BT_Info.Size = New System.Drawing.Size(34, 23)
        Me.BT_Info.TabIndex = 12
        Me.BT_Info.Text = "Info"
        Me.BT_Info.UseVisualStyleBackColor = True
        '
        'BT_Comunicar
        '
        Me.BT_Comunicar.Location = New System.Drawing.Point(224, 3)
        Me.BT_Comunicar.Name = "BT_Comunicar"
        Me.BT_Comunicar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Comunicar.TabIndex = 14
        Me.BT_Comunicar.Text = "Comunicar"
        Me.BT_Comunicar.UseVisualStyleBackColor = True
        '
        'Monitor_serial2
        '
        Me.Monitor_serial2.Location = New System.Drawing.Point(264, 32)
        Me.Monitor_serial2.Name = "Monitor_serial2"
        Me.Monitor_serial2.Size = New System.Drawing.Size(257, 476)
        Me.Monitor_serial2.TabIndex = 13
        '
        'Monitor_serial1
        '
        Me.Monitor_serial1.Location = New System.Drawing.Point(3, 32)
        Me.Monitor_serial1.Name = "Monitor_serial1"
        Me.Monitor_serial1.Size = New System.Drawing.Size(255, 476)
        Me.Monitor_serial1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 509)
        Me.Controls.Add(Me.BT_Comunicar)
        Me.Controls.Add(Me.Monitor_serial2)
        Me.Controls.Add(Me.BT_Info)
        Me.Controls.Add(Me.Monitor_serial1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "UserControl Monitor serial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_Info As Button
    Friend WithEvents BT_Comunicar As Button
    Friend WithEvents Monitor_serial2 As Monitor_serial
    Friend WithEvents Monitor_serial1 As Monitor_serial
End Class
