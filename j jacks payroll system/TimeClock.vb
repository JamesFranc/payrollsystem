Public Class TimeClock


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeOfDay.ToString("h:mm:ss")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DesktopLocation = New Point(100, 100)
        Me.txtUserName.Focus()

        Timer1.Start()

    End Sub

    Private Sub btnAdminUser_Click(sender As Object, e As EventArgs) Handles btnAdminUser.Click

        AdminLogin.Show()
        AdminLogin.Location = Me.Location
        AdminLogin.txtUser.Focus()

        Me.Hide()

    End Sub


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim EmpDB As New EmployeeDB
        EmpDB.LoadDB()

        If (EmpDB.search(txtUserName.Text)) Then
            Dim tempEmp As Employee = EmpDB.getEmployee(txtUserName.Text)

            mBox.Show()
            txtUserName.Text = ""
            txtUserName.Focus()

        Else
            'MessageBox.Show("Wrong Username!")
            Invalid.Show("Wrong Username")
        End If


    End Sub

    Private Sub TimeClock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub




End Class


