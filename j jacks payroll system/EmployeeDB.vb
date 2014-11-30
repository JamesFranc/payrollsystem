Public Class EmployeeDB


    Dim lisEmployees As New List(Of Employee)


    'loads employee info from file
    Public Sub LoadDB()
        Dim fsrEmployees As System.IO.StreamReader
        Dim strLine(12) As String

        fsrEmployees = New System.IO.StreamReader("Employees.csv")

        Do Until fsrEmployees.EndOfStream
            Dim tempEmp As New Employee
            strLine = Split(fsrEmployees.ReadLine, ",")

            tempEmp.userId = strLine(0)
            tempEmp.password = strLine(1)
            tempEmp.fName = strLine(2)
            tempEmp.lName = strLine(3)
            tempEmp.address1 = strLine(4)
            tempEmp.address2 = strLine(5)
            tempEmp.city = strLine(6)
            tempEmp.state = strLine(7)
            tempEmp.zip = strLine(8)
            tempEmp.phone = strLine(9)
            tempEmp.SSN = strLine(10)
            tempEmp.admin = CBool(strLine(11))

            lisEmployees.Add(tempEmp)

        Loop
        fsrEmployees.Close()
    End Sub

    'saves employee info to file
    Public Sub save()

        Dim fswEmployees As System.IO.StreamWriter
        fswEmployees = New System.IO.StreamWriter("Employees.csv", False)

        For Each tempEmp As Employee In lisEmployees
            fswEmployees.WriteLine(tempEmp.userId & "," & tempEmp.password & "," & _
                                   tempEmp.fName & "," & tempEmp.lName & "," & tempEmp.address1 & "," & _
                                   tempEmp.address2 & "," & tempEmp.city & "," * tempEmp.state & "," & _
                                   tempEmp.zip & "," & tempEmp.phone & "," & tempEmp.SSN & "," & tempEmp.admin)
        Next


    End Sub

    'Adds new employee
    Public Sub addEmp(ByVal strUserID As String, _
                            ByVal strPassword As String, _
                            ByVal strFName As String, _
                            ByVal strLName As String, _
                            ByVal strAddress1 As String, _
                            ByVal strAddress2 As String, _
                            ByVal strCity As String, _
                            ByVal strState As String, _
                            ByVal strZip As String, _
                            ByVal strPhone As String, _
                            ByVal strSSN As String,
                            ByVal blnAdmin As Boolean)
        Dim tempEmp As New Employee
        tempEmp.userId = strUserID
        tempEmp.password = strPassword
        tempEmp.fName = strFName
        tempEmp.lName = strLName
        tempEmp.address1 = strAddress1
        tempEmp.address2 = strAddress2
        tempEmp.city = strCity
        tempEmp.state = strState
        tempEmp.zip = strZip
        tempEmp.phone = strPhone
        tempEmp.SSN = strSSN
        tempEmp.address1 = blnAdmin
        lisEmployees.Add(tempEmp)
        save()

    End Sub

    'Another option for adding new Employee
    Public Sub addEmp(ByRef newEmployee As Employee)
        lisEmployees.Add(newEmployee)
        save()
    End Sub

    'update employee
    Public Sub updateEmp(ByVal strUserID As String, _
                         ByVal blnAdmin As Boolean, _
                            Optional ByVal strPassword As String = "", _
                            Optional ByVal strFName As String = "", _
                            Optional ByVal strLName As String = "", _
                            Optional ByVal strAddress1 As String = "", _
                            Optional ByVal strAddress2 As String = "", _
                            Optional ByVal strCity As String = "", _
                            Optional ByVal strState As String = "", _
                            Optional ByVal strZip As String = "", _
                            Optional ByVal strPhone As String = "", _
                            Optional ByVal strSSN As String = "")
        If (Not search(strUserID)) Then
            MessageBox.Show("User not found")
            Return
        End If

        Dim tempEmp As Employee = getEmployee(strUserID)
        terminateEmployee(strUserID)
        tempEmp.admin = blnAdmin

        If Not strPassword.Equals("") Then
            tempEmp.password = strPassword
        End If

        If Not strFName.Equals("") Then
            tempEmp.fName = strFName
        End If

        If Not strLName.Equals("") Then
            tempEmp.lName = strLName
        End If

        If Not strAddress1.Equals("") Then
            tempEmp.address1 = strAddress1
        End If

        If Not strAddress2.Equals("") Then
            tempEmp.address2 = strAddress2
        End If

        If Not strCity.Equals("") Then
            tempEmp.city = strCity
        End If

        If Not strState.Equals("") Then
            tempEmp.state = strState
        End If

        If Not strZip.Equals("") Then
            tempEmp.zip = strZip
        End If

        If Not strPhone.Equals("") Then
            tempEmp.phone = strPhone
        End If

        If Not strSSN.Equals("") Then
            tempEmp.SSN = strSSN
        End If

        lisEmployees.Add(tempEmp)
        save()

    End Sub


    'another oprion for update employee
    Public Sub updateEmp(ByRef newEmployee As Employee)

        If (Not search(newEmployee.userId)) Then
            MessageBox.Show("User not found")
            Return
        End If

        terminateEmployee(newEmployee.userId)

        addEmp(newEmployee)

    End Sub

    'employee returns true if employee found
    Public Function search(ByVal strUserId As String) As Boolean
        Dim blnResult As Boolean = False

        For Each tempEmp As Employee In lisEmployees
            If (tempEmp.userId.Equals(strUserId)) Then
                blnResult = True
            End If
        Next

        Return blnResult
    End Function

    'returns employee by employee id
    Public Function getEmployee(ByVal strUserId As String) As Employee
        For Each tempEmp As Employee In lisEmployees
            If (tempEmp.userId.Equals(strUserId)) Then
                Return tempEmp
            End If
        Next
        Return New Employee
    End Function

    'Deletes employee from list
    Public Sub terminateEmployee(ByVal strUserId As String)
        Dim intCounter As Integer = 0
        For Each tempEmp As Employee In lisEmployees
            If (tempEmp.userId.Equals(strUserId)) Then
                lisEmployees.RemoveAt(intCounter)
            End If
            intCounter = intCounter + 1
        Next
        save()
    End Sub



End Class
