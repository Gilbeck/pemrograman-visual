Module ModArray
    Public Sub TampilkanPesan(nama As String)
        MessageBox.Show("Hallo " & nama)
    End Sub

    Function Hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang <= 50 Then
            Return 2 * (panjang + lebar)

        Else
            Return panjang * lebar
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90, 100}
    Public nilai2D(,) As Integer = {
        {55, 58, 60},
        {65, 67, 69},
        {78, 85, 90}
    }
End Module
