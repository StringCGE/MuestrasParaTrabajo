Imports System.IO
#Region "Imports de Detectar coneccion de dispositivos"
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Management
#End Region
Public Class OpenFileDialogCGE
#Region "Detectar coneccion de dispositivos"
    Private Sub ActualizaDispositivos()
        ComboBox1.Items.Clear()
        For Each vUnidad As String In Directory.GetLogicalDrives()
            ComboBox1.Items.Add(vUnidad)
        Next vUnidad
    End Sub

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2

    Private Structure DEV_BROADCAST_VOLUME
        Dim Dbcv_Size As Integer
        Dim Dbcv_Devicetype As Integer
        Dim Dbcv_Reserved As Integer
        Dim Dbcv_Unitmask As Integer
        Dim Dbcv_Flags As Short
    End Structure
    Protected Overrides Sub WndProc(ByRef M As System.Windows.Forms.Message)
        On Error Resume Next
        If M.Msg = WM_DEVICECHANGE Then
            Select Case M.WParam
                Case DBT_DEVICEARRIVAL
                    Dim DevType As Integer = Marshal.ReadInt32(M.LParam, 4)
                    If DevType = DBT_DEVTYP_VOLUME Then
                        Dim Vol As New DEV_BROADCAST_VOLUME
                        Vol = Marshal.PtrToStructure(M.LParam, GetType(DEV_BROADCAST_VOLUME))
                        If Vol.Dbcv_Flags = 0 Then
                            For i As Integer = 0 To 20
                                If Math.Pow(2, i) = Vol.Dbcv_Unitmask Then
                                    Dim Usb As String = Chr(65 + i) + ":\"
                                    ComboBox1.Items.Add("Dispositivo Conectado[" & Usb & "]")
                                    ActualizaDispositivos()
                                    'If CheckBox1.Checked = True Then
                                    'Process.Start(Usb)
                                    'End If
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                Case DBT_DEVICEREMOVECOMPLETE
                    Dim DevType As Integer = Marshal.ReadInt32(M.LParam, 4)
                    If DevType = DBT_DEVTYP_VOLUME Then
                        Dim Vol As New DEV_BROADCAST_VOLUME
                        Vol = Marshal.PtrToStructure(M.LParam, GetType(DEV_BROADCAST_VOLUME))
                        If Vol.Dbcv_Flags = 0 Then
                            For i As Integer = 0 To 20
                                If Math.Pow(2, i) = Vol.Dbcv_Unitmask Then
                                    Dim Usb As String = Chr(65 + i) + ":\"
                                    'ListBox1.Items.Add("Dispositivo Desconectado")
                                    ActualizaDispositivos()
                                    Exit For
                                End If
                            Next
                        End If
                    End If
            End Select
        End If
        MyBase.WndProc(M)
    End Sub
#End Region
    Public Event AbreArchivo(ByVal Ruta)

    Dim Ruta As String = ""
    Dim Carpeta As String = ""
    Dim NRuta As String = ""


    Public FileName As String = ""
    Public BT_Ac_Name_Folder As String = "Abrir carpeta"
    Public BT_Ac_Name_File As String = "Abrir Archivo"
    Public BT_Ac_Name_NotExist As String = "-----"

    'Public InitialDirectory As String = "C:\Users\CGE\Documents\Visual Studio 2017\Projects\01 EIL\EIL Final\Exportador\Exportador\bin\Debug\Prueba la base de datos No Importa" '"C:\Users\CGE\Documents\Visual Studio 2017\Projects" 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Visual Studio 2017\Projects\01 EIL\JAEN 20190310"
    Public InitialDirectory As String = "C:\Users\CGE\Documents"
    Public IsFilterBlackList As Boolean = True
    Public BlackList As New List(Of String)
    Private Sub OpenFileDialogCGE01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizaDispositivos()
        Ruta = InitialDirectory
        CHB_TE.Checked = True ' Si se quita esta linea, se deja la linea de abajo sin comentar
        'VerTipoArch()



        LRutasComunes.AddRange({DirAtras(My.Computer.FileSystem.CurrentDirectory),
                                My.Computer.FileSystem.SpecialDirectories.Desktop,
                                My.Computer.FileSystem.SpecialDirectories.MyDocuments})
        'LRutasComunes.AddRange({"C:\Users\CGE\Documents\Visual Studio 2017\Projects\VB MisAbreviaturas o IDs\VB MisAbreviaturas o IDs\bin\Debug\BasesDeDatos"})
    End Sub

    Public Sub SetBlackListItem(ByVal FilePathOrName As String)
        BlackList.Add(System.IO.Path.GetFileName(FilePathOrName))
    End Sub
    Public Sub ClearBlackListItem()
        BlackList.Clear()
    End Sub

    Private Sub carpetaOarchivo(ByVal Ruta_ As String,
                                ByRef Carpeta As String,
                                ByRef ListView_A As ListView,
                                ByRef TB_Ruta_A As TextBox)
        Try
            If Directory.Exists(Ruta_) Then
                'MsgBox("Es carpeta " & NuevaRuta)
                Carpeta = Ruta_
                CargarEnListView(Carpeta, ListView1)
                TB_Ruta_A.Text = Carpeta
            ElseIf File.Exists(Ruta_) Then
                FileName = Ruta_
                'MsgBox("Se cierra el form y FileName = " & FileName)
