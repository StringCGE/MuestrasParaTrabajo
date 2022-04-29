<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Columnas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_EsLlavePrimaria = New System.Windows.Forms.CheckBox()
        Me.CB_TipoDato = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Visualizador_de_DB.My.Resources.Resources.Tacho_de_papeles_001
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(387, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 59)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_EsLlavePrimaria
        '
        Me.CB_EsLlavePrimaria.AutoSize = True
        Me.CB_EsLlavePrimaria.Location = New System.Drawing.Point(279, 34)
        Me.CB_EsLlavePrimaria.Name = "CB_EsLlavePrimaria"
        Me.CB_EsLlavePrimaria.Size = New System.Drawing.Size(102, 17)
        Me.CB_EsLlavePrimaria.TabIndex = 10
        Me.CB_EsLlavePrimaria.Text = "Es llave primaria"
        Me.CB_EsLlavePrimaria.UseVisualStyleBackColor = True
        '
        'CB_TipoDato
        '
        Me.CB_TipoDato.FormattingEnabled = True
        Me.CB_TipoDato.Items.AddRange(New Object() {"TEXT", "integer"})
        Me.CB_TipoDato.Location = New System.Drawing.Point(152, 32)
        Me.CB_TipoDato.Name = "CB_TipoDato"
        Me.CB_TipoDato.Size = New System.Drawing.Size(121, 21)
        Me.CB_TipoDato.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo de dato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(8, 32)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(138, 20)
        Me.TB_Nombre.TabIndex = 6
        '
        'Columnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_EsLlavePrimaria)
        Me.Controls.Add(Me.CB_TipoDato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Name = "Columnas"
        Me.Size = New System.Drawing.Size(467, 73)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents CB_EsLlavePrimaria As CheckBox
    Friend WithEvents CB_TipoDato As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Nombre As TextBox
End Class
