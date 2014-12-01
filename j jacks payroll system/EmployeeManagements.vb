Public Class EmployeeManagements

    Private Sub ModifyEmployee_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub ModifyEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = AdminPage.Location
        Me.Show()

        HideLabels()
        HideTextBoxes()
        txtSearch.Focus()
    End Sub

    Public Sub HideLabels()
        lblA1.Visible = False
        lblA2.Visible = False
        lblCity.Visible = False
        lblFName.Visible = False
        lblLName.Visible = False
        lblPhone.Visible = False
        lblSSN.Visible = False
        lblState.Visible = False
        lblZip.Visible = False
        btnSave.Visible = False
    End Sub

    Public Sub HideTextBoxes()
        txtA1.Visible = False
        txtA2.Visible = False
        txtCity.Visible = False
        txtFName.Visible = False
        txtLName.Visible = False
        txtPhone.Visible = False
        txtState.Visible = False
        txtSSN.Visible = False
        txtZip.Visible = False
    End Sub

    Public Sub ShowLabels()
        lblA1.Visible = True
        lblA2.Visible = True
        lblCity.Visible = True
        lblFName.Visible = True
        lblLName.Visible = True
        lblPhone.Visible = True
        lblSSN.Visible = True
        lblState.Visible = True
        lblZip.Visible = True
    End Sub

    Public Sub ShowTextBoxes()
        txtA1.Visible = True
        txtA2.Visible = True
        txtCity.Visible = True
        txtFName.Visible = True
        txtLName.Visible = True
        txtPhone.Visible = True
        txtSSN.Visible = True
        txtState.Visible = True
        txtZip.Visible = True
        btnSave.Visible = True
    End Sub

    Public Sub PopulateTextBoxes()
        Dim oEmpDB As New EmployeeDB
        oEmpDB.LoadDB()
        Dim oEmp As New Employee
        oEmp = oEmpDB.getEmployee(CInt(txtSearch.Text))

        With oEmp
            txtA1.Text = .address1
            txtA2.Text = .address2
            txtCity.Text = .city
            txtFName.Text = .fName
            txtLName.Text = .lName
            txtPhone.Text = .phone
            txtSSN.Text = .SSN
            txtState.Text = .state
            txtZip.Text = .zip
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim oEmpDB As New EmployeeDB
        oEmpDB.LoadDB()
        If Not ContainsCharOrPunc(txtSearch.Text.ToString) Then
            If oEmpDB.search(txtSearch.Text.ToString) Then
                ShowLabels()
                PopulateTextBoxes()
                ShowTextBoxes()
            Else
                MessageBox.Show("The Employee ID " & txtSearch.Text.ToString & " could not be found.")
                txtSearch.Focus()
            End If
        Else
            MessageBox.Show("The Employee ID should only contain digits.")
            txtSearch.Focus()
        End If
    End Sub

    Public Function ContainsCharOrPunc(ByVal pEmpId As String) As Boolean
        For i = 0 To pEmpId.Length - 1
            If Char.IsLetter(pEmpId.Chars(i)) Then
                Return True
            ElseIf Char.IsPunctuation(pEmpId.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strEmpID As String = txtSearch.Text.ToString
        Dim oEmpDB As New EmployeeDB
        oEmpDB.LoadDB()
        If (oEmpDB.search(strEmpID)) Then
            Dim oEmp As New Employee
            oEmp = oEmpDB.getEmployee(strEmpID)
            Dim IsAdmin As Boolean = oEmp.admin
            oEmpDB.updateExisting(oEmp.userId.ToString, IsAdmin, oEmp.password.ToString, txtFName.Text.ToString, txtLName.Text.ToString, _
                                  txtA1.Text.ToString, txtA2.Text.ToString, txtCity.Text.ToString, txtState.Text.ToString, txtZip.Text.ToString, _
                                  txtPhone.Text.ToString, txtSSN.Text.ToString)
        End If
        MessageBox.Show(strEmpID & " has successfully been updated")
        HideLabels()
        HideTextBoxes()
        txtSearch.Clear()
        txtSearch.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HideLabels()
        HideTextBoxes()
        txtSearch.Clear()
        txtSearch.Focus()
        AdminPage.Location = Me.Location
        AdminPage.Show()

        Me.Hide()

    End Sub
End Class