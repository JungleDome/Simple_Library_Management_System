Imports System.Data.OleDb
Public Class LoginForm
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lms.mdb; Persist Security Info=False;")
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbMemberID.ResetText()
        tbPassword.ResetText()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmdText As String = "SELECT memberID,password,memberName FROM Member WHERE memberID = @ID AND password = @password"
        Dim cmdText2 As String = "SELECT librarianID,librarianPassword,librarianName FROM Librarian WHERE librarianID = @ID AND librarianPassword = @password"
        Dim cmd As New OleDbCommand(cmdText, conn)
        Dim cmd2 As New OleDbCommand(cmdText2, conn)
        cmd.Parameters.AddWithValue("@ID", Integer.Parse(tbMemberID.Text.ToString))
        cmd.Parameters.AddWithValue("@password", tbPassword.Text.ToString)
        cmd2.Parameters.AddWithValue("@ID", Integer.Parse(tbMemberID.Text.ToString))
        cmd2.Parameters.AddWithValue("@password", tbPassword.Text.ToString)

        Try
            conn.Open()
            Dim memberDr As OleDbDataReader = cmd.ExecuteReader()
            Dim librarianDr As OleDbDataReader = cmd2.ExecuteReader()
            If memberDr.HasRows Then
                Form1.IsMember = True
                While memberDr.Read()
                    Form1.memberID = memberDr.Item(0)
                    Form1.memberName = memberDr.Item(1)
                End While
                MessageBox.Show("You successfully logged in!", "Login Success")
                Me.Dispose()
            ElseIf librarianDr.HasRows Then
                Form1.IsLibrarian = True
                While librarianDr.Read()
                    Form1.memberID = librarianDr.Item(0)
                    Form1.memberName = librarianDr.Item(2)
                End While
                MessageBox.Show("You successfully logged in!", "Login Success")
                Me.Dispose()
            Else
                MessageBox.Show("You entered the wrong memberID/password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbPassword.ResetText()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbViewPass.CheckedChanged
        If cbViewPass.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class