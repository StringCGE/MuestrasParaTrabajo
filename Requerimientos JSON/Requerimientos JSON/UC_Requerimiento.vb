Public Class UC_Requerimiento
    Public Event algo(s As String)
    Private Sub UC_Requerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_Cerrar_Click(sender As Object, e As EventArgs) Handles BT_Cerrar.Click
        Cerrar()
    End Sub

    Private Sub Cerrar()
        Dim Obj As Object = Parent
        If Obj IsNot Nothing Then
            If TypeOf Obj Is FlowLayoutPanel Then
                Obj.Controls.Remove(Me)
            Else
                'Obj = Parent.Parent
                'If Obj IsNot Nothing Then

                'Else
                Throw New Exception("Algo Raro paso aqui 01")
                'End If
            End If
        Else
            Throw New Exception("Algo Raro paso aqui 02")
        End If
    End Sub
    Private Sub BT_Max_Click(sender As Object, e As EventArgs) Handles BT_Max.Click
        Ventana_Max()
    End Sub

    Private Sub BT_Min_Click(sender As Object, e As EventArgs) Handles BT_Min.Click
        Ventana_Min()
    End Sub

    Private Sub BT_Agrandar_Click(sender As Object, e As EventArgs) Handles BT_Agrandar.Click
        If BT_Agrandar.Text = "V" Then
            BT_Agrandar.Text = "∧"
            Ventana_Agr()
        Else
            BT_Agrandar.Text = "V"
            Ventana_Max()
        End If
    End Sub

    Public Sub MinTodo()
        Ventana_Min()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.MinTodo()
        Next
    End Sub

    Public Sub MaxTodo()
        Ventana_Max()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.MaxTodo()
        Next
    End Sub
    Public Sub AgrTodo()
        Ventana_Agr()
        For Each C As UC_Requerimiento In FLP_.Controls
            C.AgrTodo()
        Next
    End Sub
    Public Sub Ventana_Min()
        Size = New Size(Width_, 53)
        IsMin = True
        IsAgr = False
    End Sub
    Public Sub Ventana_Max()
        Size = New Size(Width_, 131)
        IsMin = False
        IsAgr = False
    End Sub
    Public Sub Ventana_Agr()
        Size = New Size(Width_, 574)
        IsMin = False
        IsAgr = True
    End Sub
    Private Sub BT_Agregar_Click(sender As Object, e As EventArgs) Handles BT_Agregar.Click
        AñadirRequerimiento(New UC_Requerimiento)
    End Sub

    Dim IsMin As Boolean = False
    Dim IsAgr As Boolean = False
    Public Function GetJSON() As String
        Dim texto As New List(Of Char)
        Dim texto_for As New List(Of Char)
        Dim StrTipo As String = ""
        Dim StrPrioridad As String = ""
        If RB_Requisito.Checked Then
            StrTipo = "Req"
        ElseIf RB_Restriccion.Checked Then
            StrTipo = "Res"
        End If
        If RB_Alta_Esencial.Checked Then
            StrPrioridad = "Alt"
        ElseIf RB_Media_Deseado.Checked Then
            StrPrioridad = "Med"
        ElseIf RB_Baja_Opcional.Checked Then
            StrPrioridad = "Baj"
        End If
        texto.AddRange(
"{
""Wid"":""" & Width & """,
""Min"":""" & IsMin.ToString & """,
""Agr"":""" & IsAgr.ToString & """,
""Cod"":""" & TB_Codigo.Text & """,
""Nom"":""" & TB_Nombre.Text & """,
""Tip"":""" & StrTipo & """,
""Fue"":""" & TB_Fuente.Text & """,
""Pri"":""" & StrPrioridad & """,
""Com"":""" & TB_Comentario.Text.Replace("""", "\""") & """,
""Sub"":")
        Dim Boo As Boolean = False
        texto_for.AddRange("[")
        For Each Req As UC_Requerimiento In FLP_.Controls
            If Boo Then
                texto_for.AddRange("," & vbCrLf)
            End If
            texto_for.AddRange(Req.GetJSON())
            Boo = True
        Next
        texto_for.AddRange("]")
        If Boo Then
            texto.AddRange(texto_for.ToArray())
        Else
            texto.AddRange("""NULL""")
        End If
        texto.AddRange(
"
}")
        Return texto.ToArray
    End Function
    Private Separador As String = " \pard\ltrpar\par "


    Public Function RTF_Comentario(ByRef comentario As String)
        Dim espacio As Boolean = False
        Dim puso As Boolean = False
        Dim l As New List(Of Char)
        For Each c As Char In comentario
            Select Case c
                Case vbCr
                    espacio = True
                    puso = False
                Case vbLf
                    espacio = True
                    puso = False
                Case vbCrLf
                    espacio = True
                    puso = False
                Case Else
                    If espacio And Not puso Then
                        espacio = False
                        puso = True
                        l.AddRange("\par ")
                    End If
                    l.Add(c)
            End Select
        Next
        'l.Reverse()
        Return l.ToArray()
    End Function


    Public Function GetComentarios(enterTitulo As Boolean) As String
        Dim num As Integer = Form1.GetNumero()
        Dim texto As New List(Of Char)
        Dim boo As Boolean = False
        For Each Req_2 As UC_Requerimiento In FLP_.Controls
            If boo Then
                texto.AddRange(Separador & vbCrLf)
            End If
            texto.AddRange(Req_2.GetComentarios(enterTitulo))
            boo = True
        Next
        Dim Titulo As String = ""
        If Form1.CHB_Numerar.Checked Then
            Titulo = num & Form1.TB_Separador.Text & TB_Codigo.Text & " " & TB_Nombre.Text
        Else
            Titulo = TB_Codigo.Text & " " & TB_Nombre.Text
        End If

        Dim Comentario_ As String = "\f1\fs22\cf0\b " & Titulo
        If enterTitulo Then
            Comentario_ = Comentario_ & "\par \b0\f0\fs22\cf0" & RTF_Comentario(GetComentario())
        Else
            Comentario_ = Comentario_ & "\b0\f0\fs22\cf0: " & RTF_Comentario(GetComentario())
        End If


        If texto.Count <> 0 Then
            Return Comentario_ & " \par " & vbCrLf & texto.ToArray
        Else
            Return Comentario_ 'texto.ToArray
        End If
    End Function


    Public Function GetRTF()
        Dim texto As New List(Of Char)

        Dim req As New Requerimiento()
        req.codigo = TB_Codigo.Text
        req.nombre = TB_Nombre.Text
        If RB_Requisito.Checked Then
            req.tipo = REQ_TIPO.REQUISITO
        ElseIf RB_Restriccion.Checked Then
            req.tipo = REQ_TIPO.RESTRICCION
        End If
        req.fuente = TB_Fuente.Text
        If RB_Alta_Esencial.Checked Then
            req.prioridad = REQ_PRIORIDAD.ESENCIAL
        ElseIf RB_Media_Deseado.Checked Then
            req.prioridad = REQ_PRIORIDAD.DESEADO
        ElseIf RB_Baja_Opcional.Checked Then
            req.prioridad = REQ_PRIORIDAD.OPCIONAL
        End If

        Dim boo As Boolean = False
        For Each Req_2 As UC_Requerimiento In FLP_.Controls
            If boo Then
                texto.AddRange("\pard\ltrpar\par")
            End If
            texto.AddRange(Req_2.GetRTF())
            boo = True

        Next
        If texto.Count <> 0 Then
            Return req.GetRTF & "\pard\ltrpar\par" & vbCrLf & texto.ToArray
        Else
            Return req.GetRTF  'texto.ToArray
        End If

    End Function

    Public Function GetComentario()
        Return TB_Comentario.Text
    End Function

    Public Function GetText() As String
        Dim texto As New List(Of Char)

        Return texto.ToArray
    End Function

    Public Sub New()
        InitializeComponent()
        Width_ = 501
        Ventana_Max()
    End Sub
    Public Sub New(ByRef O As OBJECT_)
        InitializeComponent()
        SetJSON(O)
    End Sub
    Dim O As OBJECT_
    Public Sub AñadirRequerimiento(ByRef Req As UC_Requerimiento)
        FLP_.Controls.Add(Req)
    End Sub
    Dim Width_ As Integer



    Public Sub SetJSON(ByRef O As OBJECT_)
        Json.Set_Obj(O)
        Try
            Width_ = CInt(GetVarJSON("Wid"))
            Me.Width = Width_
            If GetVarJSON("Min") = "True" Then
                Ventana_Min()
            Else
                Ventana_Max()
            End If
            If GetVarJSON("Agr") = "True" Then
                Ventana_Agr()
            End If
        Catch ex As Exception
        End Try

        TB_Nombre.Text = GetVarJSON("Nom")
        TB_Codigo.Text = GetVarJSON("Cod")

        Dim StrTipo As String = GetVarJSON("Tip")
        Dim StrPrioridad As String = GetVarJSON("Pri")
        Select Case StrTipo
            Case "Req"
                RB_Requisito.Checked = True
            Case "Res"
                RB_Restriccion.Checked = True
        End Select
        Select Case StrPrioridad
            Case "Alt"
                RB_Alta_Esencial.Checked = True
            Case "Med"
                RB_Media_Deseado.Checked = True
            Case "Baj"
                RB_Baja_Opcional.Checked = True
        End Select
        TB_Fuente.Text = GetVarJSON("Fue")
        TB_Comentario.Text = GetVarJSON("Com")

        Dim Encontro As Boolean = False
        Dim Res_ As Object = Json.Buscar("Sub", Encontro)
        Dim Encontro_2 As Boolean = False
        If Encontro Then 'MsgBox("Es Archivo Valido")
            If TypeOf Res_.Get_Value Is Array_ Then
                For Each OBj_2 As OBJECT_ In Res_.Get_Value.GetList()
                    Dim Rec As New UC_Requerimiento(OBj_2)
                    AñadirRequerimiento(Rec)
                Next
            ElseIf TypeOf Res_.Get_Value Is String Then
                If Res_.Get_Value.ToString <> "NULL" Then
                    MsgBox("Error en el tipo de valor que almacena")
                End If

            End If

        End If

    End Sub
    Dim Json As New JSON
    Public Function GetVarJSON(NomVal As String)
        Dim Encontro As Boolean = False
        Dim Res_ As Object = Json.Buscar(NomVal, Encontro)
        Dim Encontro_2 As Boolean = False
        If Encontro Then 'MsgBox("Es Archivo Valido")
            If TypeOf Res_.Get_Value Is String Then
                Return Res_.Get_Value
            Else
                Return "Errror 03 Tipo de dato no valido"
            End If
        Else
            Return "Errror 02 No existe Campo"
        End If
        Return "Errror 01 No se sabe que paso"
    End Function

    Private Sub BT_Up_Click(sender As Object, e As EventArgs) Handles BT_Up.Click
        Reordenar(Reorden.Manda_Arriba)
    End Sub

    Private Sub BT_Down_Click(sender As Object, e As EventArgs) Handles BT_Down.Click
        Reordenar(Reorden.Manda_Abajo)
    End Sub

    Private Sub Reordenar(Tipo As Reorden)
        Dim ubicacion As Integer = Parent.Controls.IndexOf(Me)
        Dim Ejecuta As Boolean = True
        If Tipo = Reorden.Manda_Abajo Then
            If ubicacion >= Parent.Controls.Count - 1 Then
                Ejecuta = False
            End If
        ElseIf Tipo = Reorden.Manda_Arriba Then
            If ubicacion <= 0 Then
                Ejecuta = False
            End If
        End If
        If Ejecuta Then

            Dim Obj As Object = Parent.Parent
            Try
                Obj.Reordenar(ubicacion, Tipo)
            Catch ex As Exception
                Obj = ParentForm
                Obj.Reordenar(ubicacion, Tipo)
            End Try
        End If
    End Sub

    Public Sub DoubleBufferring_(value As Boolean)
        Me.DoubleBuffered = value
        DB.EnableDoubleBuferring(Label1)
        DB.EnableDoubleBuferring(Label2)
        DB.EnableDoubleBuferring(Label3)
        DB.EnableDoubleBuferring(Label4)
        DB.EnableDoubleBuferring(Label5)
        DB.EnableDoubleBuferring(Label6)
        DB.EnableDoubleBuferring(TB_Codigo)
        DB.EnableDoubleBuferring(TB_Comentario)
        DB.EnableDoubleBuferring(TB_Fuente)
        DB.EnableDoubleBuferring(TB_Nombre)
        DB.EnableDoubleBuferring(BT_Agrandar)
        DB.EnableDoubleBuferring(BT_Agregar)
        DB.EnableDoubleBuferring(BT_Cerrar)
        DB.EnableDoubleBuferring(BT_Down)
        DB.EnableDoubleBuferring(BT_Max)
        DB.EnableDoubleBuferring(BT_Min)
        DB.EnableDoubleBuferring(BT_Up)
        DB.EnableDoubleBuferring(RB_Alta_Esencial)
        DB.EnableDoubleBuferring(RB_Alta_Esencial)
        DB.EnableDoubleBuferring(RB_Media_Deseado)
        DB.EnableDoubleBuferring(RB_Requisito)
        DB.EnableDoubleBuferring(RB_Restriccion)
        For Each r As UC_Requerimiento In FLP_.Controls
            r.DoubleBufferring_(value)
        Next
    End Sub

    Private Sub BT_AchicarHorizontal_Click(sender As Object, e As EventArgs) Handles BT_AchicarHorizontal.Click
        If Width > 501 Then
            Width = Width - 10
            Width_ = Width
        Else
            Width = 501
            Width_ = Width
        End If

    End Sub

    Private Sub BT_AgrandarHorizontal_Click(sender As Object, e As EventArgs) Handles BT_AgrandarHorizontal.Click
        Width = Width + 10
        Width_ = Width
    End Sub

    Public Sub Reenumerar(base As String, Fin As String)
        If Fin <> "" Then
            TB_Codigo.Text = base & Fin
        Else
            TB_Codigo.Text = base
        End If
        Dim Num As Integer = 1
        For Each C As UC_Requerimiento In FLP_.Controls
            C.Reenumerar(base & "." & Num, Fin)
            Num += 1
        Next
    End Sub
    Public Sub Reenumerar(base As String, ByRef Num As Integer, Fin As String)
        If base <> "" Then
            TB_Codigo.Text = base & Num
        Else
            TB_Codigo.Text = Num
        End If
        Num += 1
        If Fin <> "" Then
            TB_Codigo.Text = TB_Codigo.Text & Fin
        End If
        For Each C As UC_Requerimiento In FLP_.Controls
            C.Reenumerar(base, Num, Fin)
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

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Cortar()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Copiar()
    End Sub

    Private Sub SobreescribirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreescribirToolStripMenuItem.Click
        Sobreescribir()
    End Sub

    Public Sub Cortar()
        Clipboard.SetText(GetJSON())
        Cerrar()
    End Sub
    Public Sub Copiar()
        Clipboard.SetText(GetJSON())
    End Sub
    Public Sub Sobreescribir()
        If MessageBox.Show("¿Desea pegar y sobreescribir este requerimiento?", "Sobreescribir el requerimiento", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim Json As New JSON
                Json.Set_Cadena(Clipboard.GetText())
                Json.Leer()
                SetJSON(Json.Get_Obj())
            Catch ex As Exception
                MsgBox("El formato no es el correcto. No se puede leer")
            End Try
        End If
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
End Class
