Public Class TerminateEmployee

    Dim lisEmployees As List(Of Employee)

    Private Sub TerminateEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub TerminateEmployee_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

#Region "Button Events"

    Private Sub btnAddTerm_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTerm.Click
        If (Not IsNothing(lbCurrentlyEmployed.SelectedItem)) Then
            lbTerminated.Items.Add(lbCurrentlyEmployed.SelectedItem)
            lbCurrentlyEmployed.Items.Remove(lbCurrentlyEmployed.SelectedItem)
        End If
    End Sub

    Private Sub btnRemoveTerm_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveTerm.Click
        If (Not IsNothing(lbTerminated.SelectedItem)) Then
            lbCurrentlyEmployed.Items.Add(lbTerminated.SelectedItem)
            lbTerminated.Items.Remove(lbTerminated.SelectedItem)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'ARE YOU SURE?
        Dim empDB As New EmployeeDB
        empDB.LoadDB()

        For Each termEmp As String In lbTerminated.Items
            Dim tempEmp As New Employee
            tempEmp = empDB.getEmployeeByName(termEmp)
            empDB.terminateEmployee(tempEmp.userId)
        Next
        lisEmployees = empDB.getEmployeeList
        lbCurrentlyEmployed.Items.Clear()
        lbTerminated.Items.Clear()
        LoadForm()
        AdminPage.Location = Me.Location
        AdminPage.Show()

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        AdminPage.Location = Me.Location
        AdminPage.Show()
        Me.Hide()
    End Sub

#End Region

    Private Sub LoadForm()
        'Load employees to listbox
        Dim empDB As New EmployeeDB
        empDB.LoadDB()
        lbCurrentlyEmployed.Items.Clear()
        lbTerminated.Items.Clear()

        lisEmployees = empDB.getEmployeeList
        For Each tempEmp As Employee In lisEmployees
            lbCurrentlyEmployed.Items.Add(tempEmp.lName & ", " & tempEmp.fName)
        Next
        Me.Location = AdminPage.Location
        Me.Show()
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        LoadForm()
    End Sub

End Class