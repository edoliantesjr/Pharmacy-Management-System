<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchProduct
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
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchProduct))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.tSearch = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.productCount = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 34)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(110, 20)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Manage Product"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'tSearch
        '
        Me.tSearch.AcceptsReturn = False
        Me.tSearch.AcceptsTab = False
        Me.tSearch.AnimationSpeed = 200
        Me.tSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tSearch.BackColor = System.Drawing.Color.Transparent
        Me.tSearch.BackgroundImage = CType(resources.GetObject("tSearch.BackgroundImage"), System.Drawing.Image)
        Me.tSearch.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tSearch.BorderColorHover = System.Drawing.Color.Green
        Me.tSearch.BorderColorIdle = System.Drawing.Color.Silver
        Me.tSearch.BorderRadius = 30
        Me.tSearch.BorderThickness = 1
        Me.tSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tSearch.DefaultFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.tSearch.DefaultText = ""
        Me.tSearch.FillColor = System.Drawing.Color.White
        Me.tSearch.HideSelection = True
        Me.tSearch.IconLeft = Nothing
        Me.tSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.tSearch.IconPadding = 2
        Me.tSearch.IconRight = CType(resources.GetObject("tSearch.IconRight"), System.Drawing.Image)
        Me.tSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.tSearch.Lines = New String(-1) {}
        Me.tSearch.Location = New System.Drawing.Point(86, 68)
        Me.tSearch.MaxLength = 32767
        Me.tSearch.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tSearch.Modified = False
        Me.tSearch.Multiline = False
        Me.tSearch.Name = "tSearch"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tSearch.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.tSearch.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.Green
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tSearch.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tSearch.OnIdleState = StateProperties4
        Me.tSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tSearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.tSearch.PlaceholderText = "Search Products"
        Me.tSearch.ReadOnly = False
        Me.tSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tSearch.SelectedText = ""
        Me.tSearch.SelectionLength = 0
        Me.tSearch.SelectionStart = 0
        Me.tSearch.ShortcutsEnabled = True
        Me.tSearch.Size = New System.Drawing.Size(318, 35)
        Me.tSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tSearch.TabIndex = 1
        Me.tSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tSearch.TextMarginBottom = 0
        Me.tSearch.TextMarginLeft = 15
        Me.tSearch.TextMarginTop = 0
        Me.tSearch.TextPlaceholder = "Search Products"
        Me.tSearch.UseSystemPasswordChar = False
        Me.tSearch.WordWrap = True
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgview.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgview.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgview.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgview.EnableHeadersVisualStyles = False
        Me.dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgview.Location = New System.Drawing.Point(26, 109)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(437, 206)
        Me.dgview.TabIndex = 2
        Me.dgview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald
        Me.dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgview.ThemeStyle.HeaderStyle.Height = 25
        Me.dgview.ThemeStyle.ReadOnly = True
        Me.dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgview.ThemeStyle.RowsStyle.Height = 22
        Me.dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'productCount
        '
        Me.productCount.AutoEllipsis = False
        Me.productCount.CursorType = Nothing
        Me.productCount.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.productCount.Location = New System.Drawing.Point(33, 327)
        Me.productCount.Name = "productCount"
        Me.productCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.productCount.Size = New System.Drawing.Size(100, 18)
        Me.productCount.TabIndex = 3
        Me.productCount.Text = "999 Total Products"
        Me.productCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.productCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(491, 28)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.CheckedState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.CustomImages.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton2.HoverState.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(440, 5)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.ShadowDecoration.Parent = Me.Guna2CircleButton2
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CircleButton2.TabIndex = 0
        Me.Guna2CircleButton2.Text = "_"
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Red
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(465, 5)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CircleButton1.TabIndex = 0
        Me.Guna2CircleButton1.Text = "X"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'searchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(491, 354)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.productCount)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "searchProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchProduct"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents tSearch As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents productCount As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
