Imports System.IO

Public Class Desde_Archivo

    Dim Ruta As String = ""
    Private Sub Desde_Archivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function Leer(Ruta As String, ByRef Texto As String) As Boolean
        Try
            Texto = File.ReadAllText(Ruta, System.Text.Encoding.UTF8)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub BT_Abrir_Click(sender As Object, e As EventArgs) Handles BT_Abrir.Click
        If OFD_.ShowDialog = DialogResult.OK Then
            Ruta = OFD_.FileName
            Leer(Ruta, RTB_.Text)
        End If
    End Sub

    Private Sub BT_Accion_Click(sender As Object, e As EventArgs) Handles BT_Accion.Click
        If MessageBox.Show("Recuerde que las columnas del archivo se correspondan con el orden de columnas de la base de datos y esten separadas por Tab", "Agregar a base de datos", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Agregar(RTB_.Text)
        End If
    End Sub
    Private Function Agregar(ByRef Str As String) As List(Of Char)

        Dim Max As Integer = Str.Count
        Dim Char__ As New List(Of Char)
        Dim Lista As New List(Of String)
        Dim Palabra As String = ""
        For I As Integer = 0 To Max - 1
            If Str(I) = vbTab Then
                Lista.Add(Palabra)
                Palabra = ""
            ElseIf InStr(1, vbCr & vbLf, Str(I)) > 0 Then
                AgregarItem(Lista, Palabra)
            Else
                Palabra = Palabra & Str(I)
            End If
        Next
        AgregarItem(Lista, Palabra)
        MsgBox("Termino")
        Return Char__
    End Function

    Private Sub AgregarItem(ByRef Lista As List(Of String), ByRef Palabra As String)
        Dim Comando As String = ""
        If Palabra <> "" Then
            Lista.Add(Palabra)
            Palabra = ""
        End If
        If Lista.Count > 0 Then
            'Aqui va el ciclo para ingresar los datos a la DB
            Dim VerLista As String = ""
            For Each Str_ As String In Lista
                If VerLista <> "" Then
                    VerLista = VerLista & ","
                End If
                VerLista = VerLista & "'" & Str_ & "'"
            Next
            Comando = "insert into " & Form1.Ultabla & " values(" & VerLista & ");"
            TB_Consulta.Text = Comando
            Try
                Form1.DBDB_.CSR(Comando)
                If Form1.Ultima <> "" Then
                    Me.Text = Form1.Ultabla
                    Form1.Cargar(Form1.Ultima)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Lista.Clear()
        End If
    End Sub

    Private Sub BT_Generar_Click(sender As Object, e As EventArgs) Handles BT_Generar.Click

    End Sub

    Private Function Agregar_2(ByRef Str As String) As List(Of Char)

        Dim Max As Integer = Str.Count
        Dim Char__ As New List(Of Char)
        Dim Lista As New List(Of String)
        Dim Palabra As String = ""
        For I As Integer = 0 To Max - 1
            If Str(I) = vbTab Then
                Lista.Add(Palabra)
                Palabra = ""
            ElseIf InStr(1, vbCr & vbLf, Str(I)) > 0 Then
                AgregarItem(Lista, Palabra)
            Else
                Palabra = Palabra & Str(I)
            End If
        Next
        AgregarItem_2(Lista, Palabra)
        MsgBox("Termino")
        Return Char__
    End Function

    Private Sub AgregarItem_2(ByRef Lista As List(Of String), ByRef Palabra As String)
        Dim Comando As String = ""
        If Palabra <> "" Then
            Lista.Add(Palabra)
            Palabra = ""
        End If
        If Lista.Count > 0 Then
            'Aqui va el ciclo para ingresar los datos a la DB
            Dim VerLista As String = ""
            For Each Str_ As String In Lista
                If VerLista <> "" Then
                    VerLista = VerLista & ","
                End If
                VerLista = VerLista & "'" & Str_ & "'"
            Next
            Comando = "insert into " & Form1.Ultabla & " values(" & VerLista & ");"
            TB_Consulta.Text = Comando
            Clipboard.SetText(Comando)
            'Try
            '    Form1.DBDB_.CSR(Comando)
            '    If Form1.Ultima <> "" Then
            '        Me.Text = Form1.Ultabla
            '        Form1.Cargar(Form1.Ultima)
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            Lista.Clear()
        End If
    End Sub
End Class