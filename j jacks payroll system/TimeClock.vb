Public Class TimeClock


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeOfDay.ToString("h:mm:ss")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DesktopLocation = New Point(100, 100)
        Me.txtUserName.Focus()

        Timer1.Start()

    End Sub

    Private Sub btnAdminUser_Click(sender As Object, e As EventArgs) Handles btnAdminUser.Click

        AdminLogin.Show()
        AdminLogin.Location = Me.Location
        Me.Hide()

    End Sub


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        
        If txtUserName.Text = "12345" Then

            mBox.Show()
            txtUserName.Text = ""
            txtUserName.Focus()

        Else
            Invalid.Show()
        End If

    End Sub

    Private Sub TimeClock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub




End Class


