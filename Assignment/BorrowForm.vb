Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class BorrowForm
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lms.mdb; Persist Security Info=False;")
    Public Sub New()
        InitializeComponent()
        'Set memberID
        lbID2.Text = Form1.memberID
        Dim cmd As New OleDbCommand("SELECT TOP 1 loanID FROM [Loan] ORDER BY loanID DESC", conn)
        Dim cmd2 As New OleDbCommand("SELECT ISBN FROM [Book] ORDER BY ISBN", conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader()
            While dr.Read()
                'Set loanID
                lbLoanID2.Text = Integer.Parse(dr.Item("loanID")) + 1
            End While
            While dr2.Read()
                'Populate combobox items
                cbISBN.Items.Add(dr2.Item("ISBN"))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try

    End Sub

    Private Sub cbISBN_TextChanged(sender As Object, e As EventArgs) Handles cbISBN.TextChanged

        lbAuthor2.ResetText()
        lbEdition2.ResetText()
        lbPublisher2.ResetText()
        lbYear2.ResetText()
        lbType2.ResetText()
        lbDuration2.ResetText()
        lbExpiryDate2.ResetText()

        Dim cmd As New OleDbCommand("SELECT TOP 1 Book.*, Loan.returnDate 
FROM Book INNER JOIN Loan ON Book.ISBN = Loan.ISBN WHERE Book.ISBN = @isbn ORDER BY Loan.borrowDate desc", conn)
        cmd.Parameters.AddWithValue("@isbn", cbISBN.Text.ToString)
        Try
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read()
                If dr.Item("returnDate").ToString <> "" Then
                    lbAuthor2.Text = dr.Item("authors")
                    lbEdition2.Text = dr.Item("edition")
                    lbPublisher2.Text = dr.Item("publisher")
                    lbYear2.Text = dr.Item("publishYear")
                    lbType2.Text = dr.Item("type")
                    Dim duration As String = dr.Item("loanDuration")
                    lbDuration2.Text = duration
                    duration = Regex.Replace(duration, "days|day", "")
                    lbExpiryDate2.Text = Date.Now().AddDays(Double.Parse(duration)).ToShortDateString
                ElseIf dr.Item("returnDate").ToString = "" Then
                    Console.WriteLine("no")
                    MessageBox.Show("The book Is borrowed!", "Book Is borrowed!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Break
                End If
            End While
Break:
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        'Validate if the books are really exist by checking if there are any author
        If lbAuthor2.Text.ToString = "" Then
            MessageBox.Show("Please select a book to borrow!", "Please enter ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cbISBN.Text.ToString <> "" And lbAuthor2.Text.ToString = "" Then
            MessageBox.Show("Please enter a correct ISBN!", "Invalid ISBN!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cmd As New OleDbCommand("INSERT INTO [Loan] ([loanID],[borrowDate],[expiryDate],[memberID],[ISBN]) VALUES (@loanID,@borrowDate,@expiryDate,@memberID,@ISBN);", conn)
            Dim borrowDate As Date = Date.Now().ToShortDateString
            Dim expiryDate As Date = Date.Parse(lbExpiryDate2.Text)
            With cmd.Parameters
                .AddWithValue("@loanID", lbLoanID2.Text.ToString)
                .AddWithValue("@borrowDate", borrowDate)
                .AddWithValue("@expiryDate", expiryDate)
                .AddWithValue("@memberID", lbID2.Text.ToString)
                .AddWithValue("@ISBN", cbISBN.Text.ToString)
            End With
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Borrow Successful!" & vbNewLine & "Borrow By : " & borrowDate & "." & vbNewLine & "Please return it by : " & expiryDate & ".", "Success")
                conn.Close()
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Something went wrong!")
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If cbISBN.Text.ToString <> "" Then
            Dim response = MessageBox.Show("Are you sure you want to exit without borrowing books?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = DialogResult.Yes Then
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub tbISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbISBN.KeyPress
        If Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
        Else
            e.Handled = True
        End If
    End Sub
End Class