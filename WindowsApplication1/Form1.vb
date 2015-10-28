Public Class Form1

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        Dim tb As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(tb.Text)) Then
            tb.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim tb As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(tb.Text)) Then
            tb.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = ("login")and txtPassword.Text = ("abc123")Then
            MessageBox.Show("帳號密碼正確")
        Else
            MessageBox.Show("帳號密碼錯誤或未輸入完成!")
        End If
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
