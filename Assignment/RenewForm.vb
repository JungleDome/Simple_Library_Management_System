Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class RenewForm
    Public AuthorList(0) As String
    Public PublisherList(0) As String
    Public Shared SelectedItem As ListViewItem
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lms.mdb; Persist Security Info=False;")
    Public Sub New()
        InitializeComponent()
        'Filling all the data, imcluding combobox list items
        lbID2.Text = Form1.memberID
        Dim cmd As New OleDbCommand("SELECT * FROM [Loan] INNER JOIN [Book] ON Loan.ISBN = Book.ISBN WHERE Loan.memberID = @id ORDER BY [Loan].[ISBN]", conn)
        cmd.Parameters.AddWithValue("@id", Form1.memberID)
        Try
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Do While dr.Read()
                If dr.Item("returnDate").ToString = String.Empty Then
                    cbAuthor.Items.Add(dr.Item("authors"))
                    cbPublisher.Items.Add(dr.Item("publisher"))
                    cbISBN.Items.Add(dr.Item(5))
                    cbEdition.Items.Add(dr.Item("edition"))
                    cbYear.Items.Add(dr.Item("publishYear"))
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If cbISBN.Text.ToString <> "" Then
            Dim response = MessageBox.Show("Are you sure you want to exit without return or renew books?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = DialogResult.Yes Then
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cbISBN_TextChanged(sender As Object, e As EventArgs) Handles cbISBN.TextChanged
        ClearItems()
        SelectLatestTransaction(cbISBN.Text.ToString)
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        'Double validates
        If cbISBN.Text.ToString <> "" And lbLoanID2.Text.ToString <> "" Then
            Dim loanDuration As Double = Regex.Replace(cbDuration.Text, "days|day", "")
            Dim newExpiryDate As Date = Now.AddDays(loanDuration)
            'Use old expirydate to calculate IsLate or not


            Dim cmd As New OleDbCommand("UPDATE Loan SET returnDate=@returnDate WHERE loanID=@loanID", conn)
            Dim cmd2 As New OleDbCommand("INSERT INTO [Loan] ([loanID],[borrowDate],[expiryDate],[memberID],[ISBN]) VALUES (@loanID,@borrowDate,@newExpiryDate,@memberID,@ISBN);", conn)
            cmd.Parameters.AddWithValue("@returnDate", Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@loanID", lbLoanID2.Text.ToString)
            With cmd2.Parameters
                .AddWithValue("@borrowDate", Date.Now().ToShortDateString)
                .AddWithValue("@newExpiryDate", newExpiryDate.ToShortDateString)
                .AddWithValue("@memberID", lbID2.Text.ToString)
                .AddWithValue("@ISBN", cbISBN.Text.ToString)
            End With
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                conn.Close()
                If LateDate() > 0 Then
                    'Late renew
                    MessageBox.Show("Book renew successful! Please pay your fine : RM" & LateDate(), "Renew with fine !", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    MessageBox.Show("Book renew successfully! Thank you!", "Renew Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        ElseIf cbISBN.Text.ToString <> "" And lbLoanID2.Text.ToString = "" Then
            MessageBox.Show("Please enter a correct ISBN!", "Invalid ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Handle empty tb entered
            MessageBox.Show("Please enter the ISBN to proceed!", "Please enter ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Double validates is always better ;)
        If cbISBN.Text.ToString <> "" And lbLoanID2.Text.ToString <> "" Then
            Dim cmd As New OleDbCommand("UPDATE Loan SET returnDate=@returnDate WHERE loanID = @loanID", conn)
            cmd.Parameters.AddWithValue("@returnDate", Date.Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@loanID", lbLoanID2.Text.ToString)
            If LateDate() > 0 Then
                MessageBox.Show("Late return of book! Please pay your fine : RM" & LateDate(), "Return with fine !", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                MessageBox.Show("Book return successfully! Thank you!", "Return Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Dispose()
        ElseIf cbISBN.Text.ToString <> "" And lbLoanID2.Text.ToString = "" Then
            MessageBox.Show("Please enter a correct ISBN!", "Invalid ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Please enter the ISBN to proceed!", "Please enter ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Function LateDate() As Double
        Return DateDiff(DateInterval.Day, Date.Parse(lbExpiryDate2.Text), Date.Now)
    End Function

    Private Sub cbISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbISBN.KeyPress
        If Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub SelectLatestTransaction(ISBN As String)
        If ISBN <> "" Then
            Dim cmd As New OleDbCommand("SELECT TOP 1 * FROM [Loan] INNER JOIN [Book] ON Loan.ISBN = Book.ISBN WHERE Loan.ISBN = @ISBN AND Loan.memberID = @id ORDER BY [Loan].[loanID] desc", conn)
            cmd.Parameters.AddWithValue("@ISBN", ISBN)
            cmd.Parameters.AddWithValue("@id", Form1.memberID)
            'Select the latest transaction of the book
            Try
                conn.Close()
                conn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.HasRows = False Then
                    MessageBox.Show("The book had never been borrowed before! Please refer to a librarian.", "Book never been borrowed!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    ClearItems()
                End If
                While dr.Read()
                    'Check if has row and if the book is already return or not
                    If dr.HasRows And dr.Item("returnDate").ToString = String.Empty Then
                        lbLoanID2.Text = dr.Item("loanID")
                        lbBorrowDate2.Text = dr.Item("borrowDate")
                        lbExpiryDate2.Text = dr.Item("expiryDate")
                        cbISBN.Text = dr.Item("Loan.ISBN")
                        cbAuthor.Text = dr.Item("authors")
                        cbEdition.Text = dr.Item("edition")
                        cbPublisher.Text = dr.Item("publisher")
                        cbYear.Text = dr.Item("publishYear")
                        cbType.Text = dr.Item("type")
                        cbDuration.Text = dr.Item("loanDuration")
                    ElseIf dr.Item("returnDate").ToString <> "" Then
                        MessageBox.Show("The book had never been borrowed before! Please refer to a librarian.", "Book never been borrowed!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        ClearItems()
                    End If
                End While
                conn.Close()
            Catch ex As Exception
                conn.Close()
            End Try
        End If
    End Sub

    Sub ClearItems()
        lbLoanID2.ResetText()
        lbExpiryDate2.ResetText()
        lbBorrowDate2.ResetText()
        cbAuthor.ResetText()
        cbDuration.SelectedIndex = -1
        cbEdition.SelectedIndex = -1
        cbPublisher.ResetText()
        cbType.SelectedIndex = -1
        cbYear.SelectedIndex = -1
    End Sub

    Private Sub cbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuthor.SelectedIndexChanged
        cbISBN.SelectedIndex = cbAuthor.SelectedIndex
        'Once cbISBN is changed , the data will be automatically refreshed
    End Sub

    Private Sub cbPublisher_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPublisher.SelectedIndexChanged
        cbISBN.SelectedIndex = cbPublisher.SelectedIndex
        'Once cbISBN is changed , the data will be automatically refreshed
    End Sub

End Class