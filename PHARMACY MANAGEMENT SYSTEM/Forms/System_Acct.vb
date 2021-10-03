Imports MySql.Data.MySqlClient
Public Class System_Acct

#Region "My Methods"


    Sub saveAccount()
        Try
            Dim fileSize As UInt64
            Dim mStream As New System.IO.MemoryStream()
            userProfile.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim buffImage() As Byte = mStream.GetBuffer()
            fileSize = mStream.Length
            mStream.Close()
            Dim sql As String = "INSERT INTO systemacct (userId, empID,empName,username,password,type,dateCreated,photo) values('" & userID.Text & _
                "','" & empID.Text & "','" & empName.Text & "','" & tUser.Text & "','" & password.Text & "','" & "staff" & "','" & Date.Now.ToString("yyyy/M/dd") & "',@arrimage)"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            cmd.Parameters.AddWithValue("@arrimage", buffImage)
            cmd.ExecuteNonQuery()
            con.Close()

            Alert("Success", "Account save", Notification.alertTypeEnum.Success)
            clear()
        Catch ex As Exception
            Alert("Error", ex.Message, Notification.alertTypeEnum.Error)
        End Try

    End Sub

    Sub clear()
        empID.Text = Nothing
        tUser.Text = Nothing
        empName.Text = Nothing
        password.Text = Nothing
        confirmPass.Text = Nothing
        userProfile.Image = Nothing
    End Sub

    'Auto Generate Id
    Function autoUserID(ByVal table As String, ByVal field As String) As Int32
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " select " & field & " from " & table & "  Order by 1 desc limit 1"
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
        userID.ForeColor = Color.Black
        userID.Text = "PMS-" & Format(autoUserID("systemacct", "userID"), "0000")

    End Sub
#End Region

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            userProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If empId.Text = "" Then
            Alert("Warning", "Emp Id is required", Notification.alertTypeEnum.Warning)
            empId.Focus()
            errSound()
        ElseIf tUser.Text = Nothing Then
            Alert("Warning", "Username is required", Notification.alertTypeEnum.Warning)
            tUser.Focus()
            errSound()
        ElseIf password.Text = "" Or confirmpass.Text = "" Then
            Alert("Warning", "Password is required", Notification.alertTypeEnum.Warning)
            password.Focus()
            errSound()
        ElseIf password.Text <> confirmpass.Text Then
            Alert("Warning", "Password not match", Notification.alertTypeEnum.Warning)
            confirmpass.Focus()
            errSound()
        ElseIf userProfile.Image Is Nothing Then
            Alert("Warning", "User photo is required", Notification.alertTypeEnum.Warning)
            errSound()
        ElseIf MessageBox.Show("Are you sure to " & btnSave.Text & " this Account?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            saveAccount()


        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        clear()
    End Sub

    Private Sub System_Acct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadID()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadID()
    End Sub

    Private Sub textLeave(sender As Object, e As EventArgs) Handles empName.Leave, empID.Leave
        empID.Text = StrConv(empID.Text, VbStrConv.Uppercase)
        empName.Text = StrConv(empName.Text, VbStrConv.Uppercase)
    End Sub
End Class