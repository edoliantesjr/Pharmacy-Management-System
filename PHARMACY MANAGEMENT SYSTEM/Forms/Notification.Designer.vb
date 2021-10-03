<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notification))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.header = New Bunifu.UI.WinForms.BunifuLabel()
        Me.icons = New Guna.UI.WinForms.GunaPictureBox()
        Me.msg1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.icons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 136)
        Me.Panel1.TabIndex = 0
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(357, 5)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(13, 20)
        Me.BunifuLabel1.TabIndex = 1
        Me.BunifuLabel1.Text = "X"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'header
        '
        Me.header.AutoEllipsis = False
        Me.header.CursorType = Nothing
        Me.header.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(60, 12)
        Me.header.Name = "header"
        Me.header.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.header.Size = New System.Drawing.Size(110, 26)
        Me.header.TabIndex = 4
        Me.header.Text = "My Header"
        Me.header.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.header.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'icons
        '
        Me.icons.BaseColor = System.Drawing.Color.White
        Me.icons.Image = Global.PHARMACY_MANAGEMENT_SYSTEM.My.Resources.Resources.check
        Me.icons.Location = New System.Drawing.Point(14, 5)
        Me.icons.Name = "icons"
        Me.icons.Size = New System.Drawing.Size(40, 33)
        Me.icons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icons.TabIndex = 3
        Me.icons.TabStop = False
        '
        'msg1
        '
        Me.msg1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.msg1.AutoEllipsis = False
        Me.msg1.CursorType = Nothing
        Me.msg1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msg1.ForeColor = System.Drawing.Color.White
        Me.msg1.Location = New System.Drawing.Point(82, 64)
        Me.msg1.Name = "msg1"
        Me.msg1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msg1.Size = New System.Drawing.Size(159, 23)
        Me.msg1.TabIndex = 5
        Me.msg1.Text = "The First Message Text"
        Me.msg1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.msg1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Timer1
        '
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 136)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.icons)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.Text = "Notification"
        Me.TopMost = True
        CType(Me.icons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents header As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents icons As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents msg1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
