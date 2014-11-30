<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeClock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdminUser = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtEmployeeNumber = New System.Windows.Forms.Label()
        Me.dispEmployeeNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Time"
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(576, 355)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(66, 24)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Label2"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(247, 163)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(215, 20)
        Me.txtUserName.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(158, 166)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(70, 13)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 78)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "J JACKS TIRE SERVICE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIME CLOCK"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdminUser
        '
        Me.btnAdminUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAdminUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminUser.Location = New System.Drawing.Point(12, 318)
        Me.btnAdminUser.Name = "btnAdminUser"
        Me.btnAdminUser.Size = New System.Drawing.Size(90, 61)
        Me.btnAdminUser.TabIndex = 3
        Me.btnAdminUser.Text = "Admin Login"
        Me.btnAdminUser.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Location = New System.Drawing.Point(310, 223)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(89, 27)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Clock In/Out"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.AutoSize = True
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(250, 104)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(0, 13)
        Me.txtEmployeeNumber.TabIndex = 9
        Me.txtEmployeeNumber.Visible = False
        '
        'dispEmployeeNumber
        '
        Me.dispEmployeeNumber.AutoSize = True
        Me.dispEmployeeNumber.Location = New System.Drawing.Point(316, 104)
        Me.dispEmployeeNumber.Name = "dispEmployeeNumber"
        Me.dispEmployeeNumber.Size = New System.Drawing.Size(0, 13)
        Me.dispEmployeeNumber.TabIndex = 10
        '
        'TimeClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.dispEmployeeNumber)
        Me.Controls.Add(Me.txtEmployeeNumber)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnAdminUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TimeClock"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TimeClock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAdminUser As System.Windows.Forms.Button
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.Label
    Friend WithEvents dispEmployeeNumber As System.Windows.Forms.Label

End Class
