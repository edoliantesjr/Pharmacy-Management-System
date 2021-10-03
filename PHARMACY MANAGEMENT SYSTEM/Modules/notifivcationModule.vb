Module notifivcationModule

    Public Sub Alert(header As String, msg1 As String, type As Notification.alertTypeEnum)
        Dim f As Notification = New Notification
        f.setAlert(header, msg1, Type)
    End Sub
End Module
