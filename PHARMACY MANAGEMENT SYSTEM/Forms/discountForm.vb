Imports MySql.Data.MySqlClient
Public Class discountForm

#Region "Mymethod"

    Sub addNow()
        Dim sql As String = "INSERT INTO discount(vname,vcode,vdiscounted,vexpiry,vstatus,dateCreated)values('" & vname.Text & _
            "','" & vcode.Text & "','" & Val(vdiscounted.Text) / 100 & "','" & vexpiry.Value.ToString("yyyy/M/dd") & _
            "','" & vStatus.Text & "','" & Date.Now.ToString("yyyy/M/dd") & "')"
        bQuery(sql)
        Alert("SUCCESS", "Voucher Created", Notification.alertTypeEnum.Success)
    End Sub

    Sub updateNow()
        Dim sql As String = "UPDATE discount SET vname='" & vname.Text & "',vcode='" & vcode.Text & "',vdiscounted='" & Val(vdiscounted.Text) / 100 & _
            "',vexpiry='" & vexpiry.Value.ToString("yyyy/M/dd") & "',vstatus='" & vStatus.Text & "',dateCreated='" & Date.Now.ToString("yyyy/M/dd") & "' WHERE id='" & vid.Text & "'"
        bQuery(sql)
        Alert("UPDATED", "Voucher Updated", Notification.alertTypeEnum.Success)
    End Sub

    Sub deleteNow()
        Dim sql As String = "DELETE FROM discount WHERE id='" & vid.Text & "'"
        bQuery(sql)
        Alert("DELETED", "Voucher Deleted!", Notification.alertTypeEnum.Error)
    End Sub

    Sub countAvailableDiscount()
        Dim sql As String = "SELECT COUNT(*) FROM discount "
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        countDiscount.Text = count.ToString + " Total Voucher"
    End Sub

    Sub searchVoucher()
        Dim sql As String = "SELECT id as `ID`,vname as `Voucher`, vcode as `Code`,vstatus as `Status`,vdiscounted,vexpiry FROM discount WHERE vname LIKE '%" + tSearch.Text + "%' OR vcode LIKE '%" + tSearch.Text + "%' or vstatus LIKE '%" + tSearch.Text + "%' "
        Dim da As New MySqlDataAdapter(sql, con)
        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "discount")
        dgview.DataSource = ds.Tables(0)

        dgview.Columns(0).Visible = False
        dgview.Columns(4).Visible = False
        dgview.Columns(5).Visible = False

        con.Close()

        If tSearch.Text = Nothing Then
            countAvailableDiscount()
        Else
            countDiscount.Text = dgview.RowCount.ToString + " Found Voucher"
        End If


    End Sub

    Sub getSelectedCell()
        vid.Text = dgview.SelectedCells(0).Value.ToString
        vname.Text = dgview.SelectedCells(1).Value.ToString
        vcode.Text = dgview.SelectedCells(2).Value.ToString
        vStatus.Text = dgview.SelectedCells(3).Value.ToString
        vdiscounted.Text = (Val(dgview.SelectedCells(4).Value) * 100).ToString()
        vexpiry.Text = dgview.SelectedCells(5).Value.ToString

        btnAdd.Text = "Update"
        btnDelete.Enabled = True

    End Sub

    Sub clear()
        vid.Text = ""
        vname.Text = ""
        vcode.Text = ""
        vStatus.SelectedIndex = -1
        vdiscounted.Text = ""
        vexpiry.Value = Date.Now()
        btnAdd.Text = "Add"

    End Sub

#End Region

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        searchVoucher()
    End Sub

    Private Sub discountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchVoucher()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            If vname.Text = "" Then
                Alert("Warning", "Voucher name is empty!", Notification.alertTypeEnum.Warning)
                errSound()
                vname.Focus()
            ElseIf vcode.Text = "" Then
                Alert("Warning", "Voucher Code is empty!", Notification.alertTypeEnum.Warning)
                errSound()
                vcode.Focus()
            ElseIf vdiscounted.Text = "" Then
                Alert("Warning", "Discounted price is empty!", Notification.alertTypeEnum.Warning)
                errSound()
                vdiscounted.Focus()
            ElseIf vexpiry.Value = Date.Now Then
                Alert("Warning", "Expiry date cannot be today!", Notification.alertTypeEnum.Warning)
                errSound()
                vexpiry.Focus()
            ElseIf vStatus.Text = "" Then
                Alert("Warning", "Status is empty!", Notification.alertTypeEnum.Warning)
                errSound()
                vStatus.Focus()
            ElseIf btnAdd.Text = "Add" Then
                addNow()
                clear()
                searchVoucher()
            ElseIf btnAdd.Text = "Update" Then
                updateNow()
                clear()
                searchVoucher()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgview_MouseClick(sender As Object, e As MouseEventArgs) Handles dgview.MouseClick
        getSelectedCell()
    End Sub

    Private Sub discountForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            addNow()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteNow()
        clear()
    End Sub
End Class