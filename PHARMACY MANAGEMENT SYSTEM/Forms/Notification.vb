﻿Public Class Notification

    Enum alertTypeEnum
        Success
        Warning
        [Error]
        Info
    End Enum

    Dim x, y As Integer
    Public Sub setAlert(header As String, msg1 As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As Notification = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Error
                Me.icons.Image = My.Resources.err
                Me.BackColor = Color.FromArgb(255, 121, 70)
            Case alertTypeEnum.Info
                Me.icons.Image = My.Resources.check
                Me.BackColor = Color.FromArgb(71, 169, 248)
            Case alertTypeEnum.Success
                Me.icons.Image = My.Resources.check
                Me.BackColor = Color.FromArgb(42, 171, 160)
            Case alertTypeEnum.Warning
                Me.icons.Image = My.Resources.warning
                Me.BackColor = Color.FromArgb(255, 179, 2)
        End Select
        Me.header.Text = header
        Me.msg1.Text = msg1

        '  Me.TopMost = True
        '  Me.ShowIcon = False
        '  Me.ShowInTaskbar = False
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum actionEnum
        wait
        start
        close
    End Enum
    Private action As actionEnum = actionEnum.start



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 5000
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Me.Timer1.Interval = 1
        action = actionEnum.close
    End Sub
End Class