Public Class LoginForm
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtUserName.Text = "Adzilla" And txtPass.Text = "123" Then
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Username or Password",, "Invalid Login")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If

    End Sub

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



End Class
