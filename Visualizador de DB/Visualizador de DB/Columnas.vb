Public Class Columnas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub CB_EsLlavePrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles CB_EsLlavePrimaria.CheckedChanged
        If CB_EsLlavePrimaria.Checked Then
            If Not Agregar_tabla.CB_MultiLlavePrim.Checked Then
                For Each Control As Columnas In Agregar_tabla.FLP_.Controls
                    If Control.Name <> Name Then
                        Control.CB_EsLlavePrimaria.Checked = False
                    End If
                Next
            End If
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

    Private Sub Columnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
