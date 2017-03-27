
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportForm
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lms.mdb; Persist Security Info=False;")
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1)
        refreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        refreshReport()
    End Sub

    Public Sub refreshReport()
        'Apply data filter
        DataTable1BindingSource.Filter = "borrowDate=#" & Date.Parse(DateTimePicker1.Value).ToShortDateString & " 12:00:00 AM#"
        'Making new data source and replace the older version of data source
        Dim newRS As New ReportDataSource
        newRS.Name = "Report_DataSet"
        newRS.Value = DataTable1BindingSource
        ReportViewer1.LocalReport.DataSources.Add(newRS)
        'Refresh local report
        ReportViewer1.LocalReport.Refresh()
        'Refresh reportViewer
        ReportViewer1.RefreshReport()

    End Sub

End Class