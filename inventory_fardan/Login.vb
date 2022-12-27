Public Class Login

    Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf TextBox1.Text = "fardan" And TextBox2.Text = "12355555" Then
            MsgBox("Login berhasil", MsgBoxStyle.Information, "Akses berhasil")
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Kombinasi Username dan Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
            Call Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
            ElseIf TextBox1.Text = "frrdann_" And TextBox2.Text = "12355555" Then
                MsgBox("Login berhasil", MsgBoxStyle.Information, "Akses berhasil")
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Kombinasi Username dan Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
                Call Clear()
                TextBox1.Focus()
            End If
        End If
    End Sub
End Class