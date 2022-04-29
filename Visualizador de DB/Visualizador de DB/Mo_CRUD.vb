Imports System.Data.SQLite
Imports System.IO
Module Mo_CRUD

#Region "CRUD Archivos"

    Public Function Leer(Ruta As String, ByRef Texto As String) As Boolean
        Try
            Texto = File.ReadAllText(Ruta, System.Text.Encoding.UTF8)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function Abrir_Crear(ByVal Ruta As String)
        Try
            If System.IO.File.Exists(Ruta) Then
                Dim sr As New System.IO.StreamReader(Ruta)
                Dim Str As String = sr.ReadToEnd()
                sr.Close()
                Return Str
            Else
                Dim fs As System.IO.FileStream = System.IO.File.Create(Ruta)
                fs.Close()
                fs.Dispose()
                Return ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try
    End Function
    Public Sub Guardar(ByVal Ruta As String, ByVal Dato As String)
        Guardar(Ruta, Dato, False)
    End Sub
    Public Sub Guardar(ByVal Ruta As String, ByVal Dato As String, ANCI As Boolean)
        Try
            If ANCI Then
                If System.IO.File.Exists(Ruta) Then
                    System.IO.File.Delete(Ruta)
                End If
                Dim fs As New System.IO.StreamWriter(Ruta, False, System.Text.Encoding.Default)
                fs.WriteLine(Dato)
                fs.Close()
                fs.Dispose()
            Else
                Dim fs As System.IO.FileStream = System.IO.File.Create(Ruta)
                Dim info As Byte() = New System.Text.UTF8Encoding(True).GetBytes(Dato)
                fs.Write(info, 0, info.Length)
                fs.Close()
                fs.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Guardar01(ByVal Ruta As String, ByVal Dato As String)
        Dim info As Byte() = New System.Text.UTF8Encoding(True).GetBytes(Dato)
        File.WriteAllBytes(Ruta, info)
    End Sub
#End Region

    Public Function ContarPalabrasArchivo(Ruta As String)
        Dim Str As String = ""
        Leer(Ruta, Str)
        Dim Palab As Boolean = False
        Dim CantidadPalabras As Integer = 0
        For Each Char_ As Char In Str
            If InStr(1, " ;:-_!#$%&¡""'?¿" & vbCr & vbLf, Char_) > 0 Then
                If Palab Then
                    CantidadPalabras += 1
                    Palab = False
                End If
            Else
                Palab = True
            End If
        Next
        If Palab Then
            CantidadPalabras += 1
            Palab = False
        End If
        Return CantidadPalabras
    End Function
    Public Function ContarPalabrasMarcadas(Usuario As String, TipoUsuario As String, TextoOrigen As String, SoloTexOri As Boolean)
        Dim CantidadPalabras As Integer = 0
        Dim Ds As DataSet = DB_.Ver("SELECT * FROM TipoPalabras;", True)
        Try
            If Ds.Tables(0).Rows.Count > 0 Then
                For Each Row As DataRow In Ds.Tables(0).Rows
                    If SoloTexOri Then
                        If Row("TextoOrigen") = TextoOrigen Then
                            CantidadPalabras += 1
                        End If
                    Else
                        If Row("TextoOrigen") = TextoOrigen And Row("Usuario") = Usuario And Row("TipoUsuario") = TipoUsuario Then
                            CantidadPalabras += 1
                        End If
                    End If

                Next
            End If
        Catch ex As Exception
        End Try
        Return CantidadPalabras
    End Function
    Public DB_ As New Form1.SQLiteDB


    Public Sub Crear(ByVal Ruta As String)
        Dim SQLConn As SQLiteConnection
        SQLConn = New SQLiteConnection("Data Source = " & Ruta & ";" & "New=true;")
        SQLConn.Open()
        If Not IsNothing(SQLConn) Then
            SQLConn.Close()
        End If
    End Sub



    Public TabTipPal As New TablaSQL("TipoPalabras", {
                                                "Palabra TEXT",
                                                "TipoPalabra TEXT",
                                                "Usuario TEXT",
                                                "TipoUsuario TEXT",
                                                "TextoOrigen TEXT",
                                                "Posicion TEXT",
                                                "Largo TEXT",
                                                "SaltoLinea TEXT",
                                                "Fecha TEXT"})
    Public TabResFin As New TablaSQL("ResultadoFinal", {
                                                "Palabra TEXT Primary KEY",
                                                "Tipo TEXT",
                                                "Cantidad TEXT"})
    Public Usuario As New TablaSQL("Usuario", {
                                                "Cedula Text",
                                                "TipoUsuario Text",
                                                "Nombre TEXT",
                                                "Apellidos TEXT",
                                                "UltAcceso TEXT",
                                                "CantMsg TEXT"})

    Structure TablaSQL
        ''' <summary>Va el nombre que tomara la tabla </summary>
        Public Nombre As String
        ''' <summary>IEnumerable(Of String) {"Columna1 TEXT", "Colu2 INTEGER"}</summary>
        Public Columnas As List(Of String)
        ''' <summary>Permite ingresar el nombre de la tabla y sus columnas via {"","",...}</summary>
        ''' <param name="Nombre">Nombre de la tabla</param>
        ''' <param name="Columnas">{"","",...}</param>
        Sub New(Nombre As String, Columnas As IEnumerable(Of String)) ', Columnas Enumerable(Of String))
            Me.Nombre = Nombre
            Dim Lista As New List(Of String)
            Lista.AddRange(Columnas) ' {"C1 TEXT", "C2 TEXT", "C3 TEXT", "C4 INTEGER"}
            Me.Columnas = Lista
        End Sub
        ''' <summary>Permite ingresar el nombre de la tabla y sus columnas via {"","",...}</summary>
        ''' <param name="Nombre">Nombre de la tabla</param>
        ''' <param name="Columnas">Lista.Add("")</param>
        Sub New(Nombre As String, Columnas As List(Of String))
            Me.Nombre = Nombre
            Me.Columnas = Columnas
        End Sub
    End Structure


    Public Sub CrearDB(NombreDB As String, Tabla As IEnumerable(Of TablaSQL))
        If (File.Exists(NombreDB)) Then
            File.Delete(NombreDB)
        End If
        Dim DB_Temp As New Form1.SQLiteDB(NombreDB)
        For Each LaTabla As TablaSQL In Tabla
            DB_Temp.CSR(CrearConsultaTabla(LaTabla))
        Next
    End Sub


    Public Function CrearConsultaTabla(Tabla As TablaSQL)
        Dim S As String = ""
        For Each Str As String In Tabla.Columnas
            If S = "" Then
                S = S & Str
            Else
                S = S & ", " & Str
            End If
        Next
        Return "CREATE TABLE " & Tabla.Nombre & " (" & S & ");"
    End Function
End Module
