<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPage))
        Dim StateProperties1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonOrder = New System.Windows.Forms.Panel()
        Me.btnAdvanceOrder = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.listTransaction = New System.Windows.Forms.ListView()
        Me.Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ddlDay = New Bunifu.UI.Winforms.BunifuDropdown()
        Me.BunifuButton1 = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.pnlLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonOrder)
        Me.pnlLeftSide.Controls.Add(Me.btnAdvanceOrder)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(267, 568)
        Me.pnlLeftSide.TabIndex = 1
        '
        'pnlOnButtonOrder
        '
        Me.pnlOnButtonOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlOnButtonOrder.Location = New System.Drawing.Point(0, 117)
        Me.pnlOnButtonOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnButtonOrder.Name = "pnlOnButtonOrder"
        Me.pnlOnButtonOrder.Size = New System.Drawing.Size(13, 53)
        Me.pnlOnButtonOrder.TabIndex = 1
        '
        'btnAdvanceOrder
        '
        Me.btnAdvanceOrder.FlatAppearance.BorderSize = 0
        Me.btnAdvanceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvanceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanceOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAdvanceOrder.Image = Global.RestaurantBooking.My.Resources.Resources.btnOrder
        Me.btnAdvanceOrder.Location = New System.Drawing.Point(0, 117)
        Me.btnAdvanceOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdvanceOrder.Name = "btnAdvanceOrder"
        Me.btnAdvanceOrder.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnAdvanceOrder.Size = New System.Drawing.Size(267, 53)
        Me.btnAdvanceOrder.TabIndex = 0
        Me.btnAdvanceOrder.Text = "Check Transactions"
        Me.btnAdvanceOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdvanceOrder.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(267, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(782, 37)
        Me.pnlTopSide.TabIndex = 2
        '
        'listTransaction
        '
        Me.listTransaction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Number, Me.TableNo, Me.Type, Me.Time, Me.Price, Me.Status})
        Me.listTransaction.Location = New System.Drawing.Point(329, 117)
        Me.listTransaction.Name = "listTransaction"
        Me.listTransaction.Size = New System.Drawing.Size(643, 205)
        Me.listTransaction.TabIndex = 3
        Me.listTransaction.UseCompatibleStateImageBehavior = False
        Me.listTransaction.View = System.Windows.Forms.View.Details
        '
        'Number
        '
        Me.Number.Text = "No."
        Me.Number.Width = 38
        '
        'TableNo
        '
        Me.TableNo.Text = "Table No."
        Me.TableNo.Width = 86
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 114
        '
        'Time
        '
        Me.Time.Text = "Time Ordered"
        Me.Time.Width = 145
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 118
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 136
        '
        'ddlDay
        '
        Me.ddlDay.BackColor = System.Drawing.SystemColors.Control
        Me.ddlDay.BorderRadius = 1
        Me.ddlDay.Direction = Bunifu.UI.Winforms.BunifuDropdown.Directions.Down
        Me.ddlDay.DisabledColor = System.Drawing.Color.Gray
        Me.ddlDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlDay.DropdownBorderThickness = Bunifu.UI.Winforms.BunifuDropdown.BorderThickness.Thick
        Me.ddlDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDay.DropDownTextAlign = Bunifu.UI.Winforms.BunifuDropdown.TextAlign.Left
        Me.ddlDay.FillDropDown = False
        Me.ddlDay.FillIndicator = False
        Me.ddlDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlDay.ForeColor = System.Drawing.Color.Purple
        Me.ddlDay.FormattingEnabled = True
        Me.ddlDay.Icon = Nothing
        Me.ddlDay.IndicatorColor = System.Drawing.Color.Purple
        Me.ddlDay.IndicatorLocation = Bunifu.UI.Winforms.BunifuDropdown.Indicator.Right
        Me.ddlDay.ItemBackColor = System.Drawing.Color.White
        Me.ddlDay.ItemBorderColor = System.Drawing.Color.White
        Me.ddlDay.ItemForeColor = System.Drawing.Color.Purple
        Me.ddlDay.ItemHeight = 26
        Me.ddlDay.ItemHighLightColor = System.Drawing.Color.Thistle
        Me.ddlDay.Items.AddRange(New Object() {"Today", "Yesterday"})
        Me.ddlDay.Location = New System.Drawing.Point(329, 57)
        Me.ddlDay.Name = "ddlDay"
        Me.ddlDay.Size = New System.Drawing.Size(265, 32)
        Me.ddlDay.TabIndex = 5
        Me.ddlDay.Text = Nothing
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Close"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.Red
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.Location = New System.Drawing.Point(728, 415)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.Size = New System.Drawing.Size(210, 45)
        Me.BunifuButton1.TabIndex = 6
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuButton2
        '
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.ButtonText = "Export to Excel"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton2.IdleBorderRadius = 1
        Me.BunifuButton2.IdleBorderThickness = 0
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.ForestGreen
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.Location = New System.Drawing.Point(384, 415)
        Me.BunifuButton2.Name = "BunifuButton2"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState = StateProperties2
        Me.BunifuButton2.Size = New System.Drawing.Size(210, 45)
        Me.BunifuButton2.TabIndex = 7
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 568)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.ddlDay)
        Me.Controls.Add(Me.listTransaction)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnButtonOrder As Panel
    Friend WithEvents btnAdvanceOrder As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents listTransaction As ListView
    Friend WithEvents Number As ColumnHeader
    Friend WithEvents TableNo As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents ddlDay As Bunifu.UI.Winforms.BunifuDropdown
    Friend WithEvents BunifuButton1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton
End Class
