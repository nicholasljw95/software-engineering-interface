Public Class Login
    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "1" And txtPassword.Text = "111" Then
            AdminPage.ShowDialog()
        ElseIf txtUsername.Text = "2" And txtPassword.Text = "222" Then
            CustomerHomePage.ShowDialog()
        ElseIf txtUsername.Text = "3" And txtPassword.Text = "333" Then
            ' WaiterHomepage.ShowDialog()
        Else
            MsgBox("Invalid login.")
        End If
    End Sub
End Class