﻿Public Class Invalid

    Private WithEvents tm As New Timer


    Private Sub Invalid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        Me.SetDesktopLocation(TimeClock.Location.X + 200, TimeClock.Location.Y + 100)
        tm.Interval = 1750
        tm.Start()
    End Sub


    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        Close()
    End Sub


    Public Overloads Sub Show(ByVal strMessage As String)
        lblInvalid.Text = strMessage
        Show()
    End Sub
End Class