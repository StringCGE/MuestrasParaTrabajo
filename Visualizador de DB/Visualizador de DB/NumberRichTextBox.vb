Public Class NumberRichTextBox
    Public Event TextChanged_()
    'Aqui se escribe codigo en fase beta
    Private Sub NumberRichTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Numeros en linea
        LB_Num.Font = New Font(RTB_.Font.FontFamily, RTB_.Font.Size)
        Carga_ColoreaPalabra()
        Sombrear_(0, RTB_.Text.Length) 'Colorea todo lo que este en el RichTextBox
    End Sub
    Public Overrides Property Text As String
        Get
            Return RTB_.Text
        End Get
        Set(value As String)
            RTB_.Text = value
            Sombrear_(0, RTB_.Text.Count - 1)
        End Set
    End Property
    Dim NoBorrarColor As Boolean = False
#Region "Sobreescribiendo metodos"
    'Con esto impido que se pueda pegar con formato cualquier texto
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If (keyData = (Keys.Control Or Keys.V)) Then
            Dim Selec As Integer = RTB_.SelectionStart
            Dim Texto = Clipboard.GetText()
            RTB_.Text = RTB_.Text.Insert(RTB_.SelectionStart, Texto)
            NoBorrarColor = True
            'Sombrear(Selec, Selec + Texto.Length - 1)
            Sombrear(0, RTB_.Text.Length - 1)
            If Texto.Length + Selec >= RTB_.Text.Length Then
                RTB_.SelectionStart = Selec + Texto.Length - 1
            Else
                RTB_.SelectionStart = Selec + Texto.Length
            End If

            Return True
        ElseIf keyData = Keys.C Then
            Return False
        Else
            Return False
        End If
        Return True
    End Function
#End Region
#Region "Numeros en lineas"
    Private Sub RTB__TextChanged(sender As Object, e As EventArgs) Handles RTB_.TextChanged
        Actualiza()
        RTB_TextChanged()
        RaiseEvent TextChanged_()
    End Sub
    Private Sub Actualiza()
        Dim pos As Point = New Point(0, 0)
        Dim PosIni As Integer = RTB_.GetCharIndexFromPosition(pos)
        Dim PrimLin As Integer = RTB_.GetLineFromCharIndex(PosIni)
        pos.X = ClientRectangle.Width
        pos.Y = ClientRectangle.Height
        Dim PosFin As Integer = RTB_.GetCharIndexFromPosition(pos)
        Dim UltLin As Integer = RTB_.GetLineFromCharIndex(PosFin)
        LB_Num.Text = ""
        Dim Num As Integer = 0
        For i As Integer = PrimLin To UltLin Step 1
            Num = i + 1
            LB_Num.Text += Num & vbCrLf
        Next
    End Sub
    Private Sub RTB_TextChanged()
        Sombrear()
    End Sub
    Private Sub RTB__VScroll(sender As Object, e As EventArgs) Handles RTB_.VScroll
        Dim d As Integer = RTB_.GetPositionFromCharIndex(0).Y Mod (RTB_.Font.Height) ' + 1)
        LB_Num.Location = New Point(0, d)
        Actualiza()
    End Sub
    Private Sub RTB__FontChanged(sender As Object, e As EventArgs) Handles RTB_.FontChanged
        Actualiza()
        RTB__VScroll(Nothing, Nothing)
    End Sub
    Private Sub RTB__Resize(sender As Object, e As EventArgs) Handles RTB_.Resize
        RTB__VScroll(Nothing, Nothing)
    End Sub
#End Region

