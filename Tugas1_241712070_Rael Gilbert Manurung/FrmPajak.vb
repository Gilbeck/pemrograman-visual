Public Class FrmPajak
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If txtPendapatan.Text = "" Then
            MessageBox.Show("Pendapatan harus diisi.")
            txtPendapatan.Focus()
            Return
        End If


        Dim pendapatan As Integer

        If Not Integer.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Pendapatan harus berupa angka.")
            txtPendapatan.Focus()
            Return
        End If

        If pendapatan < 0 Then
            MessageBox.Show("Pendapatan tidak boleh kurang dari 0.")
            txtPendapatan.Focus()
            Return
        End If


        Dim pajak As Integer

        If pendapatan <= 5000000 Then
            pajak = 0

        ElseIf pendapatan <= 20000000 Then
            pajak = pendapatan * 10 \ 100

        ElseIf pendapatan <= 100000000 Then
            pajak = pendapatan * 20 \ 100

        Else
            pajak = pendapatan * 30 \ 100
        End If


        MessageBox.Show("Pendapatan : Rp" & pendapatan & vbCrLf & "Total Pajak : Rp" & pajak)

    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class