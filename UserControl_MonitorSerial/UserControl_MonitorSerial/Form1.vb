Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Monitor_serial1.Setear("COM7", 9600, "enviar")
        Monitor_serial1.Enlazar()
        Monitor_serial2.Setear("COM8", 9600, "enviar")
        Monitor_serial2.Enlazar()
    End Sub
    Private Sub BT_Info_Click(sender As Object, e As EventArgs) Handles BT_Info.Click
        MsgBox("64: @   65: A   85: U   125: }" & vbCrLf &
               "write es escribir" & vbCrLf &
               "64,85,125 => @U}" & vbCrLf &
               "com0com es el driver que crea puertos virtuales" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf &
               "" & vbCrLf)
    End Sub
    Private Sub LeeMS1(b As Byte(), i As Integer) Handles Monitor_serial1.Salida
        Dim MsgTexto As String = ""
        For j As Integer = 0 To i - 1 Step 1
            MsgTexto = MsgTexto & Chr(b(j))
        Next
        'MsgBox("MS1: " & MsgTexto & "|")
    End Sub
    Private Sub LeeMS2(b As Byte(), i As Integer) Handles Monitor_serial2.Salida
        Dim MsgTexto As String = ""
        For j As Integer = 0 To i - 1 Step 1
            MsgTexto = MsgTexto & Chr(b(j))
        Next
        'MsgBox("MS2: " & MsgTexto & "|")
    End Sub
    Private Sub Converciones(ByVal Byte__ As Byte)
        'Chr$(64)
        'Chr(64) ' = @
        'Asc("@") ' = 64
    End Sub

    Private Sub BT_Comunicar_Click(sender As Object, e As EventArgs) Handles BT_Comunicar.Click
        MsgBox("No soportado aun")
    End Sub
End Class
