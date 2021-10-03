Imports MySql.Data.MySqlClient

Public Class receiptForm

    Dim dataAdapter As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Sub printReceipt()

        ds.Clear()
        Try
            With con
                If .State = ConnectionState.Open Then .Close()

                con.Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            Dim qryCompanies As String = "select billReceipt.*,receipt_content.* from billReceipt,receipt_content WHERE billReceipt.receiptId='" & buyForm.receiptID.Text & _
                "' and receipt_content.receiptID='" & buyForm.receiptID.Text & "'"
            dataAdapter.SelectCommand = New MySqlCommand(qryCompanies, con)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(dataAdapter)

            dataAdapter.Fill(ds, "billReceipt,receipt_content")
            dataAdapter.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Dim objRpt As New Billreport()
        objRpt.SetDataSource(ds.Tables("billReceipt,receipt_content"))
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.RefreshReport()

    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub receiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class