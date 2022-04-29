Public Class ErrrorMsg
    Public Sub New(value As String)
        InitializeComponent()
        CargarMensage = value
    End Sub
    Public Property CargarMensage As String
        Get
            Return TB_ErrrorMsg.Text
        End Get
        Set(value As String)
            TB_ErrrorMsg.Text = value
        End Set
    End Property
    Private Sub ErrrorMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class