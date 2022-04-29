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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LB_Temas = New System.Windows.Forms.Label()
        Me.CB_Pieles = New System.Windows.Forms.ComboBox()
        Me.LB_SalidaN = New System.Windows.Forms.Label()
        Me.LB_Salida = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_MInimizar = New System.Windows.Forms.Button()
        Me.PB_Icono = New System.Windows.Forms.PictureBox()
        Me.LB_Titulo = New System.Windows.Forms.Label()
        Me.BT_Cerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BT_Todo0 = New System.Windows.Forms.Button()
        Me.CHB_Color = New System.Windows.Forms.CheckBox()
        Me.Mapa4Var1 = New Re_Mi_Ex_03.Mapa4Var()
        Me.FLP_Historial = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PB_Icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_Temas
        '
        Me.LB_Temas.AutoSize = True
        Me.LB_Temas.Location = New System.Drawing.Point(12, 454)
        Me.LB_Temas.Name = "LB_Temas"
        Me.LB_Temas.Size = New System.Drawing.Size(39, 13)
        Me.LB_Temas.TabIndex = 36
        Me.LB_Temas.Text = "Temas"
        '
        'CB_Pieles
        '
        Me.CB_Pieles.FormattingEnabled = True
        Me.CB_Pieles.Items.AddRange(New Object() {"Default", "Azul", "RosadoN", "Verde", "VerdeN", "NaranjaN"})
        Me.CB_Pieles.Location = New System.Drawing.Point(12, 470)
        Me.CB_Pieles.Name = "CB_Pieles"
        Me.CB_Pieles.Size = New System.Drawing.Size(97, 21)
        Me.CB_Pieles.TabIndex = 35
        '
        'LB_SalidaN
        '
        Me.LB_SalidaN.AutoSize = True
        Me.LB_SalidaN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SalidaN.Location = New System.Drawing.Point(12, 335)
        Me.LB_SalidaN.Name = "LB_SalidaN"
        Me.LB_SalidaN.Size = New System.Drawing.Size(69, 20)
        Me.LB_SalidaN.TabIndex = 34
        Me.LB_SalidaN.Text = "Salida: "
        '
        'LB_Salida
        '
        Me.LB_Salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Salida.Location = New System.Drawing.Point(12, 366)
        Me.LB_Salida.Name = "LB_Salida"
        Me.LB_Salida.Size = New System.Drawing.Size(266, 78)
        Me.LB_Salida.TabIndex = 33
        Me.LB_Salida.Text = "-0-"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BT_MInimizar)
        Me.Panel1.Controls.Add(Me.PB_Icono)
        Me.Panel1.Controls.Add(Me.LB_Titulo)
        Me.Panel1.Controls.Add(Me.BT_Cerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 30)
        Me.Panel1.TabIndex = 39
        '
        'BT_MInimizar
        '
        Me.BT_MInimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_MInimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BT_MInimizar.FlatAppearance.BorderSize = 0
        Me.BT_MInimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BT_MInimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BT_MInimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_MInimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MInimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BT_MInimizar.Location = New System.Drawing.Point(341, -1)
        Me.BT_MInimizar.Name = "BT_MInimizar"
        Me.BT_MInimizar.Size = New System.Drawing.Size(30, 30)
        Me.BT_MInimizar.TabIndex = 43
        Me.BT_MInimizar.Text = "_"
        Me.BT_MInimizar.UseVisualStyleBackColor = False
        '
        'PB_Icono
        '
        Me.PB_Icono.BackColor = System.Drawing.Color.Transparent
        Me.PB_Icono.BackgroundImage = Global.Re_Mi_Ex_03.My.Resources.Resources.ICO
        Me.PB_Icono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Icono.Location = New System.Drawing.Point(0, 0)
        Me.PB_Icono.Name = "PB_Icono"
        Me.PB_Icono.Size = New System.Drawing.Size(30, 30)
        Me.PB_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Icono.TabIndex = 43
        Me.PB_Icono.TabStop = False
        '
        'LB_Titulo
        '
        Me.LB_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Titulo.Font = New System.Drawing.Font("No. Seven Regular", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Titulo.Location = New System.Drawing.Point(36, 0)
        Me.LB_Titulo.Name = "LB_Titulo"
        Me.LB_Titulo.Size = New System.Drawing.Size(297, 30)
        Me.LB_Titulo.TabIndex = 2
        Me.LB_Titulo.Text = "Re  Mi  Ex"
        Me.LB_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BT_Cerrar
        '
        Me.BT_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BT_Cerrar.FlatAppearance.BorderSize = 0
        Me.BT_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BT_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BT_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BT_Cerrar.Location = New System.Drawing.Point(423, 0)
        Me.BT_Cerrar.Name = "BT_Cerrar"
        Me.BT_Cerrar.Size = New System.Drawing.Size(30, 30)
        Me.BT_Cerrar.TabIndex = 1
        Me.BT_Cerrar.Text = "X"
        Me.BT_Cerrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(373, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BT_Todo0
        '
        Me.BT_Todo0.BackgroundImage = Global.Re_Mi_Ex_03.My.Resources.Resources.BT_001
        Me.BT_Todo0.FlatAppearance.BorderSize = 0
        Me.BT_Todo0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BT_Todo0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BT_Todo0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Todo0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Todo0.Location = New System.Drawing.Point(115, 462)
        Me.BT_Todo0.Name = "BT_Todo0"
        Me.BT_Todo0.Size = New System.Drawing.Size(76, 33)
        Me.BT_Todo0.TabIndex = 42
        Me.BT_Todo0.Text = "Todo 0"
        Me.BT_Todo0.UseVisualStyleBackColor = True
        '
        'CHB_Color
        '
        Me.CHB_Color.Appearance = System.Windows.Forms.Appearance.Button
        Me.CHB_Color.BackgroundImage = Global.Re_Mi_Ex_03.My.Resources.Resources.CHB_1211
        Me.CHB_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHB_Color.FlatAppearance.BorderSize = 0
        Me.CHB_Color.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CHB_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CHB_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CHB_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHB_Color.Location = New System.Drawing.Point(202, 463)
        Me.CHB_Color.Name = "CHB_Color"
        Me.CHB_Color.Size = New System.Drawing.Size(76, 33)
        Me.CHB_Color.TabIndex = 41
        Me.CHB_Color.UseVisualStyleBackColor = True
        '
        'Mapa4Var1
        '
        Me.Mapa4Var1.ColorLetra = System.Drawing.Color.Black
        Me.Mapa4Var1.Location = New System.Drawing.Point(12, 36)
        Me.Mapa4Var1.Name = "Mapa4Var1"
        Me.Mapa4Var1.Size = New System.Drawing.Size(284, 279)
        Me.Mapa4Var1.TabIndex = 38
        '
        'FLP_Historial
        '
        Me.FLP_Historial.AutoScroll = True
        Me.FLP_Historial.BackColor = System.Drawing.Color.Transparent
        Me.FLP_Historial.Location = New System.Drawing.Point(303, 67)
        Me.FLP_Historial.Name = "FLP_Historial"
        Me.FLP_Historial.Size = New System.Drawing.Size(92, 437)
        Me.FLP_Historial.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Historial"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1750
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 510)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FLP_Historial)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_Todo0)
        Me.Controls.Add(Me.CHB_Color)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Mapa4Var1)
        Me.Controls.Add(Me.LB_Temas)
        Me.Controls.Add(Me.CB_Pieles)
        Me.Controls.Add(Me.LB_SalidaN)
        Me.Controls.Add(Me.LB_Salida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PB_Icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Temas As Label
    Friend WithEvents CB_Pieles As ComboBox
    Friend WithEvents LB_SalidaN As Label
    Friend WithEvents LB_Salida As Label
    Friend WithEvents Mapa4Var1 As Mapa4Var
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BT_Cerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BT_Todo0 As Button
    Friend WithEvents CHB_Color As CheckBox
    Friend WithEvents LB_Titulo As Label
    Friend WithEvents PB_Icono As PictureBox
    Friend WithEvents BT_MInimizar As Button
    Friend WithEvents FLP_Historial As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