#Region "Colorea Palabras"

    Public Structure PalCol
        Public Palabra As String
        Public Color As Color
        Sub New(Palabra As String, Color As Color)
            Me.Palabra = Palabra
            Me.Color = Color
        End Sub
    End Structure
    Dim Lista As New List(Of PalCol)
    Private Sub Carga_ColoreaPalabra()
        CargaPalColor(Color.Blue, {"DROP", "Drop", "drop", "TO", "To", "to", "RENAME", "Rename", "rename", "AS", "As", "as", "SELECT", "Select", "select", "FROM", "From", "from", "INNER", "Inner", "inner", "JOIN", "Join", "join", "WHERE", "Where", "where", "INSERT", "Insert", "insert", "ALTER", "Alter", "alter", "DELETE", "Delete", "delete", "CREATE", "Create", "create", "TABLE", "Table", "table", "TEXT", "Text", "text", "INTEGER", "Integer", "integer", "PRIMARY", "Primary", "primary", "KEY", "Key", "key", "NOT", "Not", "not", "NULL", "Null", "null", "FOREIGN", "Foreign", "foreign", "REFERENCES", "References", "references", "INTO", "Into", "into", "VALUES", "Values", "values", "AUTOINCREMENT", "Autoincrement", "autoincrement", "AND", "And", "and", "OR", "Or", "or", "IF", "If", "if", "EXISTS", "Exists", "exists"})
        CargaPalColor(Color.Blue, {"Dim", "Private", "ByRef", "ByVal", "Next", "My", "Function", "For", "AddressOf", "Catch", "Try", "And", "Or", "Not", "Each", "New", "Of", "String", "Integer", "Handles", "As", "Public", "Dim", "Sub", "Return", "If", "Then", "Else", "End", "ByVal", "Class", "MarshalByRefObject", "ByRefObject", "Object"})

        CargaPalColor(Color.Red, {"Gasolina", "Pavo"})
        CargaPalColor(Color.Gray, {"Color", "List"})
    End Sub
    Public Sub CargaPalColor(Color As Color, Palabras As IEnumerable(Of String))
        For Each Palabra As String In Palabras
            Lista.Add(New PalCol(Palabra, Color))
        Next
    End Sub
    Public Function MuestraLista()
        Return Lista
    End Function

#Region "Sombrea palabras"
    'Aqui va la linea que desencadena tal accion
    Dim AccionDesdeCodigo As Boolean = False
    Public Sub Sombrear()
        AccionDesdeCodigo = True
        AccionAgregaRTB(RTB_, AddressOf Sombrear_)
        AccionDesdeCodigo = False
    End Sub
    Dim Ini As Integer = 0
    Dim FIn As Integer = 0
    Dim SombrearArgu As Boolean = False

    Public Sub Sombrear(Ini As Integer, Fin As Integer)
        Me.Ini = Ini
        Me.FIn = Fin
        'MsgBox(Ini & "  " & Fin)
        SombrearArgu = True
        AccionDesdeCodigo = True
        AccionAgregaRTB(RTB_, AddressOf Sombrear_)
        AccionDesdeCodigo = False
    End Sub
    'Private Sub Sombrear_()

    '    Dim NoValChar As String = " "" '¿?¡!#$%&()={[(|)]}:;-_<>" & vbCr & vbLf & vbTab
    '    Dim Str As String = RTB_.Text
    '    Dim Palabra As String = ""
    '    Dim I As Integer = 0
    '    While I < Str.Length
    '        If Not InStr(1, NoValChar & ".,", Str(I)) > 0 Then
    '            Palabra = Palabra & Str(I)
    '        Else
    '            MarcaSi(Palabra, I)
    '        End If
    '        I += 1
    '    End While
    '    MarcaSi(Palabra, I)
    'End Sub
    Private Sub Sombrear_()
        If SombrearArgu Then
            'Sombrea lo que se pego
            Sombrear_(Ini, FIn)
            SombrearArgu = False
        Else
            SombreaPalabra()
        End If
    End Sub
    Public VerCosa As Boolean = False
    Private Sub SombreaPalabra()
        Dim Pos As Integer = RTB_.SelectionStart
        Dim PosIni As Integer = Pos
        Dim PosFin As Integer = 0
        While True
            If Restar1(Pos) Then
                If Not InStr(1, Criterio.PalabraNum, RTB_.Text(Pos)) > 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While
        If Not Pos = 0 Then
            Pos += 1
        End If
        PosIni = Pos
        Dim Palabra As String = ""
        While True
            Try
                If Not InStr(1, Criterio.PalabraNum, RTB_.Text(Pos)) > 0 Then
                    Exit While
                Else
                    Palabra = Palabra & RTB_.Text(Pos)
                End If
            Catch ex As Exception
                Exit While
            End Try
            If Sumar1(Pos) Then

            Else
                Exit While
            End If
        End While
        Pos -= 1
        PosFin = Pos

        MarcaSi(Palabra, PosFin + 1)

        If True And RTB_.Text.Length - 1 >= 0 Then
            RTB_.SelectionStart = RTB_.Text.Length
            RTB_.SelectionLength = 0
            RTB_.SelectionColor = System.Drawing.SystemColors.WindowText
        End If
    End Sub


    Private Sub Sombrear_(Ini As Integer, Fin As Integer)

        Dim NoValChar As String = " "" '¿?¡!#$%&()={[(|)]}:;-_<>" & vbCr & vbLf & vbTab
        Dim Str As String = RTB_.Text
        Dim Palabra As String = ""
        Dim I As Integer = Ini
        If Fin > RTB_.Text.Length - 1 Then
            Fin = RTB_.Text.Length - 1
        End If
        While I < Fin
            If Not InStr(1, NoValChar & ".,", Str(I)) > 0 Then
                Palabra = Palabra & Str(I)
            Else
                MarcaSi(Palabra, I)
            End If
            I += 1
        End While
        'If Palabra.Length + I > RTB_.Text.Length Then
        MarcaSi(Palabra, I)
        'Else
        '    MarcaSi(Palabra, I - 1)
        'End If
        If True And RTB_.Text.Length - 1 >= 0 Then
            RTB_.SelectionStart = RTB_.Text.Length
            RTB_.SelectionLength = 0
            RTB_.SelectionColor = System.Drawing.SystemColors.WindowText
        End If

    End Sub
    Private Sub MarcaSi(ByRef Palabra As String, I As Integer)
        If Palabra <> "" Then
            Dim Encontro As Boolean = False
            Debug.Print(Palabra)
            For Each PalColor As PalCol In Me.Lista
                If PalColor.Palabra = Palabra Then
                    RTB_.SelectionStart = I - Palabra.Length
                    RTB_.SelectionLength = Palabra.Length
                    RTB_.SelectionColor = PalColor.Color
                    RTB_.SelectionStart = Palabra.Length
                    RTB_.SelectionLength = 0
                    RTB_.SelectionColor = System.Drawing.SystemColors.WindowText
                    Encontro = True
                    Exit For
                End If
            Next
            If Not Encontro Then
                RTB_.SelectionStart = I - Palabra.Length
                RTB_.SelectionLength = Palabra.Length
                RTB_.SelectionColor = System.Drawing.SystemColors.WindowText
            End If
            Palabra = ""
        End If
    End Sub


