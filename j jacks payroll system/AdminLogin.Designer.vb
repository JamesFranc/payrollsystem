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
        Me.btnTimeClock = New System.Windows.Forms.Button()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTimeClock
        '
        Me.btnTimeClock.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTimeClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeClock.Location = New System.Drawing.Point(12, 318)
        Me.btnTimeClock.Name = "btnTimeClock"
        Me.btnTimeClock.Size = New System.Drawing.Size(90, 61)
        Me.btnTimeClock.TabIndex = 6
        Me.btnTimeClock.Text = "Time Clock"
        Me.btnTimeClock.UseVisualStyleBackColor = True
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(191, 186)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(56, 13)
        Me.lblPW.TabIndex = 13
        Me.lblPW.Text = "Password:"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(264, 186)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(215, 20)
        Me.txtPW.TabIndex = 12
        Me.txtPW.UseSystemPasswordChar = True
        '
        'btnSignIn
        '
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Location = New System.Drawing.Point(327, 212)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(89, 27)
        Me.btnSignIn.TabIndex = 11
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(189, 155)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 10
        Me.lblUserName.Text = "Username:"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(264, 152)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(215, 20)
        Me.txtUserName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 39)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "J Jacks Administration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(576, 355)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(66, 24)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "Label2"
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
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnTimeClock)
        Me.Name = "AdminLogin"
        Me.Text = "Admin Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTimeClock As System.Windows.Forms.Button
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
End Class
