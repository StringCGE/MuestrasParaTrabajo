Public Class Form1
    Public DefBackColorNom As String
    Public DesdeCodigoM4V As Boolean = False
    Sub New()
        InitializeComponent()
        ModoObscuro = CHB_Color.Checked
        ModoClaroObscuro()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mapa4Var1.Cargo = True
    End Sub

    Private Sub CB_Pieles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Pieles.SelectedIndexChanged
        Select Case CB_Pieles.SelectedItem
            Case "Default"
                Panel1.BackColor = Color.FromArgb(203, 140, 52)
                Tema(Color.FromArgb(234, 209, 174), Color.Black, Color.White)
                DefBackColorNom = ""
            Case "Azul"
                Panel1.BackColor = Color.Blue
                Tema(Color.LightBlue, Color.Blue)
                DefBackColorNom = "LightBlue"
            Case "Rosado"
                Panel1.BackColor = Color.Pink
                Tema(Color.LightPink, Color.Pink)
                DefBackColorNom = "LightPink"
            Case "RosadoN"
                Panel1.BackColor = Color.Pink
                Tema(Color.LightPink, Color.Black)
                DefBackColorNom = "LightPink"
            Case "Verde"
                Panel1.BackColor = Color.Green
                Tema(Color.LightGreen, Color.Green)
                DefBackColorNom = "LightGreen"
            Case "VerdeN"
                Panel1.BackColor = Color.Green
                Tema(Color.LightGreen, Color.Black)
                DefBackColorNom = "LightGreen"
            Case "Naranja"
                Panel1.BackColor = Color.DarkOrange
                Tema(Color.Orange, Color.DarkOrange)
                DefBackColorNom = "Orange"
            Case "NaranjaN"
                Panel1.BackColor = Color.DarkOrange
                Tema(Color.Orange, Color.Black)
                DefBackColorNom = "Orange"
        End Select
        Mapa4Var1.Accion()
    End Sub

    Private Sub Tema(BackColorForm As Color, ColorLetra As Color)
        Tema(BackColorForm, ColorLetra, BackColorForm)
    End Sub

    Private Sub Tema(BackColorForm As Color, ColorLetra As Color, BackColorRTB As Color)
        Mapa4Var1.ColorLetra = ColorLetra
        Label1.ForeColor = ColorLetra
        Me.BackColor = BackColorForm
        LB_Salida.ForeColor = ColorLetra
        LB_SalidaN.ForeColor = ColorLetra
        For Each Control As UC_Historico In FLP_Historial.Controls
            If Control.Name <> Name Then
                Control.LB_Texto.ForeColor = ColorLetra
            End If
        Next
    End Sub

    Private Sub BT_Todo0_Click(sender As Object, e As EventArgs) Handles BT_Todo0.Click
        Mapa4Var1.Matriz = {{0, 0, 0, 0},
                            {0, 0, 0, 0},
                            {0, 0, 0, 0},
                            {0, 0, 0, 0}}
        Mapa4Var1.Accion()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Dim PosC_X As Integer = 0
    Dim PosC_Y As Integer = 0
    Dim MoverForm As Boolean = False
    Dim ModoObscuro As Boolean = False

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, LB_Titulo.MouseDown, PB_Icono.MouseDown
        PosC_X = e.X
        PosC_Y = e.Y
        MoverForm = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, LB_Titulo.MouseMove, PB_Icono.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location = New Point(Me.Left + e.X - PosC_X, Me.Top + e.Y - PosC_Y)
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, LB_Titulo.MouseUp, PB_Icono.MouseUp
        MoverForm = False
    End Sub
    Private Sub ModoClaroObscuro()
        If ModoObscuro Then 'Modo Obscuro
            CHB_Color.BackgroundImage = My.Resources.CHB_1212
            Panel1.BackColor = Color.Gray
            Tema(Color.Black, Color.White)
            BT_Todo0.BackgroundImage = My.Resources.BT_003
            CB_Pieles.Visible = False
            LB_Temas.Visible = False
            CB_Pieles.Text = ""
            Mapa4Var1.Accion()
        Else 'Modo claro
            CHB_Color.BackgroundImage = My.Resources.CHB_1211
            Panel1.BackColor = Color.FromArgb(203, 140, 52)
            Tema(Color.FromArgb(234, 209, 174), Color.Black, Color.White)
            BT_Todo0.BackgroundImage = My.Resources.BT_001
            CB_Pieles.Visible = True
            LB_Temas.Visible = True
            CB_Pieles.Text = ""

        End If
    End Sub

    Private Sub CHB_Color_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_Color.CheckedChanged
        ModoObscuro = CHB_Color.Checked
        ModoClaroObscuro()
    End Sub

    Private Sub BT_Todo0_MouseLeave(sender As Object, e As EventArgs) Handles BT_Todo0.MouseLeave
        If ModoObscuro Then 'Modo Obscuro
            BT_Todo0.BackgroundImage = My.Resources.BT_003
        Else 'Modo claro
            BT_Todo0.BackgroundImage = My.Resources.BT_001
        End If

    End Sub

    Private Sub BT_Todo0_MouseMove(sender As Object, e As MouseEventArgs) Handles BT_Todo0.MouseMove
        If ModoObscuro Then 'Modo Obscuro
            BT_Todo0.BackgroundImage = My.Resources.BT_004
        Else 'Modo claro
            BT_Todo0.BackgroundImage = My.Resources.BT_002
        End If

    End Sub

    Private Sub BT_MInimizar_Click(sender As Object, e As EventArgs) Handles BT_MInimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Mapa4Var1.GuardaHistorico Then
            Dim Matriz__(4, 4) As Integer
            Dim UC_H As New UC_Historico
            Matriz__ = Mapa4Var1.Matriz
            UC_H.CargaMatriz(Matriz__)
            FLP_Historial.Controls.Add(UC_H)
            Mapa4Var1.GuardaHistorico = False
        End If
    End Sub

End Class