#End Region

#End Region

#Region "Mantiene Pos"
    Public Class CGE_RTB
        Public Shared Sub MantienePos(RTB As RichTextBox, Metodo As MethodInvoker)
            SB_V = GetScrollPos(RTB.Handle, SBS_VERT)
            SB_H = GetScrollPos(RTB.Handle, SBS_HORZ)
            SeleccionStart = RTB.SelectionStart
            Metodo()
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            RtfScroll(RTB.Handle, EM_SETSCROLLPOS, 0, New System.Drawing.Point(SB_H, SB_V))
        End Sub

        Public Shared Sub ResetSombreo(RTB As RichTextBox, Metodo As MethodInvoker)
            SeleccionStart = RTB.SelectionStart
            RTB.SelectionColor = RTB.ForeColor
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            MantienePos(RTB, Metodo)
        End Sub
        Public Shared Sub ResetLetras(RTB As RichTextBox, Metodo As MethodInvoker)
            SeleccionStart = RTB.SelectionStart
            RTB.BackColor = System.Drawing.SystemColors.Window
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            MantienePos(RTB, Metodo)
        End Sub
        Public Shared Sub Reset(RTB As RichTextBox, Metodo As MethodInvoker)
            SeleccionStart = RTB.SelectionStart
            RTB.SelectionColor = RTB.ForeColor
            RTB.BackColor = System.Drawing.SystemColors.Window
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            MantienePos(RTB, Metodo)
        End Sub
#Region "Escenciales"
        Private Declare Function LockWindowUpdate Lib "user32" (ByVal hWnd As Integer) As Integer
        Private Declare Function GetScrollPos Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nBar As Integer) As Integer
        Private Const SBS_VERT As Integer = &H1
        Private Const SBS_HORZ As Integer = &H0
        Private Declare Auto Function RtfScroll _
                Lib "user32.dll" Alias "SendMessage" (
                ByVal hWnd As IntPtr,
                ByVal Msg As Integer,
                ByVal wParam As IntPtr,
                ByRef lParam As System.Drawing.Point) As Integer
        Private Const WM_USER = &H400
        Private Const EM_GETSCROLLPOS = WM_USER + 221
        Private Const EM_SETSCROLLPOS = WM_USER + 222
        Private Shared SB_V As Integer = 0
        Private Shared SB_H As Integer = 0
        Private Shared SeleccionStart As Integer = 0
