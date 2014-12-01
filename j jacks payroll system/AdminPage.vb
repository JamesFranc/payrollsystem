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


    Private Sub btnTermEmployee_Click(sender As Object, e As System.EventArgs) Handles btnTermEmployee.Click
        TerminateEmployee.Location = Me.Location
        TerminateEmployee.Show()

        Me.Hide()
    End Sub


    Private Sub btnAddEmployee_Click(sender As Object, e As System.EventArgs) Handles btnAddEmployee.Click
        AddEmployee.Location = Me.Location
        AddEmployee.Show()

        Me.Hide()
    End Sub



    Private Sub btnManageTime_Click(sender As Object, e As System.EventArgs) Handles btnManageTime.Click
        Timecard.Location = Me.Location
        Timecard.Show()

        Me.Hide()
    End Sub
End Class