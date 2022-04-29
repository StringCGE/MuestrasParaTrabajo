Module Module1

    Class PSerial
        'Clases con eventos
        Private WithEvents Timer As New System.Windows.Forms.Timer()
        Private WithEvents Serial As New System.IO.Ports.SerialPort
        'Variables
        Public Puertos As Integer() = {300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400, 250000, 1382400, 3686400}
        Public BufferInSize As Integer = Serial.ReadBufferSize
        Dim BufferIn(BufferInSize) As Byte
        Dim BufferInCount As Integer = 0
        Dim Algo As Boolean = False
        Public Conectado As Boolean
        Public Puerto As String = ""
        Public Velocidad As Integer = 0
        Dim S_COM As String
        Dim P_COM As String

        'Controles
        Dim CB_Puerto As ComboBox
        Dim CB_Velocidad As ComboBox

        'Eventos
        Public Event SalidaBytes(ByVal Bytes As Byte(), ByVal Count As Integer)
        Public Event SeDesconecto()

        'Constructor
        Sub New(ByRef Msg As String,
                ByRef Puertos_ As ComboBox,
                ByRef Velocidad As ComboBox)
            CB_Puerto = Puertos_
            CB_Velocidad = Velocidad
            For Each Int As Integer In Puertos
                CB_Velocidad.Items.Add(Int)
            Next
            Timer.Interval = 800
            Timer.Start()
        End Sub

        Public Function Conectar()
            Try
                If Conectado = False Then
                    Velocidad = CB_Velocidad.SelectedItem
                    Puerto = CB_Puerto.SelectedItem
                    Serial.BaudRate = Velocidad
                    Serial.PortName = Puerto
                    Serial.Open()
                    Serial.DiscardInBuffer() : Serial.DiscardOutBuffer()
                    Conectado_(True)
                    Return True
                Else
                    Serial.Close()
                    Conectado_(False)
                    Return False
                End If

            Catch ex As Exception
                Conectado_(False)
                Return False
            End Try
        End Function
        Public Sub Desconectar()
            Try
                Serial.Close()
                Velocidad = 0
                Puerto = ""
            Catch ex As Exception
                Conectado_(False)
            End Try
        End Sub
        Private Sub Conectado_(Conectado As Boolean)
            Me.Conectado = Conectado
            If Me.Conectado Then
                'Timer.Stop() quito esto ya que no deja actualizar cuando esta conectado
            Else
                'Timer.Start()
                RaiseEvent SeDesconecto()
            End If
        End Sub
#Region "Comunicacion"
        Public Function Enviar(ByVal Texto As String) As Boolean
            If Texto <> "" Then
                Try
                    Serial.DiscardOutBuffer()
                    Serial.Write(Texto)
                Catch ex As Exception
                    Conectado_(False)
                    Return False
                End Try
            End If
            Return True
        End Function
        Public Function Enviar(ByVal Bytes As Byte(), Offset As Integer, Count As Integer) As Boolean
            Try
                Serial.DiscardOutBuffer()
                Serial.Write(Bytes, Offset, Count)
            Catch ex As Exception
                Conectado_(False)
                Return False
            End Try
            Return True
        End Function
        Private Sub Recibe(myObject As Object, ByVal myEventArgs As EventArgs) Handles Serial.DataReceived
            If Leer() Then
                RaiseEvent SalidaBytes(BufferIn, BufferInCount)
            End If
        End Sub
        Private Function Leer()
            Try
                BufferInCount = 0
                If Serial.BytesToRead > 0 Then
                    BufferInCount = Serial.Read(BufferIn, 0, BufferInSize)
                End If
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Conectado_(False)
                Return False
            End Try
        End Function
#End Region

        Public Sub SetearCB(Optional ByVal Puerto_ As String = "", Optional ByVal Baudio_ As Integer = 0)
            MonitorPuertos()
            If Baudio_ <> 0 Then
                CB_Velocidad.SelectedItem = Baudio_
            End If
            If Puerto_ <> "" Then
                CB_Puerto.SelectedItem = Puerto_
            End If
        End Sub
        Private Sub TimerTicks(myObject As Object, ByVal myEventArgs As EventArgs) Handles Timer.Tick
            MonitorPuertos()
        End Sub
        Private Sub MonitorPuertos()
            S_COM = ""
            For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
                S_COM = S_COM + PuertoDisponible
            Next
            If S_COM = P_COM Then
            Else
                CB_Puerto.Items.Clear()
                For Each PD As String In My.Computer.Ports.SerialPortNames
                    CB_Puerto.Items.Add(PD)
                Next
                P_COM = S_COM
                If CB_Puerto.Items.Count > 0 Then
                    If CB_Puerto.Items.Count > 1 Then
                        CB_Puerto.Text = CB_Puerto.Items(1)
                    Else
                        CB_Puerto.Text = CB_Puerto.Items(0)
                    End If
                    'MessageBox.Show("Perros al puerto")
                    CB_Puerto.Enabled = True
                Else
                    'MessageBox.Show("Perros fuera")
                    CB_Puerto.Enabled = False
                    CB_Puerto.Items.Clear()
                    CB_Puerto.Text = ""
                End If
                CB_Puerto.SelectedItem = Puerto
            End If
        End Sub
    End Class
End Module
