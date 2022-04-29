Imports System.Data.SQLite
Imports System.IO
Public Class Form1
#Region "Area de cositas que se encuentran"
    'https://www.sqlitetutorial.net/sqlite-autoincrement/
    'insert into Comandos(Comando, Detalle) values('45', '45');
    'Select Case rowid, ID, Comando, Detalle FROM Comandos;
#End Region

    Public WithEvents DBDB_ As New SQLiteDB

    Private Sub Archivo(Ruta As Object) Handles OpenFileDialogCGE1.AbreArchivo
        CargarArchivo(Ruta)
    End Sub

    Private Sub CargarArchivo(Ruta As String)
        Me.Ruta = Ruta
        Nombre = System.IO.Path.GetFileNameWithoutExtension(Me.Ruta)
        DBDB_.Ruta = Me.Ruta
        Me.Text = Nombre & "   Todas las tablas"
        Cargar()
    End Sub
    Public Ruta As String = ""
    Dim Nombre As String = ""
    Public RutaGuarda As String = My.Computer.FileSystem.CurrentDirectory & "\ruta.txt"
    Public Ultima As String = ""
    Public Ultabla As String = ""
    Dim Tablas As String = "SELECT * FROM sqlite_master WHERE type = 'table';"
    Dim Esquema As String = ""
    Dim Exclusiones As New List(Of String)
    Dim EstaTablas As Boolean = False
    Dim NombreDB As String = ""
    Public RefrescarEdicion As Boolean = False
    Public Sub New()
        'SQLiteShow = True
        InitializeComponent()
        'Dim Rutatemp As String = ""
        'NombreDB = My.Settings.NombreDB

        'Rutatemp = My.Computer.FileSystem.CurrentDirectory & "\" & NombreDB
        'CargarDB(Rutatemp)
        'Cargar()
    End Sub




    'Public Sub CargarDB(ByVal RutaTemp As String)
    '    If System.IO.File.Exists(RutaTemp) Then
    '        DBDB_.Ruta = RutaTemp
    '        Cargar()
    '    Else
    '        MsgBox("No existe el archivo de base de datos")
    '        NombreDB = My.Settings.NombreDBPorDefecto
    '        RutaTemp = My.Computer.FileSystem.CurrentDirectory & "\" & NombreDB
    '        Crear(RutaTemp)
    '        DBDB_.Ruta = RutaTemp
    '        Cargar()
    '    End If
    'End Sub
    Public Sub Cargar(VerCom As Boolean)
        DBDB_.Ver(Tablas, DGV, VerCom)
        EstaTablas = True
        BT_Agregar.Text = "Agregar tabla"
    End Sub

    Public Sub Cargar(Optional Str As String = "", Optional VerCom As Boolean = True)
        If Str = "" Then
            DBDB_.Ver(Tablas, DGV, VerCom)
            EstaTablas = True
            BT_Agregar.Text = "Agregar tabla"
        Else
            DBDB_.Ver(Str, DGV, VerCom)
            EstaTablas = False
            BT_Agregar.Text = "Agregar registro"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BT_Guardar.Visible = False
        Dim Archivo As String = ""
        If Environment.GetCommandLineArgs.Length > 1 Then
            'MsgBox(Environment.GetCommandLineArgs(0))
            Archivo = Environment.GetCommandLineArgs(1)
            OpenFileDialogCGE1.InitialDirectory = Path.GetDirectoryName(Archivo)
            CargarArchivo(Archivo)
        Else
            OpenFileDialogCGE1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        End If

        ' Exclusiones.AddRange({"integer", "Primary", "KEY", "TEXT"})
    End Sub


    Private Sub BT_Agregar_Click(sender As Object, e As EventArgs) Handles BT_Agregar.Click
        If BT_Agregar.Text = "Agregar registro" Then
            Dim Datos As String = ""
            Cargar()
            For i As Integer = 0 To DGV.Rows.Count - 1
                If Ultabla = DGV(1, i).Value Then
                    Esquema = DGV(4, i).Value
                End If
            Next
            Cargar(Ultima)
            Dim Lista As New List(Of Colum)
            'Dim Otra As String = ""
            For Each L As List(Of String) In LectorDeColumna(Esquema)
                'Otra = Otra & "{"
                'For Each Li As String In L
                '    Otra = Otra & "<" & Li & ">"
                'Next
                'Otra = Otra & "}" & vbCrLf
                If L(0).ToLower <> "Foreign".ToLower Then
                    Lista.Add(New Colum(L(0), L(1)))
                End If

            Next
            'Dim Lista As New List(Of String)
            'Dim Palabra As String = ""
            'Dim Coma As Boolean = False
            'For Each Char_ As Char In Esquema
            '    Select Case Char_
            '        Case ","
            '            Coma = True
            '            Excluir(Palabra)
            '            Lista.Add(Palabra)
            '            Palabra = ""
            '        Case "("
            '            Palabra = ""
            '        Case ")"
            '            Excluir(Palabra)
            '            Lista.Add(Palabra)
            '            Palabra = ""
            '        Case Else
            '            If Coma And Char_ = " " Then
            '                Coma = False
            '            Else
            '                Palabra = Palabra & Char_
            '            End If
            '    End Select
            'Next
            Editar.FLP_.Controls.Clear()
            For Each c As Colum In Lista
                Dim Control As New Registros
                Control.LB_Registro.Text = c.Nombre
                Control.LB_Tipo.Text = c.Tipo
                Editar.FLP_.Controls.Add(Control)
            Next
            Editar.ShowDialog()
            If Editar.DesdeArchivo Then
                Desde_Archivo.ShowDialog()
            End If
        ElseIf BT_Agregar.Text = "Agregar tabla" Then
            Agregar_tabla.ShowDialog()
        End If

    End Sub
    Class Colum
        Public Nombre As String
        Public Tipo As String
        Public Sub New(nombre As String, tipo As String)
            Me.Nombre = nombre
            Me.Tipo = tipo
        End Sub
    End Class
    Private Function LectorDeColumna(s As String) As List(Of List(Of String))
        Dim par As Integer = 0
        Dim Pal As String = ""
        Dim Lista As New List(Of List(Of String))
        Lista.Add(New List(Of String))
        For Each c As Char In s
            Select Case c
                Case "("
                    par += 1
                    If par > 1 Then
                        GoTo eti1
                    End If
                Case ")"
                    If par > 1 Then
                        par -= 1
                        GoTo eti1
                    End If
                    par -= 1
                Case Else
