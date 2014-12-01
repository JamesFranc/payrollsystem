Public Class Timecard

    Private Sub Timecard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = AdminPage.Location
        Me.Show()
    End Sub



    Private Sub Timecard_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub


    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        AdminPage.Location = Me.Location
        AdminPage.Show()

        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'SUBMIT CHANGES
    End Sub
End Class