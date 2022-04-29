Public Class Monitor_serial
    Dim Msg As String = ""
    Private WithEvents Sr As PSerial
    Public BufferInSize As Integer
    Public Event Salida(ByVal Bytes As Byte(), ByVal Count As Integer)
    Dim NPuerto As String = ""
    Public Nombre As String = ""
    Dim MsgTexto As String = ""

#Region "Basicos"
    Private Sub Monitor_serial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sr = New PSerial(Msg, CB_Puertos, CB_Velocidad)
        CB_AutoScroll.Checked = True
        BufferInSize = Sr.BufferInSize
        Conectado(Sr.Conectado)
        CHB_EnviaEnter.Checked = True
    End Sub
    Private Sub BT_Enlace_Click(sender As Object, e As EventArgs) Handles BT_Enlace.Click
        Enlazar()
    End Sub
    Public Sub Enlazar()
        LB_Msg.Text = ""
        Sr.Conectar()
        Conectado(Sr.Conectado)
    End Sub
    Public Function Estado() As Boolean
        Return Sr.Conectado
    End Function
    Public Sub SeDesconecto() Handles Sr.SeDesconecto
        Conectado(Sr.Conectado)
    End Sub
    Private Sub Conectado(B As Boolean)
        If B Then
            LB_Msg.Text = "Conectado"
            BT_Enlace.Text = "Desconectar"
            BT_MS_Enviar.Enabled = True
        Else
            LB_Msg.Text = "Desconectado"
            BT_Enlace.Text = "Conectar"
            BT_MS_Enviar.Enabled = False
        End If
    End Sub
    Private Sub Recibe(b As Byte(), c As Integer) Handles Sr.SalidaBytes
        Bytes = b : Count = c
        RTB_Entrada.Invoke(New MethodInvoker(AddressOf RTB_Entrada_Invoke))
    End Sub
    Private Sub RTB_Entrada_Invoke()
        Select Case Visualizacion
            Case 0
                AgregaDatoStr()
            Case 1
                AgregaDatoBts()
        End Select
        RaiseEvent Salida(Bytes, Count)
    End Sub
    Private Sub BT_MS_Enviar_Click(sender As Object, e As EventArgs) Handles BT_MS_Enviar.Click
        If TB_Salida.Text <> "" Then
            Try
                Dim Str As String = TB_Salida.Text
                Dim Bytes_(4096) As Byte
                Dim Count_ As Integer = 0
                Select Case Visualizacion
                    Case 0
                        If CHB_EnviaEnter.Checked Then
                            Str = Str & vbCrLf
                        End If
                        Enviar(Str)
                        If ChB_LimpiaSalida.Checked Then
                            TB_Salida.Text = ""
                        End If
                    Case 1
                        If Texto_Bytes(Str, Bytes_, Count_) Then
                            EnviarBytes(Bytes_, Count_)
                            If ChB_LimpiaSalida.Checked Then
                                TB_Salida.Text = ""
                            End If
                        Else
                            MsgBox("No esta ingresando los datos correctos." & vbCrLf & "El formato de cadena de bytes es:" & vbCrLf & "64,125,35")
                        End If
                End Select
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            LB_Msg.Text = "No hay nada que enviar"
        End If
    End Sub
    Public Sub Enviar(ByVal Texto As String)
        Sr.Enviar(Texto)
    End Sub
    Public Function EnviarBytes(ByVal Bytes As Byte(), ByVal Count As Integer) As Boolean
        Try
            Sr.Enviar(Bytes, 0, Count)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region

    Public Sub Config(ByVal Puerto As String, ByVal Velocidad As Integer)
        CB_Puertos.Text = Puerto
        CB_Velocidad.Text = Velocidad
        NPuerto = Puerto
    End Sub
    Public Sub Setear(Optional ByVal Puerto_ As String = "", Optional ByVal Baudio_ As Integer = 0, Optional ByVal Nombre_ As String = "")
        TB_NombreMS.Text = Nombre_
        Sr.SetearCB(Puerto_, Baudio_)
    End Sub

    Private Function Texto_Bytes(ByVal String_ As String, ByRef Buffer As Byte(), ByRef Count As Integer)
        Dim ByteStr As String = ""
        Dim Index As Integer = 0
        For Each Char_ As Char In String_
            If Char_ = "," Then
                If EsByte(ByteStr) Then
                    Buffer(Index) = ByteStr
                    Index += 1
                Else
                    Return False
                End If
                ByteStr = ""
            Else
                ByteStr = ByteStr & Char_
            End If
        Next
        If EsByte(ByteStr) Then
            Buffer(Index) = ByteStr
            Index += 1
        Else
            Return False
        End If
        Count = Index
        ByteStr = ""
        Return True
    End Function
    Private Function EsByte(ByVal Texto As String) As Boolean
        Try
            Dim Byte_ As Byte = CByte(Texto)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        EnRTB.Clear()
        RTB_Entrada.Clear()
    End Sub

    Private Sub TB_NombreMS_TextChanged(sender As Object, e As EventArgs) Handles TB_NombreMS.TextChanged
        Nombre = TB_NombreMS.Text
    End Sub



