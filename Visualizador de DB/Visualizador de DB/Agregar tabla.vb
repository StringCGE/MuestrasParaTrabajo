Public Class Agregar_tabla
    Dim Numero As Integer = 0
    Public Remover As String = ""
    Private Sub BT_Mas_Click(sender As Object, e As EventArgs) Handles BT_Mas.Click
        Dim Control As New Columnas
        Control.Name = "Control" & Numero
        FLP_.Controls.Add(Control)
        Numero += 1
    End Sub
    Private Sub BT_Guardar_Click(sender As Object, e As EventArgs) Handles BT_Guardar.Click
        If TB_Nombre.Text <> "" And FLP_.Controls.Count > 0 Then
            Dim Datos As String = ""
            Dim Ya As Boolean = True
            Datos = "CREATE TABLE " & TB_Nombre.Text & " ("
            For Each Control As Columnas In FLP_.Controls
                If Ya Then
                    Ya = False
                Else
                    Datos = Datos & ", "
                End If
                Datos = Datos & Control.TB_Nombre.Text
                If Control.CB_TipoDato.SelectedItem <> "" Then
                    Datos = Datos & " " & Control.CB_TipoDato.SelectedItem
                Else
                    Datos = Datos & " TEXT"
                End If
                If Control.CB_EsLlavePrimaria.Checked Then
                    Datos = Datos & " Primary KEY"
                End If
            Next
            Datos = Datos & ");"
            Try
                Form1.DBDB_.CSR(Datos)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Form1.Cargar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TB_SentenciaSQL.Text = Datos
            MsgBox("Creo su tabla adecuadamente")
        Else
            MsgBox("No tiene columnas o no tiene nombre la tabla")
        End If
    End Sub

    Private Sub TB_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Nombre.KeyPress
        Select Case e.KeyChar
            Case " "
                e.KeyChar = "_"
            Case "-"
                e.KeyChar = "_"
            Case Else
                If InStr(1, """#$%&()=?¡]}¡¨´+*~[{^;:.!°|¬\/", e.KeyChar) Then
                    e.KeyChar = ""
                End If
        End Select
    End Sub

    Private Sub Agregar_tabla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CB_MultiLlavePrim_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MultiLlavePrim.CheckedChanged

    End Sub
End Class