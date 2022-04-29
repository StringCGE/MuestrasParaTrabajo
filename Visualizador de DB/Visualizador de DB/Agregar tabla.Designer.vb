<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_tabla
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
        Me.CB_MultiLlavePrim = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.FLP_ = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_Guardar = New System.Windows.Forms.Button()
        Me.BT_Mas = New System.Windows.Forms.Button()
        Me.TB_SentenciaSQL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_MultiLlavePrim
        '
        Me.CB_MultiLlavePrim.AutoSize = True
        Me.CB_MultiLlavePrim.Location = New System.Drawing.Point(200, 31)
        Me.CB_MultiLlavePrim.Name = "CB_MultiLlavePrim"
        Me.CB_MultiLlavePrim.Size = New System.Drawing.Size(202, 17)
        Me.CB_MultiLlavePrim.TabIndex = 11
        Me.CB_MultiLlavePrim.Text = "Experimento Multiples llaves primarias"
        Me.CB_MultiLlavePrim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre de tabla:"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(200, 6)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(207, 20)
        Me.TB_Nombre.TabIndex = 9
        '
        'FLP_
        '
        Me.FLP_.AutoScroll = True
        Me.FLP_.Location = New System.Drawing.Point(5, 54)
        Me.FLP_.Name = "FLP_"
        Me.FLP_.Size = New System.Drawing.Size(517, 249)
        Me.FLP_.TabIndex = 6
        '
        'BT_Guardar
        '
        Me.BT_Guardar.BackgroundImage = Global.Visualizador_de_DB.My.Resources.Resources.Disket_001
        Me.BT_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT_Guardar.FlatAppearance.BorderSize = 0
        Me.BT_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Guardar.Location = New System.Drawing.Point(476, 3)
        Me.BT_Guardar.Name = "BT_Guardar"
        Me.BT_Guardar.Size = New System.Drawing.Size(45, 45)
        Me.BT_Guardar.TabIndex = 8
        Me.BT_Guardar.UseVisualStyleBackColor = True
        '
        'BT_Mas
        '
        Me.BT_Mas.BackgroundImage = Global.Visualizador_de_DB.My.Resources.Resources.Signo_mas_001
        Me.BT_Mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT_Mas.FlatAppearance.BorderSize = 0
        Me.BT_Mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Mas.Location = New System.Drawing.Point(5, 3)
        Me.BT_Mas.Name = "BT_Mas"
        Me.BT_Mas.Size = New System.Drawing.Size(45, 45)
        Me.BT_Mas.TabIndex = 7
        Me.BT_Mas.UseVisualStyleBackColor = True
        '
        'TB_SentenciaSQL
        '
        Me.TB_SentenciaSQL.Location = New System.Drawing.Point(91, 309)
        Me.TB_SentenciaSQL.Name = "TB_SentenciaSQL"
        Me.TB_SentenciaSQL.ReadOnly = True
        Me.TB_SentenciaSQL.Size = New System.Drawing.Size(430, 20)
        Me.TB_SentenciaSQL.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Sentencia SQL:"
        '
        'Agregar_tabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 337)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_SentenciaSQL)
        Me.Controls.Add(Me.CB_MultiLlavePrim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.BT_Guardar)
        Me.Controls.Add(Me.BT_Mas)
        Me.Controls.Add(Me.FLP_)
        Me.Name = "Agregar_tabla"
        Me.Text = "Agregar_tabla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_MultiLlavePrim As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Nombre As TextBox
    Friend WithEvents BT_Guardar As Button
    Friend WithEvents BT_Mas As Button
    Friend WithEvents FLP_ As FlowLayoutPanel
    Friend WithEvents TB_SentenciaSQL As TextBox
    Friend WithEvents Label2 As Label
End Class
