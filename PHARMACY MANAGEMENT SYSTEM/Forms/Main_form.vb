Imports MySql.Data.MySqlClient

Public Class Main_form

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' If addProduct.camera.Start Then addProduct.camera.Stop()
        End
    End Sub

#Region "myMethod"
    Public Sub hideSubMenu()
        medPanel.Visible = False
        discountPanel.Visible = False
        settingsPanel.Visible = False
    End Sub
    Public Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
    Public Sub showPanel(myPanel As Object)
        Me.mainPanel.Controls.Clear()
        Dim mpanel As Form = TryCast(myPanel, Form)
        mpanel.TopLevel = False
        mpanel.Dock = DockStyle.Fill
        Me.mainPanel.Controls.Add(mpanel)
        Me.mainPanel.Tag = mpanel
        mpanel.Show()

    End Sub

    Sub showDashboard()
        mainPanel.Controls.Clear()

        mainPanel.Controls.Add(earningPanel)
        mainPanel.Controls.Add(totalProductPanel)
        mainPanel.Controls.Add(soldPanel)
        mainPanel.Controls.Add(BunifuDataViz1)
        mainPanel.Controls.Add(btnShop)
        mainPanel.Controls.Add(btnProduct1)
        mainPanel.Controls.Add(btnAcct)
        mainPanel.Controls.Add(BunifuLabel2)
        mainPanel.Controls.Add(BunifuLabel3)
        mainPanel.Controls.Add(BunifuLabel4)
        mainPanel.Controls.Add(dMonth)
        mainPanel.Controls.Add(dYear)
        mainPanel.Controls.Add(BunifuLabel1)
        mainPanel.Controls.Add(BunifuLabel5)
    End Sub

    Sub showTotalEarnings(month As String, year As String)
        Try
            Dim sql As String = "SELECT SUM(totalAmountDue) FROM `billreceipt` WHERE MONTH(datecreated)='" & month & _
              "' and YEAR(datecreated)='" & year & "' "
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    If Not IsDBNull(dr.Item("SUM(totalAmountDue)")) Then
                        Dim total As Double = dr.Item("SUM(totalAmountDue)")
                        totalEarning.Text = Format(total, "###,###,###.00")
                    Else
                        ' Alert("ERROR", "No Data Found", Notification.alertTypeEnum.Error)
                        totalEarning.Text = "0"
                    End If

                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub
    Sub showTotalProducts(month As String, year As String)
        Try
            Dim sql As String = "SELECT SUM(stocks) FROM products WHERE Month(dateCreated)='" & month & "' and Year(dateCreated)='" & year & "' "
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    If Not IsDBNull(dr.Item("SUM(stocks)")) Then
                        Dim total As Double = dr.Item("SUM(stocks)")
                        totalProducts.Text = total.ToString()
                    Else
                        'Alert("ERROR", "No Data Found", Notification.alertTypeEnum.Error)
                        totalProducts.Text = "0"
                    End If

                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub
    Sub showTotalSold(month As String, year As String)
        Try
            Dim sql As String = "SELECT SUM(quantity) FROM `receipt_content` WHERE Month(dateCreated)='" & month & "' and Year(dateCreated)='" & year & "' "
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    If Not IsDBNull(dr.Item("SUM(quantity)")) Then
                        Dim total As Double = dr.Item("SUM(quantity)")
                        totalProductSold.Text = total.ToString()
                    Else
                        'Alert("ERROR", "No Data Found", Notification.alertTypeEnum.Error)
                        totalProductSold.Text = "0"
                    End If

                End While
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub showAll()
        showTotalEarnings(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
        showTotalProducts(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
        showTotalSold(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
    End Sub
   
#End Region

#Region "Show Data"

    Dim jan As Double
    Dim feb As Double
    Dim mar As Double
    Dim apr As Double
    Dim may As Double
    Dim jun As Double
    Dim jul As Double
    Dim aug As Double
    Dim sep As Double
    Dim oct As Double
    Dim nov As Double
    Dim dec As Double
    Sub showData()
        Dim sql1 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=1 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql2 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=2 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql3 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=3 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql4 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=4 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql5 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=5 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql6 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=6 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql7 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=7 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql8 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=8 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql9 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=9 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql10 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=10 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql11 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=11 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"
        Dim sql12 As String = "SELECT SUM(totalAmountDue) FROM billreceipt WHERE MONTH(dateCreated)=12 and Year(dateCreated)='" & Date.Now.ToString("yyyy") & "'"

        'get jan
        Dim cmd As New MySqlCommand(sql1, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If Not IsDBNull(dr.Item("SUM(totalAmountDue)")) Then jan = Convert.ToDouble(dr.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get feb
        Dim cmd2 As New MySqlCommand(sql2, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr2 As MySqlDataReader = cmd2.ExecuteReader
        If dr2.HasRows Then
            While dr2.Read
                If Not IsDBNull(dr2.Item("SUM(totalAmountDue)")) Then feb = Convert.ToDouble(dr2.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get mar
        Dim cmd3 As New MySqlCommand(sql3, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr3 As MySqlDataReader = cmd3.ExecuteReader
        If dr3.HasRows Then
            While dr3.Read
                If Not IsDBNull(dr3.Item("SUM(totalAmountDue)")) Then mar = Convert.ToDouble(dr3.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get april
        Dim cmd4 As New MySqlCommand(sql4, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr4 As MySqlDataReader = cmd4.ExecuteReader
        If dr4.HasRows Then
            While dr4.Read
                If Not IsDBNull(dr4.Item("SUM(totalAmountDue)")) Then apr = Convert.ToDouble(dr4.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get may
        Dim cmd5 As New MySqlCommand(sql5, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr5 As MySqlDataReader = cmd5.ExecuteReader
        If dr5.HasRows Then
            While dr5.Read
                If Not IsDBNull(dr5.Item("SUM(totalAmountDue)")) Then may = Convert.ToDouble(dr5.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get jun
        Dim cmd6 As New MySqlCommand(sql6, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr6 As MySqlDataReader = cmd6.ExecuteReader
        If dr6.HasRows Then
            While dr6.Read
                If Not IsDBNull(dr6.Item("SUM(totalAmountDue)")) Then jun = Convert.ToDouble(dr6.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get july
        Dim cmd7 As New MySqlCommand(sql7, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr7 As MySqlDataReader = cmd7.ExecuteReader
        If dr7.HasRows Then
            While dr7.Read
                If Not IsDBNull(dr7.Item("SUM(totalAmountDue)")) Then jul = Convert.ToDouble(dr7.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get aug
        Dim cmd8 As New MySqlCommand(sql8, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr8 As MySqlDataReader = cmd8.ExecuteReader
        If dr8.HasRows Then
            While dr8.Read
                If Not IsDBNull(dr8.Item("SUM(totalAmountDue)")) Then aug = Convert.ToDouble(dr8.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get sep
        Dim cmd9 As New MySqlCommand(sql9, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr9 As MySqlDataReader = cmd9.ExecuteReader
        If dr9.HasRows Then
            While dr9.Read
                If Not IsDBNull(dr9.Item("SUM(totalAmountDue)")) Then sep = Convert.ToDouble(dr9.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get oct
        Dim cmd10 As New MySqlCommand(sql10, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr10 As MySqlDataReader = cmd10.ExecuteReader
        If dr10.HasRows Then
            While dr10.Read
                If Not IsDBNull(dr10.Item("SUM(totalAmountDue)")) Then oct = Convert.ToDouble(dr10.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get nov
        Dim cmd11 As New MySqlCommand(sql11, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr11 As MySqlDataReader = cmd11.ExecuteReader
        If dr11.HasRows Then
            While dr11.Read
                If Not IsDBNull(dr11.Item("SUM(totalAmountDue)")) Then nov = Convert.ToDouble(dr11.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        'get dec
        Dim cmd12 As New MySqlCommand(sql12, con)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim dr12 As MySqlDataReader = cmd10.ExecuteReader
        If dr12.HasRows Then
            While dr12.Read
                If Not IsDBNull(dr12.Item("SUM(totalAmountDue)")) Then dec = Convert.ToDouble(dr12.Item("SUM(totalAmountDue)"))
            End While
        End If
        con.Close()

        Dim canvas As New Bunifu.DataViz.WinForms.Canvas
        Dim datapoint1 As New Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline)
        BunifuDataViz1.colorSet.Add(Color.Goldenrod)

        '  BunifuDataViz1.Font = New Font("Comic Sans MS", 9, FontStyle.Regular)
        datapoint1.addLabely("Jan", jan.ToString())
        datapoint1.addLabely("Feb", feb.ToString())
        datapoint1.addLabely("Mar", mar.ToString())
        datapoint1.addLabely("Apr", apr.ToString())
        datapoint1.addLabely("May", may.ToString())
        datapoint1.addLabely("Jun", jun.ToString())
        datapoint1.addLabely("Jul", jul.ToString())
        datapoint1.addLabely("Aug", aug.ToString())
        datapoint1.addLabely("Sep", sep.ToString())
        datapoint1.addLabely("Oct", oct.ToString())
        datapoint1.addLabely("Nov", nov.ToString())
        datapoint1.addLabely("Dec", dec.ToString())

        canvas.addData(datapoint1)
        BunifuDataViz1.Render(canvas)

    End Sub


#End Region

    Private Sub Main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        hideSubMenu()
        btn_restore.Hide()
        showTotalEarnings(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
        showTotalProducts(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
        showTotalSold(Date.Now.ToString("MM"), Date.Now.ToString("yyyy"))
        showData()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
        btnMax.Hide()
        btn_restore.Show()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        hideSubMenu()
        showDashboard()
    End Sub

    Private Sub btnMedical_Click(sender As Object, e As EventArgs) Handles btnMedical.Click
        showSubMenu(medPanel)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Me.WindowState = FormWindowState.Normal
        btn_restore.Hide()
        btnMax.Show()
    End Sub

    Private Sub dateTimer_Tick(sender As Object, e As EventArgs) Handles dateTimer.Tick
        txtDate.Text = Date.Now.ToString("MMMM dd,yyyy") + " || " + TimeOfDay
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        showPanel(addProduct)
        searchProduct.ShowDialog()
    End Sub

    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        hideSubMenu()
        showPanel(buyForm)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        showPanel(buyForm)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        showSubMenu(settingsPanel)
    End Sub

    Private Sub addSystemAcct_Click(sender As Object, e As EventArgs) Handles addSystemAcct.Click
        showPanel(System_Acct)
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        showSubMenu(discountPanel)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        addProduct.clear()
        showPanel(addProduct)
    End Sub

    Private Sub addDiscount_Click(sender As Object, e As EventArgs) Handles addDiscount.Click
        showPanel(discountForm)
        discountForm.clear()
    End Sub

    Private Sub btnProduct1_Click(sender As Object, e As EventArgs) Handles btnProduct1.Click
        showPanel(addProduct)
        addProduct.clear()
    End Sub

    Private Sub btnAcct_Click(sender As Object, e As EventArgs) Handles btnAcct.Click
        showPanel(System_Acct)
        System_Acct.clear()
    End Sub

    Private Sub manageSystemAcct_Click(sender As Object, e As EventArgs) Handles manageSystemAcct.Click
        showPanel(searchSystemAcct)
    End Sub

    Private Sub dMonth_ValueChanged(sender As Object, e As EventArgs) Handles dMonth.ValueChanged, dYear.ValueChanged
        showTotalEarnings(dMonth.Value.ToString("MM"), dYear.Value.ToString("yyyy"))
        showTotalProducts(dMonth.Value.ToString("MM"), dYear.Value.ToString("yyyy"))
        showTotalSold(dMonth.Value.ToString("MM"), dYear.Value.ToString("yyyy"))
    End Sub

    Private Sub BunifuDataViz1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDataViz1_Load(sender As Object, e As EventArgs) Handles BunifuDataViz1.Load

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        showPanel(showRecord)
    End Sub
End Class