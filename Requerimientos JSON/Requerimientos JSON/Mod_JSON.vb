Public Module Mod_JSON
    Public Class JSON
        Public Sub Set_Cadena(ByRef value As String)
            cadena_ = value
        End Sub
        Public Sub Leer()
            Obj = Leer(Get_Cadena())
        End Sub
        Public Function Buscar(ByRef Ruta As String, ByRef Encontro As Boolean)
            'MsgBox(Obj.ToString)
            Return Buscar(Obj, Ruta, Encontro)
        End Function

        Public Function Get_Cadena()
            Return cadena_
        End Function
        Protected cadena_ As String = ""
        Protected Obj As OBJECT_
        Public Function Get_Obj()
            Return Obj
        End Function
        Public Sub Set_Obj(ByRef value As OBJECT_)
            Obj = value
        End Sub
        Protected Function Leer(ByRef JSON As String) 'Version 2.0
            'JSON = "   { ""Nombre"" : ""Christian"" , ""Apellido"" : ""Gonzalez"" , ""Edad"" : 2,5 , ""Materias"":{""Normales"":""Lenguaje-matematica""},""Carrera"":""Software"",""Platos"":[{""Entrada"":""Sopa de queso"",""Segundo"":""Tallarin""},{""Entrada"":""Caldo de Pollo"",""Segundo"":""Seco de pollo""}]}"
            If JSON = "" Then
                Throw New Exception("No hay el texto...")
            End If
            Dim Ent As ENTRADA = ENTRADA.NULL
            Dim Obj As OBJECT_
            For i As Integer = 0 To JSON.Length - 1
                Select Case JSON(i)
                    Case """"
                        Ent = ENTRADA.Dato
                    Case ","
                        Throw New Exception("Caracter fuera de lugar")
                    Case ":"
                        Throw New Exception("Caracter fuera de lugar")
                    Case "}"
                        Throw New Exception("Caracter fuera de lugar")
                    Case "{"
                        i += 1
                        Obj = LeerClase(JSON, i)
                    Case Else

                End Select
            Next
            Return Obj
        End Function

        Public Function LeerClase(ByRef JSON As String, ByRef Index As Integer) As OBJECT_
            Dim Obj As New OBJECT_
            Dim str As String = ""
            Dim nom As String = ""
            Dim val As String = Nothing
            Dim valNum As Object = 0
            Dim Fue_Var As FUENTE_VAR = FUENTE_VAR.Nombre
            For i As Integer = Index To JSON.Length - 1
                Select Case JSON(i)
                    Case """"
                        i += 1
                        Select Case Fue_Var
                            Case FUENTE_VAR.Nombre
                                nom = ColectaVar(JSON, i)
                            Case FUENTE_VAR.Valor
                                val = ColectaVar(JSON, i)
                        End Select
                        str = ColectaVar(JSON, i)
                    Case "["
                        i += 1
                        Fue_Var = FUENTE_VAR.Array
                        Obj.Add(New ELEMENT_(nom, ColectarArray(JSON, i)))

                    Case "]"

                    Case ","
                        If Not Fue_Var = FUENTE_VAR.Clase Then
                            If Fue_Var = FUENTE_VAR.Numero Then
                                Obj.Add(New ELEMENT_(nom, valNum))
                            Else
                                Obj.Add(New ELEMENT_(nom, val))
                            End If
                        End If
                        Fue_Var = FUENTE_VAR.Nombre
                    Case ":"
                        Fue_Var = FUENTE_VAR.Valor
                    Case "{"
                        Select Case Fue_Var
                            Case FUENTE_VAR.Nombre
                                Throw New Exception("No puede capturar otra clase en el apartado de nombre")
                            Case FUENTE_VAR.Valor
                                i += 1
                                Fue_Var = FUENTE_VAR.Clase
                                Obj.Add(New ELEMENT_(nom, LeerClase(JSON, i)))
                        End Select
                    Case "}"
                        If Fue_Var = FUENTE_VAR.Valor Then
                            Obj.Add(New ELEMENT_(nom, val))
                        ElseIf Fue_Var = FUENTE_VAR.Numero Then
                            Obj.Add(New ELEMENT_(nom, valNum))
                        End If
                        Fue_Var = FUENTE_VAR.NULL
                        Index = i
                        Return Obj
                    Case " "
                    Case vbCr
                    Case vbLf
                    Case vbTab
                    Case Else
                        Select Case Fue_Var
                            Case FUENTE_VAR.Nombre
                                Throw New Exception("No puede capturar nombre")
                            Case FUENTE_VAR.Valor
                                Fue_Var = FUENTE_VAR.Numero
                                valNum = Util.ConvertirNum(ColectaNum(JSON, i))
                                If InStr(1, "-1234567890.,", JSON(i + 1), CompareMethod.Text) > 0 Then
                                    If Not JSON(i + 1) = "," Then
                                        Throw New Exception("Caracter fuera de lugar")
                                    End If
                                End If
                        End Select
                End Select
            Next
            Throw New Exception("No se como llego aqui")
        End Function
        Public Function ColectarArray(ByRef JSON As String, ByRef Index As Integer) As Array_
            Dim L As New Array_
            For i As Integer = Index To JSON.Length - 1
                Select Case JSON(i)
                    Case """"

                    Case "["

                    Case "]"
                        Index = i
                        Return L
                    Case ","

                    Case "{"
                        i += 1
                        L.Add(LeerClase(JSON, i))
                End Select
            Next
            Throw New Exception("No ha llegado al final del array y se acabo la cadena")
        End Function
        Public Sub RecorreBlanco(ByRef JSON As String, ByRef Index As Integer)
            For i As Integer = Index To JSON.Length - 1
                If Not InStr(1, vbCr & vbLf & vbTab & ChrW(8), JSON(i)) > 0 Then
                    Exit Sub
                End If
            Next
        End Sub
        Public Function ColectaNum(ByRef JSON As String, ByRef Index As Integer)
            Dim l As New List(Of Char)
            Dim Coma As Integer = 0
            For i As Integer = Index To JSON.Length - 1
                If InStr(1, "-1234567890.,", JSON(i), CompareMethod.Text) > 0 Then
                    If JSON(i) = "," Or JSON(i) = "." Then
                        Coma += 1
                    End If
                    If Coma > 1 Then
                        Index = i
                        Return l.ToArray()
                    End If
                    l.Add(JSON(i))
                Else
                    Index = i
                    Return l.ToArray()
                End If
            Next
            Throw New Exception("Errror en lectura, esta embrujado el programa")
        End Function


        Class Num
            Public Boolean_ As System.Boolean
            Public Byte_ As System.Byte
            Public Char_ As System.Char
            Public DateTime_ As System.DateTime
            Public Decimal_ As System.Decimal
            Public Double_ As System.Double
            Public Int16_ As System.Int16
            Public Int32_ As System.Int32
            Public Int64_ As System.Int64
            Public IntPtr_ As System.IntPtr
            Public SByte_ As System.SByte
            Public Single_ As System.Single
            Public TimeSpan_ As System.TimeSpan
            Public UInt16_ As System.UInt16
            Public UInt32_ As System.UInt32
            Public UInt64_ As System.UInt64
            Public UIntPtr_ As System.UIntPtr
        End Class

        Public Function ColectaVar(ByRef JSON As String, ByRef Index As Integer)
            Dim escape As Boolean = False
            Dim otro As Boolean = False
            Dim l As New List(Of Char)
            For i As Integer = Index To JSON.Length - 1
                Select Case JSON(i)
                    Case """"
                        If escape And Not otro Then
                            l.AddRange("""")
                            otro = True
                            escape = False
                        ElseIf Not escape Then
                            Index = i
                            Return l.ToArray()
                        End If
                    Case "\"
                        escape = True
                        otro = False
                    Case Else
                        If escape And Not otro Then
                            l.AddRange("\" & JSON(i))
                        Else
                            l.Add(JSON(i))
                        End If
                        otro = True
                        escape = False
                End Select
            Next
            Throw New Exception("Fin de archivo sin encontrar el fin del string")
        End Function
        Public Function Buscar(Obj As OBJECT_, ByRef Ruta As String, ByRef Encontro As Boolean) As Object
            'Jugo:Naranja
            Encontro = False
            If Obj Is Nothing Then
                Throw New Exception("Obj fue Nothing")
                Return Nothing
            End If
            Dim Argu As String = Separar(Ruta)
            Dim Str As String = Argu
            Dim Index As Integer = 0
            Dim Name As String = ""
            Dim Value As String = ""
            Dim N As String = ""
            Dim Arr As Boolean = EsArray(Str, Index, N, Name, Value)
            'Este script si funciona
            For Each El As ELEMENT_ In Obj.GetElements
                If El.Get_Name = N Then
                    If Ruta <> "" Then
                        If TypeOf El.Get_Value Is OBJECT_ Then
                            Return Buscar(CType(El.Get_Value, OBJECT_), Ruta, Encontro)
                        ElseIf TypeOf El.Get_Value Is Array_ Then
                            If Index <> -1 Then 'Index
                                Return Buscar(CType(El.Get_Value().GetList()(Index), OBJECT_), Ruta, Encontro)
                            Else
                                For Each Obj_ As OBJECT_ In El.Get_Value.GetList() 'Comida[ Jugo:Tomatillo].Entrada
                                    Dim Aux As String = Name
                                    If Buscar(Obj_, Aux, Encontro).Get_Value() = Value Then
                                        Return Buscar(CType(Obj_, OBJECT_), Ruta, Encontro)
                                    End If
                                Next
                            End If
                        End If
                    Else
                        If Arr Then
                            If Index <> -1 Then 'Index
                                Encontro = True
                                Return El.Get_Value(Index)
                            End If
                        Else
                            Encontro = True
                            Return El
                        End If
                    End If
                End If
            Next
            Encontro = False
            Return Nothing
        End Function
        Public Function BuscarRespaldo(Obj As OBJECT_, ByRef Ruta As String, ByRef Encontro As Boolean) As Object
            'Jugo:Naranja
            Encontro = False
            If Obj Is Nothing Then
                Throw New Exception("Obj fue Nothing")
                Return Nothing
            End If
            Dim Argu As String = Separar(Ruta)
            Dim ArguAnte As String = Ruta
            Dim Str As String = Argu
            Dim Index As Integer = 0
            Dim Name As String = ""
            Dim Value As String = ""
            Dim N As String = ""
            Dim Arr As Boolean = EsArray(Str, Index, N, Name, Value)
            'Este script si funciona
            For Each El As ELEMENT_ In Obj.GetElements
                If El.Get_Name = N Then
                    If Ruta <> "" Then
                        If TypeOf El.Get_Value Is OBJECT_ Then
                            Return Buscar(CType(El.Get_Value, OBJECT_), Ruta, Encontro)
                        ElseIf TypeOf El.Get_Value Is OBJECT_() Then
                            If Index <> -1 Then 'Index
                                Return Buscar(CType(El.Get_Value()(Index), OBJECT_), Ruta, Encontro)
                            Else
                                For Each Obj_ As OBJECT_ In El.Get_Value
                                    Dim Aux As String = Name
                                    If Buscar(Obj_, Aux, Encontro) = Value Then
                                        Return Buscar(CType(Obj_, OBJECT_), Ruta, Encontro)
                                    End If
                                Next
                            End If
                        End If
                    Else
                        If Arr Then
                            If Index <> -1 Then 'Index
                                Encontro = True
                                Return El.Get_Value()(Index)
                            End If
                        Else
                            Encontro = True
                            Return El.Get_Value
                        End If
                    End If
                End If
            Next
            Encontro = False
            Return Nothing
        End Function
#Region "Utilidades"

        Enum FUENTE_VAR
            NULL
            Nombre
            Valor
            Clase
            Array
            Numero
        End Enum
        Enum ENTRADA
            NULL
            Clase
            Array
            Dato
        End Enum
        Private Function EsArray(ByRef Str As String, ByRef Index As Integer, ByRef N As String, ByRef Name As String, ByRef Value As String)
            Dim Arr As Boolean = False
            Dim Escribe As Boolean = False
            Dim Argu As String = ""
            Dim Aux As String = ""
            For Each c As Char In Str
                Select Case c
                    Case "["
                        Arr = True
                        Escribe = True
                    Case "]"
                        Escribe = False
                    Case Else
                        If Escribe Then
                            Argu = Argu & c
                        ElseIf Not Arr Then
                            N = N & c
                        End If
                End Select
            Next
            Try
                Index = CInt(Argu)
            Catch ex As Exception
                Index = -1
                Dim Sig As Boolean = False
                For Each c As Char In Argu
                    Select Case c
                        Case ":"
                            Sig = True
                        Case Else
                            If Not Sig Then
                                Name = Name & c
                            Else
                                Value = Value & c
                            End If
                    End Select
                Next
            End Try
            Return Arr
        End Function
        Private Function Separar(ByRef Orig As String)
            Dim Aux As String = Orig
            Orig = ""
            Dim Act As String = ""
            Dim B_Act As Boolean = True
            For Each c As Char In Aux
                If c = "." And B_Act Then
                    B_Act = False
                Else
                    If B_Act Then
                        Act = Act & c
                    Else
                        Orig = Orig & c
                    End If
                End If

            Next
            Return Act
        End Function
#End Region
    End Class

    Public Class Util
        Public Shared Function ConvertirNum(value As String)
            If value = "" Then
                MsgBox("Aqui no deberia entrar")
                Return ""
                Throw New Exception("Cadena vacia")
            End If
            If EsDecimal(value) Then
                Try
                    Return CSng(value)
                Catch ex1 As Exception
                    Try
                        Return CDec(value)
                    Catch ex2 As Exception
                        Try
                            Return CDbl(value)
                        Catch ex3 As Exception
                            MsgBox("No esta bien escrito el numero")
                        End Try
                    End Try
                End Try
            Else
                If value(0) = "-" Then
                    Try
                        Return CSByte(value)
                    Catch ex1 As Exception
                        Try
                            Return CShort(value)
                        Catch ex2 As Exception
                            Try
                                Return CInt(value)
                            Catch ex3 As Exception
                                Try
                                    Return CLng(value)
                                Catch ex4 As Exception
                                    Try
                                        Return CDbl(value)
                                    Catch ex5 As Exception
                                        Throw New Exception("No esta bien escrito el numero")
                                    End Try
                                End Try
                            End Try
                        End Try
                    End Try
                Else
                    Try
                        Return CByte(value)
                    Catch ex1 As Exception
                        Try
                            Return CUShort(value)
                        Catch ex2 As Exception
                            Try
                                Return CUInt(value)
                            Catch ex3 As Exception
                                Try
                                    Return CULng(value)
                                Catch ex4 As Exception
                                    Try
                                        Return CDbl(value)
                                    Catch ex5 As Exception
                                        Throw New Exception("No esta bien escrito el numero")
                                    End Try
                                End Try
                            End Try
                        End Try
                    End Try
                End If
            End If
            Throw New Exception("Exprecion nula")
        End Function
        Public Shared Function EsDecimal(value As String)
            For Each C As Char In value
                If C = "," Or C = "." Then
                    Return True
                End If
            Next
            Return False
        End Function
    End Class
#Region "Modelo"
    Public Class OBJECT_
        Protected bloquear_ As Boolean = False
        Public Parent As Object
        Public Property Bloquear As Boolean
            Get
                Return bloquear_
            End Get
            Set(value As Boolean)
                bloquear_ = value
                For Each Element As ELEMENT_ In Elements
                    If TypeOf Element.Get_Value Is OBJECT_ Then
                        Element.Get_Value.Bloquear = bloquear_
                    ElseIf TypeOf Element.Get_Value Is OBJECT_() Then
                        For Each o As Object In Element.Get_Value
                            o.Bloquear = bloquear_
                        Next
                    End If
                Next
            End Set
        End Property
        Private Elements As New List(Of ELEMENT_)
        Public Sub New()

        End Sub
        Public Sub New(Elements As IEnumerable(Of ELEMENT_))
            Add(Elements)
        End Sub
        Public Sub Add(Elements As ELEMENT_)
            If Not Bloquear Then
                Elements.Set_Parent(Me)
                Me.Elements.Add(Elements)
            End If
        End Sub
        Public Sub AddRange(Elements As IEnumerable(Of ELEMENT_))
            If Not Bloquear Then
                Me.Elements.AddRange(Elements)
            End If
        End Sub
        Public Function Item(index As Integer) As ELEMENT_
            Return Elements(index)
        End Function
        Public Sub Remove(index As Integer)
            Elements.RemoveAt(index)
        End Sub
        Public Function Remove(element As ELEMENT_)
            Return Elements.Remove(element)
        End Function
        Public Function GetElement(Index As Integer) As ELEMENT_
            Try
                Return Elements(Index)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function GetElement(Name As String) As ELEMENT_
            For Each Element As ELEMENT_ In Elements
                If Name = Element.Get_Name Then
                    Return Element
                End If
            Next
            Return Nothing
        End Function
        Public ReadOnly Property GetElements As List(Of ELEMENT_)
            Get
                Return Elements
            End Get
        End Property
        Private Function Clonar(ByVal Elements As IEnumerable(Of ELEMENT_))
            Return New OBJECT_(Elements)
        End Function
        Public Function Clonar()
            Return Clonar(Elements)
        End Function
        Public Overrides Function ToString() As String
            Dim L As New List(Of Char)
            Dim B As Boolean = False
            L.AddRange("{" & vbCrLf)
            For Each Ele As ELEMENT_ In Elements
                If B Then
                    L.AddRange("," & vbCrLf)
                End If
                B = True
                L.AddRange(Ele.ToString())
            Next
            L.AddRange(vbCrLf)
            L.AddRange("}" & vbCrLf)
            Return L.ToArray()
        End Function
    End Class
    Public Class Array_
        Protected bloquear_ As Boolean = False
        Public Property Bloquear As Boolean
            Get
                Return bloquear_
            End Get
            Set(value As Boolean)
                bloquear_ = value
                For Each o As Object In L
                    o.Bloquear = bloquear_
                Next
            End Set
        End Property

        Protected Parent_ As Object
        Public Sub Set_Parent(value As Object)
            Parent_ = value
        End Sub
        Public Function Get_Parent()
            Return Parent_
        End Function

        Protected L As New List(Of OBJECT_)
        Public Sub Add(value As OBJECT_)
            value.Parent = Me
            L.Add(value)
        End Sub
        Public Sub Remove(value As OBJECT_)
            L.Remove(value)
        End Sub
        Public Function GetObjecto(Name As String, Value As String)
            For Each O As OBJECT_ In L
                Dim El As ELEMENT_ = O.GetElement(Name)
                If El IsNot Nothing Then
                    If TypeOf El.Get_Value IsNot ELEMENT_ Or TypeOf El.Get_Value IsNot Array_ Then
                        If El.Get_Value = Value Then
                            Return O
                        End If
                    End If
                End If
            Next
            Return Nothing
        End Function
        Public Function GetList()
            Return L
        End Function
    End Class
    Public Class ELEMENT_
        Protected Name_ As String = Nothing
        Protected Value_ As Object = Nothing
        Protected Parent_ As OBJECT_

        Public Property Bloquear As Boolean
            Get
                Return bloquear_
            End Get
            Set(value As Boolean)
                bloquear_ = value
                If TypeOf Get_Value() Is OBJECT_ Then
                    Get_Value.Bloquear = bloquear_
                ElseIf TypeOf Get_Value() Is Array_ Then
                    For Each o As Object In Get_Value.GetList()
                        o.Bloquear = bloquear_
                    Next
                End If
            End Set
        End Property

        Public Sub Set_Parent(value As OBJECT_)
            Parent_ = value
        End Sub
        Public Function Get_Parent()
            Return Parent_
        End Function

        Public Sub Set_Name(value As String)
            Name_ = value
        End Sub
        Public Function Get_Name()
            Return Name_
        End Function

        Public Sub Set_Value(value As Object)
            Value_ = value
            Set_Parent(value)
        End Sub
        Public Function Get_Value()
            Return Value_
        End Function
        Protected bloquear_ As Boolean = False
        Public Sub New()

        End Sub
        Private Sub Set_Parent(value As Object)
            If TypeOf value Is OBJECT_ Then
                Me.Get_Value().Parent = Me
            ElseIf TypeOf value Is Array_ Then
                Dim Arr As Array_ = value
                Arr.Set_Parent(Me)
                For Each v As OBJECT_ In value.GetList()
                    v.Parent = Arr
                Next
            End If
        End Sub
        Public Sub New(Name As String, Value As Object)
            Set_Name(Name)
            Set_Value(Value)

        End Sub
        Public Overrides Function ToString() As String
            Dim L As New List(Of Char)
            L.AddRange("""" & Get_Name() & """:")
            If TypeOf Get_Value() Is OBJECT_() Then
                Dim Res_ As OBJECT_() = Get_Value()
                'MsgBox("---Es OBJECT_()")
                L.AddRange("[" & vbCrLf)
                Dim B As Boolean = False
                For Each O As OBJECT_ In Res_
                    If B Then
                        L.AddRange("," & vbCrLf)
                    End If
                    B = True
                    L.AddRange(O.ToString())
                Next
                L.AddRange("]")
            ElseIf TypeOf Get_Value() Is OBJECT_ Then
                Dim Res_ As OBJECT_ = Get_Value()
                'MsgBox("---Es OBJECT_")
                L.AddRange(Res_.ToString())

            ElseIf TypeOf Get_Value() Is String Then
                'MsgBox("---Es String")
                L.AddRange("""" & Get_Value().Replace("""", "\""") & """")
                'ElseIf TypeOf Value Is Object Then
                '    MsgBox("Es Object")
            ElseIf Get_Value() Is Nothing Then
                L.AddRange("""""")
            Else
                L.AddRange(CStr(Get_Value()))
            End If
            Return L.ToArray()
        End Function
    End Class
#End Region
End Module
