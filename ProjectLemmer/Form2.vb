Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" AndAlso txtPassword.Text = "admin" Then
            ' Login successful
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()

            Form1.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password")
        End If


    End Sub
End Class