Public Class Ver_contenido
    Public PrimColumValor As String = ""
    Public PrimColumNombre As String = ""
    Public Tabla As String = ""
    Public Columna As String = ""
    Public FilaIndex As Integer = 0
    Public ColumnaIndex As Integer = 0
    Public Sub Datos(Tabla As String, PrimColumNombre As String, PrimColumValor As String, Columna As String)
        Me.PrimColumValor = PrimColumValor
        Me.PrimColumNombre = PrimColumNombre
        Me.Tabla = Tabla
        Me.Columna = Columna
    End Sub

    Private Sub BT_Guardar_Click(sender As Object, e As EventArgs) Handles BT_Guardar.Click
        Try
            Form1.DBDB_.CSR("UPDATE " & Tabla & " SET " & Columna & " = '" & RTB_.Text & "' WHERE " & PrimColumNombre & " = '" & PrimColumValor & "';")
            Form1.DGV(ColumnaIndex, FilaIndex).Value = RTB_.Text
            Form1.DGV.Rows(FilaIndex).Cells(ColumnaIndex).Style.BackColor = Color.LightGreen
        Catch ex As Exception

        End Try
        Try
            If Form1.RefrescarEdicion Then
                Form1.Cargar(Form1.Ultima, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BT_Salir_Click(sender As Object, e As EventArgs) Handles BT_Salir.Click
        Me.Close()
    End Sub

    Private Sub Ver_contenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ver contenido  Tabla: " & Tabla & "  Id: " & PrimColumValor & "  Columna: " & Columna
    End Sub
End Class