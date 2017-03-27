<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.lbMemberID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.tbMemberID = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbViewPass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lbMemberID
        '
        Me.lbMemberID.AutoSize = True
        Me.lbMemberID.Location = New System.Drawing.Point(28, 63)
        Me.lbMemberID.Name = "lbMemberID"
        Me.lbMemberID.Size = New System.Drawing.Size(59, 13)
        Me.lbMemberID.TabIndex = 0
        Me.lbMemberID.Text = "Member ID"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(30, 100)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(53, 13)
        Me.lbPassword.TabIndex = 2
        Me.lbPassword.Text = "Password"
        '
        'tbMemberID
        '
        Me.tbMemberID.Location = New System.Drawing.Point(156, 60)
        Me.tbMemberID.Name = "tbMemberID"
        Me.tbMemberID.Size = New System.Drawing.Size(100, 20)
        Me.tbMemberID.TabIndex = 0
        '
        'tbPassword
        '
        Me.tbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbPassword.Location = New System.Drawing.Point(156, 97)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbPassword.TabIndex = 2
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(45, 135)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(160, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cbViewPass
        '
        Me.cbViewPass.AutoSize = True
        Me.cbViewPass.Location = New System.Drawing.Point(157, 118)
        Me.cbViewPass.Name = "cbViewPass"
        Me.cbViewPass.Size = New System.Drawing.Size(98, 17)
        Me.cbViewPass.TabIndex = 5
        Me.cbViewPass.Text = "View Password"
        Me.cbViewPass.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(284, 170)
        Me.Controls.Add(Me.cbViewPass)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbMemberID)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbMemberID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMemberID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents tbMemberID As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbViewPass As CheckBox
End Class
