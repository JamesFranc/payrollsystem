Public Class mBox

    Private Property futureTime As Integer
    Private WithEvents tm As New Timer

    Private Sub mBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.DesktopLocation = New Point(150, 150)
        tm.Interval = 3000
        lblEmpNum.Text = TimeClock.txtUserName.Text
        lblTime.Text = TimeOfDay.ToString("h:mm:ss")
        tm.Start()
    End Sub

    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        Close()
    End Sub


End Class