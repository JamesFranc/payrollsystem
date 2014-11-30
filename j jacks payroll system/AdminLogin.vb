Public Class AdminLogin


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = TimeClock.Location

    End Sub

    Private Sub btnTimeClock_Click(sender As Object, e As EventArgs) Handles btnTimeClock.Click
        'If lblPW.Visible = False Then
        'lblUserName.Text = "Admin Number:"
        'lblPW.Visible = True
        'txtPW.Visible = True
        'btnAdminUser.Text = "Time Clock"
        'txtUserName.Focus()
        'Else
        'lblUserName.Text = "Employee ID:"
        'lblPW.Visible = False
        'txtPW.Visible = False
        'btnAdminUser.Text = "Admin Login"
        'txtUserName.Focus()
        'End If
        Me.Close()
        TimeClock.Show()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUserName.Text = "12345" And txtPW.Text = "12345" Then
            Me.Close()
            AdminPage.Show()

        Else
            MessageBox.Show("Wrong Password!")
        End If

    End Sub



End Class