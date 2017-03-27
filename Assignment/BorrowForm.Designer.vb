<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowForm
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
        Me.gbBook = New System.Windows.Forms.GroupBox()
        Me.lbDuration2 = New System.Windows.Forms.Label()
        Me.lbType2 = New System.Windows.Forms.Label()
        Me.lbDuration = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.lbISBN = New System.Windows.Forms.Label()
        Me.lbPublisher = New System.Windows.Forms.Label()
        Me.lbPublisher2 = New System.Windows.Forms.Label()
        Me.lbYear2 = New System.Windows.Forms.Label()
        Me.lbAuthor2 = New System.Windows.Forms.Label()
        Me.lbEdition2 = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.lbEdition = New System.Windows.Forms.Label()
        Me.lbAuthor = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbLoan = New System.Windows.Forms.GroupBox()
        Me.lbLoanID2 = New System.Windows.Forms.Label()
        Me.lbExpiryDate2 = New System.Windows.Forms.Label()
        Me.lbReturnDate2 = New System.Windows.Forms.Label()
        Me.lbReturnDate = New System.Windows.Forms.Label()
        Me.lbExpiryDate = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbID2 = New System.Windows.Forms.Label()
        Me.lbLoanID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbISBN = New System.Windows.Forms.ComboBox()
        Me.gbBook.SuspendLayout()
        Me.gbLoan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBook
        '
        Me.gbBook.Controls.Add(Me.cbISBN)
        Me.gbBook.Controls.Add(Me.lbDuration2)
        Me.gbBook.Controls.Add(Me.lbType2)
        Me.gbBook.Controls.Add(Me.lbDuration)
        Me.gbBook.Controls.Add(Me.lbType)
        Me.gbBook.Controls.Add(Me.lbISBN)
        Me.gbBook.Controls.Add(Me.lbPublisher)
        Me.gbBook.Controls.Add(Me.lbPublisher2)
        Me.gbBook.Controls.Add(Me.lbYear2)
        Me.gbBook.Controls.Add(Me.lbAuthor2)
        Me.gbBook.Controls.Add(Me.lbEdition2)
        Me.gbBook.Controls.Add(Me.lbYear)
        Me.gbBook.Controls.Add(Me.lbEdition)
        Me.gbBook.Controls.Add(Me.lbAuthor)
        Me.gbBook.Location = New System.Drawing.Point(0, 175)
        Me.gbBook.Name = "gbBook"
        Me.gbBook.Size = New System.Drawing.Size(584, 235)
        Me.gbBook.TabIndex = 20
        Me.gbBook.TabStop = False
        Me.gbBook.Text = "Book Details"
        '
        'lbDuration2
        '
        Me.lbDuration2.AutoSize = True
        Me.lbDuration2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDuration2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbDuration2.Location = New System.Drawing.Point(403, 97)
        Me.lbDuration2.Name = "lbDuration2"
        Me.lbDuration2.Size = New System.Drawing.Size(2, 15)
        Me.lbDuration2.TabIndex = 21
        '
        'lbType2
        '
        Me.lbType2.AutoSize = True
        Me.lbType2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbType2.Location = New System.Drawing.Point(107, 97)
        Me.lbType2.Name = "lbType2"
        Me.lbType2.Size = New System.Drawing.Size(2, 15)
        Me.lbType2.TabIndex = 20
        '
        'lbDuration
        '
        Me.lbDuration.AutoSize = True
        Me.lbDuration.Location = New System.Drawing.Point(309, 97)
        Me.lbDuration.Name = "lbDuration"
        Me.lbDuration.Size = New System.Drawing.Size(74, 13)
        Me.lbDuration.TabIndex = 19
        Me.lbDuration.Text = "Loan Duration"
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(13, 97)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(31, 13)
        Me.lbType.TabIndex = 18
        Me.lbType.Text = "Type"
        '
        'lbISBN
        '
        Me.lbISBN.AutoSize = True
        Me.lbISBN.Location = New System.Drawing.Point(12, 22)
        Me.lbISBN.Name = "lbISBN"
        Me.lbISBN.Size = New System.Drawing.Size(32, 13)
        Me.lbISBN.TabIndex = 1
        Me.lbISBN.Text = "ISBN"
        '
        'lbPublisher
        '
        Me.lbPublisher.AutoSize = True
        Me.lbPublisher.Location = New System.Drawing.Point(13, 196)
        Me.lbPublisher.Name = "lbPublisher"
        Me.lbPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lbPublisher.TabIndex = 11
        Me.lbPublisher.Text = "Publisher"
        '
        'lbPublisher2
        '
        Me.lbPublisher2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbPublisher2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbPublisher2.Location = New System.Drawing.Point(109, 195)
        Me.lbPublisher2.Name = "lbPublisher2"
        Me.lbPublisher2.Size = New System.Drawing.Size(450, 30)
        Me.lbPublisher2.TabIndex = 13
        '
        'lbYear2
        '
        Me.lbYear2.AutoSize = True
        Me.lbYear2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbYear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbYear2.Location = New System.Drawing.Point(403, 56)
        Me.lbYear2.Name = "lbYear2"
        Me.lbYear2.Size = New System.Drawing.Size(2, 15)
        Me.lbYear2.TabIndex = 17
        '
        'lbAuthor2
        '
        Me.lbAuthor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAuthor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbAuthor2.Location = New System.Drawing.Point(109, 140)
        Me.lbAuthor2.Name = "lbAuthor2"
        Me.lbAuthor2.Size = New System.Drawing.Size(450, 30)
        Me.lbAuthor2.TabIndex = 12
        '
        'lbEdition2
        '
        Me.lbEdition2.AutoSize = True
        Me.lbEdition2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEdition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbEdition2.Location = New System.Drawing.Point(109, 58)
        Me.lbEdition2.Name = "lbEdition2"
        Me.lbEdition2.Size = New System.Drawing.Size(2, 15)
        Me.lbEdition2.TabIndex = 16
        '
        'lbYear
        '
        Me.lbYear.AutoSize = True
        Me.lbYear.Location = New System.Drawing.Point(308, 60)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(66, 13)
        Me.lbYear.TabIndex = 15
        Me.lbYear.Text = "Publish Year"
        '
        'lbEdition
        '
        Me.lbEdition.AutoSize = True
        Me.lbEdition.Location = New System.Drawing.Point(12, 58)
        Me.lbEdition.Name = "lbEdition"
        Me.lbEdition.Size = New System.Drawing.Size(39, 13)
        Me.lbEdition.TabIndex = 14
        Me.lbEdition.Text = "Edition"
        '
        'lbAuthor
        '
        Me.lbAuthor.AutoSize = True
        Me.lbAuthor.Location = New System.Drawing.Point(12, 140)
        Me.lbAuthor.Name = "lbAuthor"
        Me.lbAuthor.Size = New System.Drawing.Size(38, 13)
        Me.lbAuthor.TabIndex = 7
        Me.lbAuthor.Text = "Author"
        '
        'btnBorrow
        '
        Me.btnBorrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBorrow.Location = New System.Drawing.Point(402, 451)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrow.TabIndex = 21
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(507, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbLoan
        '
        Me.gbLoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLoan.Controls.Add(Me.lbLoanID2)
        Me.gbLoan.Controls.Add(Me.lbExpiryDate2)
        Me.gbLoan.Controls.Add(Me.lbReturnDate2)
        Me.gbLoan.Controls.Add(Me.lbReturnDate)
        Me.gbLoan.Controls.Add(Me.lbExpiryDate)
        Me.gbLoan.Controls.Add(Me.lbID)
        Me.gbLoan.Controls.Add(Me.lbID2)
        Me.gbLoan.Controls.Add(Me.lbLoanID)
        Me.gbLoan.Location = New System.Drawing.Point(0, 70)
        Me.gbLoan.Name = "gbLoan"
        Me.gbLoan.Size = New System.Drawing.Size(582, 86)
        Me.gbLoan.TabIndex = 23
        Me.gbLoan.TabStop = False
        Me.gbLoan.Text = "Loan Details"
        '
        'lbLoanID2
        '
        Me.lbLoanID2.AutoSize = True
        Me.lbLoanID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLoanID2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbLoanID2.Location = New System.Drawing.Point(109, 22)
        Me.lbLoanID2.Name = "lbLoanID2"
        Me.lbLoanID2.Size = New System.Drawing.Size(2, 15)
        Me.lbLoanID2.TabIndex = 15
        '
        'lbExpiryDate2
        '
        Me.lbExpiryDate2.AutoSize = True
        Me.lbExpiryDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbExpiryDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbExpiryDate2.Location = New System.Drawing.Point(109, 55)
        Me.lbExpiryDate2.Name = "lbExpiryDate2"
        Me.lbExpiryDate2.Size = New System.Drawing.Size(2, 15)
        Me.lbExpiryDate2.TabIndex = 14
        '
        'lbReturnDate2
        '
        Me.lbReturnDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbReturnDate2.AutoSize = True
        Me.lbReturnDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbReturnDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbReturnDate2.Location = New System.Drawing.Point(402, 55)
        Me.lbReturnDate2.Name = "lbReturnDate2"
        Me.lbReturnDate2.Size = New System.Drawing.Size(2, 15)
        Me.lbReturnDate2.TabIndex = 13
        '
        'lbReturnDate
        '
        Me.lbReturnDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbReturnDate.AutoSize = True
        Me.lbReturnDate.Location = New System.Drawing.Point(306, 55)
        Me.lbReturnDate.Name = "lbReturnDate"
        Me.lbReturnDate.Size = New System.Drawing.Size(65, 13)
        Me.lbReturnDate.TabIndex = 10
        Me.lbReturnDate.Text = "Return Date"
        '
        'lbExpiryDate
        '
        Me.lbExpiryDate.AutoSize = True
        Me.lbExpiryDate.Location = New System.Drawing.Point(11, 55)
        Me.lbExpiryDate.Name = "lbExpiryDate"
        Me.lbExpiryDate.Size = New System.Drawing.Size(61, 13)
        Me.lbExpiryDate.TabIndex = 9
        Me.lbExpiryDate.Text = "Expiry Date"
        '
        'lbID
        '
        Me.lbID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(306, 19)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(59, 13)
        Me.lbID.TabIndex = 3
        Me.lbID.Text = "Member ID"
        '
        'lbID2
        '
        Me.lbID2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbID2.AutoSize = True
        Me.lbID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbID2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbID2.Location = New System.Drawing.Point(402, 19)
        Me.lbID2.Name = "lbID2"
        Me.lbID2.Size = New System.Drawing.Size(2, 15)
        Me.lbID2.TabIndex = 4
        '
        'lbLoanID
        '
        Me.lbLoanID.AutoSize = True
        Me.lbLoanID.Location = New System.Drawing.Point(11, 22)
        Me.lbLoanID.Name = "lbLoanID"
        Me.lbLoanID.Size = New System.Drawing.Size(45, 13)
        Me.lbLoanID.TabIndex = 5
        Me.lbLoanID.Text = "Loan ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.aa
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'cbISBN
        '
        Me.cbISBN.FormattingEnabled = True
        Me.cbISBN.Location = New System.Drawing.Point(109, 22)
        Me.cbISBN.Name = "cbISBN"
        Me.cbISBN.Size = New System.Drawing.Size(121, 21)
        Me.cbISBN.TabIndex = 22
        '
        'BorrowForm
        '
        Me.AcceptButton = Me.btnBorrow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(584, 476)
        Me.Controls.Add(Me.gbLoan)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbBook)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BorrowForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BorrowForm"
        Me.gbBook.ResumeLayout(False)
        Me.gbBook.PerformLayout()
        Me.gbLoan.ResumeLayout(False)
        Me.gbLoan.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBook As GroupBox
    Friend WithEvents lbDuration2 As Label
    Friend WithEvents lbType2 As Label
    Friend WithEvents lbDuration As Label
    Friend WithEvents lbType As Label
    Friend WithEvents lbISBN As Label
    Friend WithEvents lbPublisher As Label
    Friend WithEvents lbPublisher2 As Label
    Friend WithEvents lbYear2 As Label
    Friend WithEvents lbAuthor2 As Label
    Friend WithEvents lbEdition2 As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents lbEdition As Label
    Friend WithEvents lbAuthor As Label
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbLoan As GroupBox
    Friend WithEvents lbExpiryDate2 As Label
    Friend WithEvents lbReturnDate2 As Label
    Friend WithEvents lbReturnDate As Label
    Friend WithEvents lbExpiryDate As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbID2 As Label
    Friend WithEvents lbLoanID As Label
    Friend WithEvents lbLoanID2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbISBN As ComboBox
End Class
