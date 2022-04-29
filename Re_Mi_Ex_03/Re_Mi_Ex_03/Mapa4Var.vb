Public Class Mapa4Var
    Public Matriz(4, 4) As Integer
    Public MatrizCE1(4, 4) As Integer
    Public MatrizCE2(4, 4) As Integer
    Private Matriz0(4, 4) As Integer
    Public ColorLetra_ As Color
    Dim Color_ As New List(Of ElColor)
    Dim Lista As New List(Of Pos)
    Dim ListaPosGen As New List(Of Pos)
    Public Cargo As Boolean = False
    Public GuardaHistorico As Boolean = False
#Region "Graficador"
    Public Sub CargaMatriz(ByVal Matriz_(,) As Integer)
        Matriz = Matriz_
    End Sub
    Sub New()
        InitializeComponent()
        ColorLetra_ = Color.Black
        PB_.BackColor = Color.Transparent
        Matriz = {{0, 0, 0, 0},
                  {0, 0, 0, 0},
                  {0, 0, 0, 0},
                  {0, 0, 0, 0}}
        MatrizCE1 = {{1, 1, 0, 1},
                    {0, 1, 1, 1},
                    {1, 1, 1, 0},
                    {1, 0, 1, 1}}
        MatrizCE2 = {{1, 0, 1, 1},
                    {1, 1, 1, 0},
                    {0, 1, 1, 1},
                    {1, 1, 0, 1}}
        Matriz0 = {{0, 0, 0, 0},
                  {0, 0, 0, 0},
                  {0, 0, 0, 0},
                  {0, 0, 0, 0}}
    End Sub
    Private Sub Mapa4Var_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Color_.Add(New ElColor(Color.Red, "Red"))
        Color_.Add(New ElColor(Color.Orange, "Orange"))
        Color_.Add(New ElColor(Color.Green, "Green"))
        Color_.Add(New ElColor(Color.Purple, "Purple"))
        Color_.Add(New ElColor(Color.RoyalBlue, "RoyalBlue"))
        Color_.Add(New ElColor(Color.Green, "Green"))
        Color_.Add(New ElColor(Color.Blue, "Blue"))
        Color_.Add(New ElColor(Color.Pink, "Pink"))
        Color_.Add(New ElColor(Color.LightGreen, "LightGreen"))
        Color_.Add(New ElColor(Color.Gray, "Gray"))
        Color_.Add(New ElColor(Color.Violet, "Violet"))
        Color_.Add(New ElColor(Color.Turquoise, "Turquoise"))
        Accion()
    End Sub
    ''' <summary>Este metodo se entarga de recibir la posicion del click en el control para transformarla en posicion de matriz y luego alterar ese valor por uno
    ''' contrario(1->0) o (0->1)</summary>
    Public Sub ActualizaMatriz(ByRef Matriz(,) As Integer, x As Integer, y As Integer)
        Dim VarX As Integer = 48, VarY As Integer = 50
        Dim VXM As Integer = 5, VYM As Integer = 5
        Dim EjeX As Integer = x, EjeY As Integer = y
        Dim _i As Integer = 0, _j As Integer = 0
        'Primer if Elseif para el eje x y las columnas de la Matriz
        If EjeX > (VXM + 0 * VarX) And EjeX <= (VXM + 1 * VarX) Then : _j = 0
        ElseIf EjeX > (VXM + 1 * VarX) And EjeX <= (VXM + 2 * VarX) Then : _j = 1
        ElseIf EjeX > (VXM + 2 * VarX) And EjeX <= (VXM + 3 * VarX) Then : _j = 2
        ElseIf EjeX > (VXM + 3 * VarX) And EjeX <= (VXM + 4 * VarX) Then : _j = 3
        End If
        'Segundo if Elseif para el eje y y las filas de la Matriz
        If EjeY > (VYM + 0 * VarY) And EjeY <= (VYM + 1 * VarY) Then : _i = 0
        ElseIf EjeY > (VYM + 1 * VarY) And EjeY <= (VYM + 2 * VarY) Then : _i = 1
        ElseIf EjeY > (VYM + 2 * VarY) And EjeY <= (VYM + 3 * VarY) Then : _i = 2
        ElseIf EjeY > (VYM + 3 * VarY) And EjeY <= (VYM + 4 * VarY) Then : _i = 3
        End If
        'Aqui ya sabemos en que posicion con respecto a la matriz se hizo click y se alterara el valor
        If Matriz(_i, _j) = 0 Then : Matriz(_i, _j) = 1 : Else : Matriz(_i, _j) = 0 : End If
    End Sub
    Public Property ColorLetra As Color
        Get
            Return ColorLetra_
        End Get
        Set(value As Color)
            ColorLetra_ = value
            Label1.ForeColor = ColorLetra_
            Label2.ForeColor = ColorLetra_
            Label3.ForeColor = ColorLetra_
            Label4.ForeColor = ColorLetra_
            Label5.ForeColor = ColorLetra_
            Label6.ForeColor = ColorLetra_
            Label7.ForeColor = ColorLetra_
            Label8.ForeColor = ColorLetra_
            LB_AB.ForeColor = ColorLetra_
            LB_CD.ForeColor = ColorLetra_
            If Cargo Then Accion()
        End Set
    End Property
    ''' <summary>Metodo encargado de pintar un uno o cero segun el valor encontrado en la matriz para la posicion que se esta evaluando</summary>
    Public Sub PintaNumero(ByVal texto As String, ByVal cox As Integer, ByVal coy As Integer, Base As Integer, Altura As Integer, Lista As List(Of Gru))
        Dim Bit As Bitmap
        Dim Grap As Graphics 'Microsoft Sans Serif
        Dim drawFont As New System.Drawing.Font("Arial", 35)
        Dim drawBrush As New System.Drawing.SolidBrush(ColorLetra)
        Dim x As Integer = cox
        Dim y As Integer = coy
        Dim drawFormat As New System.Drawing.StringFormat
        Bit = New Bitmap(Base, Altura)
        Grap = Graphics.FromImage(Bit)
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                y = 5 + i * 50
                x = 5 + j * 50
                If Matriz(i, j) = 0 Then
                    Grap.DrawString("0", drawFont, drawBrush, x, y, drawFormat)
                Else
                    Grap.DrawString("1", drawFont, drawBrush, x, y, drawFormat)
                End If
            Next
        Next
        PB_.Image = Bit
        Dim ColorIndex As Integer = 0
        For Each Gru_ As Gru In Lista
            If Color_(ColorIndex).C <> Form1.BackColor Then
                PintaGrupos(Gru_.N, Grap, Color_(ColorIndex).C)
                ColorIndex += 1
            Else
                ColorIndex += 1
                PintaGrupos(Gru_.N, Grap, Color_(ColorIndex).C)
                ColorIndex += 1
            End If

        Next

        drawFont.Dispose()
        drawBrush.Dispose()
        Grap.Dispose()
    End Sub
    Private Sub GrafAgru(x As Integer, y As Integer, b As Integer, h As Integer, ByRef Grap As Graphics, ByRef color As Color)
        Dim Pen_ As New Pen(color, 3)
        Grap.DrawArc(Pen_, New Rectangle(x, y, 45, 45), -90, -90)
        Grap.DrawArc(Pen_, New Rectangle(x, y + h, 45, 45), 90, 90)
        Grap.DrawArc(Pen_, New Rectangle(x + b, y, 45, 45), 0, -90)
        Grap.DrawArc(Pen_, New Rectangle(x + b, y + h, 45, 45), 0, 90)
        Grap.DrawLine(Pen_, x, y + 23, x, y + 23 + h)
        Grap.DrawLine(Pen_, x + 46 + b, y + 23, x + 46 + b, y + 23 + h)
        Grap.DrawLine(Pen_, x + 23, y, x + 23 + b, y)
        Grap.DrawLine(Pen_, x + 23, y + 45 + h, x + 23 + b, y + 45 + h)
    End Sub
    Private Sub PintaGrupos(Caso As Integer, Grap As Graphics, Color_ As Color)
        Select Case Caso
            Case 0
                GrafAgru(7, 7, 140, 150, Grap, Color_)
            Case 1
                GrafAgru(7, 7, 140, 50, Grap, Color_)
            Case 2
                GrafAgru(7, 57, 140, 50, Grap, Color_)
            Case 3
                GrafAgru(7, 107, 140, 50, Grap, Color_)
            Case 4
                GrafAgru(5, -25, 145, 35, Grap, Color_)
                GrafAgru(5, 155, 145, 35, Grap, Color_)
            Case 5
                GrafAgru(3, 10, 50, 150, Grap, Color_)
            Case 6
                GrafAgru(53, 10, 50, 150, Grap, Color_)
            Case 7
                GrafAgru(103, 10, 50, 150, Grap, Color_)
            Case 8
                GrafAgru(-20, 7, 20, 150, Grap, Color_)
                GrafAgru(155, 7, 25, 150, Grap, Color_)
            Case 9
                GrafAgru(3, 10, 150, 0, Grap, Color_)
            Case 10
                GrafAgru(3, 60, 150, 0, Grap, Color_)
            Case 11
                GrafAgru(3, 110, 150, 0, Grap, Color_)
            Case 12
                GrafAgru(3, 160, 150, 0, Grap, Color_)
            Case 13
                GrafAgru(3, 10, 0, 150, Grap, Color_)
            Case 14
                GrafAgru(53, 10, 0, 150, Grap, Color_)
            Case 15
                GrafAgru(103, 10, 0, 150, Grap, Color_)
            Case 16
                GrafAgru(153, 10, 0, 150, Grap, Color_)
            Case 17
                GrafAgru(3, 10, 50, 48, Grap, Color_)
            Case 18
                GrafAgru(53, 10, 50, 48, Grap, Color_)
            Case 19
                GrafAgru(103, 10, 50, 48, Grap, Color_)
            Case 20
                GrafAgru(-20, 10, 20, 48, Grap, Color_)
                GrafAgru(155, 10, 25, 48, Grap, Color_)
            Case 21
                GrafAgru(3, 60, 50, 48, Grap, Color_)
            Case 22
                GrafAgru(53, 60, 50, 48, Grap, Color_)
            Case 23
                GrafAgru(103, 60, 50, 48, Grap, Color_)
            Case 24
                GrafAgru(-20, 60, 20, 48, Grap, Color_)
                GrafAgru(155, 60, 25, 48, Grap, Color_)
            Case 25
                GrafAgru(3, 110, 50, 48, Grap, Color_)
            Case 26
                GrafAgru(53, 110, 50, 48, Grap, Color_)
            Case 27
                GrafAgru(103, 110, 50, 48, Grap, Color_)
            Case 28
                GrafAgru(-20, 110, 20, 48, Grap, Color_)
                GrafAgru(155, 110, 25, 48, Grap, Color_)
            Case 29
                GrafAgru(5, -25, 40, 35, Grap, Color_)
                GrafAgru(5, 155, 40, 35, Grap, Color_)
            Case 30
                GrafAgru(55, -25, 40, 35, Grap, Color_)
                GrafAgru(55, 155, 40, 35, Grap, Color_)
            Case 31
                GrafAgru(105, -25, 40, 35, Grap, Color_)
                GrafAgru(105, 155, 40, 35, Grap, Color_)
            Case 32
                GrafAgru(-20, -25, 20, 35, Grap, Color_)
                GrafAgru(155, -25, 40, 35, Grap, Color_)
                GrafAgru(-20, 155, 20, 35, Grap, Color_)
                GrafAgru(155, 155, 40, 35, Grap, Color_)
            Case 33
                GrafAgru(3, 10, 50, 0, Grap, Color_)
            Case 34
                GrafAgru(53, 10, 50, 0, Grap, Color_)
            Case 35
                GrafAgru(103, 10, 50, 0, Grap, Color_)
            Case 36
                GrafAgru(-20, 10, 20, 0, Grap, Color_)
                GrafAgru(155, 10, 25, 0, Grap, Color_)
            Case 37
                GrafAgru(3, 60, 50, 0, Grap, Color_)
            Case 38
                GrafAgru(53, 60, 50, 0, Grap, Color_)
            Case 39
                GrafAgru(103, 60, 50, 0, Grap, Color_)
            Case 40
                GrafAgru(-20, 60, 20, 0, Grap, Color_)
                GrafAgru(155, 60, 25, 0, Grap, Color_)
            Case 41
                GrafAgru(3, 110, 50, 0, Grap, Color_)
            Case 42
                GrafAgru(53, 110, 50, 0, Grap, Color_)
            Case 43
                GrafAgru(103, 110, 50, 0, Grap, Color_)
            Case 44
                GrafAgru(-20, 110, 20, 0, Grap, Color_)
                GrafAgru(155, 110, 25, 0, Grap, Color_)
            Case 45
                GrafAgru(3, 160, 50, 0, Grap, Color_)
            Case 46
                GrafAgru(53, 160, 50, 0, Grap, Color_)
            Case 47
                GrafAgru(103, 160, 50, 0, Grap, Color_)
            Case 48
                GrafAgru(-20, 160, 20, 0, Grap, Color_)
                GrafAgru(155, 160, 25, 0, Grap, Color_)
            Case 49
                GrafAgru(3, 10, 0, 48, Grap, Color_)
            Case 50
                GrafAgru(53, 10, 0, 48, Grap, Color_)
            Case 51
                GrafAgru(103, 10, 0, 48, Grap, Color_)
            Case 52
                GrafAgru(153, 10, 0, 48, Grap, Color_)
            Case 53
                GrafAgru(3, 60, 0, 48, Grap, Color_)
            Case 54
                GrafAgru(53, 60, 0, 48, Grap, Color_)
            Case 55
                GrafAgru(103, 60, 0, 48, Grap, Color_)
            Case 56
                GrafAgru(153, 60, 0, 48, Grap, Color_)
            Case 57
                GrafAgru(3, 110, 0, 48, Grap, Color_)
            Case 58
                GrafAgru(53, 110, 0, 48, Grap, Color_)
            Case 59
                GrafAgru(103, 110, 0, 48, Grap, Color_)
            Case 60
                GrafAgru(153, 110, 0, 48, Grap, Color_)
            Case 61
                GrafAgru(3, -25, 0, 35, Grap, Color_)
                GrafAgru(3, 155, 0, 35, Grap, Color_)
            Case 62
                GrafAgru(53, -25, 0, 35, Grap, Color_)
                GrafAgru(53, 155, 0, 35, Grap, Color_)
            Case 63
                GrafAgru(103, -25, 0, 35, Grap, Color_)
                GrafAgru(103, 155, 0, 35, Grap, Color_)
            Case 64
                GrafAgru(153, -25, 0, 35, Grap, Color_)
                GrafAgru(153, 155, 0, 35, Grap, Color_)
            Case 65
                GrafAgru(3, 10, 0, 0, Grap, Color_)
            Case 66
                GrafAgru(53, 10, 0, 0, Grap, Color_)
            Case 67
                GrafAgru(103, 10, 0, 0, Grap, Color_)
            Case 68
                GrafAgru(153, 10, 0, 0, Grap, Color_)
            Case 69
                GrafAgru(3, 60, 0, 0, Grap, Color_)
            Case 70
                GrafAgru(53, 60, 0, 0, Grap, Color_)
            Case 71
                GrafAgru(103, 60, 0, 0, Grap, Color_)
            Case 72
                GrafAgru(153, 60, 0, 0, Grap, Color_)
            Case 73
                GrafAgru(3, 110, 0, 0, Grap, Color_)
            Case 74
                GrafAgru(53, 110, 0, 0, Grap, Color_)
            Case 75
                GrafAgru(103, 110, 0, 0, Grap, Color_)
            Case 76
                GrafAgru(153, 110, 0, 0, Grap, Color_)
            Case 77
                GrafAgru(3, 160, 0, 0, Grap, Color_)
            Case 78
                GrafAgru(53, 160, 0, 0, Grap, Color_)
            Case 79
                GrafAgru(103, 160, 0, 0, Grap, Color_)
            Case 80
                GrafAgru(153, 160, 0, 0, Grap, Color_)
        End Select
    End Sub
    ''' <summary>Este metodo es llamado por el evento MouseClick del control PB_ (PictureBox) donde estan los numeros unos y ceros en forma de Matriz</summary>
    ''' <param name="sender">Esta variable contiene al objeto desde donde se lo llama via referencia, es decir, Ud puede manipular ese control a travez de esa variable</param>
    ''' <param name="e">Esta variable contiene datos del evento que la produce. Para nuestro caso, contiene los ejes coordenados del punto donde se hizo el click con respecto
    ''' a la esquina superior izquierda del control PB_(PictureBox)</param>
    Private Sub PB__MouseClick(sender As Object, e As MouseEventArgs) Handles PB_.MouseClick
        ActualizaMatriz(Matriz, e.X, e.Y) 'Recibe una patriz por referencia y las coordenadas del click en una imagen

        Accion()
        Debug.Print("Aqui PB__MouseClick")
        If Not ComparaMat(Matriz, Matriz0) Then
            If Not Form1.DesdeCodigoM4V Then
                Form1.Timer1.Stop()
                Form1.Timer1.Enabled = False
                GuardaHistorico = True
                Form1.Timer1.Enabled = True
                Form1.Timer1.Start()
            End If
        Else
            Form1.Timer1.Stop()
            Form1.Timer1.Enabled = False
            GuardaHistorico = False
            Form1.Timer1.Enabled = True
            Form1.Timer1.Start()
        End If
    End Sub
#End Region
#Region "Tipo de datos"
    ''' <summary>Contiene el dato de la posicion y la cantidad de grupos en la que esta siendo tomado en cuenta</summary>
    Structure Pos
        ''' <summary>Indica la posicion en i para una matriz que representa el mapa</summary>
        Dim X As Integer
        ''' <summary>Indica la posicion en j para una matriz que representa el mapa</summary>
        Dim Y As Integer
        ''' <summary>Contiene el numero de apariciones totales en el mapa</summary>
        Dim U As Integer
        ''' <summary>Constructor para asignar valores a las variables de la estructura</summary>
        Sub New(X As Integer, Y As Integer, U As Integer)
            Me.X = X
            Me.Y = Y
            Me.U = U
        End Sub
    End Structure
    Structure Gru
        ''' <summary>Número de caso</summary>
        Dim N As Integer
        ''' <summary>Lista de posiciones</summary>
        Dim L As List(Of Pos)
        ''' <summary>Expresion</summary>
        Dim E As String
        ''' <summary>Cardinalidad</summary>
        Dim C As Integer
        ''' <summary>Booleano Enable</summary>
        Dim B As Boolean
        ''' <summary>Constructor para asignar valores a las variables de la estructura</summary>
        Sub New(N As Integer, E As String, L As List(Of Pos))
            Me.N = N
            Me.E = E
            Me.L = L
            C = -1
        End Sub
        ''' <summary>Constructor para asignar valores a las variables de la estructura</summary>
        Sub New(N As Integer, E As String, L As List(Of Pos), C As Integer)
            Me.N = N
            Me.E = E
            Me.L = L
            Me.C = C
        End Sub
        ''' <summary>Constructor para asignar valores a las variables de la estructura</summary>
        Sub New(N As Integer, E As String, L As List(Of Pos), C As Integer, B As Boolean)
            Me.N = N
            Me.E = E
            Me.L = L
            Me.C = C
            Me.B = B
        End Sub
    End Structure
    Structure ElColor
        ''' <summary>Almacena el color en una variable tipo Color</summary>
        Dim C As Color
        ''' <summary>Guarda el nombre del color usado</summary>
        Dim N As String
        ''' <summary>Constructor para asignar valores a las variables de la estructura</summary>
        Sub New(C As Color, N As String)
            Me.C = C
            Me.N = N
        End Sub
    End Structure
#End Region
#Region "Algoritmo"
    Private Function VerificarGrupos(iPos As Integer, jPos As Integer, iLar As Integer, jLar As Integer, Lista As List(Of Pos))
        Dim ListaAux As New List(Of Pos)
        Dim Val As Boolean = True
        iLar -= 1
        jLar -= 1
        For i As Integer = iPos To iPos + iLar
            For j As Integer = jPos To jPos + jLar
                If Matriz(i, j) = 0 Then
                    Val = False
                Else
                    ListaAux.Add(New Pos(i, j, 1))
                End If
            Next
        Next
        If Val Then
            Lista.AddRange(ListaAux)
        End If
        Return Val
    End Function
    Private Sub CDGAdd(ByVal Num As Integer, ByVal Exp As String, LisPos As List(Of Pos), ByRef CDG As List(Of Gru))
        'For Each Pos_ As Pos In LisPos
        '    ListaPosAdd(Pos_, ListaPos)
        'Next
        CDG.Add(New Gru(Num, Exp, LisPos))
    End Sub
    Private Function GruRedun(Lista As List(Of Gru))
        For i As Integer = 0 To Lista.Count - 1
            If Not Lista(i).B Then
                Lista.RemoveAt(i)
                Return True
            End If
        Next
        Return False
    End Function
    Private Function ComparaMat(ByVal Mat1(,) As Integer, ByVal Mat2(,) As Integer)
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                If Not Mat1(i, j) = Mat2(i, j) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Public Sub ListaPosAdd(Pos_ As Pos, ByRef Lista As List(Of Pos))
        Dim Bool As Boolean = False
        For i As Integer = 0 To Lista.Count - 1
            If Lista(i).X = Pos_.X And Lista(i).Y = Pos_.Y Then
                Lista(i) = New Pos(Pos_.X, Pos_.Y, Lista(i).U + 1)
                Bool = True
                Exit Sub
            End If
        Next
        If Not Bool Then
            Lista.Add(Pos_)
        End If
    End Sub
    Private Sub ListaGruAdd(Gru_ As Gru, ListaGru As List(Of Gru))
        For Each Pos_ As Pos In Gru_.L
            ListaPosAdd(Pos_, ListaPosGen)
        Next
        ListaGru.Add(Gru_)
    End Sub
    Private Sub Quitar(ByRef Lista As List(Of Gru), Nums As IEnumerable(Of Integer))
        For Each Num As Integer In Nums
            For i As Integer = 0 To Lista.Count - 1
                If Num = Lista(i).N Then
                    Lista.RemoveAt(i)
                    Exit For
                End If
            Next
        Next
    End Sub
    Private Function Numero(ByRef Lista As List(Of Gru), ByRef Num As Integer)
        Try
            If Lista.Count <> 0 Then
                Num = Lista(0).N
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function BuscandoTodosLosGrupos(ByRef Matriz(,) As Integer) As List(Of Gru)
        ListaPosGen.Clear()
        'El retorno es tipo cadena porpue se obtendra una expresion del tipo
        'a es "A" negada y A es "A" sin negar
        Dim CDG As New List(Of Gru) 'Dim CodigosDeGuerra As String = ""
        Dim LisPos As New List(Of Pos)
        Dim Val As Boolean

        '(00)     (01)     (02)     (03)     (04)
        '1 1 1 1  1 1 1 1  0 0 0 0  0 0 0 0  1 1 1 1
        '1 1 1 1  1 1 1 1  1 1 1 1  0 0 0 0  0 0 0 0
        '1 1 1 1  0 0 0 0  1 1 1 1  1 1 1 1  0 0 0 0
        '1 1 1 1  0 0 0 0  0 0 0 0  1 1 1 1  1 1 1 1

        Val = VerificarGrupos(0, 0, 4, 4, LisPos) '00
        If Val Then CDGAdd(0, "1", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 0, 2, 4, LisPos) '01
        If Val Then CDGAdd(1, "c", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 2, 4, LisPos) '02
        If Val Then CDGAdd(2, "D", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 0, 2, 4, LisPos) '03
        If Val Then CDGAdd(3, "C", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 4, LisPos) And VerificarGrupos(0, 0, 1, 4, LisPos) '04
        If Val Then CDGAdd(4, "d", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(05)     (06)     (07)     (08)
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1

        Val = VerificarGrupos(0, 0, 4, 2, LisPos) '05
        If Val Then CDGAdd(5, "a", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 4, 2, LisPos) '06
        If Val Then CDGAdd(6, "B", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 4, 2, LisPos) '07
        If Val Then CDGAdd(7, "A", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 0, 4, 1, LisPos) And VerificarGrupos(0, 3, 4, 1, LisPos) '08
        If Val Then CDGAdd(8, "b", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(09)     (10)     (11)     (12)
        '1 1 1 1  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  1 1 1 1  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  1 1 1 1  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  1 1 1 1

        Val = VerificarGrupos(0, 0, 1, 4, LisPos) '09
        If Val Then CDGAdd(9, "cd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 1, 4, LisPos) '10
        If Val Then CDGAdd(10, "cD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 0, 1, 4, LisPos) '11
        If Val Then CDGAdd(11, "CD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 4, LisPos) '12
        If Val Then CDGAdd(12, "Cd", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(13)     (14)     (15)     (16)
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1

        Val = VerificarGrupos(0, 0, 4, 1, LisPos) '13
        If Val Then CDGAdd(13, "ab", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 4, 1, LisPos) '14
        If Val Then CDGAdd(14, "aB", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 4, 1, LisPos) '15
        If Val Then CDGAdd(15, "AB", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 3, 4, 1, LisPos) '16
        If Val Then CDGAdd(16, "Ab", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(17)     (18)     (19)     (20)     (21)     (22)     (23)     (24)
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0

        Val = VerificarGrupos(0, 0, 2, 2, LisPos) '17
        If Val Then CDGAdd(17, "ac", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 2, 2, LisPos) '18
        If Val Then CDGAdd(18, "Bc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 2, 2, LisPos) '19
        If Val Then CDGAdd(19, "Ac", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 0, 2, 1, LisPos) And VerificarGrupos(0, 3, 2, 1, LisPos) '20
        If Val Then CDGAdd(20, "bc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 2, 2, LisPos) '21
        If Val Then CDGAdd(21, "aD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 1, 2, 2, LisPos) '22
        If Val Then CDGAdd(22, "BD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 2, 2, 2, LisPos) '23
        If Val Then CDGAdd(23, "AD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 2, 1, LisPos) And VerificarGrupos(1, 3, 2, 1, LisPos) '24
        If Val Then CDGAdd(24, "bD", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(25)     (26)     (27)     (28)     (29)     (30)     (31)     (32)
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1

        Val = VerificarGrupos(2, 0, 2, 2, LisPos) '25
        If Val Then CDGAdd(25, "aC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 1, 2, 2, LisPos) '26
        If Val Then CDGAdd(26, "BC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 2, 2, 2, LisPos) '27
        If Val Then CDGAdd(27, "AC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 0, 2, 1, LisPos) And VerificarGrupos(2, 3, 2, 1, LisPos) '28
        If Val Then CDGAdd(28, "bC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 2, LisPos) And VerificarGrupos(0, 0, 1, 2, LisPos)  '29
        If Val Then CDGAdd(29, "aD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 1, 1, 2, LisPos) And VerificarGrupos(0, 1, 1, 2, LisPos)  '30
        If Val Then CDGAdd(30, "Bd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 2, 1, 2, LisPos) And VerificarGrupos(0, 2, 1, 2, LisPos)  '31
        If Val Then CDGAdd(31, "Ad", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = (VerificarGrupos(3, 0, 1, 1, LisPos) And VerificarGrupos(0, 0, 1, 1, LisPos)) And (VerificarGrupos(3, 3, 1, 1, LisPos) And VerificarGrupos(0, 3, 1, 1, LisPos))  '32
        If Val Then CDGAdd(32, "bd", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(33)     (34)     (35)     (36)     (37)     (38)     (39)     (40)
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0

        Val = VerificarGrupos(0, 0, 1, 2, LisPos) '33
        If Val Then CDGAdd(33, "acd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 1, 2, LisPos) '34
        If Val Then CDGAdd(34, "Bcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 1, 2, LisPos) '35
        If Val Then CDGAdd(35, "Acd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 0, 1, 1, LisPos) And VerificarGrupos(0, 3, 1, 1, LisPos) '36
        If Val Then CDGAdd(36, "bcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 1, 2, LisPos) '37
        If Val Then CDGAdd(37, "acD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 1, 1, 2, LisPos) '38
        If Val Then CDGAdd(38, "BcD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 2, 1, 2, LisPos) '39
        If Val Then CDGAdd(39, "AcD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 1, 1, LisPos) And VerificarGrupos(1, 3, 1, 1, LisPos) '40
        If Val Then CDGAdd(40, "bcD", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(41)     (42)     (43)     (44)     (45)     (46)     (47)     (48)
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 1 0 0  0 1 1 0  0 0 1 1  1 0 0 1

        Val = VerificarGrupos(2, 0, 1, 2, LisPos) '41
        If Val Then CDGAdd(41, "aCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 1, 1, 2, LisPos) '42
        If Val Then CDGAdd(42, "BCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 2, 1, 2, LisPos) '43
        If Val Then CDGAdd(43, "ACD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 0, 1, 1, LisPos) And VerificarGrupos(2, 3, 1, 1, LisPos) '44
        If Val Then CDGAdd(44, "bCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 2, LisPos) '45
        If Val Then CDGAdd(45, "aCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 1, 1, 2, LisPos) '46
        If Val Then CDGAdd(46, "BCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 2, 1, 2, LisPos) '47
        If Val Then CDGAdd(47, "ACd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 1, LisPos) And VerificarGrupos(3, 3, 1, 1, LisPos) '48
        If Val Then CDGAdd(48, "bCd", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(49)     (50)     (51)     (52)     (53)     (54)     (55)     (56)
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0

        Val = VerificarGrupos(0, 0, 2, 1, LisPos) '49
        If Val Then CDGAdd(49, "abc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 2, 1, LisPos) '50
        If Val Then CDGAdd(50, "aBc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 2, 1, LisPos) '51
        If Val Then CDGAdd(51, "ABc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 3, 2, 1, LisPos) '52
        If Val Then CDGAdd(52, "Abc", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 2, 1, LisPos) '53
        If Val Then CDGAdd(53, "abD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 1, 2, 1, LisPos) '54
        If Val Then CDGAdd(54, "aBD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 2, 2, 1, LisPos) '55
        If Val Then CDGAdd(55, "ABD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 3, 2, 1, LisPos) '56
        If Val Then CDGAdd(56, "AbD", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(57)     (58)     (59)     (60)     (61)     (62)     (63)     (64)
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1

        Val = VerificarGrupos(2, 0, 2, 1, LisPos) '57
        If Val Then CDGAdd(57, "abC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 1, 2, 1, LisPos) '58
        If Val Then CDGAdd(58, "aBC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 2, 2, 1, LisPos) '59
        If Val Then CDGAdd(59, "ABC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 3, 2, 1, LisPos) '60
        If Val Then CDGAdd(60, "AbC", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 0, 1, 1, LisPos) And VerificarGrupos(3, 0, 1, 1, LisPos) '61
        If Val Then CDGAdd(61, "abd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 1, 1, LisPos) And VerificarGrupos(3, 1, 1, 1, LisPos) '62
        If Val Then CDGAdd(62, "aBd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 1, 1, LisPos) And VerificarGrupos(3, 2, 1, 1, LisPos) '63
        If Val Then CDGAdd(63, "ABd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 3, 1, 1, LisPos) And VerificarGrupos(3, 3, 1, 1, LisPos) '64
        If Val Then CDGAdd(64, "Abd", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(65)     (66)     (67)     (68)     (69)     (70)     (71)     (72)
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0

        Val = VerificarGrupos(0, 0, 1, 1, LisPos) '65
        If Val Then CDGAdd(65, "abcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 1, 1, 1, LisPos) '66
        If Val Then CDGAdd(66, "aBcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 2, 1, 1, LisPos) '67
        If Val Then CDGAdd(67, "ABcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(0, 3, 1, 1, LisPos) '68
        If Val Then CDGAdd(68, "Abcd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 0, 1, 1, LisPos) '69
        If Val Then CDGAdd(69, "abcD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 1, 1, 1, LisPos) '70
        If Val Then CDGAdd(70, "aBcD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 2, 1, 1, LisPos) '71
        If Val Then CDGAdd(71, "ABcD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(1, 3, 1, 1, LisPos) '72
        If Val Then CDGAdd(72, "AbcD", LisPos, CDG)
        LisPos = New List(Of Pos)

        '(73)     (74)     (75)     (76)     (77)     (78)     (79)     (80)
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1  0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
        '0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0  1 0 0 0  0 1 0 0  0 0 1 0  0 0 0 1

        Val = VerificarGrupos(2, 0, 1, 1, LisPos) '73
        If Val Then CDGAdd(73, "abCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 1, 1, 1, LisPos) '74
        If Val Then CDGAdd(74, "aBCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 2, 1, 1, LisPos) '75
        If Val Then CDGAdd(75, "ABCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(2, 3, 1, 1, LisPos) '76
        If Val Then CDGAdd(76, "AbCD", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 0, 1, 1, LisPos) '77
        If Val Then CDGAdd(77, "abCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 1, 1, 1, LisPos) '78
        If Val Then CDGAdd(78, "aBCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 2, 1, 1, LisPos) '79
        If Val Then CDGAdd(79, "ABCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Val = VerificarGrupos(3, 3, 1, 1, LisPos) '80
        If Val Then CDGAdd(80, "AbCd", LisPos, CDG)
        LisPos = New List(Of Pos)
        Return CDG
    End Function
    Private Function Reduce01(ByVal Lista As List(Of Gru)) As List(Of Gru)
        Dim Numero_ As Integer
        Dim ListaGru As New List(Of Gru)
        If Not Numero(Lista, Numero_) Then
            Return ListaGru
        End If
        If Numero_ = 0 Then
            ListaGruAdd(Lista(0), ListaGru)
            Lista.Clear()
            Return ListaGru
        End If
        If Numero_ = 1 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {1, 9, 10, 17, 18, 19, 20, 33, 34, 35, 36, 37, 38, 39, 40, 49, 50, 51, 52, 65, 66, 67, 68, 69, 70, 71, 72, 81, 82, 83, 84})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 2 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {2, 10, 11, 21, 22, 23, 24, 37, 38, 39, 40, 41, 42, 43, 44, 53, 54, 55, 56, 69, 70, 71, 72, 73, 74, 75, 76, 85, 86, 87, 88})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 3 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {3, 11, 12, 25, 26, 27, 28, 41, 42, 43, 44, 45, 46, 47, 48, 57, 58, 59, 60, 73, 74, 75, 76, 77, 78, 79, 80, 89, 90, 91, 92})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 4 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {4, 9, 12, 29, 30, 31, 32, 33, 34, 35, 36, 45, 46, 47, 48, 61, 62, 63, 64, 65, 66, 67, 68, 77, 78, 79, 80, 93, 94, 95, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 5 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {5, 13, 14, 17, 21, 25, 29, 33, 37, 41, 45, 49, 50, 53, 54, 57, 58, 61, 62, 65, 66, 69, 70, 73, 74, 77, 78, 81, 82, 85, 86, 89, 90, 93, 94})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 6 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {6, 14, 15, 18, 22, 26, 30, 34, 38, 42, 46, 50, 51, 54, 55, 58, 59, 62, 63, 66, 67, 70, 71, 74, 75, 78, 79, 82, 83, 86, 87, 90, 91, 94, 95})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 7 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {7, 15, 16, 19, 23, 27, 31, 35, 39, 43, 47, 51, 52, 55, 56, 59, 60, 63, 64, 67, 68, 71, 72, 75, 76, 79, 80, 83, 84, 87, 88, 91, 92, 95, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 8 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {8, 13, 16, 20, 24, 28, 32, 36, 40, 44, 48, 49, 52, 53, 56, 57, 60, 61, 64, 65, 68, 69, 72, 73, 76, 77, 80, 81, 84, 85, 88, 89, 92, 93, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 9 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {9, 33, 34, 35, 36, 65, 66, 67, 68})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 10 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {10, 37, 38, 39, 40, 69, 70, 71, 72})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 11 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {11, 41, 42, 43, 44, 73, 74, 75, 76})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 12 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {12, 45, 46, 47, 48, 77, 78, 79, 80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 13 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {13, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 14 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {14, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 15 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {15, 51, 55, 59, 63, 67, 71, 75, 79, 83, 87, 91, 95})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 16 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {16, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 17 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {17, 33, 37, 49, 50, 65, 66, 69, 70, 81, 82})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 18 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {18, 34, 38, 50, 51, 66, 67, 70, 71, 82, 83})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 19 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {19, 35, 39, 51, 52, 67, 68, 71, 72, 83, 84})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 20 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {20, 36, 40, 49, 52, 65, 68, 69, 72, 81, 84})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 21 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {21, 37, 41, 53, 54, 69, 70, 73, 74, 85, 86})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 22 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {22, 38, 42, 54, 55, 70, 71, 74, 75, 86, 87})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 23 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {23, 39, 43, 55, 56, 71, 72, 75, 76, 87, 88})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 24 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {24, 40, 44, 53, 56, 69, 72, 73, 76, 85, 88})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 25 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {25, 41, 45, 57, 58, 73, 74, 77, 78, 89, 90})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 26 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {26, 42, 46, 58, 59, 74, 75, 78, 79, 90, 91})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 27 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {27, 43, 47, 59, 60, 75, 76, 79, 80, 91, 92})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 28 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {28, 44, 48, 57, 60, 73, 76, 77, 80, 89, 92})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 29 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {29, 33, 45, 61, 62, 65, 66, 77, 78, 93, 94})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 30 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {30, 34, 46, 62, 63, 66, 67, 78, 79, 94, 95})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 31 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {31, 35, 47, 63, 64, 67, 68, 79, 80, 95, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 32 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {32, 36, 48, 61, 64, 65, 68, 77, 80, 93, 96})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 33 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {33, 65, 66})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 34 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {34, 66, 67})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 35 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {35, 67, 68})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 36 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {36, 65, 68})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 37 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {37, 69, 70})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 38 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {38, 70, 71})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 39 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {39, 71, 72})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 40 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {40, 69, 72})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 41 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {41, 73, 74})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 42 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {42, 74, 75})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 43 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {43, 75, 76})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 44 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {44, 73, 76})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 45 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {45, 77, 78})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 46 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {46, 78, 79})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 47 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {47, 79, 80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 48 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {48, 77, 80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 49 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {49, 65, 69})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 50 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {50, 66, 70})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 51 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {51, 67, 71})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 52 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {52, 68, 72})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 53 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {53, 69, 73})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 54 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {54, 70, 74})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 55 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {55, 71, 75})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 56 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {56, 72, 76})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 57 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {57, 73, 77})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 58 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {58, 74, 78})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 59 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {59, 75, 79})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 60 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {60, 76, 80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 61 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {61, 65, 77})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 62 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {62, 66, 78})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 63 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {63, 67, 79})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 64 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {64, 68, 80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 65 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {65})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 66 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {66})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 67 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {67})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 68 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {68})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 69 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {69})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 70 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {70})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 71 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {71})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 72 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {72})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 73 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {73})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 74 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {74})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 75 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {75})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 76 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {76})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 77 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {77})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 78 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {78})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 79 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {79})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
        If Numero_ = 80 Then
            ListaGruAdd(Lista(0), ListaGru)
            Quitar(Lista, {80})
            If Not Numero(Lista, Numero_) Then GoTo Retorna
        End If
Retorna:
        Return ListaGru
    End Function
    Public Sub MGER(ByRef Lista As List(Of Gru))
        Dim ListaPos_ As New List(Of Integer)
        For i As Integer = 0 To Lista.Count - 1 'Este for recorre grupo a grupo
            ListaPos_ = New List(Of Integer) 'Esta lista recoje los valores de cada posicion para ser usados despues de este fro que sigue
            For j As Integer = 0 To Lista(i).L.Count - 1 'Este for recorre posicion a posicion
                Lista(i).L(j) = New Pos(Lista(i).L(j).X, Lista(i).L(j).Y, BCGPP(Lista(i).L(j), Lista))
                ListaPos_.Add(Lista(i).L(j).U)
            Next
            Dim Uno As Boolean = False 'Aqui se pone true si en la posicion evaluada solo existe un grupo al que pertenece
            Dim Otro As Boolean = False 'True si hay alguna posicion que pertenesca a mas de un grupo
            For Each inte As Integer In ListaPos_ 'En este for lo que se hace es que se marca dos variables que en conjunto a los if que le siguen se decide que tipo de grupo es
                If inte = 1 Then
                    Uno = True
                ElseIf inte <> 1 Then
                    Otro = True
                End If
            Next
            If Uno And Otro Then 'Existe un 1
                Lista(i) = New Gru(Lista(i).N, Lista(i).E, Lista(i).L, 11, True) 'Entra aqui si almenos hay una posicion que solo pertenece a un grupo
            ElseIf Uno And Not Otro Then 'Todos 1
                Lista(i) = New Gru(Lista(i).N, Lista(i).E, Lista(i).L, 10, True) 'Si solo hay posiciones que pertenecen a un grupo Estos grupos son llamados isla
            ElseIf Not Uno And Otro Then 'No existe un 1
                Lista(i) = New Gru(Lista(i).N, Lista(i).E, Lista(i).L, 12, False) 'Grupo redundante ya que solo hay posiciones con mas de un grupo al que pertenece.
            End If
        Next
    End Sub




    Private Function BCGPP(Pos_ As Pos, ByRef Lista As List(Of Gru)) ' lo que hace es entrar a cada grupo que hay en la Lista y preguntar si existe la posicion en ese grupo
        'Si existe la posicion en el grupo se acumula permitiendo contar la cantidad de grupos a los que pertenece esa posicion
        Dim Sumador As Integer = 0
        For Each Gru_ As Gru In Lista
            For Each PosL_ As Pos In Gru_.L
                If Pos_.X = PosL_.X And Pos_.Y = PosL_.Y Then
                    Sumador += 1
                End If
            Next
        Next
        Return Sumador
    End Function






    Public Sub Accion() 'Metodo que se llama para ejecutar el algoritmo
        Form1.LB_Salida.Text = "" 'Reseteando la salida
        Dim Salida As New List(Of Gru) 'Salida del programa
        If Cargo Then 'Variable que impide la ejecucion de codigo si no se a cargado el formulario
            Dim Val As Boolean = False
            Dim LisPos As New List(Of Pos)
            'Verifica si no se trata de casos especiales 
            If ComparaMat(Matriz, MatrizCE1) Then
                Val = (VerificarGrupos(3, 0, 1, 1, LisPos) And VerificarGrupos(0, 0, 1, 1, LisPos)) And (VerificarGrupos(3, 3, 1, 1, LisPos) And VerificarGrupos(0, 3, 1, 1, LisPos))  '32
                If Val Then CDGAdd(32, "bd", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(1, 1, 2, 2, LisPos) '22
                If Val Then CDGAdd(22, "BD", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(0, 1, 2, 1, LisPos) '50
                If Val Then CDGAdd(50, "aBc", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(1, 2, 1, 2, LisPos) '39
                If Val Then CDGAdd(39, "AcD", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(2, 2, 2, 1, LisPos) '59
                If Val Then CDGAdd(59, "ABC", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(2, 0, 2, 1, LisPos) '57
                If Val Then CDGAdd(57, "abC", LisPos, Salida)
                LisPos = New List(Of Pos)
                GoTo Salir
            ElseIf ComparaMat(Matriz, MatrizCE2) Then
                Val = (VerificarGrupos(3, 0, 1, 1, LisPos) And VerificarGrupos(0, 0, 1, 1, LisPos)) And (VerificarGrupos(3, 3, 1, 1, LisPos) And VerificarGrupos(0, 3, 1, 1, LisPos))  '32
                If Val Then CDGAdd(32, "bd", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(1, 1, 2, 2, LisPos) '22
                If Val Then CDGAdd(22, "BD", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(1, 0, 1, 2, LisPos) '37
                If Val Then CDGAdd(37, "acD", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(0, 2, 2, 1, LisPos) '51
                If Val Then CDGAdd(51, "ABc", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(2, 3, 2, 1, LisPos) '60
                If Val Then CDGAdd(60, "AbC", LisPos, Salida)
                LisPos = New List(Of Pos)
                Val = VerificarGrupos(2, 1, 2, 1, LisPos) '58
                If Val Then CDGAdd(58, "aBC", LisPos, Salida)
                LisPos = New List(Of Pos)
                GoTo Salir
            End If
            'Si no hay casos especiales salta hasta aqui ignorando lo que esta plegado


            'Codigo para la reduccion
            'Es esto el algoritmo

            'Esta linea la he separado para que ka entiendas mejor
            Dim Lista As List(Of Gru)
            Lista = BuscandoTodosLosGrupos(Matriz) 'Aqui se recojen todos los posibles grupos y se almacenan en Lista
            Lista = Reduce01(Lista) 'Aqui se filtra la lista con grupos redundantes directos
            Salida = Lista 'Esta parte puede ser eliminada porque igual salida no esta haciendo nada en estos momentos
            Dim Var As Boolean = True 'Esto es para ver en que momento se sale del bucle While
            Dim Index As Integer = 0 'Este indice no se para que esta 
            While Var
                MGER(Lista) 'Aqui se marca cada grupo para saber si existe almenos una posicion que solo pertenesca a un solo grupo
                'Si todas las posiciones solo pertenecen a solo un grupo respectivamente
                'Pero lo que importa es que los grupos marcados como Todas las posiciones pertenecen a mas de un grupo
                Var = GruRedun(Lista) 'entran aqui y el primer grupo con esta ultima caracteristica es borrado virtualmente y la funcion retorna verdadero
                '¨Pero si la funcion no encuentra grupos marcados con la caracteristica de que todas las posiciones tiene mas de un grupo al que pertenece.
                Index += 1 'No se pa que sirve 
            End While
            'Una vez la Lista reducida al maximo, Se pasa el contenido de Lista a Salida y pasa a ser mostrado y graficado.
            Salida = Lista








        End If
Salir:'Si hay casos especiales salta hasta aca
        Dim SalidaExp As String = "" 'Esta variable sirve para ir sumando las expresiones que salgan de la lista Salida
        For Each Gru_ As Gru In Salida 'For para presentar la salida
            If SalidaExp <> "" Then
                SalidaExp = SalidaExp & " + "
            End If
            SalidaExp = SalidaExp & Gru_.E
        Next
        'MsgBox("Aquiiiiiiiii")
        Form1.LB_Salida.Text = SalidaExp 'Presentando la salida
        PintaNumero("0", 5, 5, 400, 400, Salida) 'Metodo para pintar unicamente los numeros
    End Sub
#End Region

End Class
