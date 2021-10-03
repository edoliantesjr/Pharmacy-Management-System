Imports MySql.Data.MySqlClient

Public Class searchProduct

    Private Sub searchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        countAvailableProduct()
        searchProducts()
    End Sub
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


#Region "My methods"

    Sub countAvailableProduct()
        Dim sql As String = "SELECT COUNT(*) FROM products where stocks<>0"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim i As Integer = cmd.ExecuteScalar()
        con.Close()
        productCount.Text = i.ToString() + " Available Products"

    End Sub

    Sub searchProducts()

        Try

            Dim sql As String = "SELECT productID as `ID`, name as `Product`,scientific as `Scientific name`,brand,type,amount,stocks,tempStocks,sold FROM products WHERE productID LIKE '%" + tSearch.Text + "%' or brand LIKE '%" + tSearch.Text + "%'  or name LIKE '%" + tSearch.Text + "%'  LIMIT 50 "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "products")

            dgview.DataSource = ds.Tables(0)
            dgview.Columns(3).Visible = False
            dgview.Columns(4).Visible = False
            dgview.Columns(5).Visible = False
            dgview.Columns(6).Visible = False
            dgview.Columns(7).Visible = False
            dgview.Columns(8).Visible = False

            con.Close()

            If tSearch.Text = Nothing Then
                countAvailableProduct()
            Else
                productCount.Text = dgview.RowCount.ToString + " Found Products"
            End If


        Catch ex As Exception
            Alert("Error", "System Error", Notification.alertTypeEnum.Error)
        End Try


    End Sub

    Sub countSold()
        Dim tempStock As Integer = CInt(dgview.SelectedCells(7).Value)
        Dim sold As Integer = CInt(dgview.SelectedCells(8).Value)

        'get soldPercentage
        Dim soldPercentage = (sold / tempStock) * 100
        addProduct.percentSold.Value = soldPercentage
        addProduct.soldCount.Text = sold.ToString + " out of " + tempStock.ToString() + " SOLD"

    End Sub

    Sub getSelectedCell()
        addProduct.productID.Text = dgview.SelectedCells(0).Value.ToString
        addProduct.tbrand.Text = dgview.SelectedCells(3).Value.ToString
        addProduct.tname.Text = dgview.SelectedCells(1).Value.ToString
        addProduct.cTypes.Text = dgview.SelectedCells(4).Value.ToString
        addProduct.tScientific.Text = dgview.SelectedCells(2).Value.ToString
        addProduct.tamount.Text = dgview.SelectedCells(5).Value.ToString
        addProduct.tstocks.Text = dgview.SelectedCells(6).Value.ToString

        countSold()
        getProductPhoto()
        addProduct.btnAdd.Text = "Update"
        addProduct.btnDelete.Enabled = True
        Me.Close()

    End Sub

    Sub getProductPhoto()
        Dim arrImage As Byte()
        Dim sql As String = "select photo from products where productID='" & dgview.SelectedCells(0).Value.ToString() & "' limit 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                arrImage = dr.Item("photo")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                addProduct.productPhoto.Image = Image.FromStream(mstream)

            End While
        End If
        con.Close()

    End Sub
   
#End Region

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        searchProducts()
    End Sub

    Private Sub dgview_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgview.CellMouseDoubleClick
        getSelectedCell()
    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Enter Then
            getSelectedCell()
        End If

    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick

    End Sub
End Class