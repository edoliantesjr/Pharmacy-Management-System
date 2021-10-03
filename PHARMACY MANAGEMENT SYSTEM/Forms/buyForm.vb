Imports MySql.Data.MySqlClient

Public Class buyForm

#Region "Mymethods"

    Sub countAvailableProduct()
        Try

            Dim sql As String = "SELECT COUNT(*) FROM products where stocks<>0"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim i As Integer = cmd.ExecuteScalar()
            con.Close()
            productCount.Text = i.ToString() + " Total Products"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub searchProduct()
        Try
            Dim sql As String = "SELECT productID as `ID`, name as `Product`,scientific as `Scientific name`,amount,stocks FROM products WHERE productID LIKE '%" + tSearch.Text + "%' or brand LIKE '%" + tSearch.Text + "%'  or name LIKE '%" + tSearch.Text + "%' LIMIT 100 "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "products")

            dgview.DataSource = ds.Tables(0)
            dgview.Columns(3).Visible = False
            dgview.Columns(4).Visible = False

            con.Close()

            If tSearch.Text = Nothing Then
                countAvailableProduct()
            Else
                productCount.Text = dgview.RowCount.ToString + " Found Products"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub getProductPhoto()
        Try
            Dim arrImage As Byte()
            Dim sql As String = "select photo from products where productID='" & dgview.SelectedCells(0).Value.ToString() & "' limit 1"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    arrImage = dr.Item("photo")
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    productPhoto.Image = Image.FromStream(mstream)

                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub getSelectedCell()

        Try

            clear()
            productID.Text = dgview.SelectedCells(0).Value.ToString()
            product_name.Text = dgview.SelectedCells(1).Value.ToString
            tStocks.Text = dgview.SelectedCells(4).Value.ToString()
            tPrice.Text = dgview.SelectedCells(3).Value.ToString()
            calTotalPrice()
            quantity.Text = "1"
            tSearch.Text = Nothing
            getProductPhoto()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim totAmount As Double
    Sub calTotalPrice()
        Try
            Dim price As Double = Val(tPrice.Text)
            If quantity.Text <> Nothing Then
                Dim numItems As Integer = CInt(quantity.Text)

                totAmount = price * numItems

                totalPrice.Text = Format(totAmount, "###,###,###.00")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub clear()
        productID.Text = ""
        product_name.Text = ""
        tStocks.Text = ""
        tPrice.Text = "0"
        quantity.Text = "0"
        totalPrice.Text = "0"
        productPhoto.Image = My.Resources.icons8_add_shopping_cart_480px_3

    End Sub
    Sub clear1()
        discountList.SelectedIndex = -1
        tPayment.Text = ""
        totalAmountDue.Text = "0"
        totalChange1.Text = "0"
        totalSum.Text = "0"
    End Sub

    'Auto Generate Id
    Function autoUserID(ByVal table As String, ByVal field As String) As Int32
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " select " & field & " from " & table & " Order by 1 desc limit 1"
        If con.State = ConnectionState.Closed Then con.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            autoUserID = Microsoft.VisualBasic.Right(dr(0), 4) + 1
        Else
            autoUserID = 1
        End If
        dr.Close()
        con.Close()

    End Function

    'showID
    Public Sub loadID()
        receiptID.ForeColor = Color.Black
        receiptID.Text = "AFD-" & Format(autoUserID("billreceipt", "receiptID"), "00000")

    End Sub

    Dim oldNumSold As Double
    Sub updateTotalStocks()
        Try
            'get num of sold from db
            Dim sql As String = "SELECT sold FROM products WHERE productId='" & productID.Text & "'"
            Dim cmd As New MySqlCommand(sql, con)

            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    oldNumSold = Val(dr.Item("sold"))
                End While
            End If
            con.Close()
            '''''''''''''''''''''''''
            If tStocks.Text <> Nothing Then
                Dim stock As Integer = CInt(tStocks.Text)
                Dim subStock As Integer = CInt(quantity.Text)
                Dim updateSoldCOunt As Double = subStock + oldNumSold

                Dim remainingStock As Integer = stock - subStock
                Dim sql1 As String = " Update products SET stocks='" & remainingStock & "',sold='" & updateSoldCOunt & "' WHERE productID='" & productID.Text & "' "
                bQuery(sql1)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim checkB As Boolean
    Dim oldQuantity As Integer
    Dim oldPrice As Double
    Sub checkDuplicateProduct()

        oldQuantity = 0
        oldPrice = 0

        Dim sql As String = "SELECT productId,quantity,totalPrice FROM receipt_content WHERE receiptId='" & receiptID.Text & "' and productID='" & productID.Text & "' "
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            checkB = True
            While dr.Read
                oldQuantity = dr.Item("quantity")
                oldPrice = dr.Item("totalPrice")
            End While
        Else
            checkB = False
        End If
        con.Close()
    End Sub
    Sub updateProductPurchased()
        Dim updateQuanity As Double = oldQuantity + Convert.ToInt32(quantity.Text)
        Dim updateTotalPrice As Double = oldPrice + Convert.ToDouble(totalPrice.Text)
        Dim sql1 As String = "Update receipt_content SET quantity='" & updateQuanity & "',totalPrice='" & updateTotalPrice & _
            "',dateCreated='" & Date.Now.ToString("yyyy/M/dd") & "' WHERE receiptId='" & receiptID.Text & "' and productID='" & productID.Text & "'"
        bQuery(sql1)
    End Sub

    Sub buyProduct()
        Try
            updateTotalStocks()

            Dim sql As String = "INSERT INTO receipt_content(receiptID,productID,name,quantity,totalPrice,dateCreated) VALUES('" & receiptID.Text & _
                "','" & productID.Text & "','" & product_name.Text & "','" & quantity.Text & "','" & totAmount & "','" & Date.Now.ToString("yyyy/M/dd") & "')"
            bQuery(sql)
            speakNow("Product addded to list.")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub showPurchases()
        Try
            Dim sql As String = "SELECT quantity as `Qty.`,name as `Product`,totalPrice as `Price`,productID FROM receipt_content WHERE receiptID='" & receiptID.Text & "'"
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "products")

            purchaseList.DataSource = ds.Tables(0)
            If purchaseList.ColumnCount > 0 Then
                purchaseList.Columns(3).Visible = False
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub calculateTotal()
        Try
            Dim total As Double = 0
            For count As Integer = 0 To purchaseList.RowCount - 1
                total += Convert.ToDouble(purchaseList.Rows(count).Cells(2).Value)
            Next
            totalSum.Text = Format(total, "###,###,###.00")
            totalAmountDue.Text = totalSum.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub getDiscountList()

        Try
            Dim sql As String = "SELECT vcode FROM discount WHERE vstatus='" & "ACTIVE" & "'"
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "vcode")
            con.Close()

            discountList.DataSource = ds.Tables(0)
            discountList.DisplayMember = "vcode"
            discountList.ValueMember = "vcode"
            discountList.SelectedIndex = -1


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim totalPayable As Double
    Sub calTotalAmountDue()
        Try

            If discountList.SelectedIndex < 0 Or discountList.Text = Nothing Then
                totalAmountDue.Text = totalSum.Text
                ldiscount.Text = "0.00"

            Else
                Dim sql As String = "SELECT vdiscounted FROM discount WHERE vcode='" & discountList.Text & "' LIMIT 1"
                Dim cmd As New MySqlCommand(sql, con)

                con.Open()
                Dim dr As MySqlDataReader = cmd.ExecuteReader

                If dr.HasRows Then
                    While dr.Read
                        Dim discountValue As Double = Convert.ToDouble(dr.Item("vdiscounted"))

                        Dim totalDiscountValue As Double = Convert.ToDouble(totalSum.Text) * discountValue
                        totalPayable = Convert.ToDouble(totalSum.Text) - totalDiscountValue

                        'total Amount to be paid
                        ldiscount.Text = Format(totalDiscountValue, "###,###,###.00")
                        totalAmountDue.Text = Format(totalPayable, "###,###,###.00")
                    End While
                Else
                    totalAmountDue.Text = totalSum.Text
                    ldiscount.Text = "0.00"
                End If

                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub calculateChange()

        Try
            If tPayment.Text <> Nothing Then
                Dim totalChange = Convert.ToDouble(tPayment.Text) - Convert.ToDouble(totalAmountDue.Text)
                totalChange1.Text = Format(totalChange, "###,###,###.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim Clerk As String

    Sub saveReceipt()
        Try
            Dim sql As String = "INSERT INTO billreceipt(receiptID,clerk,initialTotal,discount,discountAmount,bChange,bPayment,totalAmountDue,dateCreated,timeCreated)values('" & receiptID.Text & _
                       "','" & frmLogin.getClerk & "','" & Convert.ToDouble(totalSum.Text) & "','" & discountList.Text & "','" & Convert.ToDouble(ldiscount.Text) & "','" & Convert.ToDouble(totalChange1.Text) & _
                       "','" & Convert.ToDouble(tPayment.Text) & "','" & Convert.ToDouble(totalAmountDue.Text) & "','" & Date.Now.ToString("yyyy/M/dd") & "','" & TimeOfDay & "')"
            Dim cmd As New MySqlCommand(sql, con)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'values(@receiptID,@initialTotal,@discount,@discountAmount,@change,@bPayment,@totalAmountDue,@dateCreated,@timeCreated)"
        ' cmd.Parameters.AddWithValue("@receiptID", receiptID.Text)
        ' cmd.Parameters.AddWithValue("@initialTotal", Val(totalSum.Text))
        'cmd.Parameters.AddWithValue("@discount", discountList.SelectedValue.ToString())
        'cmd.Parameters.AddWithValue("@discountAmount", Val(ldiscount.Text))
        'cmd.Parameters.AddWithValue("@change", Val(totalChange1.Text))
        'cmd.Parameters.AddWithValue("@bPayment", Val(tPayment.Text))
        'cmd.Parameters.AddWithValue("@totalAmountDue", Val(totalAmountDue.Text))
        'cmd.Parameters.AddWithValue("@dateCreated", Date.Now.ToString("yyyy/M/dd"))
        'cmd.Parameters.AddWithValue("@timeCreated", TimeOfDay)

    End Sub

#End Region


    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        searchProduct()
    End Sub


    Private Sub buyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchProduct()
        clear()
        loadID()
        getDiscountList()
        showPurchases()
        calculateTotal()
        calTotalAmountDue()
    End Sub

    Private Sub dgview_MouseClick(sender As Object, e As MouseEventArgs) Handles dgview.MouseClick
        getSelectedCell()
    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        getSelectedCell()
    End Sub

    Private Sub numItem_TextChange(sender As Object, e As EventArgs) Handles quantity.TextChange, totalChange1.TextChange, tPayment.TextChange
        If quantity.Text <> Nothing Then

            calTotalPrice()
            Return
        End If
        If Not IsNumeric(tPayment.Text) Then
            tPayment.Text = ""
            Return
        End If
        If Not IsNumeric(totalChange1.Text) Then
            totalChange1.Text = ""
            Return
        End If

    End Sub

    Private Sub numItem_MouseMove(sender As Object, e As MouseEventArgs) Handles quantity.MouseMove, totalChange1.MouseMove, tPayment.MouseMove
        calTotalPrice()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        If productID.Text = Nothing Or product_name.Text = Nothing Or tStocks.Text = Nothing Then
            Alert("WARNING", "No producted selected.", Notification.alertTypeEnum.Warning)
            errSound()

        ElseIf quantity.Text = "0" Then
            Alert("WARNING", "Quantity cannot be zero.", Notification.alertTypeEnum.Warning)
            errSound()
        ElseIf Convert.ToInt32(tStocks.Text) <= 0 Then
            Alert("WARNING", "Out of stock or less than quantity", Notification.alertTypeEnum.Error)
            errSound()
        Else
            checkDuplicateProduct()
            ' buyProduct()
            If checkB = True Then
                updateProductPurchased()
            Else
                buyProduct()
            End If
            showPurchases()
            calculateTotal()
            calTotalAmountDue()
            clear()
            searchProduct()
            updateTotalStocks()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        searchProduct()
    End Sub

    Private Sub discountList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles discountList.SelectedIndexChanged
        calTotalAmountDue()
        calculateChange()
    End Sub

    Private Sub tPayment_TextChanged(sender As Object, e As EventArgs) Handles tPayment.TextChanged
        If Not IsNumeric(tPayment.Text) Then
            tPayment.Text = ""
            Return

        End If
        calculateChange()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If totalAmountDue.Text = "0" Then
            Alert("WARNING", "No item was purchased", Notification.alertTypeEnum.Warning)
            errSound()
        ElseIf tPayment.Text = Nothing Then
            Alert("WARNING", "Payment cannot be empty!", Notification.alertTypeEnum.Warning)
            errSound()
            tPayment.Focus()
        ElseIf Val(totalChange1.Text) < 0 Then
            Alert("WARNING", "Paymment is insuffecient!", Notification.alertTypeEnum.Warning)
            errSound()
        Else
            saveReceipt()
            receiptForm.printReceipt()
            clear1()
            receiptForm.Show()
            receiptForm.CrystalReportViewer1.RefreshReport()
            loadID()
            showPurchases()
            Main_form.showAll()
            Main_form.showData()

        End If

    End Sub

    Private Sub discountList_SelectedValueChanged(sender As Object, e As EventArgs) Handles discountList.SelectedValueChanged
        calTotalAmountDue()
        calculateChange()

    End Sub

    Private Sub discountList_Leave(sender As Object, e As EventArgs) Handles discountList.Leave
        calTotalAmountDue()
        calculateChange()
    End Sub

    Private Sub discountList_MouseMove(sender As Object, e As MouseEventArgs) Handles discountList.MouseMove
        calTotalAmountDue()
        calculateChange()
    End Sub

    Private Sub purchaseList_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles purchaseList.RowStateChanged
        If purchaseList.RowCount = 0 Then
            tPayment.Enabled = False
            totalChange1.Enabled = False
        Else
            tPayment.Enabled = True
            totalChange1.Enabled = True
        End If
    End Sub

    Private Sub REMOVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEToolStripMenuItem.Click
        Try

            If MessageBox.Show("Are you sure to remove " + purchaseList.SelectedCells(1).Value.ToString() + " ?", "REMOVE", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "DELETE FROM receipt_content WHERE productID='" & purchaseList.SelectedCells(3).Value.ToString() & "'"
                Dim cmd As New MySqlCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                Alert("REMOVED", "Product Removed from purchased items.", Notification.alertTypeEnum.Error)
                con.Close()
                loadID()
                showPurchases()
                calculateTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class