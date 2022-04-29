Public Module Mod_RTF
    Public Class RTF

    End Class

    Public Class Requerimiento
        Public codigo As String = ""
        Public nombre As String = ""
        Public tipo As REQ_TIPO = REQ_TIPO.NULL
        Public prioridad As REQ_PRIORIDAD = REQ_PRIORIDAD.NULL
        Public fuente As String = ""
        Public comentario As String = ""
        Public Sub New()

        End Sub
        Public Sub New(ByVal codigo As String, ByVal nombre As String, ByVal tipo As REQ_TIPO, ByVal prioridad As REQ_PRIORIDAD, ByVal fuente As String, ByVal comentario As String)
            Asignar(codigo, nombre, tipo, prioridad, fuente, comentario)
        End Sub
        Public Sub Asignar(codigo As String, nombre As String, tipo As REQ_TIPO, prioridad As REQ_PRIORIDAD, fuente As String, comentario As String)
            Me.codigo = codigo
            Me.nombre = nombre
            Me.tipo = tipo
            Me.prioridad = prioridad
            Me.fuente = fuente
            Me.comentario = comentario
        End Sub

        Public Function GetRTF()
            Dim tabla As New Tabla
            Dim fila1 As New Fila, fila2 As New Fila, fila3 As New Fila, fila4 As New Fila, fila5 As New Fila
            fila1.acumula = True : fila2.acumula = True : fila3.acumula = True : fila4.acumula = True : fila5.acumula = True
            Dim col1 As Integer = 2700
            Dim col2 As Integer = 2400
            Dim col3 As Integer = 2400
            Dim col4 As Integer = 2400
            Dim tipreq As String = "  ", tipres As String = "  "
            Dim priesc As String = "  ", prides As String = "  ", priopc As String = "  "
            If tipo = REQ_TIPO.REQUISITO Then
                tipreq = "\u10004?"
            ElseIf tipo = REQ_TIPO.RESTRICCION Then
                tipres = "\u10004?" ' "✔"
            End If
            If prioridad = REQ_PRIORIDAD.ESENCIAL Then
                priesc = "\u10004?"
            ElseIf prioridad = REQ_PRIORIDAD.DESEADO Then
                prides = "\u10004?"
            ElseIf prioridad = REQ_PRIORIDAD.OPCIONAL Then
                priopc = "\u10004?"
            End If
            fila1.AñadirCampos({New Campo(col1, "Número de requerimiento"),
                                New Campo(col2 + col3 + col4, codigo)})
            fila2.AñadirCampos({New Campo(col1, "Nombre de requisito"),
                                New Campo(col2 + col3 + col4, nombre)})
            fila3.AñadirCampos({New Campo(col1, "Tipo"),
                                New Campo(col2, tipreq & "  Requisito"),
                                New Campo(col3 + col4, tipres & "  Restriccion")})
            fila4.AñadirCampos({New Campo(col1, "Fuente del requisito"),
                                New Campo(col2 + col3 + col4, fuente)})
            fila5.AñadirCampos({New Campo(col1, "Prioridad del requisito"),
                                New Campo(col2, priesc & "  Esencial"),
                                New Campo(col3, prides & "  Deseada"),
                                New Campo(col4, priopc & "  Opcional")})

            tabla.AñadirFila(fila1) : tabla.AñadirFila(fila2) : tabla.AñadirFila(fila3) : tabla.AñadirFila(fila4) : tabla.AñadirFila(fila5)
            Return tabla.GetRTF()
        End Function

    End Class
    Public Enum REQ_TIPO
        NULL
        REQUISITO
        RESTRICCION
    End Enum
    Public Enum REQ_PRIORIDAD
        NULL
        ESENCIAL
        DESEADO
        OPCIONAL
    End Enum
    Public Class Tabla
        Public Filas As New List(Of Fila)
        Public Sub AñadirFila(fila As Fila)
            Filas.Add(fila)
        End Sub
        Public Function GetRTF()
            Dim texto As New List(Of Char)
            Dim Boo As Boolean = False
            For Each f As Fila In Filas
                If Boo Then
                    texto.AddRange("\trowd\trgaph70\trleft-108\trqc\trbrdrt\brdrs\brdrw10 " & vbCrLf)
                End If
                texto.AddRange(f.GetRTF())
                Boo = True
            Next
            Return texto.ToArray
        End Function
    End Class

    Public Class Fila
        Public l_campo As New List(Of Campo)
        Public acumula As Boolean = False
        Public base As Integer = 0
        Public Sub AñadirCampos(ByRef campos As IEnumerable(Of Campo))
            l_campo.AddRange(campos)
        End Sub
        Public Sub AñadirCampo(cellx As Integer, campo As String)
            l_campo.Add(New Campo(cellx, campo))
        End Sub
        Public Function GetRTF()
            Dim texto As New List(Of Char)
            Dim texto_for As New List(Of Char)
            texto.AddRange("\trbrdrl\brdrs\brdrw10 
\trbrdrb\brdrs\brdrw10 
\trbrdrr\brdrs\brdrw10 ")
            base = 0
            For Each c As Campo In l_campo
                texto.AddRange("\clbrdrt\brdrw15\brdrs\clbrdrl\brdrw15\brdrs\clbrdrb\brdrw15\brdrs\clbrdrr\brdrw15\brdrs " & vbCrLf & "\cellx" & base + c.cellx)
                If acumula Then
                    base += c.cellx
                End If
            Next
            texto.AddRange("\pard\intbl\ltrpar\sl252\slmult1\f0\fs22 " & vbCrLf)
            For Each c As Campo In l_campo
                texto.AddRange(" " & c.valor & "\cell")
            Next
            texto.AddRange("\row")
            Return texto.ToArray
        End Function
    End Class

    Public Class Campo
        Public cellx As Integer = 0
        Public valor As String = ""
        Public Sub New()
        End Sub
        Public Sub New(cellx As Integer, valor As String)
            Me.cellx = cellx
            Me.valor = valor
        End Sub
    End Class
End Module
