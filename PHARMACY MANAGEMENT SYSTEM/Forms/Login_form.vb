Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        txtPass.PlaceholderText = "Your Password"
        txtUser.PlaceholderText = "Your Username/User ID/Emp. ID"
        showPass.Visible = False
        hidePass.Visible = False
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Application.Exit()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#Region "Mymethod"
    Sub loginNow()
        Try
            Dim sql As String = "SELECT * FROM systemacct WHERE (username='" & txtUser.Text & _
                "' or empID='" & txtUser.Text & "' or userId='" & txtUser.Text & "') and password='" & txtPass.Text & "' LIMIT 1"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim count As Integer = cmd.ExecuteScalar()
            con.Close()
            If count > 0 Then
                Main_form.Show()
                Alert("Success!", "You have Logged In Successfully", Notification.alertTypeEnum.Success)
                speakNow("You Have Logged In Successfully!")

                getUserPhoto()
                txtUser.Text = ""
                txtPass.Text = ""
                Me.Hide()
            Else
                'MessageBox.Show("User Not Found", "Wrong username/password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Alert("Login Failed!", "Wrong username/password!", Notification.alertTypeEnum.Warning)
                txtPass.Text = ""
                txtPass.Focus()
                errSound()
            End If

        Catch ex As Exception
            Alert("ERROR", "SYSTEM ERROR!", Notification.alertTypeEnum.Error)
            errSound()
        End Try
        
    End Sub
    Public getClerk As String
    Sub getUserPhoto()
        Dim arrImage As Byte()

        Dim sql As String = " SELECT photo,empName FROM systemacct WHERE username='" & txtUser.Text & "' or empID='" & txtUser.Text & "' or userID='" & txtUser.Text & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)

        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Main_form.txtUser.Text = "Welcome " + dr.Item("empName").ToString()
                getClerk = dr.Item("empName").ToString()
                arrImage = dr.Item("photo")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Main_form.userPhoto.Image = Image.FromStream(mstream)

            End While
        End If
        con.Close()

    End Sub

#End Region


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If txtUser.Text = Nothing Then
            Alert("Warning!", "Username cannot be empty", Notification.alertTypeEnum.Warning)
            errSound()
            txtUser.Focus()
        ElseIf txtPass.Text = Nothing Then
            Alert("Warning!", "Password cannot be empty", Notification.alertTypeEnum.Warning)
            errSound()
            txtPass.Focus()
        Else
            loginNow()
        End If


    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtUser.Text = Nothing Then
                Alert("Warning!", "Username cannot be empty", Notification.alertTypeEnum.Warning)
                errSound()
                txtUser.Focus()
            ElseIf txtPass.Text = Nothing Then
                Alert("Warning!", "Password cannot be empty", Notification.alertTypeEnum.Warning)
                errSound()
                txtPass.Focus()
            Else
                loginNow()
            End If

        End If
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        errSound()
        contact.ShowDialog()

    End Sub

    Private Sub showPass_Click(sender As Object, e As EventArgs) Handles showPass.Click
        txtPass.UseSystemPasswordChar = False
        hidePass.Visible = True
        hidePass.bringToFront()
    End Sub

    Private Sub hidePass_Click(sender As Object, e As EventArgs) Handles hidePass.Click
        txtPass.UseSystemPasswordChar = True
        showPass.Visible = True
        showPass.BringToFront()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text <> "" Then
            showPass.Visible = True
        Else
            showPass.Visible = False
            hidePass.Visible = False
        End If
    End Sub
End Class
