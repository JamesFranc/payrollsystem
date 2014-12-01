Public Class Print
    Private WithEvents tm As New Timer


    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.SetDesktopLocation(TimeClock.Location.X + 200, TimeClock.Location.Y + 100)
        tm.Interval = 1750
        tm.Start()
    End Sub

    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        Close()
    End Sub


    Public Overloads Sub Show(ByVal strMessage As String, ByVal strName As String)
        lblTxt.Text = strMessage
        Me.Text = strName
        Show()
    End Sub
End Class