<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitor_serial
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_AutoScroll = New System.Windows.Forms.CheckBox()
        Me.BT_Visualizacion = New System.Windows.Forms.Button()
        Me.TB_NombreMS = New System.Windows.Forms.TextBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.ChB_LimpiaSalida = New System.Windows.Forms.CheckBox()
        Me.CHB_EnviaEnter = New System.Windows.Forms.CheckBox()
        Me.RTB_Entrada = New System.Windows.Forms.RichTextBox()
        Me.BT_MS_Enviar = New System.Windows.Forms.Button()
        Me.TB_Salida = New System.Windows.Forms.TextBox()
        Me.LB_Msg = New System.Windows.Forms.Label()
        Me.BT_Enlace = New System.Windows.Forms.Button()
        Me.CB_Puertos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Velocidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GB_EnlaceA1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GB_EnlaceA1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.CB_AutoScroll)
        Me.GroupBox1.Controls.Add(Me.BT_Visualizacion)
        Me.GroupBox1.Controls.Add(Me.TB_NombreMS)
        Me.GroupBox1.Controls.Add(Me.Limpiar)
        Me.GroupBox1.Controls.Add(Me.ChB_LimpiaSalida)
        Me.GroupBox1.Controls.Add(Me.CHB_EnviaEnter)
        Me.GroupBox1.Controls.Add(Me.RTB_Entrada)
        Me.GroupBox1.Controls.Add(Me.BT_MS_Enviar)
        Me.GroupBox1.Controls.Add(Me.TB_Salida)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 382)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitor Serial"
        '
        'CB_AutoScroll
        '
        Me.CB_AutoScroll.AutoSize = True
        Me.CB_AutoScroll.Location = New System.Drawing.Point(5, 365)
        Me.CB_AutoScroll.Name = "CB_AutoScroll"
        Me.CB_AutoScroll.Size = New System.Drawing.Size(74, 17)
        Me.CB_AutoScroll.TabIndex = 10
        Me.CB_AutoScroll.Text = "AutoScroll"
        Me.CB_AutoScroll.UseVisualStyleBackColor = True
        '
        'BT_Visualizacion
        '
        Me.BT_Visualizacion.Location = New System.Drawing.Point(195, 340)
        Me.BT_Visualizacion.Name = "BT_Visualizacion"
        Me.BT_Visualizacion.Size = New System.Drawing.Size(47, 23)
        Me.BT_Visualizacion.TabIndex = 9
        Me.BT_Visualizacion.Text = "String"
        Me.BT_Visualizacion.UseVisualStyleBackColor = True
        '
        'TB_NombreMS
        '
        Me.TB_NombreMS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_NombreMS.Location = New System.Drawing.Point(5, 15)
        Me.TB_NombreMS.Name = "TB_NombreMS"
        Me.TB_NombreMS.Size = New System.Drawing.Size(113, 13)
        Me.TB_NombreMS.TabIndex = 8
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(195, 7)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(50, 20)
        Me.Limpiar.TabIndex = 7
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'ChB_LimpiaSalida
        '
        Me.ChB_LimpiaSalida.AutoSize = True
        Me.ChB_LimpiaSalida.Checked = True
        Me.ChB_LimpiaSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChB_LimpiaSalida.Location = New System.Drawing.Point(4, 346)
        Me.ChB_LimpiaSalida.Name = "ChB_LimpiaSalida"
        Me.ChB_LimpiaSalida.Size = New System.Drawing.Size(86, 17)
        Me.ChB_LimpiaSalida.TabIndex = 6
        Me.ChB_LimpiaSalida.Text = "Limpia salida"
        Me.ChB_LimpiaSalida.UseVisualStyleBackColor = True
        '
        'CHB_EnviaEnter
        '
        Me.CHB_EnviaEnter.AutoSize = True
        Me.CHB_EnviaEnter.Location = New System.Drawing.Point(97, 346)
        Me.CHB_EnviaEnter.Name = "CHB_EnviaEnter"
        Me.CHB_EnviaEnter.Size = New System.Drawing.Size(51, 17)
        Me.CHB_EnviaEnter.TabIndex = 5
        Me.CHB_EnviaEnter.Text = "Enter"
        Me.CHB_EnviaEnter.UseVisualStyleBackColor = True
        '
        'RTB_Entrada
        '
        Me.RTB_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Entrada.Location = New System.Drawing.Point(5, 33)
        Me.RTB_Entrada.Name = "RTB_Entrada"
        Me.RTB_Entrada.Size = New System.Drawing.Size(240, 280)
        Me.RTB_Entrada.TabIndex = 1
        Me.RTB_Entrada.Text = ""
        Me.RTB_Entrada.WordWrap = False
        '
        'BT_MS_Enviar
        '
        Me.BT_MS_Enviar.Location = New System.Drawing.Point(195, 317)
        Me.BT_MS_Enviar.Name = "BT_MS_Enviar"
        Me.BT_MS_Enviar.Size = New System.Drawing.Size(47, 23)
        Me.BT_MS_Enviar.TabIndex = 4
        Me.BT_MS_Enviar.Text = "Enviar"
        Me.BT_MS_Enviar.UseVisualStyleBackColor = True
        '
        'TB_Salida
        '
        Me.TB_Salida.Location = New System.Drawing.Point(4, 320)
        Me.TB_Salida.Multiline = True
        Me.TB_Salida.Name = "TB_Salida"
        Me.TB_Salida.Size = New System.Drawing.Size(185, 20)
        Me.TB_Salida.TabIndex = 3
        '
        'LB_Msg
        '
        Me.LB_Msg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LB_Msg.Location = New System.Drawing.Point(31, 0)
        Me.LB_Msg.Name = "LB_Msg"
        Me.LB_Msg.Size = New System.Drawing.Size(202, 13)
        Me.LB_Msg.TabIndex = 13
        Me.LB_Msg.Text = "Msg"
        Me.LB_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BT_Enlace
        '
        Me.BT_Enlace.Location = New System.Drawing.Point(87, 11)
        Me.BT_Enlace.Name = "BT_Enlace"
        Me.BT_Enlace.Size = New System.Drawing.Size(84, 23)
        Me.BT_Enlace.TabIndex = 0
        Me.BT_Enlace.Text = "Conectar"
        Me.BT_Enlace.UseVisualStyleBackColor = True
        '
        'CB_Puertos
        '
        Me.CB_Puertos.FormattingEnabled = True
        Me.CB_Puertos.Location = New System.Drawing.Point(6, 40)
        Me.CB_Puertos.Name = "CB_Puertos"
        Me.CB_Puertos.Size = New System.Drawing.Size(112, 21)
        Me.CB_Puertos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Puerto"
        '
        'CB_Velocidad
        '
        Me.CB_Velocidad.FormattingEnabled = True
        Me.CB_Velocidad.Location = New System.Drawing.Point(138, 40)
        Me.CB_Velocidad.Name = "CB_Velocidad"
        Me.CB_Velocidad.Size = New System.Drawing.Size(107, 21)
        Me.CB_Velocidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Velocidad"
        '
        'GB_EnlaceA1
        '
        Me.GB_EnlaceA1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GB_EnlaceA1.Controls.Add(Me.Label2)
        Me.GB_EnlaceA1.Controls.Add(Me.CB_Velocidad)
        Me.GB_EnlaceA1.Controls.Add(Me.Label1)
        Me.GB_EnlaceA1.Controls.Add(Me.CB_Puertos)
        Me.GB_EnlaceA1.Controls.Add(Me.BT_Enlace)
        Me.GB_EnlaceA1.Location = New System.Drawing.Point(1, 16)
        Me.GB_EnlaceA1.Name = "GB_EnlaceA1"
        Me.GB_EnlaceA1.Size = New System.Drawing.Size(251, 70)
        Me.GB_EnlaceA1.TabIndex = 12
        Me.GB_EnlaceA1.TabStop = False
        Me.GB_EnlaceA1.Text = "Enlace"
        '
        'Monitor_serial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LB_Msg)
        Me.Controls.Add(Me.GB_EnlaceA1)
        Me.Name = "Monitor_serial"
        Me.Size = New System.Drawing.Size(255, 476)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_EnlaceA1.ResumeLayout(False)
        Me.GB_EnlaceA1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChB_LimpiaSalida As CheckBox
    Friend WithEvents CHB_EnviaEnter As CheckBox
    Friend WithEvents RTB_Entrada As RichTextBox
    Friend WithEvents BT_MS_Enviar As Button
    Friend WithEvents TB_Salida As TextBox
    Friend WithEvents LB_Msg As Label
    Friend WithEvents Limpiar As Button
    Friend WithEvents TB_NombreMS As TextBox
    Friend WithEvents BT_Visualizacion As Button
    Friend WithEvents CB_AutoScroll As CheckBox
    Friend WithEvents BT_Enlace As Button
    Friend WithEvents CB_Puertos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Velocidad As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GB_EnlaceA1 As GroupBox
End Class
