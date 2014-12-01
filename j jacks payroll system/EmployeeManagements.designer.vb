<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagements
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJJacks
        '
        Me.lblJJacks.AutoSize = True
        Me.lblJJacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJJacks.Location = New System.Drawing.Point(109, 12)
        Me.lblJJacks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJJacks.Name = "lblJJacks"
        Me.lblJJacks.Size = New System.Drawing.Size(442, 39)
        Me.lblJJacks.TabIndex = 0
        Me.lblJJacks.Text = "J. JACK'S TIRE SERVICE"
        Me.lblJJacks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(194, 51)
        Me.lblModEmp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(243, 26)
        Me.lblModEmp.TabIndex = 0
        Me.lblModEmp.Text = "Employee Management"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(118, 135)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 1
        Me.lblFName.Text = "First Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(118, 176)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name"
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Location = New System.Drawing.Point(121, 216)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(54, 13)
        Me.lblA1.TabIndex = 3
        Me.lblA1.Text = "Address 1"
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Location = New System.Drawing.Point(121, 258)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(54, 13)
        Me.lblA2.TabIndex = 4
        Me.lblA2.Text = "Address 2"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(386, 135)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(379, 174)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(361, 216)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(50, 13)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip Code"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(332, 258)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Number"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(180, 132)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(136, 20)
        Me.txtFName.TabIndex = 3
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(180, 174)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(136, 20)
        Me.txtLName.TabIndex = 4
        '
        'txtA1
        '
        Me.txtA1.Location = New System.Drawing.Point(180, 214)
        Me.txtA1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(136, 20)
        Me.txtA1.TabIndex = 5
        '
        'txtA2
        '
        Me.txtA2.Location = New System.Drawing.Point(180, 255)
        Me.txtA2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(136, 20)
        Me.txtA2.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(415, 132)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(136, 20)
        Me.txtCity.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(415, 174)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(136, 20)
        Me.txtState.TabIndex = 8
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(415, 214)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(136, 20)
        Me.txtZip.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(415, 255)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(136, 20)
        Me.txtPhone.TabIndex = 10
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(178, 102)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(104, 13)
        Me.lblSearch.TabIndex = 17
        Me.lblSearch.Text = "Search Employee ID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(284, 99)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(335, 342)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 32)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(436, 99)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(148, 294)
        Me.lblSSN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(29, 13)
        Me.lblSSN.TabIndex = 22
        Me.lblSSN.Text = "SSN"
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(180, 292)
        Me.txtSSN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(136, 20)
        Me.txtSSN.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(507, 99)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(58, 24)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'EmployeeManagements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(652, 385)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeManagements"
        Me.ShowIcon = False
        Me.Text = "Employee Management"
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
