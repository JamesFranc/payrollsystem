Public Class TerminateEmployee


    Private Sub TerminateEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load employees to listbox
        Me.Location = AdminPage.Location
        Me.Show()
    End Sub

    Private Sub TerminateEmployee_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

#Region "Button Events"

    Private Sub btnAddTerm_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTerm.Click

    End Sub

    Private Sub btnRemoveTerm_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveTerm.Click

    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'ARE YOU SURE?
        'DELETE FROM lisEMployees
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        AdminPage.Location = Me.Location
        AdminPage.Show()

        Me.Hide()
    End Sub

#End Region

End Class