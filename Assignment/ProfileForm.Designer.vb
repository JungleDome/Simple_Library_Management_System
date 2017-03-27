<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbContact = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.lbID2 = New System.Windows.Forms.Label()
        Me.lbName2 = New System.Windows.Forms.Label()
        Me.lbContact2 = New System.Windows.Forms.Label()
        Me.lbEmail2 = New System.Windows.Forms.Label()
        Me.lbType2 = New System.Windows.Forms.Label()
        Me.dgvProfile = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(629, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbID
        '
        Me.lbID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbID.Location = New System.Drawing.Point(13, 84)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(100, 15)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "Member ID"
        '
        'lbName
        '
        Me.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbName.Location = New System.Drawing.Point(13, 113)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(100, 15)
        Me.lbName.TabIndex = 2
        Me.lbName.Text = "MemberName"
        '
        'lbContact
        '
        Me.lbContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbContact.Location = New System.Drawing.Point(13, 142)
        Me.lbContact.Name = "lbContact"
        Me.lbContact.Size = New System.Drawing.Size(100, 15)
        Me.lbContact.TabIndex = 3
        Me.lbContact.Text = "Contact Number"
        '
        'lbEmail
        '
        Me.lbEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmail.Location = New System.Drawing.Point(13, 173)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(100, 15)
        Me.lbEmail.TabIndex = 4
        Me.lbEmail.Text = "Email Address"
        '
        'lbType
        '
        Me.lbType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbType.Location = New System.Drawing.Point(13, 200)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(100, 15)
        Me.lbType.TabIndex = 5
        Me.lbType.Text = "Status Type"
        '
        'lbID2
        '
        Me.lbID2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbID2.Location = New System.Drawing.Point(132, 84)
        Me.lbID2.Name = "lbID2"
        Me.lbID2.Size = New System.Drawing.Size(300, 15)
        Me.lbID2.TabIndex = 6
        '
        'lbName2
        '
        Me.lbName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbName2.Location = New System.Drawing.Point(132, 113)
        Me.lbName2.Name = "lbName2"
        Me.lbName2.Size = New System.Drawing.Size(300, 15)
        Me.lbName2.TabIndex = 7
        '
        'lbContact2
        '
        Me.lbContact2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbContact2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbContact2.Location = New System.Drawing.Point(132, 142)
        Me.lbContact2.Name = "lbContact2"
        Me.lbContact2.Size = New System.Drawing.Size(300, 15)
        Me.lbContact2.TabIndex = 8
        '
        'lbEmail2
        '
        Me.lbEmail2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmail2.Location = New System.Drawing.Point(132, 173)
        Me.lbEmail2.Name = "lbEmail2"
        Me.lbEmail2.Size = New System.Drawing.Size(300, 15)
        Me.lbEmail2.TabIndex = 9
        '
        'lbType2
        '
        Me.lbType2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbType2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbType2.Location = New System.Drawing.Point(132, 200)
        Me.lbType2.Name = "lbType2"
        Me.lbType2.Size = New System.Drawing.Size(300, 15)
        Me.lbType2.TabIndex = 10
        '
        'dgvProfile
        '
        Me.dgvProfile.AllowUserToAddRows = False
        Me.dgvProfile.AllowUserToDeleteRows = False
        Me.dgvProfile.AllowUserToOrderColumns = True
        Me.dgvProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProfile.Location = New System.Drawing.Point(13, 229)
        Me.dgvProfile.Name = "dgvProfile"
        Me.dgvProfile.ReadOnly = True
        Me.dgvProfile.Size = New System.Drawing.Size(604, 215)
        Me.dgvProfile.TabIndex = 11
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 456)
        Me.Controls.Add(Me.dgvProfile)
        Me.Controls.Add(Me.lbType2)
        Me.Controls.Add(Me.lbEmail2)
        Me.Controls.Add(Me.lbContact2)
        Me.Controls.Add(Me.lbName2)
        Me.Controls.Add(Me.lbID2)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbContact)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProfileForm"
        Me.Text = "ProfileForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbID As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbContact As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbType As Label
    Friend WithEvents lbID2 As Label
    Friend WithEvents lbName2 As Label
    Friend WithEvents lbContact2 As Label
    Friend WithEvents lbEmail2 As Label
    Friend WithEvents lbType2 As Label
    Friend WithEvents dgvProfile As DataGridView
End Class
