<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyEmployee
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
        Me.lblJJacks = New System.Windows.Forms.Label()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblJJacks
        '
        Me.lblJJacks.AutoSize = True
        Me.lblJJacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJJacks.Location = New System.Drawing.Point(164, 11)
        Me.lblJJacks.Name = "lblJJacks"
        Me.lblJJacks.Size = New System.Drawing.Size(556, 52)
        Me.lblJJacks.TabIndex = 0
        Me.lblJJacks.Text = "J. JACK'S TIRE SERVICE"
        Me.lblJJacks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(329, 63)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(221, 31)
        Me.lblModEmp.TabIndex = 0
        Me.lblModEmp.Text = "Modify Employee"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(157, 166)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(76, 17)
        Me.lblFName.TabIndex = 1
        Me.lblFName.Text = "First Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(157, 217)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(76, 17)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name"
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Location = New System.Drawing.Point(161, 266)
        Me.lblA1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(72, 17)
        Me.lblA1.TabIndex = 3
        Me.lblA1.Text = "Address 1"
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Location = New System.Drawing.Point(161, 317)
        Me.lblA2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(72, 17)
        Me.lblA2.TabIndex = 4
        Me.lblA2.Text = "Address 2"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(515, 166)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(505, 214)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(481, 266)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(65, 17)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip Code"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(443, 317)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(103, 17)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Number"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(240, 163)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(180, 22)
        Me.txtFName.TabIndex = 9
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(240, 214)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(180, 22)
        Me.txtLName.TabIndex = 10
        '
        'txtA1
        '
        Me.txtA1.Location = New System.Drawing.Point(240, 263)
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(180, 22)
        Me.txtA1.TabIndex = 11
        '
        'txtA2
        '
        Me.txtA2.Location = New System.Drawing.Point(240, 314)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(180, 22)
        Me.txtA2.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(553, 163)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 22)
        Me.txtCity.TabIndex = 13
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(553, 214)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(180, 22)
        Me.txtState.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(553, 263)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(180, 22)
        Me.txtZip.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(553, 314)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(180, 22)
        Me.txtPhone.TabIndex = 16
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(237, 125)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(136, 17)
        Me.lblSearch.TabIndex = 17
        Me.lblSearch.Text = "Search Employee ID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(379, 122)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 22)
        Me.txtSearch.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(326, 401)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 40)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(466, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(565, 118)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 30)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(197, 362)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(36, 17)
        Me.lblSSN.TabIndex = 22
        Me.lblSSN.Text = "SSN"
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(240, 359)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(180, 22)
        Me.txtSSN.TabIndex = 23
        '
        'ModifyEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 474)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtA2)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblA2)
        Me.Controls.Add(Me.lblA1)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.lblJJacks)
        Me.Name = "ModifyEmployee"
        Me.Text = "Modify Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJJacks As System.Windows.Forms.Label
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtA1 As System.Windows.Forms.TextBox
    Friend WithEvents txtA2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
End Class
