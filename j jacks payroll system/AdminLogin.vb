Public Class AdminLogin




    Private Sub AdminLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = TimeClock.Location
        Me.Show()
        txtUser.Focus()

        Timer1.Start()

    End Sub


    Private Sub btnTimeClock_Click(sender As Object, e As EventArgs) Handles btnTimeClock.Click

        TimeClock.Location = Me.Location
        TimeClock.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUser.Text = "12345" And txtPW.Text = "12345" Then
            AdminPage.Location = Me.Location
            AdminPage.Show()
            Me.Hide()
            txtUser.Text = ""
            txtPW.Text = ""
        Else
            MessageBox.Show("Wrong Password!")
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime2.Text = TimeOfDay.ToString("h:mm:ss")
    End Sub
End Class