#Region "Accion que se quiere con el archivo"
                RaiseEvent AbreArchivo(Ruta_)
#End Region
                'Me.Close()
            Else
                MsgBox("No se encontro la ruta especificada " & Ruta_)
            End If
        Catch ex As Exception
            MsgBox("Errror " & ex.Message)
        End Try
    End Sub

    Private Function CargarEnListView(ByVal Ruta_ As String, ByRef ListView_ As ListView) As Boolean
        Try
            FileSystemWatcher1.Path = Ruta_
            Dim DirInfo As DirectoryInfo =
                New DirectoryInfo(Ruta_)
            ListView_.Items.Clear()
            Dim subItems() As ListViewItem.ListViewSubItem
            Dim item As ListViewItem = Nothing

            Dim dir As DirectoryInfo
            For Each dir In DirInfo.GetDirectories()
                item = New ListViewItem(dir.Name, 0)
                subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "Directory"),
                New ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())}

                item.SubItems.AddRange(subItems)
                ListView_.Items.Add(item)
            Next dir
            Dim file As FileInfo
            For Each file In DirInfo.GetFiles()
                'MsgBox(System.IO.Path.GetExtension(file.Name))
                If System.IO.Path.GetExtension(file.Name) = ".db" Or Not CHB_TE.Checked Then
                    If BlackList.Contains(file.Name) Then ' And IsFilterBlackList 
                        Continue For
                    End If
                    item = New ListViewItem(file.Name, 1)
                    subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "File"),
                New ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())}
                    item.SubItems.AddRange(subItems)
                    ListView_.Items.Add(item)
                End If
            Next file
            Return True
        Catch ex As Exception
            MsgBox("Errror en ListView " & ex.Message)
            Return False
        End Try
    End Function
    Private Function DirAtras(ByVal Ruta_ As String) As String
        Dim RutaLeng_ As Integer = Ruta_.Length
        If RutaLeng_ > 3 Then
            For i As Integer = RutaLeng_ - 1 To 0 Step -1
                If Ruta_(i) = "\" Then
                    If RutaLeng_ - 1 = i Then
                        Ruta_ = Ruta_.Remove(i)
                    Else
                        Ruta_ = Ruta_.Remove(i)
                        Exit For
                    End If
                Else
                    Ruta_ = Ruta_.Remove(i)
                End If
            Next
            If Ruta_.Length < 3 And Ruta_.Length > 1 Then
                Ruta_ = Ruta_ & "\"
            End If

            Return Ruta_
        Else
            Return Ruta_
        End If
    End Function

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        CargaActualizacion()
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        CargaActualizacion()
    End Sub

    Private Sub FileSystemWatcher1_Deleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        CargaActualizacion()
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        CargaActualizacion()
    End Sub
    Private Sub CargaActualizacion()
        Ruta = Carpeta
        carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub

    Private Sub TB_Carpeta_Atras_Click(sender As Object, e As EventArgs) Handles TB_Carpeta_Atras.Click
        Ruta = DirAtras(Carpeta)
        carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim breakfast As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        For Each item As ListViewItem In breakfast
            Ruta = Carpeta
            EliminaUltimoSeparadorRuta(Ruta)

            Ruta = Ruta & "\" & item.SubItems(0).Text
            carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
        Next
    End Sub

    Private Sub BT_IrA_Click(sender As Object, e As EventArgs) Handles BT_IrA.Click

        Ruta = TB_Ruta.Text
        carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub

    Private Sub BT_Accion_Click(sender As Object, e As EventArgs) Handles BT_Accion.Click

        If BT_Accion.Text = "Abrir" Then
            Ruta = CombinaRutas(Carpeta, TextBox1.Text)
            carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
        ElseIf BT_Accion.Text = "Guardar" Then
            Dim Respuesta As String() = RutaDeDosOrigenes(TB_Ruta.Text, TextBox1.Text)
            If Respuesta(1) = "Ruta_A/Ruta_B" Then
                carpetaOarchivo(Respuesta(0), Carpeta, ListView1, TB_Ruta)
            End If
        End If

        'Dim Respuesta As String() = RutaDeDosOrigenes(TB_Ruta.Text, TextBox1.Text)
        'MsgBox(Respuesta(0) & "  " & Respuesta(1))

        'Ruta = TB_Ruta.Text
        'TextBox1.Text
        'carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub

    Private Function RutaDeDosOrigenes(ByVal Ruta_A As String, ByVal Ruta_B As String) As String()
        Dim R_A_Raiz As Boolean = True
        Dim R_B_Raiz As Boolean = True
        Dim Retorna As String = ""
        Dim R_A_CC As Boolean = True
        Dim R_B_CC As Boolean = True
        If Ruta_A.Length > 2 Then
            If EsLetra(Ruta_A(0)) Then R_A_Raiz = False
            If Ruta_A(1) <> ":" Then R_A_Raiz = False
            If Ruta_A(2) <> "\" Then R_A_Raiz = False
        ElseIf Ruta_A.Length > 0 Then
            R_A_Raiz = False
        Else
            R_A_CC = False
            R_A_Raiz = False
        End If

        If Ruta_B.Length > 2 Then
            If EsLetra(Ruta_B(0)) Then R_B_Raiz = False
            If Ruta_B(1) <> ":" Then R_B_Raiz = False
            If Ruta_B(2) <> "\" Then R_B_Raiz = False
        ElseIf Ruta_B.Length > 0 Then
            R_B_Raiz = False
        Else
            R_B_CC = False
            R_B_Raiz = False
        End If
        If R_A_Raiz = True And R_B_Raiz = False And R_B_CC = True Then
            Retorna = CombinaRutas(Ruta_A, Ruta_B)
            Return {Retorna, "Ruta_A/Ruta_B"}
        ElseIf R_A_Raiz = True And R_B_Raiz = False And R_B_CC = False Then
            EliminaUltimoSeparadorRuta(Ruta_A)
            Return {Ruta_A, "Ruta_A"}
        ElseIf R_A_Raiz = False And R_B_Raiz = True And R_A_CC = True Then
            Retorna = CombinaRutas(Ruta_B, Ruta_A)
            Return {Retorna, "Ruta_B/Ruta_A"}
        ElseIf R_A_Raiz = False And R_B_Raiz = True And R_A_CC = False Then
            EliminaUltimoSeparadorRuta(Ruta_B)
            Return {Ruta_B, "Ruta_B"}
        ElseIf R_A_Raiz = True And R_B_Raiz = True Then

            Return {"", "Ruta_A - Ruta_B"}
        Else
            Return {"", ""}
        End If
    End Function

    Private Function EsLetra(ByVal Char_ As Char) As Boolean
        If InStr(1, "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" & Chr(8), Char_) = 0 Then
            Return False
        Else
            Return False
        End If
    End Function
    Private Sub EliminaUltimoSeparadorRuta(ByRef Ruta_ As String)
        If Ruta_(Ruta_.Length - 1) = "\" Then
            Ruta_ = Ruta_.Remove(Ruta_.Length - 1)
        End If
    End Sub
    Private Function CombinaRutas(ByVal Ruta_Raiz, ByVal Ruta_Agregar) As String
        If Ruta_Raiz(Ruta_Raiz.Length - 1) = "\" Then
            Ruta_Raiz = Ruta_Raiz & Ruta_Agregar
        Else
            Ruta_Raiz = Ruta_Raiz & "\" & Ruta_Agregar
        End If
        Return Ruta_Raiz
    End Function

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Dim breakfast As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        For Each item As ListViewItem In breakfast
            TextBox1.Text = item.SubItems(0).Text
            NRuta = CombinaRutas(Carpeta, TextBox1.Text)
            If Directory.Exists(NRuta) Then
                BT_Accion.Text = "Abrir"
            ElseIf File.Exists(NRuta) Then
                BT_Accion.Text = "Abrir"
                'BT_Accion.Text = "Guardar"
            Else
                MsgBox("No se encontro la ruta especificada " & NRuta)
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        NRuta = CombinaRutas(Carpeta, TextBox1.Text)
        If Directory.Exists(NRuta) Then
            BT_Accion.Text = BT_Ac_Name_Folder
        ElseIf File.Exists(NRuta) Then
            BT_Accion.Text = BT_Ac_Name_File
        Else
            BT_Accion.Text = BT_Ac_Name_NotExist
        End If
    End Sub

    Private Sub CHB_TE_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_TE.CheckedChanged
        VerTipoArch()
    End Sub

    Private Sub VerTipoArch()
        If CHB_TE.Checked Then
            CHB_TE.Text = "*.db"
        Else
            CHB_TE.Text = "*.*"
        End If
        carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub
    Dim LRutasComunes As New List(Of String)
    Dim Numero As Integer = 0
    Private Sub BT_RutasComunes_Click(sender As Object, e As EventArgs) Handles BT_RutasComunes.Click
        Ruta = LRutasComunes(Numero)
        Numero += 1
        If Numero > LRutasComunes.Count - 1 Then
            Numero = 0
        End If
        carpetaOarchivo(Ruta, Carpeta, ListView1, TB_Ruta)
    End Sub
End Class