eti1:
                    If par >= 1 Then
                        Select Case c
                            Case "("
                                If Pal <> "" Then : Lista(Lista.Count - 1).Add(Pal) : End If : Pal = ""
                            Case ")"
                                If Pal <> "" Then : Lista(Lista.Count - 1).Add(Pal) : End If : Pal = ""
                            Case " "
                                If Pal <> "" Then : Lista(Lista.Count - 1).Add(Pal) : End If : Pal = ""
                            Case ","
                                If Pal <> "" Then : Lista(Lista.Count - 1).Add(Pal) : End If : Pal = ""
                                Lista.Add(New List(Of String))
                            Case Else
                                Pal = Pal + c
                        End Select
                    End If
            End Select
        Next
        If Pal <> "" Then : Lista(Lista.Count - 1).Add(Pal) : End If : Pal = ""

        Return Lista

    End Function
    Private Sub Excluir(ByRef Str As String)
        Dim Pos As Integer = 0
        For Each Str_ As String In Exclusiones
            Pos = InStr(Str, Str_, CompareMethod.Text)
            If Pos > 0 Then
                Str = Str.Substring(0, Pos - 2)
            End If
        Next
    End Sub



    Private Sub BT_Cargar_Click(sender As Object, e As EventArgs) Handles BT_Cargar.Click
        If OFD_.ShowDialog = DialogResult.OK Then
            Dim IsTrue As Boolean = False
            Dim SStr As String = OFD_.FileName.Substring(My.Computer.FileSystem.CurrentDirectory.Length + 1)
            If InStr(1, OFD_.FileName, My.Computer.FileSystem.CurrentDirectory) > 0 Then
                If MessageBox.Show("Desea establecer esta base de datos como su base de datos de trabajo actual", "Selecion de base de datos", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    SStr = OFD_.FileName.Substring(My.Computer.FileSystem.CurrentDirectory.Length + 1)
                    IsTrue = True
                End If
            End If
            DBDB_.Ruta = OFD_.FileName
            If IsTrue Then
                Me.Text = SStr & "  De sistema   Todas las tablas"
                'Form1.ActualizaControl() 'Boton desactivado
            Else
                Me.Text = SStr & "  Visualizando   Todas las tablas"
            End If

            Cargar()
        End If
    End Sub
    Dim Valor As Integer

    Private Sub DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGV.DataError
        MsgBox("Intenta ingresar un dato lo valido." & vbCrLf & "Corrija o elimine el valor")
    End Sub

    Private Sub BT_Ejecutar_Click(sender As Object, e As EventArgs) Handles BT_Ejecutar.Click
        If RTB_Comando.Text <> "" Then
            Try
                Cargar(RTB_Comando.Text)
            Catch ex As Exception
                Dim EM As New ErrrorMsg(ex.Message & vbCrLf & vbCrLf & ex.Source & vbCrLf & vbCrLf & ex.StackTrace)
                EM.ShowDialog()
                Cargar(Ultima)
            End Try
        Else
            MsgBox("No escribio comando alguno")
        End If
    End Sub
    Dim UPDATE_ As Boolean = False
    Private Sub TB_CimandoEjecutado(Str As String) Handles DBDB_.VerComando
        If InStr(1, "UPDATE", Str) > 0 Then
            UPDATE_ = True
            TB_ConsultaSQL.Text = Str
        Else
            If UPDATE_ Then
                UPDATE_ = False
            Else
                TB_ConsultaSQL.Text = Str
            End If
        End If

    End Sub

    Private Sub BT_Flecha_Izquierda_Click(sender As Object, e As EventArgs) Handles BT_Flecha_Izquierda.Click
        Cargar()
        Me.Text = Nombre & "   Todas las tablas"
    End Sub

    Private Sub BT_Flecha_Derecha_Click(sender As Object, e As EventArgs) Handles BT_Flecha_Derecha.Click
        If Ultima <> "" Then
            Me.Text = Nombre & "   " & Ultabla
            Cargar(Ultima)
        End If
    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim Str As String = ""
            Dim Str_ As String = ""
            Select Case e.ColumnIndex
                Case -1
                    If EstaTablas Then
                        If MessageBox.Show("Desea borrar la tabla", "Cuidado con borrar algo que no es", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                            Try
                                Str_ = DGV(1, e.RowIndex).Value
                                Str = "Drop Table " & Str_ & ";"
                                DBDB_.CSR(Str)
                                DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Red
                            Catch ex As Exception

                            End Try
                            Try
                                'Cargar(False)
                            Catch ex As Exception

                            End Try
                        End If
                    Else
                        If MessageBox.Show("Desea borrar el registro", "Cuidado con borrar algo que no es", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                            Try
                                Str_ = DGV(0, e.RowIndex).Value
                                Str = "DELETE FROM " & Ultabla & " WHERE " & DGV.Columns(0).Name & " = '" & Str_ & "';"
                                DBDB_.CSR(Str)
                                DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Red
                                'Cargar(Str, True)

                            Catch ex As Exception

                            End Try
                        Try
                                If Me.RefrescarEdicion Then
                                    Cargar(Ultima, False)
                                End If
                            Catch ex As Exception

                        End Try
                        End If
                    End If
                Case 1
                    If EstaTablas Then
                        Str_ = DGV(e.ColumnIndex, e.RowIndex).Value
                        Str = "SELECT * FROM " & Str_ & ";"
                        Try
                            Cargar(Str)
                            Ultabla = Str_
                            Ultima = "SELECT * FROM " & Ultabla & ";"
                            Me.Text = Nombre & "   " & Ultabla
                        Catch ex As Exception

                        End Try
                    Else
                        GoTo Saltar
                    End If
                Case Else
Saltar:
                    Ver_contenido.Datos(Ultabla, DGV.Columns(0).Name, DGV(0, e.RowIndex).Value, DGV.Columns(e.ColumnIndex).Name)
                    Ver_contenido.FilaIndex = e.RowIndex
                    Ver_contenido.ColumnaIndex = e.ColumnIndex
                    'If e.ColumnIndex = 0 Then
                    '    Ver_contenido.BT_Guardar.Enabled = False
                    'Else
                    If EstaTablas Then
                        Ver_contenido.BT_Guardar.Enabled = False
                    Else
                        Ver_contenido.BT_Guardar.Enabled = True
                    End If
                    'End If
                    Ver_contenido.RTB_.Text = DGV(e.ColumnIndex, e.RowIndex).Value
                    Ver_contenido.ShowDialog()
            End Select
            'MsgBox(" e: " & e.ColumnIndex & "  e.Y: " & e.RowIndex)
            ' MsgBox(" e.X: " & e.X & "  e.Y: " & e.Y)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SFD_.ShowDialog = DialogResult.OK Then
            Crear(SFD_.FileName)
        End If
    End Sub

    Private Sub BT_Agregar_KeyDown(sender As Object, e As KeyEventArgs) Handles BT_Agregar.KeyDown

    End Sub

    Private Sub BT_Agregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BT_Agregar.KeyPress

    End Sub

    Private Sub BT_Flecha_Derecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BT_Flecha_Derecha.KeyPress
        MsgBox("Propiedad de CGE    a presionado : " & e.KeyChar)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        '"insert into " & Form1.Ultabla & " values(" & VerLista & ");"
        Ejemplo_de_SQLiteDB()
    End Sub

    Private Sub Ejemplo_de_SQLiteDB()
        'Dim DBDB As New SQLiteDB("C:\Users\CGE\Desktop\DB\MiDB.db")
        'DBDB.CSR("insert into " & "productos" & " values(" & "'6', 'Alguito mas'" & ");")
        'DBDB.Ver("SELECT * FROM " & "productos" & ";", DGV)

        Dim DBDB As New SQLiteDB
        DBDB.Ruta = "C:\Users\CGE\Desktop\DB\MiDB.db"
        'Dim Lista As New List(Of String)
        'Lista.AddRange({"9", "yo"})
        'DBDB.Insertar("productos", Lista)
        Dim Ds As DataSet
        Ds = DBDB.Ver("SELECT * FROM " & "productos" & ";", True)
        Try
            If Ds.Tables(0).Rows.Count > 0 Then
                DGV.DataSource = Ds.Tables(0)
            Else
                DGV.DataSource = Nothing
            End If
        Catch ex As Exception
            DGV.DataSource = Nothing
        End Try
    End Sub
    Dim PoIn As New Point(205, 11)
    Dim SiIn As New Size(169, 20)
    Dim PoOu As New Point(0, 0)
    Dim SiOu As New Size(200, 200)
    Private Sub BT_MuestraC_Click(sender As Object, e As EventArgs) Handles BT_MuestraC.Click
        If BT_MuestraC.Text = "V" Then
            BT_MuestraC.Text = "∧"
            'RTB_Comando.Location = DGV.Location
            'RTB_Comando.Size = DGV.Size
            'RTB_Comando.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
            BT_Guardar.Visible = True
            BT_Abrir.Visible = True
            RTB_Comando.Visible = False
            NRTB_.Text = RTB_Comando.Text
            NRTB_.Location = DGV.Location
            NRTB_.Size = DGV.Size
            NRTB_.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
            NRTB_.Visible = True
        Else
            BT_MuestraC.Text = "V"
            'RTB_Comando.Location = PoIn
            'RTB_Comando.Size = SiIn
            'RTB_Comando.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            BT_Guardar.Visible = False
            BT_Abrir.Visible = False
            RTB_Comando.Visible = True
            RTB_Comando.Text = NRTB_.Text
            NRTB_.Visible = False
        End If


    End Sub

    Private Sub RTB_Comando_TextChanged(sender As Object, e As EventArgs) Handles RTB_Comando.TextChanged

    End Sub

    Private Sub BT_Guardar_Click(sender As Object, e As EventArgs) Handles BT_Guardar.Click
        If NRTB_.Text <> "" Then
            SFD_.Filter = "Lenguaje SQL (*.sql)|*.sql|Todos los archivos |*.*"
            If SFD_.ShowDialog = DialogResult.OK Then
                Guardar(SFD_.FileName, NRTB_.Text)
            End If
        Else
            MsgBox("No hay contenido para guardar")
        End If
    End Sub

    Private Sub BT_Abrir_Click(sender As Object, e As EventArgs) Handles BT_Abrir.Click
        If NRTB_.Text = "" Then
            OFD_.Filter = "Lenguaje SQL (*.sql)|*.sql|Todos los archivos |*.*"
            If OFD_.ShowDialog = DialogResult.OK Then
                NRTB_.Text = Abrir_Crear(OFD_.FileName)
            End If
        Else
            If MessageBox.Show("Puede perder el codigo que tiene." & vbCrLf & "¿Desea guardar?", "Guardar datos", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                SFD_.Filter = "Lenguaje SQL (*.sql)|*.sql|Todos los archivos |*.*"
                If SFD_.ShowDialog = DialogResult.OK Then
                    Guardar(SFD_.FileName, NRTB_.Text)
                End If
            Else
                OFD_.Filter = "Lenguaje SQL (*.sql)|*.sql|Todos los archivos |*.*"
                If OFD_.ShowDialog = DialogResult.OK Then
                    NRTB_.Text = Abrir_Crear(OFD_.FileName)
                End If
            End If
        End If
    End Sub


    Class SQLiteDB
        Private Ruta_ As String = ""
        Public Property Ruta As String
            Get
                Return Ruta_
            End Get
            Set(value As String)
                Ruta_ = value
                Conexion = "Data Source = " & Ruta_ & ";"
            End Set
        End Property
        Private Property Conexion As String
            Get
                Return Conexion_
            End Get
            Set(ByVal value As String)
                Conexion_ = value
                SQLConn = New SQLiteConnection(Conexion)
            End Set
        End Property
        Dim Conexion_ As String = ""
        Dim SQLConn As SQLiteConnection
        Dim SQLCom As SQLiteCommand
        Dim SQLReader As SQLiteDataAdapter
        Sub New()
        End Sub
        Sub New(ByVal Ruta As String)
            Me.Ruta = Ruta
        End Sub
        Public Sub CSR(ByVal Comando As String)
            RaiseEvent VerComando(Comando)
            AbrirDB()
            SQLCom.CommandText = Comando
            SQLCom.ExecuteNonQuery()
            SQLiteClose()
        End Sub
        Public Sub Ver(ByVal Comando As String, ByRef _DGV_ As DataGridView, VerCom As Boolean)
            Dim Ds As DataSet = Ver(Comando, VerCom)
            Try
                If Ds.Tables(0).Rows.Count > 0 Then
                    _DGV_.DataSource = Ds.Tables(0)
                Else
                    _DGV_.DataSource = Nothing
                End If
            Catch ex As Exception
                _DGV_.DataSource = Nothing
            End Try
            SQLiteClose()
        End Sub
        Public Event VerComando(Str As String)
        Public Function Ver(ByVal Comando As String, VerCom As Boolean)
            If VerCom Then
                RaiseEvent VerComando(Comando)
            End If
            Dim Ds As New DataSet
            Try
                AbrirDB()
                SQLCom.CommandText = Comando
                SQLReader = New SQLiteDataAdapter(SQLCom)
                SQLReader.Fill(Ds)
                SQLiteClose()
                Return Ds
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Ds
        End Function

        Public Sub Dispose()
            SQLReader.Dispose()
            SQLCom.Dispose()
            SQLConn.Dispose()
        End Sub
        Public Sub Insertar(ByVal Tabla As String,
                            ByVal Lista As List(Of String))
            If Lista.Count < 1 Then
                Throw New Exception("No hay nada en la lista")
                Exit Sub
            End If
            Dim Str As String = ""
            For Each Str_ As String In Lista
                If Str <> "" Then
                    Str = Str & ","
                End If
                Str = Str & "'" & Str_ & "'"
            Next
            CSR("insert into " & Tabla & " values(" & Str & ");")
        End Sub
        Public Sub AbrirDB()
            Try
                SQLConn.Open()
                SQLCom = SQLConn.CreateCommand()
            Catch ex As Exception
                Try
                    SQLCom = SQLConn.CreateCommand()
                Catch ex_ As Exception
                    SQLiteClose()
                    MsgBox("No se a podido abrir la base de datos")
                End Try
            End Try
        End Sub
        Public Sub SQLiteClose()
            If Not IsNothing(SQLConn) Then
                SQLConn.Close()
            End If
        End Sub
    End Class

    Private Sub BT_Exportar_Click(sender As Object, e As EventArgs) Handles BT_Exportar.Click
        Try
            Dim R_C As Integer = DGV.Rows.Count()
            Dim C_C As Integer = CInt(RTB_Comando.Text)
            Dim str As String = ""
            Dim L As New List(Of Char)
            For i As Integer = 0 To R_C - 1
                For j As Integer = 0 To C_C - 1
                    Dim S As String = DGV(j, i).Value
                    S = S.Replace(vbCr, " ")
                    S = S.Replace(vbLf, " ")
                    L.AddRange(S & vbTab)
                Next
                L.AddRange(vbCrLf)
            Next
            Clipboard.SetText(New String(L.ToArray))
            MsgBox("Los datos estan en el portapapeles (clipboard)")
        Catch ex As Exception
            MsgBox("Errror")
        End Try

    End Sub


    Private Sub NRTB__TextChanged_() Handles NRTB_.TextChanged_
        RTB_Comando.Text = NRTB_.Text
    End Sub

    Private Sub BT_GenerarInsert_Click(sender As Object, e As EventArgs) Handles BT_GenerarInsert.Click
        Dim DA As New Desde_Archivo
        DA.ShowDialog()
    End Sub
End Class