#Region "Algo"
    Dim Visualizacion As Integer = 0 '0 Es a String;   1 es a Bytes
    Public Bytes(4096) As Byte
    Public Count As Integer
    Dim EnRTB As New List(Of Byte)
    Private Sub AgregaDatoStr()
        Dim String_ As String = ""
        For i As Integer = 0 To Count - 1
            String_ = String_ & Chr(Bytes(i))
            EnRTB.Add(Bytes(i))
        Next
        RTB_Entrada.AppendText(String_)
        ScrollBar()
    End Sub
    Private Sub AgregaDatoBts()
        Dim String_ As String = ""
        For i As Integer = 0 To Count - 1
            String_ = String_ & Bytes(i)
            EnRTB.Add(Bytes(i))
            If MaxLine = 9 Then
                String_ = String_ & vbCrLf
                MaxLine = 0
            Else
                String_ = String_ & ","
                MaxLine += 1
            End If
        Next
        RTB_Entrada.AppendText(String_)
        Scrollbar()
    End Sub
    Private Sub Scrollbar()
        If CB_AutoScroll.Checked Then
            RTB_Entrada.ScrollToCaret()
        End If
    End Sub
    Dim MaxLine As Integer = 0
    Public Sub CambiaDatoBts()
        RTB_Entrada.Clear()
        Dim String_ As String = ""
        MaxLine = 0
        For Each Byte_ As Byte In EnRTB
            String_ = String_ & Byte_ & ","
            If MaxLine = 9 Then
                String_ = String_ & vbCrLf
                MaxLine = 0
            Else
                MaxLine += 1
            End If
        Next
        RTB_Entrada.AppendText(String_)
    End Sub
    Public Sub CambiaDatoStr()
        RTB_Entrada.Clear()
        Dim String_ As String = ""
        MaxLine = 0
        For Each Byte_ As Byte In EnRTB
            String_ = String_ & Chr(Byte_)
        Next
        RTB_Entrada.AppendText(String_)
    End Sub

    Private Sub BT_Visualizacion_Click(sender As Object, e As EventArgs) Handles BT_Visualizacion.Click
        If BT_Visualizacion.Text = "String" Then
            BT_Visualizacion.Text = "Bytes"
            Visualizacion = 1
            CambiaDatoBts()
        ElseIf BT_Visualizacion.Text = "Bytes" Then
        BT_Visualizacion.Text = "String"
        Visualizacion = 0
            CambiaDatoStr()
        End If
    End Sub
    Dim SelectedIndexChanged As String = ""


#End Region
End Class


'Private Sub Algo_(ByVal Bytes As Byte(), ByVal Count As Integer) Handles Sr.SalidaBytes

'    Dim Texto As String = ""
'    For i As Integer = 0 To Count - 1
'        Texto = Texto & Bytes(i) & ","
'    Next
'    MsgTexto = Texto
'    RTB_Entrada.Invoke(New MethodInvoker(AddressOf RTB_Entrada_Invoke))
'End Sub
