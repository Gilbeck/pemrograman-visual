Public Class FrmLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets/Gambar Staff.png")

        ElseIf cmbRole.Text = "Manager" Then
            picImage.Image = Image.FromFile("Assets/Gambar Manajer.png")
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        Dim loginBerhasil As Boolean = False

        If role = "Staff" AndAlso nama = "Nadya" AndAlso nim = "241712051" Then
            loginBerhasil = True

        ElseIf role = "Manager" AndAlso nama = "Shata Diyaul Haq" AndAlso nim = "241712061" Then
            loginBerhasil = True
        End If

        If loginBerhasil Then
            FrmPajak.Show()
            Me.Hide()

            txtNama.Clear()
            txtNIM.Clear()

        Else
            MessageBox.Show("Masukkan Akun dengan Benar")
            txtNama.Focus()
        End If
    End Sub
End Class
