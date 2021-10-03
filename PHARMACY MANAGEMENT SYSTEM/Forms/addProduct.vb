Imports MySql.Data.MySqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class addProduct

#Region "My methods"

    Sub clear()
        productID.Text = Nothing
        tbrand.Text = Nothing
        tScientific.Text = Nothing
        cTypes.StartIndex = -1
        tname.Text = Nothing
        tamount.Text = Nothing
        tstocks.Text = Nothing
        productPhoto.Image = Nothing
        percentSold.Value = 0
        soldCount.Text = "0 SOLD"
        btnAdd.Text = "Add"
    End Sub
    Sub addProduct()
        Try

            Dim fileSize As UInt64
            Dim mStream As New System.IO.MemoryStream()
            productPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim buffImage() As Byte = mStream.GetBuffer()
            fileSize = mStream.Length
            mStream.Close()

            Dim sql As String = "INSERT INTO products(productID,brand,name,amount,stocks,tempStocks,type,scientific,dateCreated,photo)values('" & productID.Text & _
                "','" & tbrand.Text & "','" & tname.Text & "','" & tamount.Text & "','" & tstocks.Text & _
                "','" & tstocks.Text & "','" & cTypes.Text & "','" & tScientific.Text & "','" & Date.Now.ToString("yyyy/M/dd") & "',@arrImage)"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@arrImage", buffImage)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            Alert("Success", "Product added succesfully!", Notification.alertTypeEnum.Success)
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'get tempStock
    Dim tempStock As Integer
    Sub getTempStock()
        tempStock = 0
        Dim sql As String = "SELECT tempStocks FROM products WHERE productId='" & productID.Text & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                tempStock = Convert.ToInt32(dr.Item("tempStocks"))
            End While
        End If
        con.Close()

    End Sub

    Sub updateProduct()

        Try

            Dim fileSize As UInt64
            Dim mStream As New System.IO.MemoryStream()
            productPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim buffImage() As Byte = mStream.GetBuffer()
            fileSize = mStream.Length
            mStream.Close()

            getTempStock()
            Dim updateTempStock As Integer = tempStock + Convert.ToInt32(tstocks.Text)

            Dim sql As String = "UPDATE products SET brand='" & tbrand.Text & "',name='" & tname.Text & _
                "',amount='" & tamount.Text & "',stocks='" & tstocks.Text & "',tempStocks='" & updateTempStock & "',dateCreated='" & Date.Now.ToString("yyyy/M/dd") & _
                "',type='" & cTypes.Text & "',scientific='" & tScientific.Text & "',photo=@arrImage WHERE productID='" & productID.Text & "'"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@arrImage", buffImage)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            Alert("Success", "Product updated succesfully!", Notification.alertTypeEnum.Success)
            btnAdd.Text = "Save"
            btnDelete.Enabled = False
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim b As Boolean
    Sub checkRecords()
        Dim sql As String = " SELECT * FROM products WHERE productID='" & productID.Text & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count >= 1 Then
            b = True
            clear()
            Alert("ERROR", "Product Already Exist.", Notification.alertTypeEnum.Error)
        Else
            b = False

        End If


    End Sub
    Sub selectImageSource()
        selectSource.ShowDialog()
    End Sub
    Public alwaysCamera As String
    Public Sub getImage()
        camera.Stop()
        selectPhoto.Text = alwaysCamera
    End Sub

    Public camera As VideoCaptureDevice
    Public Sub cameraOn()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Me.Captured)
            camera.Start()
            selectPhoto.Text = "Capture"
        End If
    End Sub

    'method to get Image and show in PictureBox
    Sub Captured(ByVal sender As Object, ByVal eventargs As NewFrameEventArgs)
        Dim bmp As Bitmap
        bmp = DirectCast(eventargs.Frame.Clone(), Bitmap)
        productPhoto.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    'Select Photo Using File Dialog
    Public Sub openFolder()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            productPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

#End Region


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles selectPhoto.Click

        If selectPhoto.Text = "Select Photo" Then
            selectImageSource()

        ElseIf selectPhoto.Text = "Capture" Then
            getImage()
        ElseIf selectPhoto.Text = "Open Camera" Then
            cameraOn()
        ElseIf selectPhoto.Text = "Open Folder" Then
            openFolder()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If productID.Text = Nothing Then
            Alert("Warning", "Product ID is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            productID.Focus()
        ElseIf tbrand.Text = Nothing Then
            Alert("Warning", "Brand is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            tbrand.Focus()
        ElseIf tname.Text = Nothing Then
            Alert("Warning", "Product name is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            tname.Focus()
        ElseIf tamount.Text = Nothing Then
            Alert("Warning", "Amount is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            tamount.Focus()
        ElseIf tstocks.Text = Nothing Then
            Alert("Warning", "Stocks is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            tstocks.Focus()
        ElseIf cTypes.Text = Nothing Then
            Alert("Warning", "Product Type is empty!", Notification.alertTypeEnum.Warning)
            errSound()
            cTypes.Focus()
        ElseIf productPhoto.Image Is Nothing Then
            Alert("Warning", "No photo selected!", Notification.alertTypeEnum.Warning)
            errSound()
            selectPhoto.Focus()
        ElseIf MessageBox.Show("Are you sure to " & btnAdd.Text & " this Product?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If btnAdd.Text = "Add" Then
                checkRecords()

                If b <> True Then
                    addProduct()
                End If

            ElseIf btnAdd.Text = "Update" Then
                updateProduct()

            End If

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to delete this Account?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM products WHERE productID='" & productID.Text & "' "
                bQuery(sql)
                Alert("Deleted", "Product Deleted", Notification.alertTypeEnum.Error)
                clear()
            Catch ex As Exception
                Alert("Error", "System Error", Notification.alertTypeEnum.Error)
            End Try
        End If
    End Sub


    Private Sub cTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cTypes.SelectedValueChanged
        If cTypes.Text = "MEDICINE" Or cTypes.Text = "VITAMINS" Then
            tScientific.Enabled = True
        Else
            tScientific.Enabled = False
            tScientific.Text = Nothing
        End If
    End Sub

    Private Sub tamount_TextChanged(sender As Object, e As EventArgs) Handles tamount.TextChanged
        If Not IsNumeric(tamount.Text) Then
            tamount.Text = ""
            Return
        End If
    End Sub

    Private Sub tstocks_TextChanged(sender As Object, e As EventArgs) Handles tstocks.TextChanged
        If Not IsNumeric(tstocks.Text) Then
            tstocks.Text = ""
            Return
        End If
    End Sub

    Private Sub textLeave(sender As Object, e As EventArgs) Handles tScientific.Leave, tname.Leave, tbrand.Leave, productID.Leave
        productID.Text = StrConv(productID.Text, VbStrConv.Uppercase)
        tbrand.Text = StrConv(tbrand.Text, VbStrConv.Uppercase)
        tname.Text = StrConv(tname.Text, VbStrConv.Uppercase)
        tScientific.Text = StrConv(tScientific.Text, VbStrConv.Uppercase)
    End Sub
End Class