<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFileDialogCGE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenFileDialogCGE))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BT_Accion = New System.Windows.Forms.Button()
        Me.TB_Ruta = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TB_Carpeta_Atras = New System.Windows.Forms.Button()
        Me.BT_IrA = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.CHB_TE = New System.Windows.Forms.CheckBox()
        Me.BT_RutasComunes = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(159, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(3, 353)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 20)
        Me.TextBox1.TabIndex = 29
        '
        'BT_Accion
        '
        Me.BT_Accion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Accion.Location = New System.Drawing.Point(278, 351)
        Me.BT_Accion.Name = "BT_Accion"
        Me.BT_Accion.Size = New System.Drawing.Size(75, 23)
        Me.BT_Accion.TabIndex = 28
        Me.BT_Accion.Text = "-----"
        Me.BT_Accion.UseVisualStyleBackColor = True
        '
        'TB_Ruta
        '
        Me.TB_Ruta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Ruta.Location = New System.Drawing.Point(3, 3)
        Me.TB_Ruta.Name = "TB_Ruta"
        Me.TB_Ruta.Size = New System.Drawing.Size(392, 20)
        Me.TB_Ruta.TabIndex = 25
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 58)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(392, 289)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modificado"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "carpeta.png")
        Me.ImageList1.Images.SetKeyName(1, "documento.png")
        '
        'TB_Carpeta_Atras
        '
        Me.TB_Carpeta_Atras.Location = New System.Drawing.Point(3, 29)
        Me.TB_Carpeta_Atras.Name = "TB_Carpeta_Atras"
        Me.TB_Carpeta_Atras.Size = New System.Drawing.Size(73, 23)
        Me.TB_Carpeta_Atras.TabIndex = 26
        Me.TB_Carpeta_Atras.Text = "Carpeta atras"
        Me.TB_Carpeta_Atras.UseVisualStyleBackColor = True
        '
        'BT_IrA
        '
        Me.BT_IrA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_IrA.Location = New System.Drawing.Point(291, 29)
        Me.BT_IrA.Name = "BT_IrA"
        Me.BT_IrA.Size = New System.Drawing.Size(104, 23)
        Me.BT_IrA.TabIndex = 27
        Me.BT_IrA.Text = "Ir a"
        Me.BT_IrA.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'CHB_TE
        '
        Me.CHB_TE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CHB_TE.Appearance = System.Windows.Forms.Appearance.Button
        Me.CHB_TE.AutoSize = True
        Me.CHB_TE.Location = New System.Drawing.Point(359, 352)
        Me.CHB_TE.Name = "CHB_TE"
        Me.CHB_TE.Size = New System.Drawing.Size(36, 23)
        Me.CHB_TE.TabIndex = 31
        Me.CHB_TE.Text = "*.db"
        Me.CHB_TE.UseVisualStyleBackColor = True
        '
        'BT_RutasComunes
        '
        Me.BT_RutasComunes.Location = New System.Drawing.Point(82, 29)
        Me.BT_RutasComunes.Name = "BT_RutasComunes"
        Me.BT_RutasComunes.Size = New System.Drawing.Size(71, 23)
        Me.BT_RutasComunes.TabIndex = 32
        Me.BT_RutasComunes.Text = "Comunes"
        Me.BT_RutasComunes.UseVisualStyleBackColor = True
        '
        'OpenFileDialogCGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BT_RutasComunes)
        Me.Controls.Add(Me.CHB_TE)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BT_Accion)
        Me.Controls.Add(Me.TB_Ruta)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TB_Carpeta_Atras)
        Me.Controls.Add(Me.BT_IrA)
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "OpenFileDialogCGE"
        Me.Size = New System.Drawing.Size(400, 380)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BT_Accion As Button
    Friend WithEvents TB_Ruta As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TB_Carpeta_Atras As Button
    Friend WithEvents BT_IrA As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CHB_TE As CheckBox
    Friend WithEvents BT_RutasComunes As Button
End Class
