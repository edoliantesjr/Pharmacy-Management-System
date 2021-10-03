Public Class selectSource

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If checkDefault.Checked = True And rCamera.Checked = True Then
            addProduct.cameraOn()
            addProduct.alwaysCamera = "Open Camera"

        ElseIf checkDefault.Checked = True And rFile.Checked = True Then
            addProduct.openFolder()
            addProduct.selectPhoto.Text = "Open Folder"

        ElseIf rCamera.Checked = True Then
            addProduct.cameraOn()
            addProduct.alwaysCamera = "Select Photo"

        ElseIf rFile.Checked = True Then
            addProduct.openFolder()
            addProduct.selectPhoto.Text = "Select Photo"
        End If
        Me.Close()
    End Sub

    Private Sub rCamera_Click(sender As Object, e As EventArgs) Handles rCamera.Click
        btnContinue.Enabled = True
    End Sub

    Private Sub rFile_Click(sender As Object, e As EventArgs) Handles rFile.Click
        btnContinue.Enabled = True
    End Sub

    Private Sub selectSource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class