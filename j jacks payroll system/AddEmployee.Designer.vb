<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.radNotAdmin = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Add New Employee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(474, 275)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(104, 26)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(153, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(491, 89)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(96, 13)
        Me.lblUserId.TabIndex = 13
        Me.lblUserId.Text = "Employee Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SSN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "First Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(298, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "State:"
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radAdmin.Location = New System.Drawing.Point(27, 19)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(53, 17)
        Me.radAdmin.TabIndex = 24
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = True
        '
        'radNotAdmin
        '
        Me.radNotAdmin.AutoSize = True
        Me.radNotAdmin.Checked = True
        Me.radNotAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radNotAdmin.Location = New System.Drawing.Point(27, 42)
        Me.radNotAdmin.Name = "radNotAdmin"
        Me.radNotAdmin.Size = New System.Drawing.Size(73, 17)
        Me.radNotAdmin.TabIndex = 25
        Me.radNotAdmin.TabStop = True
        Me.radNotAdmin.Text = "Not Admin"
        Me.radNotAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAdmin)
        Me.GroupBox1.Controls.Add(Me.radNotAdmin)
        Me.GroupBox1.Location = New System.Drawing.Point(593, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 67)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(82, 86)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(116, 20)
        Me.txtFName.TabIndex = 27
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(82, 146)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(116, 20)
        Me.txtSSN.TabIndex = 28
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(339, 116)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(116, 20)
        Me.txtAddress2.TabIndex = 29
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(339, 86)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(116, 20)
        Me.txtAddress1.TabIndex = 30
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(339, 143)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(116, 20)
        Me.txtCity.TabIndex = 31
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(82, 176)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(116, 20)
        Me.txtPhone.TabIndex = 32
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(82, 116)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(116, 20)
        Me.txtLName.TabIndex = 33
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(339, 179)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(116, 20)
        Me.txtState.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Zip:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(339, 210)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(116, 20)
        Me.txtZip.TabIndex = 36
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(593, 113)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(116, 20)
        Me.txtPassword.TabIndex = 37
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(593, 86)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(116, 20)
        Me.txtUserId.TabIndex = 38
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 324)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddEmployee"
        Me.ShowIcon = False
        Me.Text = "Hiring"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents radAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents radNotAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
End Class
