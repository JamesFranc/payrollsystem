<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.btnTimeClock = New System.Windows.Forms.Button()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnTimeClock
        '
        Me.btnTimeClock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnTimeClock.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTimeClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeClock.Location = New System.Drawing.Point(12, 318)
        Me.btnTimeClock.Name = "btnTimeClock"
        Me.btnTimeClock.Size = New System.Drawing.Size(90, 61)
        Me.btnTimeClock.TabIndex = 4
        Me.btnTimeClock.Text = "Time Clock"
        Me.btnTimeClock.UseVisualStyleBackColor = True
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(191, 186)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(56, 13)
        Me.lblPW.TabIndex = 1
        Me.lblPW.Text = "Password:"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(264, 186)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(215, 20)
        Me.txtPW.TabIndex = 2
        Me.txtPW.UseSystemPasswordChar = True
        '
        'btnSignIn
        '
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Location = New System.Drawing.Point(323, 212)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(89, 27)
        Me.btnSignIn.TabIndex = 3
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(189, 159)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "Username:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(264, 152)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(215, 20)
        Me.txtUser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "J Jacks Administration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(576, 355)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(66, 24)
        Me.lblTime2.TabIndex = 16
        Me.lblTime2.Text = "Label2"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(450, 355)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(120, 24)
        Me.lblCurrentTime.TabIndex = 15
        Me.lblCurrentTime.Text = "Current Time"
        '
        'Timer1
        '
        '
        'AdminLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnTimeClock
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnTimeClock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminLogin"
        Me.ShowIcon = False
        Me.Text = "Admin Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTimeClock As System.Windows.Forms.Button
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTime2 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
