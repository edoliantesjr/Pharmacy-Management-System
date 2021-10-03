<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(showRecord))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Me.dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtSearch = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgview.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgview.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgview.EnableHeadersVisualStyles = False
        Me.dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgview.Location = New System.Drawing.Point(13, 45)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(815, 429)
        Me.dgview.TabIndex = 0
        Me.dgview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald
        Me.dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgview.ThemeStyle.HeaderStyle.Height = 50
        Me.dgview.ThemeStyle.ReadOnly = True
        Me.dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgview.ThemeStyle.RowsStyle.Height = 22
        Me.dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderRadius = 6
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(310, 497)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Enabled = True
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnPrint.Size = New System.Drawing.Size(180, 45)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Show & Print"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 6
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Enabled = False
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(512, 497)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnDelete.Size = New System.Drawing.Size(180, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(13, 13)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(251, 23)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Search and Manage Records"
        '
        'txtSearch
        '
        Me.txtSearch.AcceptsReturn = False
        Me.txtSearch.AcceptsTab = True
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.AnimationSpeed = 200
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BackgroundImage = CType(resources.GetObject("txtSearch.BackgroundImage"), System.Drawing.Image)
        Me.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtSearch.BorderColorHover = System.Drawing.Color.Green
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtSearch.BorderRadius = 30
        Me.txtSearch.BorderThickness = 1
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.White
        Me.txtSearch.HideSelection = True
        Me.txtSearch.IconLeft = Nothing
        Me.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.IconPadding = 2
        Me.txtSearch.IconRight = CType(resources.GetObject("txtSearch.IconRight"), System.Drawing.Image)
        Me.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(17, 497)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtSearch.Modified = False
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearch.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearch.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.Green
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearch.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearch.OnIdleState = StateProperties4
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearch.PlaceholderText = "Search Account"
        Me.txtSearch.ReadOnly = False
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(273, 45)
        Me.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtSearch.TabIndex = 8
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.TextMarginBottom = 0
        Me.txtSearch.TextMarginLeft = 15
        Me.txtSearch.TextMarginTop = 0
        Me.txtSearch.TextPlaceholder = "Search Account"
        Me.txtSearch.UseSystemPasswordChar = False
        Me.txtSearch.WordWrap = True
        '
        'showRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 571)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "showRecord"
        Me.Text = "showRecord"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSearch As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class
