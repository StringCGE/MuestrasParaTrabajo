<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberRichTextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NumberRichTextBox))
        Me.RTB_ = New System.Windows.Forms.RichTextBox()
        Me.LB_Num = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTB_
        '
        Me.RTB_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_.Location = New System.Drawing.Point(48, 0)
        Me.RTB_.Name = "RTB_"
        Me.RTB_.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RTB_.Size = New System.Drawing.Size(262, 256)
        Me.RTB_.TabIndex = 0
        Me.RTB_.Text = ""
        Me.RTB_.WordWrap = False
        '
        'LB_Num
        '
        Me.LB_Num.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LB_Num.BackColor = System.Drawing.SystemColors.Control
        Me.LB_Num.Location = New System.Drawing.Point(1, 0)
        Me.LB_Num.Name = "LB_Num"
        Me.LB_Num.Size = New System.Drawing.Size(41, 269)
        Me.LB_Num.TabIndex = 1
        Me.LB_Num.Text = resources.GetString("LB_Num.Text")
        Me.LB_Num.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LB_Num)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 245)
        Me.Panel1.TabIndex = 2
        '
        'NumberRichTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RTB_)
        Me.Name = "NumberRichTextBox"
        Me.Size = New System.Drawing.Size(310, 256)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTB_ As RichTextBox
    Private WithEvents LB_Num As Label
    Friend WithEvents Panel1 As Panel
End Class
