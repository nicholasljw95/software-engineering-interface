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
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonOrder = New System.Windows.Forms.Panel()
        Me.btnAdvanceOrder = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Number, Me.TableNo, Me.Type, Me.Price, Me.Status})
        Me.ListView1.Location = New System.Drawing.Point(362, 117)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(596, 205)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Number
        '
        Me.Number.Text = "No."
        Me.Number.Width = 38
        '
        'TableNo
        '
        Me.TableNo.Text = "Table No."
        Me.TableNo.Width = 74
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 137
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 145
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 158
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 568)
        Me.Controls.Add(Me.ListView1)
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Number As ColumnHeader
    Friend WithEvents TableNo As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Status As ColumnHeader
End Class
