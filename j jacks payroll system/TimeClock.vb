Public Class TimeClock

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTIme.Text = TimeOfDay.ToString("h:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnAdminUser_Click(sender As Object, e As EventArgs) Handles btnAdminUser.Click

        Me.Hide()
        AdminLogin.Show()

    End Sub


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "12345" Then
            txtEmployeeNumber.Show()
            dispEmployeeNumber.Text = txtUserName.Text
            dispEmployeeNumber.Show()



        Else
            MessageBox.Show("Wrong Password!")
        End If

    End Sub
End Class


