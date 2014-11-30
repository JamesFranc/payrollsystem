<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.btnManageTime = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnTax = New System.Windows.Forms.Button()
        Me.btnTimeClock = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTIme = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageEmployee.Location = New System.Drawing.Point(247, 85)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(165, 23)
        Me.btnManageEmployee.TabIndex = 0
        Me.btnManageEmployee.Text = "Employee Management"
        Me.btnManageEmployee.UseVisualStyleBackColor = True
        '
        'btnManageTime
        '
        Me.btnManageTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageTime.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnManageTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageTime.Location = New System.Drawing.Point(247, 146)
        Me.btnManageTime.Name = "btnManageTime"
        Me.btnManageTime.Size = New System.Drawing.Size(165, 23)
        Me.btnManageTime.TabIndex = 1
        Me.btnManageTime.Text = "Manage Timesheets"
        Me.btnManageTime.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCheque.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheque.Location = New System.Drawing.Point(247, 207)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(165, 23)
        Me.btnCheque.TabIndex = 2
        Me.btnCheque.Text = "Print Cheques"
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'btnTax
        '
        Me.btnTax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTax.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTax.Location = New System.Drawing.Point(247, 268)
        Me.btnTax.Name = "btnTax"
        Me.btnTax.Size = New System.Drawing.Size(165, 23)
        Me.btnTax.TabIndex = 3
        Me.btnTax.Text = "Print W2s"
        Me.btnTax.UseVisualStyleBackColor = True
        '
        'btnTimeClock
        '
        Me.btnTimeClock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTimeClock.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTimeClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeClock.Location = New System.Drawing.Point(12, 304)
        Me.btnTimeClock.Name = "btnTimeClock"
        Me.btnTimeClock.Size = New System.Drawing.Size(90, 75)
        Me.btnTimeClock.TabIndex = 4
        Me.btnTimeClock.Text = "Time Clock"
        Me.btnTimeClock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Time:"
        '
        'lblTIme
        '
        Me.lblTIme.AutoSize = True
        Me.lblTIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIme.Location = New System.Drawing.Point(599, 443)
        Me.lblTIme.Name = "lblTIme"
        Me.lblTIme.Size = New System.Drawing.Size(66, 24)
        Me.lblTIme.TabIndex = 6
        Me.lblTIme.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Current Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(512, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "J Jacks Payroll Administration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTIme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTimeClock)
        Me.Controls.Add(Me.btnTax)
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.btnManageTime)
        Me.Controls.Add(Me.btnManageEmployee)
        Me.Name = "AdminPage"
        Me.Text = "J. Jacks Administration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnManageEmployee As System.Windows.Forms.Button
    Friend WithEvents btnManageTime As System.Windows.Forms.Button
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents btnTax As System.Windows.Forms.Button
    Friend WithEvents btnTimeClock As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTIme As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
