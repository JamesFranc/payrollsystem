Public Class Timecard

    Dim lisSchedule As New List(Of Schedule)

    Private Sub Timecard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = AdminPage.Location

        Me.Show()

        txtUserID.Focus()
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
        Dim empDB As New EmployeeDB
        empDB.LoadDB()
        Dim intCounter = 0
        Dim intIndex = -1
        For Each tempSched As Schedule In lisSchedule
            If tempSched.userId.Equals(txtUserID.Text) Then
                intIndex = intCounter
            End If
            intCounter = intCounter + 1
        Next
        If intIndex <> -1 Then
            lisSchedule.RemoveAt(intIndex)

            Dim tempSched As New Schedule
            tempSched.Mon1 = txtMon1.Text
            tempSched.Mon2 = txtMon2.Text
            tempSched.Tue1 = txtTue1.Text
            tempSched.Tue2 = txtTue2.Text
            tempSched.Wed1 = txtWed1.Text
            tempSched.Wed2 = txtWed2.Text
            tempSched.Thu1 = txtThu1.Text
            tempSched.Thu2 = txtThu2.Text
            tempSched.Fri1 = txtFri1.Text
            tempSched.Fri2 = txtFri2.Text
            tempSched.Sat1 = txtSat1.Text
            tempSched.Sat2 = txtSat2.Text
            tempSched.Sun1 = txtSun1.Text
            tempSched.Sun2 = txtSun2.Text
            tempSched.userId = txtUserID.Text
            lisSchedule.Add(tempSched)


            If (empDB.search(txtUserID.Text)) Then
                updateHours()
            End If

        End If


        txtMon1.Text = "0.00"
        txtMon2.Text = "0.00"
        txtTue1.Text = "0.00"
        txtTue2.Text = "0.00"
        txtWed1.Text = "0.00"
        txtWed2.Text = "0.00"
        txtThu1.Text = "0.00"
        txtThu2.Text = "0.00"
        txtFri1.Text = "0.00"
        txtFri2.Text = "0.00"
        txtSat1.Text = "0.00"
        txtSat2.Text = "0.00"
        txtSun1.Text = "0.00"
        txtSun2.Text = "0.00"
        txtUserID.Text = ""

    End Sub


    Private Sub txtUserID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUserID.TextChanged
        Dim empDB As New EmployeeDB
        empDB.LoadDB()

        If (empDB.search(txtUserID.Text)) Then
            getHours()
        End If

    End Sub


    Private Sub getHours()
        For Each tempSched As Schedule In lisSchedule
            If (tempSched.userId.Equals(txtUserID.Text)) Then
                txtMon1.Text = tempSched.Mon1
                txtMon2.Text = tempSched.Mon2
                txtTue1.Text = tempSched.Tue1
                txtTue2.Text = tempSched.Tue2
                txtWed1.Text = tempSched.Wed1
                txtWed2.Text = tempSched.Wed2
                txtThu1.Text = tempSched.Thu1
                txtThu2.Text = tempSched.Thu2
                txtFri1.Text = tempSched.Fri1
                txtFri2.Text = tempSched.Fri2
                txtSat1.Text = tempSched.Sat1
                txtSat2.Text = tempSched.Sat2
                txtSun1.Text = tempSched.Sun1
                txtSun2.Text = tempSched.Sun2
            End If
        Next
    End Sub

    Private Sub updateHours()
        Dim fswHours As System.IO.StreamWriter
        fswHours = New System.IO.StreamWriter("Hours.csv", False)

        For Each tempSchedule As Schedule In lisSchedule
            fswHours.WriteLine(tempSchedule.userId & "," & _
                            tempSchedule.Mon1 & "," & _
                            tempSchedule.Tue1 & "," & _
                            tempSchedule.Wed1 & "," & _
                            tempSchedule.Thu1 & "," & _
                            tempSchedule.Fri1 & "," & _
                            tempSchedule.Sat1 & "," & _
                            tempSchedule.Sun1 & "," & _
                            tempSchedule.Mon2 & "," & _
                            tempSchedule.Tue2 & "," & _
                            tempSchedule.Wed2 & "," & _
                            tempSchedule.Thu2 & "," & _
                            tempSchedule.Fri2 & "," & _
                            tempSchedule.Sat2 & "," & _
                            tempSchedule.Sun2)

        Next
        fswHours.Close()

    End Sub

    Private Sub LoadData()


        Dim fsrHours As System.IO.StreamReader
        Dim strLine(15) As String

        fsrHours = New System.IO.StreamReader("Hours.csv")

        Do Until fsrHours.EndOfStream
            Dim tempSchedule As New Schedule
            strLine = Split(fsrHours.ReadLine, ",")
            tempSchedule.userId = strLine(0)
            tempSchedule.Mon1 = CInt(strLine(1))
            tempSchedule.Tue1 = CInt(strLine(2))
            tempSchedule.Wed1 = CInt(strLine(3))
            tempSchedule.Thu1 = CInt(strLine(4))
            tempSchedule.Fri1 = CInt(strLine(5))
            tempSchedule.Sat1 = CInt(strLine(6))
            tempSchedule.Sun1 = CInt(strLine(7))
            tempSchedule.Mon2 = CInt(strLine(8))
            tempSchedule.Tue2 = CInt(strLine(9))
            tempSchedule.Wed2 = CInt(strLine(10))
            tempSchedule.Thu2 = CInt(strLine(11))
            tempSchedule.Fri2 = CInt(strLine(12))
            tempSchedule.Sat2 = CInt(strLine(13))
            tempSchedule.Sun2 = CInt(strLine(14))

            lisSchedule.Add(tempSchedule)

        Loop

        fsrHours.Close()
    End Sub

    Public Class Schedule
        Dim strUserId As String
        Dim intMon1 As Double = 0.0
        Dim intTue1 As Double = 0.0
        Dim intWed1 As Double = 0.0
        Dim intThu1 As Double = 0.0
        Dim intFri1 As Double = 0.0
        Dim intSat1 As Double = 0.0
        Dim intSun1 As Double = 0.0
        Dim intMon2 As Double = 0.0
        Dim intTue2 As Double = 0.0
        Dim intWed2 As Double = 0.0
        Dim intThu2 As Double = 0.0
        Dim intFri2 As Double = 0.0
        Dim intSat2 As Double = 0.0
        Dim intSun2 As Double = 0.0

        Public Property userId() As String
            Get
                Return strUserId
            End Get
            Set(value As String)
                strUserId = value
            End Set
        End Property

        Public Property Mon1() As Double
            Get
                Return intMon1
            End Get
            Set(value As Double)
                intMon1 = value
            End Set
        End Property

        Public Property Tue1() As Double
            Get
                Return intTue1
            End Get
            Set(value As Double)
                intTue1 = value
            End Set
        End Property

        Public Property Wed1() As Double
            Get
                Return intWed1
            End Get
            Set(value As Double)
                intWed1 = value
            End Set
        End Property

        Public Property Thu1() As Double
            Get
                Return intThu1
            End Get
            Set(value As Double)
                intThu1 = value
            End Set
        End Property

        Public Property Fri1() As Double
            Get
                Return intFri1
            End Get
            Set(value As Double)
                intFri1 = value
            End Set
        End Property

        Public Property Sat1() As Double
            Get
                Return intSat1
            End Get
            Set(value As Double)
                intSat1 = value
            End Set
        End Property

        Public Property Sun1() As Double
            Get
                Return intSun1
            End Get
            Set(value As Double)
                intSun1 = value
            End Set
        End Property



        Public Property Mon2() As Double
            Get
                Return intMon2
            End Get
            Set(value As Double)
                intMon2 = value
            End Set
        End Property

        Public Property Tue2() As Double
            Get
                Return intTue2
            End Get
            Set(value As Double)
                intTue2 = value
            End Set
        End Property

        Public Property Wed2() As Double
            Get
                Return intWed2
            End Get
            Set(value As Double)
                intWed2 = value
            End Set
        End Property

        Public Property Thu2() As Double
            Get
                Return intThu2
            End Get
            Set(value As Double)
                intThu2 = value
            End Set
        End Property

        Public Property Fri2() As Double
            Get
                Return intFri2
            End Get
            Set(value As Double)
                intFri2 = value
            End Set
        End Property

        Public Property Sat2() As Double
            Get
                Return intSat2
            End Get
            Set(value As Double)
                intSat2 = value
            End Set
        End Property

        Public Property Sun2() As Double
            Get
                Return intSun2
            End Get
            Set(value As Double)
                intSun2 = value
            End Set
        End Property

    End Class



    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        LoadData()
        getHours()
    End Sub
End Class