Imports MySql.Data.MySqlClient

Public Class searchSystemAcct

    Private Sub searchSystemAcct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enable(False)
        searchAcct()
    End Sub

#Region "mysub"

    Sub countAllAccount()
        Dim sql As String = "SELECT COUNT(*) FROM systemacct"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        systemCount.Text = count.ToString() + " Total system account."
    End Sub

    Sub searchAcct()
        Dim sql As String = "SELECT userID as `ID`,username as `Username`,empName as `Name`,empID,password FROM systemacct WHERE userID LIKE '%" & txtSearch.Text & "%' or empName LIKE '%" & txtSearch.Text & "%' or empID LIKE '%" & txtSearch.Text & "%' or username LIKE '%" & txtSearch.Text & "%'"
        Dim da As New MySqlDataAdapter(sql, con)
        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "systemacct")

        dgview.DataSource = ds.Tables(0)
        dgview.Columns(3).Visible = False
        dgview.Columns(4).Visible = False
        con.Close()

        If txtSearch.Text = Nothing Then
            countAllAccount()
        Else
            systemCount.Text = dgview.RowCount.ToString + " Found acccount."
        End If

    End Sub

    Sub getAccountPhoto()
        Dim arrImage As Byte()
        Dim sql As String = "select photo from systemacct where userID='" & dgview.SelectedCells(0).Value.ToString() & "' limit 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                arrImage = dr.Item("photo")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                userPhoto.Image = Image.FromStream(mstream)

            End While
        End If
        con.Close()

    End Sub

    Sub clear()
        userID.Text = Nothing
        empID.Text = Nothing
        empName1.Text = Nothing
        tUser.Text = Nothing
        password.Text = Nothing
        confirmPass.Text = Nothing
        userPhoto.Image = My.Resources.icons8_add_user_group_man_man_480px
    End Sub

    Sub enable(b As Boolean)
        tUser.Enabled = b
        userID.Enabled = b
        empID.Enabled = b
        empName1.Enabled = b
        btnChoose.Enabled = b
        btnUpdate.Enabled = b
        btnDelete.Enabled = b
        password.Enabled = b
        confirmPass.Enabled = b

    End Sub

    Sub updateAccount()
        Dim fileSize As UInt64
        Dim mStream As New System.IO.MemoryStream()
        userPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim buffImage() As Byte = mStream.GetBuffer()
        fileSize = mStream.Length
        mStream.Close()
        Dim sql As String = "UPDATE systemacct SET empId='" & empID.Text & "',empName='" & empName1.Text & "',username='" & tUser.Text & _
            "',password='" & password.Text & "',dateCreated='" & Date.Now.ToString("yyyy/M/dd") & "',photo=@arrimage WHERE userID='" & userID.Text & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.Parameters.AddWithValue("@arrimage", buffImage)
        cmd.ExecuteNonQuery()
        con.Close()
        Alert("Success", "Account Updated", Notification.alertTypeEnum.Success)
        clear()
    End Sub

#End Region
    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchAcct()
    End Sub

    Private Sub dgview_MouseClick(sender As Object, e As MouseEventArgs) Handles dgview.MouseClick
        userID.Text = dgview.SelectedCells(0).Value.ToString()
        empID.Text = dgview.SelectedCells(3).Value.ToString()
        empName1.Text = dgview.SelectedCells(2).Value.ToString()
        tUser.Text = dgview.SelectedCells(1).Value.ToString()
        password.Text = dgview.SelectedCells(4).Value.ToString()
        getAccountPhoto()
        enable(True)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If empID.Text = "" Then
            Alert("Warning", "Emp Id is required", Notification.alertTypeEnum.Warning)
            empID.Focus()
            errSound()
        ElseIf tUser.Text = Nothing Then
            Alert("Warning", "Username is required", Notification.alertTypeEnum.Warning)
            tUser.Focus()
            errSound()
        ElseIf password.Text = "" Then
            Alert("Warning", "Password is required", Notification.alertTypeEnum.Warning)
            password.Focus()
            errSound()
        ElseIf confirmPass.Text = "" Then
            Alert("Warning", "Confirm password is required", Notification.alertTypeEnum.Warning)
            confirmPass.Focus()
            errSound()
        ElseIf password.Text <> confirmPass.Text Then
            Alert("Warning", "Password not match", Notification.alertTypeEnum.Warning)
            confirmPass.Focus()
            errSound()
        ElseIf userPhoto.Image Is Nothing Then
            Alert("Warning", "User photo is required", Notification.alertTypeEnum.Warning)
            errSound()
        ElseIf MessageBox.Show("Are you sure to update this Account?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            updateAccount()
            searchAcct()
            clear()
            enable(False)

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to delete this Account?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM systemacct WHERE userID='" & userID.Text & "' "
                bQuery(sql)
                Alert("Deleted", "Account Deleted", Notification.alertTypeEnum.Error)
                clear()
                searchAcct()
            Catch ex As Exception
                Alert("Error", "System Error", Notification.alertTypeEnum.Error)
            End Try
        End If
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            userPhoto.Image = Image.FromFile(OpenFileDialog1.FileName())
        End If
    End Sub

    Private Sub empID_Leave(sender As Object, e As EventArgs) Handles tUser.Leave, password.Leave, empName1.Leave, empID.Leave, confirmPass.Leave

        empID.Text = StrConv(empID.Text, VbStrConv.Uppercase)
        empName1.Text = StrConv(empName1.Text, VbStrConv.Uppercase)

    End Sub
End Class