Imports System.IO
Public Class Form1
    Private Sub BT_Agregar_Click(sender As Object, e As EventArgs) Handles BT_Agregar.Click
        AñadirRequerimiento(New UC_Requerimiento)
    End Sub
    Public Sub Limpiar()
        FLP_.Controls.Clear()
    End Sub


    Dim lista As New List(Of UC_Requerimiento)
    Public Sub AñadirRequerimiento(ByRef Req As UC_Requerimiento)
        FLP_.Controls.Add(Req)
    End Sub


    Public Function GetJSON()
        Dim texto As New List(Of Char)

        Dim Boo As Boolean = False
        texto.AddRange("{""Requerimientos funcionales"":[")
        For Each Req As UC_Requerimiento In FLP_.Controls
            If Boo Then
                texto.AddRange("," & vbCrLf)
            End If
            texto.AddRange(Req.GetJSON())
            Boo = True
        Next
        texto.AddRange("]}")
        Return texto.ToArray
    End Function


    Public Sub AbrirContenido(Ruta As String)
        Dim carpeta As String = System.IO.Path.GetDirectoryName(Ruta)
        Dim archivo As String = System.IO.Path.GetFileName(Ruta)
        AbrirContenido(carpeta, archivo)
    End Sub
    Public Sub AbrirContenido(carpeta As String, archivo As String)
        Me.Carpeta = carpeta
        Me.Archivo = archivo
        Text = NombreProg & """" & archivo & """"

        FLP_.Controls.Clear()
        Cursor = Cursors.WaitCursor

        FLP_.Visible = False
        Dim Cargando As New UC_Cargando
        Controls.Add(Cargando)
        Cargando.Location = FLP_.Location
        Cargando.Size = FLP_.Size
        FLP_.SendToBack()
        Cargando.BringToFront()

        Limpiar()
        Dim objReader As New System.IO.StreamReader(carpeta & "\" & archivo)
        objReader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin)
        Dim TXT As String = Copiar(objReader.ReadToEnd())
        objReader.Close()
        objReader.Dispose()
        LeerJSON(TXT)


        FLP_.Visible = True

        Controls.Remove(Cargando)
        Cursor = Cursors.Default
    End Sub
    Public Sub Abrir()
        AbrirContenido(Carpeta, Archivo)
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        If OFD_.ShowDialog = DialogResult.OK Then
            AbrirContenido(OFD_.FileName)
        End If
    End Sub
    Private Sub BT_Abrir_Click(sender As Object, e As EventArgs)
        If OFD_.ShowDialog = DialogResult.OK Then

        End If
    End Sub
    'Es para copiar sin referencia
    Public Function Copiar(ByVal str As String)
        Return str
    End Function
    Dim Json As New JSON
    Dim Obj As Object
    Public Sub LeerJSON(ByVal TXTJSON As String)
        lista.Clear()
        Json.Set_Cadena(TXTJSON)
        Json.Leer()
        Obj = Json.Get_Obj()
        Dim Encontro As Boolean = False
        Dim Res_ As Object = Json.Buscar("Requerimientos funcionales", Encontro)
        Dim Encontro_2 As Boolean = False
        If Encontro Then 'MsgBox("Es Archivo Valido")
            If TypeOf Res_.Get_Value Is Array_ Then
                For Each O As OBJECT_ In Res_.Get_Value.GetList()
                    Dim Rec As New UC_Requerimiento(O)
                    lista.Add(Rec)
                Next
            Else
                MsgBox("Error en el tipo de valor que almacena")
            End If
        Else
            MsgBox("No es Archivo Valido")
        End If
        Recargar(lista)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True





        Dim nombre = New alguito()
        nombre.algo()





































        '        Dim texto As New List(Of Char)

        '        texto.AddRange("{\rtf\ansi\ansicpg1252
        '{\fonttbl
        '    {\f0\fcharset0 Arial;}
        '    {\f1\fcharset0 Consolas;}
        '}
        '\f0\fs20\cf0 Requerimientos funcionales\par
        '\viewkind4\uc1\trowd\trgaph70\trleft-108\trqc\trbrdrt\brdrs\brdrw10
        '")

        '        Dim Tabla As New Tabla
        '        Dim fila As New Fila
        '        fila.acumula = True
        '        fila.AñadirCampo(800, "una")
        '        fila.AñadirCampo(800, "casa")
        '        Tabla.AñadirFila(fila)

        '        Dim fila2 As New Fila
        '        fila2.acumula = True
        '        fila2.AñadirCampo(800, "una")
        '        fila2.AñadirCampo(800, "casa")
        '        Tabla.AñadirFila(fila2)

        '        texto.AddRange(Tabla.GetRTF())

        '        texto.AddRange("}")
        '        Clipboard.SetText(texto.ToArray())
        '        RTB_.Rtf = texto.ToArray()
    End Sub

    Private Sub Recargar(ByRef Lista As List(Of UC_Requerimiento))
        FLP_.Controls.Clear()
        For i As Integer = 0 To Lista.Count - 1
            Lista(i).DoubleBufferring_(True)
            FLP_.Controls.Add(Lista(i))
        Next
    End Sub

    Public Sub Reordenar(ByVal ubicacion As Integer, ByVal Tipo As Reorden)
        Dim Lista As New List(Of UC_Requerimiento)
        For Each c As Control In FLP_.Controls
            Lista.Add(c)
        Next
        FLP_.Controls.Clear()
        Dim Aux As List(Of UC_Requerimiento) = Lista
        For i As Integer = 0 To Aux.Count - 1
            If Tipo = Reorden.Manda_Arriba Then
                If ubicacion - 1 = i Then
                    FLP_.Controls.Add(Lista(ubicacion))
                ElseIf ubicacion = i Then
                    FLP_.Controls.Add(Lista(ubicacion - 1))
                Else
                    FLP_.Controls.Add(Lista(i))
                End If
            ElseIf Tipo = Reorden.Manda_Abajo Then
                If ubicacion = i Then
                    FLP_.Controls.Add(Lista(ubicacion + 1))
                ElseIf ubicacion + 1 = i Then
                    FLP_.Controls.Add(Lista(ubicacion))
                Else
                    FLP_.Controls.Add(Lista(i))
                End If
            End If
        Next


    End Sub

    Private Sub BT_Reenumerar_Click(sender As Object, e As EventArgs) Handles BT_Reenumerar.Click
        Dim Num As Integer = CInt(TB_NumInicio.Text)
        If CHB_Continuo.Checked Then
            For Each C As UC_Requerimiento In FLP_.Controls
                C.Reenumerar(TB_Base.Text, Num, TB_Fin.Text)
            Next
        Else
            For Each C As UC_Requerimiento In FLP_.Controls
                If TB_Base.Text <> "" Then
                    C.Reenumerar(TB_Base.Text & Num, TB_Fin.Text)
                Else
                    C.Reenumerar(Num, TB_Fin.Text)
                End If
                Num += 1
            Next
        End If

    End Sub


    Public Sub MinTodo()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.MinTodo()
        Next
    End Sub

    Public Sub MaxTodo()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.MaxTodo()
        Next
    End Sub
    Public Sub AgrTodo()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.AgrTodo()
        Next
    End Sub

    Private Sub BT_MinimizarTodo_Click(sender As Object, e As EventArgs) Handles BT_MinimizarTodo.Click
        MinTodo()
    End Sub

    Private Sub BT_MaximizarTodo_Click(sender As Object, e As EventArgs) Handles BT_MaximizarTodo.Click
        MaxTodo()
    End Sub

    Private Sub BT_AgrandarTodo_Click(sender As Object, e As EventArgs) Handles BT_AgrandarTodo.Click
        AgrTodo()
    End Sub

    Private Sub BT_GenerarInforme_Click(sender As Object, e As EventArgs) Handles BT_GenerarInforme.Click
        RTB_.Rtf = GetRTF()
    End Sub

    Public Function GetRTF()
        Numero = Desde
        Dim texto As New List(Of Char)

        Dim Boo As Boolean = False
        texto.AddRange("{\rtf\ansi\ansicpg1252
{\fonttbl
    {\f0\fcharset0 Arial;}
    {\f1\fswiss\fprq2\fcharset0 Arial;}
}
\f1\fs22\cf0\b Requerimientos funcionales\par\par\b0
\viewkind4\uc1\trowd\trgaph70\trleft-108\trqc\trbrdrt\brdrs\brdrw10 \f0\fs20\cf0
")
        '\viewkind4\uc1\trowd\trgaph70\trleft-108\trqc\trbrdrt\brdrs\brdrw10
        For Each Req As UC_Requerimiento In FLP_.Controls
            If Boo Then
                texto.AddRange("\pard\ltrpar\par")
            End If
            texto.AddRange(Req.GetRTF())
            Boo = True
        Next
        texto.AddRange("\pard\ltrpar\par")

        For Each Req As UC_Requerimiento In FLP_.Controls
            If Boo Then
                texto.AddRange("\pard\ltrpar\par")
            End If
            texto.AddRange(Req.GetComentarios(CHB_EnterComentario.Checked))
            Boo = True
        Next

        texto.AddRange("\pard\ltrpar\par \pard\ltrpar\par \pard\ltrpar\par}")
        Return texto.ToArray
    End Function
    Public Desde As Integer = 0
    Public Numero As Integer = 0
    Public Function GetNumero() As Integer
        Dim num As Integer = Numero
        Numero += 1
        Return num
    End Function
    Dim NombreProg As String = "CGE Requerimientos -> "
    Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory & "\Requerimiento"
    Dim Archivo As String = "reque.json"
    Public Sub GuardarContenido(Ruta As String)
        Dim carpeta As String = System.IO.Path.GetDirectoryName(Ruta)
        Dim archivo As String = System.IO.Path.GetFileName(Ruta)
        GuardarContenido(carpeta, archivo)
    End Sub

    Public Sub GuardarContenido(carpeta As String, archivo As String)
        Try
            Me.Carpeta = carpeta
            Me.Archivo = archivo
            Dim ruta As String = carpeta & "\" & archivo
            If Not File.Exists(ruta) Then
                File.Create(ruta)
            End If
            Dim sw As New System.IO.StreamWriter(ruta)
            Dim str As String = GetJSON()
            sw.Write(str)
            sw.Close()
            sw.Dispose()
            Text = NombreProg & """" & archivo & """"
            MsgBox("Se a guardado """ & archivo & """ con exito")
        Catch ex As Exception
            MsgBox("Algo sucedio con la ruta del """ & archivo & """!!!")
        End Try

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        GuardarComo()
    End Sub

    Public Sub Guardar()
        GuardarContenido(Carpeta, Archivo)
    End Sub
    Public Sub GuardarComo()
        If SFD_.ShowDialog = DialogResult.OK Then
            GuardarContenido(SFD_.FileName)
        End If
    End Sub


    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If FLP_.Controls.Count > 0 Then
            Select Case MessageBox.Show("Limipiar area de trabajo", "¿Desea Guardar el contenido antes de crear nuevo documento?", MessageBoxButtons.YesNoCancel)
                Case DialogResult.Yes
                    Guardar()
                Case DialogResult.No
                    Limpiar()
                Case DialogResult.Cancel

            End Select
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub TB_Desde_TextChanged(sender As Object, e As EventArgs) Handles TB_Desde.TextChanged
        Try
            Desde = CInt(TB_Desde.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        Try
            Dim Json As New JSON
            Json.Set_Cadena(Clipboard.GetText())
            Json.Leer()
            AñadirRequerimiento(New UC_Requerimiento(Json.Get_Obj()))
        Catch ex As Exception
            MsgBox("El formato no es el correcto. No se puede leer")
        End Try

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class

Class DB
    Public Shared Sub EnableDoubleBuferring(Control As Control)
        Dim prop As Reflection.PropertyInfo = Control.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(Control, True, Nothing)
    End Sub
End Class

Public Enum Reorden
    Manda_Arriba
    Manda_Abajo
End Enum






Class Algo
    Dim TXT As String = "{""Requerimientos funcionales"":[{
""Cod"":""RF1"",
""Nom"":""RF1"",
""Tip"":""Req"",
""Fue"":""Yo"",
""Pri"":""Med"",
""Com"":""Aqui van mis comentarios"",
""Sub"":[{
""Cod"":""RF1.1"",
""Nom"":""RF1.1"",
""Tip"":""Res"",
""Fue"":""Mas cosas solo por probar"",
""Pri"":""Med"",
""Com"":""El comentario auynque se ve raro esto"",
""Sub"":[{
""Cod"":""RF1.1.1"",
""Nom"":""Esto si que se ve raro y confuso"",
""Tip"":""Req"",
""Fue"":""Dioses del diseño de experiencias de usuario Ayuuuuuuuda"",
""Pri"":"""",
""Com"":""Cuando sabes que no sabes hacer experiencias de usuario que a ti mismo te duele la cabeza intentando saber que es cada cosa en esa maraña de colores."",
""Sub"":""NULL""
},
{
""Cod"":""RF1.1.3"",
""Nom"":""Bueno me tarde en encontrar esta cosa"",
""Tip"":""Res"",
""Fue"":""QUe laaaampara este programa"",
""Pri"":""Alt"",
""Com"":""Ahora falta que se buguee y se pierda todo en un momento dado y que sea tan falat lor la cantidad de info que se pierda"",
""Sub"":""NULL""
}]
},
{
""Cod"":""RF1.2"",
""Nom"":""Mas RF1.2"",
""Tip"":""Req"",
""Fue"":""Hola que hace"",
""Pri"":""Alt"",
""Com"":""OñA Ke AsE"",
""Sub"":""NULL""
}]
},
{
""Cod"":""RF2"",
""Nom"":""RF2"",
""Tip"":""Res"",
""Fue"":""Tu"",
""Pri"":""Baj"",
""Com"":""Mas comentarios por leer"",
""Sub"":""NULL""
},
{
""Cod"":""RF3"",
""Nom"":""RF3"",
""Tip"":""Res"",
""Fue"":""El"",
""Pri"":""Alt"",
""Com"":""Si que se comenta en esta cosa"",
""Sub"":[{
""Cod"":""RF3.1"",
""Nom"":""El caminante se hace camino al andar"",
""Tip"":""Req"",
""Fue"":""El programador se hace programas al programar"",
""Pri"":""Alt"",
""Com"":""Cuando no sabes que mas poner"",
""Sub"":""NULL""
}]
}]}"
    'https://geeks.ms/fernandezja/2007/09/11/capturar-salida-de-un-proceso-ejemplo-comandos-bsicos-ping-tracert-cmd-etc/
    Private Sub Ejecutar()
        Dim strArgumentos As String = "127.0.0.1"
        Dim strExe As String = "ping"

        'Armar el proceso a ejecutar
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(strExe, strArgumentos)

        'Para poder manupular la salida indicamos que no se ejecute el shell
        startInfo.UseShellExecute = False

        'Por definicion (o mejor dicho codificacion) debemos ajustarnos a los que nos dice "San MSDN" 
        '(...)UseShellExecute debe ser true si se desea establecer ErrorDialog en true(...)
        startInfo.ErrorDialog = False

        'Sin ventana...
        startInfo.CreateNoWindow = True

        'Deseamos manipular la salida del proceso, para ello debemos establecer que se redirija la salida
        startInfo.RedirectStandardOutput = True

        Try
            Dim p As Diagnostics.Process = System.Diagnostics.Process.Start(startInfo)

            'Leemos la salida (objeto StreamReader)
            Dim sr As System.IO.StreamReader = p.StandardOutput
            Dim cadenaSalida As String = sr.ReadToEnd()
            sr.Close()

            'La visualizamos en el textbox. Un ejemplo basico ;)...
            Debug.Print(cadenaSalida)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try


    End Sub
End Class