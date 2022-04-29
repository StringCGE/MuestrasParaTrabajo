Module Module1
    Class alguito
        Sub algo()
            Dim lista As New List(Of Int16)
            lista.Add(45)
            lista.Add(12)
            lista.Add(1567)
            For Each val As Int16 In lista
                Debug.Print(val)
            Next
        End Sub
    End Class
End Module
