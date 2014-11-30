Public Class TimeClock

    Private Property futureTime As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeOfDay.ToString("h:mm:ss")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Application.OpenForms().OfType(Of Form).Any Then
            Me.Location = Location

        Else
            Dim f2 As New Form
            f2.Text = "form2"
            f2.Show()
        End If
        Me.DesktopLocation = New Point(100, 100)

        Timer1.Start()

    End Sub

    Private Sub btnAdminUser_Click(sender As Object, e As EventArgs) Handles btnAdminUser.Click

        Me.Hide()
        AdminLogin.Show()

    End Sub


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        
        If txtUserName.Text = "12345" Then

            mBox.Show()
            txtUserName.Text = ""
            btnLogIn.Focus()

        Else
            MessageBox.Show("Wrong Password!")
        End If

    End Sub




End Class


