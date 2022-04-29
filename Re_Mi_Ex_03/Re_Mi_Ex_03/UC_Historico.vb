Public Class UC_Historico
    Private Matriz(4, 4) As Integer
    Private Sub UC_Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub CargaMatriz(ByVal Matriz_(,) As Integer)
        LB_Texto.Text = ""
        For j As Integer = 0 To 3
            For i As Integer = 0 To 3
                LB_Texto.Text = LB_Texto.Text & Matriz_(j, i)
                Matriz(j, i) = Matriz_(j, i)
            Next
            LB_Texto.Text = LB_Texto.Text & vbCrLf
        Next
    End Sub

    Private Sub LB_Texto_MouseClick(sender As Object, e As MouseEventArgs) Handles LB_Texto.MouseClick

        Form1.DesdeCodigoM4V = True
        Form1.Mapa4Var1.Matriz = Matriz
        Form1.Mapa4Var1.Accion()
        Form1.DesdeCodigoM4V = False
    End Sub
End Class
