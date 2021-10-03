Imports MySql.Data.MySqlClient

Public Class showRecord

#Region "my sub"

    Sub searchRecords()
        Dim sql As String = "SELECT receiptID AS `RECEIPT ID`,initialTotal as `SUB TOTAL`,discount as `DISCOUNT CODE`   ,discountAmount as `TOTAL DISCOUNT`,bPayment as `CUSTOMER PAYMENT`,bChange as `CHANGE`,clerk as `CLERK ENCHARGED` FROM billreceipt WHERE receiptID LIKE '%" + txtSearch.Text + "%' or clerk LIKE '%" + txtSearch.Text + "%' LIMIT 50"
        Dim da As New MySqlDataAdapter(sql, con)
        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "billreceipt")
        dgview.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Dim dataAdapter As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Sub printRecord()

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
            Dim qryCompanies As String = "select billReceipt.*,receipt_content.* from billReceipt,receipt_content WHERE billReceipt.receiptId='" & dgview.SelectedCells(0).Value.ToString() & _
                "' and receipt_content.receiptID='" & dgview.SelectedCells(0).Value.ToString() & "'"
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
        receiptForm.CrystalReportViewer1.ReportSource = objRpt
        receiptForm.CrystalReportViewer1.RefreshReport()
        receiptForm.Show()
    End Sub

    Sub deleteRecord()
        Dim sql As String = "DELETE billreceipt, receipt_content FROM billreceipt INNER JOIN receipt_content ON receipt_content.receiptID=billreceipt.receiptID WHERE billreceipt.receiptId='" & dgview.SelectedCells(0).Value.ToString() & "'"
        bQuery(sql)
        Alert("DELETED", "Selected Record Deleted!", Notification.alertTypeEnum.Error)
    End Sub
#End Region

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchRecords()
    End Sub

    Private Sub showRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchRecords()
    End Sub

    Private Sub dgview_MouseClick(sender As Object, e As MouseEventArgs) Handles dgview.MouseClick
        btnDelete.Enabled = True
        btnPrint.Enabled = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            deleteRecord()
        End If
    End Sub
End Class