#End Region
    End Class
#End Region

#Region "Utilitarios"

    Private Declare Function LockWindowUpdate Lib "user32" (ByVal hWnd As Integer) As Integer
    Private Declare Function GetScrollPos Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nBar As Integer) As Integer
    Private Const SBS_VERT As Integer = &H1
    Private Const SBS_HORZ As Integer = &H0
    Private Declare Auto Function RtfScroll _
                Lib "user32.dll" Alias "SendMessage" (
                ByVal hWnd As IntPtr,
                ByVal Msg As Integer,
                ByVal wParam As IntPtr,
                ByRef lParam As System.Drawing.Point) As Integer
    Private Const WM_USER = &H400
    Private Const EM_GETSCROLLPOS = WM_USER + 221
    Private Const EM_SETSCROLLPOS = WM_USER + 222
    Private SB_V As Integer = 0
    Private SB_H As Integer = 0
    Dim SeleccionStart As Integer = 0
    Public Sub AccionRTB(RTB As RichTextBox, Algo As MethodInvoker)
        LockWindowUpdate(RTB.Handle.ToInt32)
        SB_V = GetScrollPos(RTB.Handle, SBS_VERT)
        SB_H = GetScrollPos(RTB.Handle, SBS_HORZ)
        SeleccionStart = RTB.SelectionStart
        RTB.SelectAll()
        RTB.SelectionColor = RTB.ForeColor
        RTB.BackColor = System.Drawing.SystemColors.Window
        RTB.SelectionStart = SeleccionStart
        Algo()
        RTB.SelectionStart = SeleccionStart
        RTB.SelectionLength = 0
        RtfScroll(RTB.Handle, EM_SETSCROLLPOS, 0, New System.Drawing.Point(SB_H, SB_V))
        LockWindowUpdate(0)
    End Sub

    Public Sub AccionAgregaRTB(RTB As RichTextBox, Algo As MethodInvoker)
        LockWindowUpdate(RTB.Handle.ToInt32)
        SB_V = GetScrollPos(RTB.Handle, SBS_VERT)
        SB_H = GetScrollPos(RTB.Handle, SBS_HORZ)
        SeleccionStart = RTB.SelectionStart
        Algo()
        RTB.SelectionStart = SeleccionStart
        RTB.SelectionLength = 0
        RtfScroll(RTB.Handle, EM_SETSCROLLPOS, 0, New System.Drawing.Point(SB_H, SB_V))
        LockWindowUpdate(0)
    End Sub

    Public Function Sumar1(ByRef a As Integer)
        If Not a >= 4294967295 Then : a += 1 : Return True : End If : Return False
    End Function
    Public Function Sumar1(ByRef a As Integer, ByVal Leng As Integer)
        If Not a >= Leng Then : a += 1 : Return True : End If : Return False
    End Function
    Public Function Restar1(ByRef a As Integer)
        If Not a <= 0 Then : a -= 1 : Return True : End If : Return False
    End Function


    Public Structure Criterio
        Public Shared Espacio As String = " " & vbTab
        Public Shared Enter As String = vbCr & vbLf

        'Estos criterios sirven para determinar a que conjunto pertenece un caracter
        Public Shared Vocal As String = "aeiouAEIOUáéíóúÁÉÍÓÚ"
        Public Shared Letra As String = "BCDFGHJKLMNÑPQRSTVWXYZbcdfghjklmnñpqrstvwxyz"
        Public Shared Auxiliar As String = "_"
        Public Shared Numero As String = "0123456789"
        Public Shared Operadores As String = "+-*/^="
        Public Shared SimboloAbre As String = "{[(¿¡"
        Public Shared SimboloCierra As String = "!?)]}"
        Public Shared Simbolos As String = """ºª·$%&"
        Public Shared Barras As String = "|/\"

        Public Shared Palabra As String = Vocal & Letra & Auxiliar
        Public Shared PalabraNum As String = Vocal & Letra & Auxiliar & Numero
        Public Shared Vacio As String = Espacio & Enter
    End Structure




    'Dim AccionDesdeCodigo As Boolean = False

    Public Sub SP___RTB(RTB As RichTextBox, ActualizaPantalla As Boolean, BorraColorTexto As Boolean, BorraSombreado As Boolean, Algo As MethodInvoker)
        If Not AccionDesdeCodigo Then
            AccionDesdeCodigo = True
            If ActualizaPantalla Then : LockWindowUpdate(RTB.Handle.ToInt32) : End If
            SB_V = GetScrollPos(RTB.Handle, SBS_VERT)
            SB_H = GetScrollPos(RTB.Handle, SBS_HORZ)
            SeleccionStart = RTB.SelectionStart : RTB.SelectAll()
            If BorraColorTexto Then : RTB.SelectionColor = RTB.ForeColor : End If
            If BorraSombreado Then : RTB.BackColor = System.Drawing.SystemColors.Window : End If
            RTB.SelectionStart = SeleccionStart
            Algo()
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            RtfScroll(RTB.Handle, EM_SETSCROLLPOS, 0, New System.Drawing.Point(SB_H, SB_V))
            If ActualizaPantalla Then : LockWindowUpdate(0) : End If
            AccionDesdeCodigo = False
        End If
    End Sub





    Public Sub SP___RTB01(RTB As RichTextBox, ActualizaPantalla As Boolean, BorraColorTexto As Boolean, BorraSombreado As Boolean, Algo As MethodInvoker)
        If Not AccionDesdeCodigo Then
            AccionDesdeCodigo = True
            If ActualizaPantalla Then : LockWindowUpdate(RTB.Handle.ToInt32) : End If
            SB_V = GetScrollPos(RTB.Handle, SBS_VERT)
            SB_H = GetScrollPos(RTB.Handle, SBS_HORZ)
            SeleccionStart = RTB.SelectionStart : RTB.SelectAll()
            If BorraColorTexto Then : RTB.SelectionColor = RTB.ForeColor : End If
            If BorraSombreado Then : RTB.BackColor = System.Drawing.SystemColors.Window : End If
            RTB.SelectionStart = SeleccionStart
            Algo()
            RTB.SelectionStart = SeleccionStart : RTB.SelectionLength = 0
            RtfScroll(RTB.Handle, EM_SETSCROLLPOS, 0, New System.Drawing.Point(SB_H, SB_V))
            If ActualizaPantalla Then : LockWindowUpdate(0) : End If
            AccionDesdeCodigo = False
        End If
    End Sub

#End Region

#Region "Sombreado de palabras no usado este codigo pero mas especifico"
    Public Sub Sombrear_A()
        Dim NoValChar As String = " "" '¿?¡!#$%&()={[(|)]}:;-_<>" & vbCr & vbLf & vbTab
        Dim Str As String = RTB_.Text
        Dim Palabra As String = ""
        Dim I As Integer = 0
        While I < Str.Length
            If Not InStr(1, NoValChar & ".,", Str(I)) > 0 Then
                Palabra = Palabra & Str(I)
            Else
                MarcaSi_A(Palabra, I)
            End If
            I += 1
        End While
        MarcaSi_A(Palabra, I)
    End Sub
    Private Sub MarcaSi_A(ByRef Palabra As String, I As Integer)
        If Palabra <> "" Then
            If ExistePalabra(Palabra) Then
                RTB_.SelectionStart = I - Palabra.Length
                RTB_.SelectionLength = Palabra.Length
                RTB_.SelectionColor = Color.Blue
            End If
            Palabra = ""
        End If
    End Sub
    Private Function ExistePalabra(Palabra As String)
        Dim Lista As New List(Of String) 'Entran las palaras a marcar
        Lista.AddRange({"Private", "ByRef", "ByVal", "Next", "My", "Function", "For", "AddressOf", "Catch", "Try", "And", "Or", "Not", "Each", "New", "Of", "String", "Integer", "Handles", "As", "Public", "Dim", "Sub", "Return", "If", "Then", "else", "End", "ByVal", "Class", "MarshalByRefObject", "ByRefObject", "Object"})
        For Each Str As String In Lista
            If Str = Palabra Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region

End Class
