Imports System.Data.OleDb
Public Class Form1

    Public Shared memberID As String
    Public Shared memberName As String
    Public Shared IsMember As Boolean
    Public Shared IsLibrarian As Boolean
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim borrow As New BorrowForm
        borrow.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim renew As New RenewForm
        renew.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim report As New ReportForm
        report.Show()
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim profile As New ProfileForm
        profile.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'If either one is true, means the application is logged in
        If IsMember Or IsLibrarian Then
            'Logout process, reset everything
            IsLibrarian = Nothing
            IsMember = Nothing
            memberID = Nothing
            memberName = Nothing
            lbName2.Text = Nothing
            btnBorrow.Enabled = False
            btnReturn.Enabled = False
            btnReport.Enabled = False
            btnProfile.Enabled = False
            btnLogin.Text = "Login"
            MessageBox.Show("You successfully logged out !", " Logout Successful !")
        Else
            'Login Process, show login form
            Dim login As New LoginForm
            login.ShowDialog()

            'To ensure the user is logged in,bcz the user may close the form without log in
            If IsLibrarian Or IsMember Then
                'Enable all button
                btnLogin.Text = "Logout"
                lbName2.Text = memberName
                btnBorrow.Enabled = True
                btnProfile.Enabled = True
                btnReturn.Enabled = True
                If IsLibrarian Then
                    btnReport.Enabled = True
                End If
            End If
        End If
    End Sub
End Class
