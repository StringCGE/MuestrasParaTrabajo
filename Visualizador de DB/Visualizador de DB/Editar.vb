Public Class Editar
    Public DesdeArchivo As Boolean = False
    Private Sub Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesdeArchivo = False
    End Sub

    Private Sub BT_Agregar_Click(sender As Object, e As EventArgs) Handles BT_Agregar.Click
        DesdeArchivo = False
        Dim Ya As Boolean = True
        Dim Comando As String = ""
        Comando = "insert into " & Form1.Ultabla & " values('"
        For Each Reg As Registros In FLP_.Controls
            If Reg.RTB_.Text <> "__Auto__" Then
                If Ya Then
                    Ya = False
                Else
                    Comando = Comando & ", '"
                End If
                Comando = Comando & Reg.RTB_.Text & "'"
            End If
        Next
        Comando = Comando & ");"
        Form1.DBDB_.CSR(Comando)
        TB_ComandoSQL.Text = Comando
        For Each Reg As Registros In FLP_.Controls
            Reg.RTB_.Text = ""
        Next
        If Form1.Ultima <> "" Then
            Me.Text = Form1.Ultabla
            Form1.Cargar(Form1.Ultima)
        End If

    End Sub

    Private Sub BT_AgregarDesdeArchivo_Click(sender As Object, e As EventArgs) Handles BT_AgregarDesdeArchivo.Click
        DesdeArchivo = True
        Me.Close()
    End Sub
End Class