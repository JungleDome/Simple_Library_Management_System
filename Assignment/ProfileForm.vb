Imports System.Data.OleDb
Public Class ProfileForm
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lms.mdb; Persist Security Info=False;")
    Public Sub New()
        InitializeComponent()
        Dim cmd As New OleDbCommand()
        Dim dr As OleDbDataReader
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@id", Form1.memberID)
        'Fill up profile details
        Try
            conn.Open()
            If Form1.IsMember Then
                cmd.CommandText = "SELECT * FROM [Member] WHERE memberID=@id"
                dr = cmd.ExecuteReader()
                While dr.Read()
                    lbID2.Text = dr.Item("memberID")
                    lbName2.Text = dr.Item("memberName")
                    lbContact2.Text = dr.Item("contactNumber")
                    lbEmail2.Text = dr.Item("emailAddress")
                    lbType2.Text = dr.Item("statusType")
                End While
            ElseIf Form1.IsLibrarian Then
                cmd.CommandText = "SELECT * FROM [Librarian] WHERE librarianID = @id"
                dr = cmd.ExecuteReader()
                While dr.Read()
                    lbID2.Text = dr.Item("librarianID")
                    lbName2.Text = dr.Item("librarianName")
                End While
            End If

            'Showing transaction history in datagridview
            Dim cmd2 As New OleDbCommand("SELECT * FROM [Loan] WHERE memberID=@id", conn)
            cmd2.Parameters.AddWithValue("@id", Form1.memberID)
            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr2)
            dgvProfile.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub
End Class