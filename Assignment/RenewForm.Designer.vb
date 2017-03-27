<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RenewForm
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
        Me.lbISBN = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbLoanID = New System.Windows.Forms.Label()
        Me.lbAuthor = New System.Windows.Forms.Label()
        Me.lbID2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lbPublisher = New System.Windows.Forms.Label()
        Me.lbEdition = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.gbBook = New System.Windows.Forms.GroupBox()
        Me.cbPublisher = New System.Windows.Forms.ComboBox()
        Me.cbAuthor = New System.Windows.Forms.ComboBox()
        Me.cbEdition = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbISBN = New System.Windows.Forms.ComboBox()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lbDuration = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.gbLoan = New System.Windows.Forms.GroupBox()
        Me.lbLoanID2 = New System.Windows.Forms.Label()
        Me.lbBorrowDate2 = New System.Windows.Forms.Label()
        Me.lbExpiryDate2 = New System.Windows.Forms.Label()
        Me.lbExpiryDate = New System.Windows.Forms.Label()
        Me.lbBorrowDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbBook.SuspendLayout()
        Me.gbLoan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lbLoanID
        '
        Me.lbLoanID.AutoSize = True
        Me.lbLoanID.Location = New System.Drawing.Point(11, 22)
        Me.lbLoanID.Name = "lbLoanID"
        Me.lbLoanID.Size = New System.Drawing.Size(45, 13)
        Me.lbLoanID.TabIndex = 5
        Me.lbLoanID.Text = "Loan ID"
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
        'lbID2
        '
        Me.lbID2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbID2.AutoSize = True
        Me.lbID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbID2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbID2.Location = New System.Drawing.Point(402, 20)
        Me.lbID2.Name = "lbID2"
        Me.lbID2.Size = New System.Drawing.Size(2, 15)
        Me.lbID2.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(508, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturn.Location = New System.Drawing.Point(403, 439)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
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
        'lbEdition
        '
        Me.lbEdition.AutoSize = True
        Me.lbEdition.Location = New System.Drawing.Point(12, 58)
        Me.lbEdition.Name = "lbEdition"
        Me.lbEdition.Size = New System.Drawing.Size(39, 13)
        Me.lbEdition.TabIndex = 14
        Me.lbEdition.Text = "Edition"
        '
        'lbYear
        '
        Me.lbYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbYear.AutoSize = True
        Me.lbYear.Location = New System.Drawing.Point(308, 60)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(66, 13)
        Me.lbYear.TabIndex = 15
        Me.lbYear.Text = "Publish Year"
        '
        'btnRenew
        '
        Me.btnRenew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRenew.Location = New System.Drawing.Point(299, 439)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(75, 23)
        Me.btnRenew.TabIndex = 3
        Me.btnRenew.Text = "Renew"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'gbBook
        '
        Me.gbBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBook.Controls.Add(Me.cbPublisher)
        Me.gbBook.Controls.Add(Me.cbAuthor)
        Me.gbBook.Controls.Add(Me.cbEdition)
        Me.gbBook.Controls.Add(Me.cbYear)
        Me.gbBook.Controls.Add(Me.cbISBN)
        Me.gbBook.Controls.Add(Me.cbDuration)
        Me.gbBook.Controls.Add(Me.cbType)
        Me.gbBook.Controls.Add(Me.lbDuration)
        Me.gbBook.Controls.Add(Me.lbType)
        Me.gbBook.Controls.Add(Me.lbISBN)
        Me.gbBook.Controls.Add(Me.lbPublisher)
        Me.gbBook.Controls.Add(Me.lbYear)
        Me.gbBook.Controls.Add(Me.lbEdition)
        Me.gbBook.Controls.Add(Me.lbAuthor)
        Me.gbBook.Location = New System.Drawing.Point(0, 175)
        Me.gbBook.Name = "gbBook"
        Me.gbBook.Size = New System.Drawing.Size(584, 235)
        Me.gbBook.TabIndex = 19
        Me.gbBook.TabStop = False
        Me.gbBook.Text = "Book Details"
        '
        'cbPublisher
        '
        Me.cbPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPublisher.FormattingEnabled = True
        Me.cbPublisher.Location = New System.Drawing.Point(110, 193)
        Me.cbPublisher.Name = "cbPublisher"
        Me.cbPublisher.Size = New System.Drawing.Size(450, 21)
        Me.cbPublisher.TabIndex = 28
        '
        'cbAuthor
        '
        Me.cbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAuthor.FormattingEnabled = True
        Me.cbAuthor.Location = New System.Drawing.Point(109, 137)
        Me.cbAuthor.Name = "cbAuthor"
        Me.cbAuthor.Size = New System.Drawing.Size(450, 21)
        Me.cbAuthor.TabIndex = 27
        '
        'cbEdition
        '
        Me.cbEdition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEdition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEdition.FormattingEnabled = True
        Me.cbEdition.Location = New System.Drawing.Point(109, 55)
        Me.cbEdition.Name = "cbEdition"
        Me.cbEdition.Size = New System.Drawing.Size(121, 21)
        Me.cbEdition.TabIndex = 24
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(402, 55)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 21)
        Me.cbYear.TabIndex = 23
        '
        'cbISBN
        '
        Me.cbISBN.FormattingEnabled = True
        Me.cbISBN.Location = New System.Drawing.Point(109, 19)
        Me.cbISBN.Name = "cbISBN"
        Me.cbISBN.Size = New System.Drawing.Size(121, 21)
        Me.cbISBN.TabIndex = 22
        '
        'cbDuration
        '
        Me.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"1day", "3days", "7days", "120days"})
        Me.cbDuration.Location = New System.Drawing.Point(402, 94)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(121, 21)
        Me.cbDuration.TabIndex = 21
        '
        'cbType
        '
        Me.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Open", "Yellow", "Red", "Green"})
        Me.cbType.Location = New System.Drawing.Point(109, 94)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(121, 21)
        Me.cbType.TabIndex = 20
        '
        'lbDuration
        '
        Me.lbDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'gbLoan
        '
        Me.gbLoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLoan.Controls.Add(Me.lbLoanID2)
        Me.gbLoan.Controls.Add(Me.lbBorrowDate2)
        Me.gbLoan.Controls.Add(Me.lbExpiryDate2)
        Me.gbLoan.Controls.Add(Me.lbExpiryDate)
        Me.gbLoan.Controls.Add(Me.lbBorrowDate)
        Me.gbLoan.Controls.Add(Me.lbID)
        Me.gbLoan.Controls.Add(Me.lbID2)
        Me.gbLoan.Controls.Add(Me.lbLoanID)
        Me.gbLoan.Location = New System.Drawing.Point(0, 70)
        Me.gbLoan.Name = "gbLoan"
        Me.gbLoan.Size = New System.Drawing.Size(582, 86)
        Me.gbLoan.TabIndex = 20
        Me.gbLoan.TabStop = False
        Me.gbLoan.Text = "Loan Details"
        '
        'lbLoanID2
        '
        Me.lbLoanID2.AutoSize = True
        Me.lbLoanID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLoanID2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbLoanID2.Location = New System.Drawing.Point(110, 20)
        Me.lbLoanID2.Name = "lbLoanID2"
        Me.lbLoanID2.Size = New System.Drawing.Size(2, 15)
        Me.lbLoanID2.TabIndex = 15
        '
        'lbBorrowDate2
        '
        Me.lbBorrowDate2.AutoSize = True
        Me.lbBorrowDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbBorrowDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbBorrowDate2.Location = New System.Drawing.Point(110, 55)
        Me.lbBorrowDate2.Name = "lbBorrowDate2"
        Me.lbBorrowDate2.Size = New System.Drawing.Size(2, 15)
        Me.lbBorrowDate2.TabIndex = 14
        '
        'lbExpiryDate2
        '
        Me.lbExpiryDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbExpiryDate2.AutoSize = True
        Me.lbExpiryDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbExpiryDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbExpiryDate2.Location = New System.Drawing.Point(402, 55)
        Me.lbExpiryDate2.Name = "lbExpiryDate2"
        Me.lbExpiryDate2.Size = New System.Drawing.Size(2, 15)
        Me.lbExpiryDate2.TabIndex = 13
        '
        'lbExpiryDate
        '
        Me.lbExpiryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbExpiryDate.AutoSize = True
        Me.lbExpiryDate.Location = New System.Drawing.Point(306, 55)
        Me.lbExpiryDate.Name = "lbExpiryDate"
        Me.lbExpiryDate.Size = New System.Drawing.Size(61, 13)
        Me.lbExpiryDate.TabIndex = 10
        Me.lbExpiryDate.Text = "Expiry Date"
        '
        'lbBorrowDate
        '
        Me.lbBorrowDate.AutoSize = True
        Me.lbBorrowDate.Location = New System.Drawing.Point(11, 55)
        Me.lbBorrowDate.Name = "lbBorrowDate"
        Me.lbBorrowDate.Size = New System.Drawing.Size(66, 13)
        Me.lbBorrowDate.TabIndex = 9
        Me.lbBorrowDate.Text = "Borrow Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.returnbook
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'RenewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(584, 464)
        Me.Controls.Add(Me.gbLoan)
        Me.Controls.Add(Me.gbBook)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RenewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RenewForm"
        Me.gbBook.ResumeLayout(False)
        Me.gbBook.PerformLayout()
        Me.gbLoan.ResumeLayout(False)
        Me.gbLoan.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbISBN As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbLoanID As Label
    Friend WithEvents lbAuthor As Label
    Friend WithEvents lbID2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lbPublisher As Label
    Friend WithEvents lbEdition As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents btnRenew As Button
    Friend WithEvents gbBook As GroupBox
    Friend WithEvents lbDuration As Label
    Friend WithEvents lbType As Label
    Friend WithEvents gbLoan As GroupBox
    Friend WithEvents lbBorrowDate2 As Label
    Friend WithEvents lbExpiryDate2 As Label
    Friend WithEvents lbExpiryDate As Label
    Friend WithEvents lbBorrowDate As Label
    Friend WithEvents lbLoanID2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbEdition As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbISBN As ComboBox
    Friend WithEvents cbDuration As ComboBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cbPublisher As ComboBox
    Friend WithEvents cbAuthor As ComboBox
End Class
