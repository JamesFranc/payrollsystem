Public Class AddEmployee


    Private Sub AddEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = AdminPage.Location
        Me.Show()
    End Sub

    Private Sub AddEmployee_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub



    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'check fields
        If txtFName.Text.Trim.Equals("") Then
            'error no first name entered            
            Invalid.Show("No First Name entered")
            Return
        End If

        If txtLName.Text.Trim.Equals("") Then
            'error no last name entered
            Invalid.Show("No Last Name entered")
            Return
        End If

        If txtAddress1.Text.Trim.Equals("") Then
            'error no address entered
            Invalid.Show("No Address entered")
            Return
        End If

        If txtSSN.Text.Trim.Equals("") Then
            'error no SSN entered            
            Invalid.Show("No SSN entered")
            Return
        End If

        If txtPhone.Text.Trim.Equals("") Then
            'error no phone entered
            Invalid.Show("No Phone Number entered")
            Return
        End If

        If txtCity.Text.Trim.Equals("") Then
            'error no city entered
            Invalid.Show("No City entered")
            Return
        End If

        If txtState.Text.Trim.Equals("") Then
            'error no state entered
            Invalid.Show("No State entered")
            Return
        End If

        If txtZip.Text.Trim.Equals("") Then
            'error no zip entered
            Invalid.Show("No Zip Code entered")
            Return
        End If

        If txtUserId.Text.Trim.Equals("") Then
            'error no userId entered
            Invalid.Show("No UserId entered")
            Return
        End If

        Dim empDB As New EmployeeDB
        empDB.LoadDB()

        If (empDB.search(txtUserId.Text)) Then
            'error user id already taken
            Invalid.Show("UserID already exists")
            Return
        End If

        If txtPassword.Text.Trim.Equals("") Then
            'error no password entered
            Invalid.Show("No Password entered")
            Return
        End If


        Dim tempEmp As New Employee
        tempEmp.fName = txtFName.Text.Trim
        tempEmp.lName = txtLName.Text.Trim
        tempEmp.address1 = txtAddress1.Text.Trim
        tempEmp.address2 = txtAddress2.Text.Trim
        tempEmp.city = txtCity.Text.Trim
        tempEmp.password = txtPassword.Text.Trim
        tempEmp.phone = txtPhone.Text.Trim
        tempEmp.SSN = txtSSN.Text.Trim
        tempEmp.state = txtState.Text.Trim
        tempEmp.userId = txtUserId.Text.Trim
        tempEmp.zip = txtZip.Text.Trim

        If radAdmin.Checked Then
            tempEmp.admin = True
        Else
            tempEmp.admin = False
        End If

        'clear forms
        txtFName.Text = ""
        txtLName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtSSN.Text = ""
        txtState.Text = ""
        txtUserId.Text = ""
        txtZip.Text = ""
        radNotAdmin.Checked = True


        empDB.addEmp(tempEmp)


        AdminPage.Location = Me.Location
        AdminPage.Show()
        Me.Hide()



    End Sub


    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        AdminPage.Location = Me.Location
        AdminPage.Show()

        Me.Hide()
    End Sub



    Private Sub radAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radAdmin.CheckedChanged
        If radAdmin.Checked = True Then
            radNotAdmin.Checked = False
        Else
            radNotAdmin.Checked = True
        End If
    End Sub


    Private Sub radNotAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radNotAdmin.CheckedChanged
        If radNotAdmin.Checked = True Then
            radAdmin.Checked = False
        Else
            radAdmin.Checked = True
        End If
    End Sub

End Class