Public Class AdminPage


    Private Sub AdminPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = AdminLogin.Location
        Me.Show()
        Timer1.Start()

    End Sub

    Private Sub btnTimeClock_Click(sender As Object, e As EventArgs) Handles btnTimeClock.Click
        TimeClock.Location = Me.Location
        TimeClock.Show()

        Me.Hide()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime3.Text = TimeOfDay.ToString("h:mm:ss")
    End Sub


    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click

    End Sub

    Private Sub btnCheque_Click(sender As Object, e As EventArgs) Handles btnCheque.Click
        frmPrint.Show("Cheques were sent to the bank!", "Checks Sent")
    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        frmPrint.Show("W2s sent to the default printer!", "W2s Printed")
    End Sub
End Class