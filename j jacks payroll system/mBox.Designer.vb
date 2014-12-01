<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mBox
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
        Me.txtEmployeeNumber = New System.Windows.Forms.Label()
        Me.lblEmpNum = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.AutoSize = True
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(75, 53)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(66, 13)
        Me.txtEmployeeNumber.TabIndex = 10
        Me.txtEmployeeNumber.Text = "Employee #:"
        '
        'lblEmpNum
        '
        Me.lblEmpNum.AutoSize = True
        Me.lblEmpNum.Location = New System.Drawing.Point(147, 53)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpNum.TabIndex = 11
        Me.lblEmpNum.Text = "Employee #:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(172, 118)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(66, 24)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Time recorded at:"
        '
        'mBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpNum)
        Me.Controls.Add(Me.txtEmployeeNumber)
        Me.Name = "mBox"
        Me.Text = "Display Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmpNum As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
